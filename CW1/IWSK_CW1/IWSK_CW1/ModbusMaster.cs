using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWSK_CW1
{
    class ModbusMaster : Modbus
    {
        private enum MasterState { Idle, Receiver, Processing, CharacterTimeout }
        MasterState state = MasterState.Idle;
        bool waitForFrame = false;

        string inputBuffer;
        int CharTimeout;
        int TransactionTimeout;
        Stopwatch CharacterStopwatch = new Stopwatch();

        Frame ReceivedFrame;

        public event EventHandler<ModbusMessageEventArg> ReceivedFrameHandler;
        public event EventHandler<ModbusMessageEventArg> SendFrameHandler;
        public event EventHandler<ModbusMessageEventArg> FunctionTwoHandler;
        public event EventHandler<ModbusMessageEventArg> CheckSumErrorHandler;
        public event EventHandler<ModbusMessageEventArg> StatusHandler;

        public override void Receive(char character)
        {
            if (waitForFrame)
            {
                if (character == ':')
                {
                    state = MasterState.Receiver;
                    CharacterStopwatch = new Stopwatch();
                    CharacterStopwatch.Start();
                }
                else if (state == MasterState.Receiver)
                {
                    Thread.Sleep(20);
                    if (CharacterStopwatch.ElapsedMilliseconds > CharTimeout)
                    {
                        CharacterStopwatch.Stop();
                        inputBuffer = "";
                        state = MasterState.CharacterTimeout;
                        return;
                    }

                    inputBuffer += character.ToString();
                    if (inputBuffer.Length > 2)
                    {
                        if (inputBuffer.Substring(inputBuffer.Length - 2) == "\r\n")
                        {
                            ReceivedFrame = new Frame(inputBuffer.Remove(inputBuffer.Length - 2));
                            state = MasterState.Processing;
                            inputBuffer = "";
                            serialPort.ReadExisting();
                        }
                    }
                }
            }
            CharacterStopwatch.Restart();
        }

        private bool WaitForResponse(Frame sendFrame)
        {
            waitForFrame = true;
            state = MasterState.Idle;
            serialPort.ReadExisting();
            inputBuffer = "";
            Write(sendFrame);
            Stopwatch TTimeout = new Stopwatch();
            TTimeout.Start();
            while (state != MasterState.Processing)
            {
                if (state == MasterState.CharacterTimeout)
                {
                    waitForFrame = false;
                    inputBuffer = "";
                    serialPort.ReadExisting();
                    return false;
                }

                if (TTimeout.ElapsedMilliseconds > TransactionTimeout)
                {
                    waitForFrame = false;
                    inputBuffer = "";
                    state = MasterState.Idle;
                    serialPort.ReadExisting();
                    return false;
                }
            }
            TTimeout.Stop();
            waitForFrame = false;

            if (ReceivedFrame != null)
            {
                if (ReceivedFrame.CheckLRC())
                {
                    ReceivedFrameHandler(this, new ModbusMessageEventArg(ReceivedFrame.ToString()));
                    ExecuteFrame(ReceivedFrame);
                }
                else
                    CheckSumErrorHandler(this, new ModbusMessageEventArg("LRC Error"));
            }
            state = MasterState.Idle;
            return true;
        }

        private void ExecuteFrame(Frame recivedFrame)
        {
            if (recivedFrame.function == 2)
            {
                FunctionTwoHandler(this, new ModbusMessageEventArg(recivedFrame.args));
            }
        }

        public bool makeTransaction(int slaveAdres, int function, string args)
        {
            Frame sendFrame = new Frame((char)slaveAdres, (char)function, args);
            SendFrameHandler(this, new ModbusMessageEventArg(sendFrame.ToString()));
            if (slaveAdres == 0)
            {
                Write(sendFrame);
                return true;
            }
            else
            {
                return WaitForResponse(sendFrame);
            }
        }

        public void RunTransaction(int slaveAdres, int function, string args, int charTimeout, int transactionTimeout, int retransmission)
        {
            this.CharTimeout = charTimeout;
            this.TransactionTimeout = transactionTimeout;

            if (function != 1 && function != 2)
            {
                StatusHandler(this, new ModbusMessageEventArg("Nieprawidłowa funkcja"));
                return;
            }
            if (function == 2 && slaveAdres == 0)
            {
                StatusHandler(this, new ModbusMessageEventArg("Błąd: Nie można rozesłać przez broadcast"));
                return;
            }

            for (int i = 1; i <= retransmission + 1; i++)
            {
                if (makeTransaction(slaveAdres, function, args))
                    return;
                if (state == MasterState.CharacterTimeout)
                {
                    StatusHandler(this, new ModbusMessageEventArg("Character Timeout"));
                }
                else
                    StatusHandler(this, new ModbusMessageEventArg(string.Format("Timeout Error {0}", i)));
            }
        }

    }
}
