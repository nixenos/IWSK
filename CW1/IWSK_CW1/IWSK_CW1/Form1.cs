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
        Stopwatch timer;
        public Form1()
        {
            InitializeComponent();
            SerialService.RxDataEvent += ReceiveData;
            SerialService.PinChangeEvent += PinMonitor;
            SerialService.PingEvent += PingResolver;
            BaudSelection.SelectedIndex = 0;
            PortSelection.Items.Clear();
            PortSelection.Items.AddRange(SerialService.GetPossibleCOMDevices());

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
    }
}