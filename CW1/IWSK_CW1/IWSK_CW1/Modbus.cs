using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWSK_CW1
{
    class Modbus
    {

        protected SerialPort serialPort;

        protected Frame ReceivedFrame;

        public bool BadCRCChecksum { get; set; } = false;

        public Modbus()
        {
            serialPort = new SerialPort();
            serialPort.DataReceived += SerialPort_DataReceived;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (serialPort.BytesToRead > 0)
            {
                Receive((char)serialPort.ReadByte());
            }
        }

        public virtual void Receive(char character) { }

        public void Open(string portName, int baudRate)
        {
            if (portName == "") return;
            serialPort.PortName = portName;
            serialPort.BaudRate = baudRate;
            try
            {
                serialPort.Open();
            }
            catch { }
        }

        public bool IsOpen()
        {
            return this.serialPort.IsOpen;
        }
        public void Close()
        {
            serialPort.Close();
        }
        public void Write(Frame frame)
        {
            if (serialPort.IsOpen)
            {
                if (BadCRCChecksum)
                    frame.setWrongCRC();
                serialPort.Write(frame.ToWrite());
            }
        }
        public string[] GetAvaliablePorts()
        {
            return SerialPort.GetPortNames();
        }
    }

    class Frame
    {

        public char addres { get; set; }
        public char function { get; set; }
        public string args { get; set; }
        public char LRC { get; set; }

        private string byteArray;

        public Frame(string hexdata)
        {
            if (hexdata.Length < 6)
                return;
            string addresSubstring = hexdata.Substring(0, 2);
            string functionSubstring = hexdata.Substring(2, 2);
            string argsSubstring = hexdata.Substring(4, hexdata.Length - 2 - 4);
            string LRCSubstring = hexdata.Substring(hexdata.Length - 2, 2);

            this.addres = (char)Convert.ToByte(addresSubstring, 16);
            this.function = (char)Convert.ToByte(functionSubstring, 16);
            this.args = argsSubstring;
            this.LRC = (char)Convert.ToByte(LRCSubstring, 16);

            byteArray = hexdata;
        }

        public Frame(char addres, char function, string args)
        {
            this.addres = addres;
            this.function = function;
            this.args = args;
            byteArray = ((byte)this.addres).ToString("x2") + ((byte)this.function).ToString("x2") + this.args;
            this.LRC = (char)Crc8.ComputeChecksum(Encoding.ASCII.GetBytes(byteArray));
            byteArray += ((byte)this.LRC).ToString("x2");
        }

        // https://www.automatas.org/modbus/crc7.html
        public bool CheckLRC()
        {
            if (LRC == Crc8.ComputeChecksum(Encoding.ASCII.GetBytes(byteArray.Remove(byteArray.Length - 2))))
                return true;
            else
                return false;
        }

        public string ToWrite()
        {
            return ":" + byteArray + "\r\n";
        }

        public string ToString()
        {

            return ":" + byteArray + "\\r\\n";
        }

        internal void setWrongCRC()
        {
            byteArray = ((byte)this.addres).ToString("x2") + ((byte)this.function).ToString("x2") + this.args;
            this.LRC = 'b';
            byteArray += ((byte)this.LRC).ToString("x2");
        }
    }

    public static class Crc8
    {
        static byte[] table = new byte[256];
        // x8 + x7 + x6 + x4 + x2 + 1
        const byte poly = 0xd5;

        public static byte ComputeChecksum(params byte[] bytes)
        {
            byte crc = 0;
            if (bytes != null && bytes.Length > 0)
            {
                foreach (byte b in bytes)
                {
                    crc = table[crc ^ b];
                }
            }
            return crc;
        }

        static Crc8()
        {
            for (int i = 0; i < 256; ++i)
            {
                int temp = i;
                for (int j = 0; j < 8; ++j)
                {
                    if ((temp & 0x80) != 0)
                    {
                        temp = (temp << 1) ^ poly;
                    }
                    else
                    {
                        temp <<= 1;
                    }
                }
                table[i] = (byte)temp;
            }
        }
    }

    class ModbusMessageEventArg : EventArgs
    {
        public string message { get; set; }
        public ModbusMessageEventArg(string message)
        {
            this.message = message;
        }
    }
}

