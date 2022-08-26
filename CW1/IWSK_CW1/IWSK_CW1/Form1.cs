using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IWSK_CW1
{
    public partial class Form1 : Form
    {
        SerialInterfaceServer SerialService = new SerialInterfaceServer();
        ModbusMaster modbusMasterService = new ModbusMaster();
        ModbusSlave modbusSlaveService = new ModbusSlave();
        Stopwatch timer;
        public Form1()
        {
            InitializeComponent();
            BaudComboBox.SelectedIndex = 0;
            StationComboBox.SelectedIndex = 0;
            BaudSelection.SelectedIndex = 0;
            SerialService.RxDataEvent += ReceiveData;
            SerialService.PinChangeEvent += PinMonitor;
            SerialService.PingEvent += PingResolver;
            BaudSelection.SelectedIndex = 0;
            PortSelection.Items.Clear();
            PortSelection.Items.AddRange(SerialService.GetPossibleCOMDevices());
            PortComboBox.Items.Clear();
            PortComboBox.Items.AddRange(modbusMasterService.GetAvaliablePorts());

            modbusSlaveService.CheckSumErrorHandler += ModbusSlave_CheckSumErrorHandler;
            modbusSlaveService.FirstCommandExecutionHandler += ModbusSlave_FirstCommandExecutionHandler;
            modbusSlaveService.ReceivedFrameHandler += ModbusSlave_ReceivedFrameHandler;
            modbusSlaveService.SendFrameHandler += ModbusSlave_SendFrameHandler;
            modbusSlaveService.StatusHandler += ModbusSlave_StatusHandler;

            modbusMasterService.StatusHandler += ModbusMaster_StatusHandler;
            modbusMasterService.FunctionTwoHandler += ModbusMaster_FunctionTwoHandler;
            modbusMasterService.CheckSumErrorHandler += ModbusSlave_CheckSumErrorHandler;
            modbusMasterService.ReceivedFrameHandler += ModbusMaster_ReceivedFrameHandler;
            modbusMasterService.SendFrameHandler += ModbusMaster_SendFrameHandler;
        }
        private void ReceiveData(object sender, EventArgs e)
        {
            if (ReceiveTextbox.InvokeRequired)
            {
                ReceiveTextbox.Invoke(new Action(delegate () { ReceiveTextbox.Text += ((SerialInterfaceEvent)e).data; }));
            }
            else
            {
                ReceiveTextbox.Text += ((SerialInterfaceEvent)e).data + "\n";
            }
        }

        private void PingResolver(object sender, EventArgs e)
        {
            timer.Stop();
            MessageBox.Show(string.Format("Czas {0}ms", timer.ElapsedMilliseconds), "Ping");
        }

        private void PinMonitor(object sender, SerialInterfacePEvent e)
        {
            if (e.CTS)
            {
                CTSLabel.Invoke(new Action(delegate ()
                {
                    CTSLabel.ForeColor = Color.Green;
                }));
            }
            else
            {
                CTSLabel.Invoke(new Action(delegate ()
                {
                    CTSLabel.ForeColor = Color.Red;
                }));
            }
            if (e.DSR)
            {
                DSRLabel.Invoke(new Action(delegate ()
                {
                    DSRLabel.ForeColor = Color.Green;
                }));
            }
            else
            {
                DSRLabel.Invoke(new Action(delegate ()
                {
                    DSRLabel.ForeColor = Color.Red;
                }));
            }
        }

        private void OpenDevice_CheckedChanged(object sender, EventArgs e)
        {
            if (OpenDevice.Checked)
            {
                modbusMasterService.Close();
                modbusSlaveService.Close();
                string serialPort = PortSelection.Text;
                SerialService.UpdateSettings(getSettingsFromForms());
                if (!SerialService.Open(serialPort))
                {
                    return;
                }
                if (FlowControlRTS.Checked)
                {
                    EnableRTS.Enabled = false;
                }
                if (FlowControlDTR.Checked)
                {
                    EnableDTR.Enabled = false;
                }
                groupBox1.Enabled = false;
                groupBox5.Enabled = false;
                groupBox8.Enabled = false;

                groupBox7.Enabled = true;
                groupBox9.Enabled = true;
                groupBox10.Enabled = true;
                groupBox12.Enabled = true;
                OpenDevice.Text = "Zamknij port";
            }
            else
            {
                SerialService.Close();
                EnableRTS.Enabled = true;
                EnableDTR.Enabled = true;

                groupBox1.Enabled = true;
                groupBox5.Enabled = true;
                groupBox8.Enabled = true;

                groupBox7.Enabled = true;
                groupBox9.Enabled = false;
                groupBox10.Enabled = false;
                groupBox12.Enabled = false;
                OpenDevice.Text = "Otwórz port";
            }
        }

        SerialInterfaceServer.Settings getSettingsFromForms()
        {
            SerialInterfaceServer.Settings settings = new SerialInterfaceServer.Settings();
            settings.Baudrate = int.Parse(BaudSelection.Text);
            if (Selection8Bit.Checked)
            {
                settings.BitCount = 8;
            }
            else
            {
                settings.BitCount = 7;
            }


            if (ParitySelectionEven.Checked)
            {
                settings.parity = Parity.Even;
            }
            else if (ParitySelectionOdd.Checked)
            {
                settings.parity = Parity.Odd;
            }
            else
            {
                settings.parity = Parity.None;
            }

            if (StopBitSelection1.Checked)
            {
                settings.stopBits = StopBits.One;
            }
            else
            {
                settings.stopBits = StopBits.Two;
            }

            if (TerminatorSelectionCR.Checked)
            {
                settings.terminator = SerialInterfaceServer.Settings.Terminator.CR;
            }
            else if (TerminatorSelectionLF.Checked)
            {
                settings.terminator = SerialInterfaceServer.Settings.Terminator.LF;
            }
            else if (TerminatorSelectionCRLF.Checked)
            {
                settings.terminator = SerialInterfaceServer.Settings.Terminator.CRLF;
            } 
            else if (TerminatorSelectionCustom.Checked)
            {
                settings.terminator = SerialInterfaceServer.Settings.Terminator.Custom;
                settings.CustomTerminator = CustomTerminatorInput.Text;
            }
            else
            {
                settings.terminator = SerialInterfaceServer.Settings.Terminator.None;
            }

            if (FlowControlXONXOFF.Checked)
            {
                settings.handshake = SerialInterfaceServer.Settings.Handshake.XONXOFF;
            }
            else if (FlowControlDTR.Checked)
            {
                settings.handshake = SerialInterfaceServer.Settings.Handshake.DTR;
            }
            else if (FlowControlRTS.Checked)
            {
                settings.handshake = SerialInterfaceServer.Settings.Handshake.RTS;
            }
            else
            {
                settings.handshake = SerialInterfaceServer.Settings.Handshake.None;
            }

            return settings;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            String data = SendTextbox.Text;
            SerialService.Send(data);
        }

        private void XONButton_Click(object sender, EventArgs e)
        {
            SerialService.SendXON();
        }

        private void XOFFButton_Click(object sender, EventArgs e)
        {
            SerialService.SendXOFF();
        }

        private void EnableDTR_CheckedChanged(object sender, EventArgs e)
        {
            SerialService.SetDTR(EnableDTR.Checked);
        }

        private void EnableRTS_CheckedChanged(object sender, EventArgs e)
        {
            SerialService.SetRTS(EnableRTS.Checked);
        }

        private void PortSelection_Click(object sender, EventArgs e)
        {
            PortSelection.Items.Clear();

            PortSelection.Items.AddRange(SerialService.GetPossibleCOMDevices());
        }

        private void EnablePing_CheckedChanged(object sender, EventArgs e)
        {
            SerialService.SetPing(EnablePing.Checked);
            CheckPing.Enabled = EnablePing.Checked;
        }

        private void CheckPing_Click(object sender, EventArgs e)
        {
            timer = new Stopwatch();
            SerialService.SendPing();
            timer.Start();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            modbusSlaveService.SecondCommand = InputDataToSendSlave.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            modbusMasterService.BadCRCChecksum = !CRCMasterCheckBox.Checked;
        }

        private void OpenPortCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (OpenPortCheckBox.Checked)
            {
                OpenPortCheckBox.Text = "Zamknij port";
                SerialService.Close();
                string serialPortName = PortComboBox.Text;
                int baudRate = int.Parse(BaudComboBox.Text);
                if (StationComboBox.Text.Contains("Master"))
                {
                    modbusMasterService.Open(serialPortName, baudRate);
                    if (!modbusMasterService.IsOpen())
                    {
                        OpenPortCheckBox.Checked = !OpenPortCheckBox.Checked;
                        OpenPortCheckBox.Text = "Otwórz port";
                        return;
                    }
                    ModbusMasterGroupBox.Enabled = true;
                    ModbusSlaveGroupBox.Enabled = false;
                }
                else
                {
                    modbusSlaveService.Open(serialPortName, baudRate);
                    if (!modbusSlaveService.IsOpen())
                    {
                        OpenPortCheckBox.Checked = !OpenPortCheckBox.Checked;
                        OpenPortCheckBox.Text = "Otwórz port";
                        return;
                    }
                    ModbusMasterGroupBox.Enabled = false;
                    ModbusSlaveGroupBox.Enabled = true;
                }
            }
            else
            {
                modbusMasterService.Close();
                modbusSlaveService.Close();
                ModbusMasterGroupBox.Enabled = false;
                ModbusSlaveGroupBox.Enabled = false;
                OpenPortCheckBox.Text = "Otwórz port";
            }
        }

        //SLAVE
        private void ModbusSlave_ReceivedFrameHandler(object sender, ModbusMessageEventArg e)
        {
            ReceivedFrameTextFieldSlave.Invoke(new Action(() =>
            {
                ReceivedFrameTextFieldSlave.Text = e.message;
            }));
        }
        private void ModbusSlave_FirstCommandExecutionHandler(object sender, ModbusMessageEventArg e)
        {
            ReceivedDataTextFieldSlave.Invoke(new Action(() =>
            {
                ReceivedDataTextFieldSlave.Text = e.message;
            }));
        }
        private void ModbusSlave_SendFrameHandler(object sender, ModbusMessageEventArg e)
        {
            SentFrameTextFieldSlave.Invoke(new Action(() =>
            {
                SentFrameTextFieldSlave.Text = e.message;
            }));
        }
        private void ModbusSlave_CheckSumErrorHandler(object sender, ModbusMessageEventArg e)
        {
            MessageBox.Show(e.message, "Bad Checksum");
        }
        private void ModbusSlave_StatusHandler(object sender, ModbusMessageEventArg e)
        {
            StatusFieldSlave.Invoke(new Action(() =>
            {
                StatusFieldSlave.Text = e.message;
            }));
        }

        private void CRCSlaveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            modbusSlaveService.BadCRCChecksum = !CRCSlaveCheckBox.Checked;
        }

        private void TransactionButton_Click(object sender, EventArgs e)
        {
            int slaveAddress = decimal.ToInt32(SlaveAddressSelectionMaster.Value);
            int functionCode = decimal.ToInt32(FunctionCodeSelection.Value);
            string functionArguments = FunctionArgsInput.Text;
            int chars = decimal.ToInt32(CharTimeSelection.Value); //T (single char) timeout
            int retransmissionsCount = decimal.ToInt32(RetransmitTimesSelection.Value);
            int transactionTimeout = decimal.ToInt32(TransactionTimeSelection.Value);

            SentFrameField.Text = "";
            ReceivedFrameField.Text = "";
            ReceivedDataField.Text = "";
            StatusField.Text = "";

            modbusMasterService.RunTransaction(slaveAddress, functionCode, functionArguments, chars, transactionTimeout, retransmissionsCount);
            Application.DoEvents();
        }

        private void ModbusMaster_StatusHandler(object sender, ModbusMessageEventArg e)
        {
            StatusField.Invoke(new Action(() =>
            {
                StatusField.Text = e.message;
            }));
        }
        private void ModbusMaster_FunctionTwoHandler(object sender, ModbusMessageEventArg e)
        {
            ReceivedDataField.Invoke(new Action(() =>
            {
                ReceivedDataField.Text = e.message;
            }));

        }
        private void ModbusMaster_ReceivedFrameHandler(object sender, ModbusMessageEventArg e)
        {
            ReceivedFrameField.Invoke(new Action(() =>
            {
                ReceivedFrameField.Text = e.message;
            }));
        }
        private void ModbusMaster_SendFrameHandler(object sender, ModbusMessageEventArg e)
        {
            SentFrameField.Invoke(new Action(() =>
            {
                SentFrameField.Text = e.message;
            }));
        }

        private void SentFrameHexButton_Click(object sender, EventArgs e)
        {
            string temp = SentFrameField.Text;
            temp = temp.Replace("\\n", "\n").Replace("\\r", "\r");
            string hexDump = "";
            foreach(char c in temp)
            {
                hexDump += "0x" + Convert.ToByte(c).ToString("x2") + " ";
            }
            MessageBox.Show(hexDump, "Konwersja do hex");
        }

        private void ReceivedFrameHexButton_Click(object sender, EventArgs e)
        {
            string temp = ReceivedFrameField.Text;
            temp = temp.Replace("\\n", "\n").Replace("\\r", "\r");
            string hexDump = "";
            foreach (char c in temp)
            {
                hexDump += "0x" + Convert.ToByte(c).ToString("x2") + " ";
            }
            MessageBox.Show(hexDump, "Konwersja do hex");
        }

        private void SentFrameTextFieldSlave_TextChanged(object sender, EventArgs e)
        {

        }

        private void SentFrameHexButtonSlave_Click(object sender, EventArgs e)
        {
            string temp = SentFrameTextFieldSlave.Text;
            temp = temp.Replace("\\n", "\n").Replace("\\r", "\r");
            string hexDump = "";
            foreach (char c in temp)
            {
                hexDump += "0x" + Convert.ToByte(c).ToString("x2") + " ";
            }
            MessageBox.Show(hexDump, "Konwersja do hex");
        }

        private void ReceivedFrameHexButtonSlave_Click(object sender, EventArgs e)
        {
            string temp = ReceivedFrameTextFieldSlave.Text;
            temp = temp.Replace("\\n", "\n").Replace("\\r", "\r");
            string hexDump = "";
            foreach (char c in temp)
            {
                hexDump += "0x" + Convert.ToByte(c).ToString("x2") + " ";
            }
            MessageBox.Show(hexDump, "Konwersja do hex");
        }

        private void OpenSlaveButton_CheckedChanged(object sender, EventArgs e)
        {
                if (OpenSlaveButton.Checked)
                {
                    int address = decimal.ToInt32(SlaveAddressSelection.Value);
                    int CharacterTimeout = decimal.ToInt32(CharTimeSelectionSlave.Value);
                    modbusSlaveService.SecondCommand = InputDataToSendSlave.Text;
                    modbusSlaveService.Run(address, CharacterTimeout);
                    SlaveAddressSelection.Enabled = false;
                    CharTimeSelectionSlave.Enabled = false;
                    OpenSlaveButton.Text = "Wy³¹cz";
                }
                else
                {
                    modbusSlaveService.Stop();
                    SlaveAddressSelection.Enabled = true;
                    CharTimeSelectionSlave.Enabled = true;
                    OpenSlaveButton.Text = "Uruchom";
                }
                ReceivedFrameField.Text = "";
                ReceivedDataField.Text = "";
                SentFrameField.Text = "";
                StatusFieldSlave.Text = "";
            }

        //MASTER

    }
}