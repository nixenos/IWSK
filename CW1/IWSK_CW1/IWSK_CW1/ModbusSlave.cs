using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWSK_CW1
{
    class ModbusSlave : Modbus
    {
        private enum SlaveState { Off, Idle, Reciver, Processing }
        SlaveState state = SlaveState.Off;

        string inputBuffer;
        int SlaveAdres;
        int CharTimeout;
        Stopwatch CharacterStopwatch = new Stopwatch();


        public string SecondCommand = "";

        public event EventHandler<ModbusMessageEventArg> ReceivedFrameHandler;
        public event EventHandler<ModbusMessageEventArg> SendFrameHandler;
        public event EventHandler<ModbusMessageEventArg> FirstCommandExecutionHandler;
        public event EventHandler<ModbusMessageEventArg> CheckSumErrorHandler;
        public event EventHandler<ModbusMessageEventArg> StatusHandler;

        public override void Receive(char character)
        {
            if (state != SlaveState.Off)
            {
                if (state == SlaveState.Idle)
                {
                    if (character == ':')
                    {
                        state = SlaveState.Reciver;
                        CharacterStopwatch = new Stopwatch();
                        CharacterStopwatch.Start();
                    }
                }
                else if (state == SlaveState.Reciver)
                {
                    // timeout znaku ??
                    Thread.Sleep(20);
                    if (CharacterStopwatch.ElapsedMilliseconds > CharTimeout)
                    {
                        CharacterStopwatch.Stop();
                        StatusHandler(this, new ModbusMessageEventArg("Character Timeout"));
                        inputBuffer = "";
                        state = SlaveState.Idle;
                        return;
                    }
                    StatusHandler(this, new ModbusMessageEventArg(CharacterStopwatch.ElapsedMilliseconds.ToString()));
                    //CharacterStopwatch.Restart();

                    inputBuffer += character.ToString();
                    if (inputBuffer.Length > 2)
                    {
                        if (inputBuffer.Substring(inputBuffer.Length - 2) == "\r\n")
                        {
                            Frame frame = new Frame(inputBuffer.Remove(inputBuffer.Length - 2));
                            ExecuteCommand(frame);
                            state = SlaveState.Idle;
                            inputBuffer = "";
                            serialPort.ReadExisting();
                        }
                    }
                }
            }
            CharacterStopwatch.Restart();
        }

        private void ExecuteCommand(Frame frame)
        {
            if (frame.CheckLRC())
            {
                ReceivedFrameHandler(this, new ModbusMessageEventArg(frame.ToString()));
                //StatusHandler(this, new ModbusMessageEventArg("Frame Recived"));
                if (frame.addres == SlaveAdres)
                {
                    if (frame.function == 1)
                    {
                        ExecuteFirstCommand(frame.args);
                        Write(frame);
                        SendFrameHandler(this, new ModbusMessageEventArg(frame.ToString()));
                    }
                    else if (frame.function == 2)
                    {
                        ExecuteSecondCommand(frame);
                    }
                }
                else if (frame.addres == 0)
                {
                    // rozgłoszeniowo
                    if (frame.function == 1)
                    {
                        ExecuteFirstCommand(frame.args);
                    }
                }
            }
            else
            {
                CheckSumErrorHandler(this, new ModbusMessageEventArg("LRC Error"));
            }
        }


        private void ExecuteFirstCommand(String data)
        {
            FirstCommandExecutionHandler(this, new ModbusMessageEventArg(data));
        }

        private void ExecuteSecondCommand(Frame data)
        {
            Frame response = new Frame(data.addres, data.function, SecondCommand);
            Write(response);
            SendFrameHandler(this, new ModbusMessageEventArg(response.ToString()));
        }

        internal void Run(int adres, int charTimeout)
        {
            state = SlaveState.Idle;
            SlaveAdres = adres;
            CharTimeout = charTimeout;
        }

        internal void Stop()
        {
            state = SlaveState.Off;
        }
    }
}
