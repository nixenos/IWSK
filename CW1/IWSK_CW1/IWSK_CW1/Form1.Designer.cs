namespace IWSK_CW1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OpenDevice = new System.Windows.Forms.CheckBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.ReceiveTextbox = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.SendTextbox = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.EnablePing = new System.Windows.Forms.CheckBox();
            this.CheckPing = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.FlowControlXONXOFF = new System.Windows.Forms.RadioButton();
            this.FlowControlRTS = new System.Windows.Forms.RadioButton();
            this.FlowControlDTR = new System.Windows.Forms.RadioButton();
            this.FlowControlNone = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.EnableRTS = new System.Windows.Forms.CheckBox();
            this.EnableDTR = new System.Windows.Forms.CheckBox();
            this.CTSLabel = new System.Windows.Forms.Label();
            this.DSRLabel = new System.Windows.Forms.Label();
            this.XOFFButton = new System.Windows.Forms.Button();
            this.XONButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CustomTerminatorInput = new System.Windows.Forms.TextBox();
            this.TerminatorSelectionCustom = new System.Windows.Forms.RadioButton();
            this.TerminatorSelectionCRLF = new System.Windows.Forms.RadioButton();
            this.TerminatorSelectionLF = new System.Windows.Forms.RadioButton();
            this.TerminatorSelectionCR = new System.Windows.Forms.RadioButton();
            this.TerminatorSelectionNone = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ParitySelectionOdd = new System.Windows.Forms.RadioButton();
            this.ParitySelectionNone = new System.Windows.Forms.RadioButton();
            this.ParitySelectionEven = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.StopBitSelection2 = new System.Windows.Forms.RadioButton();
            this.StopBitSelection1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Selection7Bit = new System.Windows.Forms.RadioButton();
            this.Selection8Bit = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BaudSelection = new System.Windows.Forms.ComboBox();
            this.PortSelection = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ModbusSlaveGroupBox = new System.Windows.Forms.GroupBox();
            this.OpenSlaveButton = new System.Windows.Forms.CheckBox();
            this.CRCSlaveCheckBox = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.ReceivedFrameHexButtonSlave = new System.Windows.Forms.Button();
            this.InputDataToSendSlave = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.SentFrameHexButtonSlave = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.StatusFieldSlave = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.CharTimeSelectionSlave = new System.Windows.Forms.NumericUpDown();
            this.ReceivedDataTextFieldSlave = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ReceivedFrameTextFieldSlave = new System.Windows.Forms.TextBox();
            this.SentFrameTextFieldSlave = new System.Windows.Forms.TextBox();
            this.SlaveAddressSelection = new System.Windows.Forms.NumericUpDown();
            this.ModbusMasterGroupBox = new System.Windows.Forms.GroupBox();
            this.ReceivedFrameHexButton = new System.Windows.Forms.Button();
            this.SentFrameHexButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CRCMasterCheckBox = new System.Windows.Forms.CheckBox();
            this.TransactionButton = new System.Windows.Forms.Button();
            this.StatusField = new System.Windows.Forms.TextBox();
            this.ReceivedDataField = new System.Windows.Forms.TextBox();
            this.ReceivedFrameField = new System.Windows.Forms.TextBox();
            this.SentFrameField = new System.Windows.Forms.TextBox();
            this.FunctionArgsInput = new System.Windows.Forms.TextBox();
            this.CharTimeSelection = new System.Windows.Forms.NumericUpDown();
            this.RetransmitTimesSelection = new System.Windows.Forms.NumericUpDown();
            this.TransactionTimeSelection = new System.Windows.Forms.NumericUpDown();
            this.FunctionCodeSelection = new System.Windows.Forms.NumericUpDown();
            this.SlaveAddressSelectionMaster = new System.Windows.Forms.NumericUpDown();
            this.ModbusPortBox = new System.Windows.Forms.GroupBox();
            this.OpenPortCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StationComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BaudComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PortComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.ModbusSlaveGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharTimeSelectionSlave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlaveAddressSelection)).BeginInit();
            this.ModbusMasterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharTimeSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetransmitTimesSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionTimeSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunctionCodeSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlaveAddressSelectionMaster)).BeginInit();
            this.ModbusPortBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(956, 600);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.OpenDevice);
            this.tabPage1.Controls.Add(this.groupBox12);
            this.tabPage1.Controls.Add(this.groupBox10);
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(948, 572);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Zadanie 1 (RS232)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // OpenDevice
            // 
            this.OpenDevice.Appearance = System.Windows.Forms.Appearance.Button;
            this.OpenDevice.AutoSize = true;
            this.OpenDevice.Location = new System.Drawing.Point(572, 89);
            this.OpenDevice.Name = "OpenDevice";
            this.OpenDevice.Size = new System.Drawing.Size(80, 25);
            this.OpenDevice.TabIndex = 10;
            this.OpenDevice.Text = "Otwórz port";
            this.OpenDevice.UseVisualStyleBackColor = true;
            this.OpenDevice.CheckedChanged += new System.EventHandler(this.OpenDevice_CheckedChanged);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.ReceiveTextbox);
            this.groupBox12.Location = new System.Drawing.Point(303, 267);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(632, 299);
            this.groupBox12.TabIndex = 9;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Odbierz";
            // 
            // ReceiveTextbox
            // 
            this.ReceiveTextbox.Location = new System.Drawing.Point(6, 22);
            this.ReceiveTextbox.Multiline = true;
            this.ReceiveTextbox.Name = "ReceiveTextbox";
            this.ReceiveTextbox.ReadOnly = true;
            this.ReceiveTextbox.Size = new System.Drawing.Size(620, 271);
            this.ReceiveTextbox.TabIndex = 0;
            this.ReceiveTextbox.Text = "\r\n\r\n\r\n\r\n\r\n";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.SendButton);
            this.groupBox10.Controls.Add(this.SendTextbox);
            this.groupBox10.Enabled = false;
            this.groupBox10.Location = new System.Drawing.Point(297, 158);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(644, 90);
            this.groupBox10.TabIndex = 7;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Wyślij";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(6, 61);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(632, 23);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Wyślij";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // SendTextbox
            // 
            this.SendTextbox.Location = new System.Drawing.Point(6, 25);
            this.SendTextbox.Name = "SendTextbox";
            this.SendTextbox.Size = new System.Drawing.Size(632, 23);
            this.SendTextbox.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.EnablePing);
            this.groupBox9.Controls.Add(this.CheckPing);
            this.groupBox9.Enabled = false;
            this.groupBox9.Location = new System.Drawing.Point(297, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(644, 42);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Ping";
            // 
            // EnablePing
            // 
            this.EnablePing.Appearance = System.Windows.Forms.Appearance.Button;
            this.EnablePing.AutoSize = true;
            this.EnablePing.Location = new System.Drawing.Point(49, 13);
            this.EnablePing.Name = "EnablePing";
            this.EnablePing.Size = new System.Drawing.Size(118, 25);
            this.EnablePing.TabIndex = 6;
            this.EnablePing.Text = "Uruchom tryb ping";
            this.EnablePing.UseVisualStyleBackColor = true;
            this.EnablePing.CheckedChanged += new System.EventHandler(this.EnablePing_CheckedChanged);
            // 
            // CheckPing
            // 
            this.CheckPing.Location = new System.Drawing.Point(479, 13);
            this.CheckPing.Name = "CheckPing";
            this.CheckPing.Size = new System.Drawing.Size(109, 23);
            this.CheckPing.TabIndex = 5;
            this.CheckPing.Text = "Test";
            this.CheckPing.UseVisualStyleBackColor = true;
            this.CheckPing.Click += new System.EventHandler(this.CheckPing_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Location = new System.Drawing.Point(6, 373);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(285, 193);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Kontrola";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.FlowControlXONXOFF);
            this.groupBox8.Controls.Add(this.FlowControlRTS);
            this.groupBox8.Controls.Add(this.FlowControlDTR);
            this.groupBox8.Controls.Add(this.FlowControlNone);
            this.groupBox8.Location = new System.Drawing.Point(139, 22);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(140, 165);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Przepływ";
            // 
            // FlowControlXONXOFF
            // 
            this.FlowControlXONXOFF.AutoSize = true;
            this.FlowControlXONXOFF.Location = new System.Drawing.Point(6, 105);
            this.FlowControlXONXOFF.Name = "FlowControlXONXOFF";
            this.FlowControlXONXOFF.Size = new System.Drawing.Size(83, 19);
            this.FlowControlXONXOFF.TabIndex = 11;
            this.FlowControlXONXOFF.Text = "XON/XOFF";
            this.FlowControlXONXOFF.UseVisualStyleBackColor = true;
            // 
            // FlowControlRTS
            // 
            this.FlowControlRTS.AutoSize = true;
            this.FlowControlRTS.Location = new System.Drawing.Point(6, 80);
            this.FlowControlRTS.Name = "FlowControlRTS";
            this.FlowControlRTS.Size = new System.Drawing.Size(68, 19);
            this.FlowControlRTS.TabIndex = 10;
            this.FlowControlRTS.Text = "RTS/CTS";
            this.FlowControlRTS.UseVisualStyleBackColor = true;
            // 
            // FlowControlDTR
            // 
            this.FlowControlDTR.AutoSize = true;
            this.FlowControlDTR.Location = new System.Drawing.Point(6, 55);
            this.FlowControlDTR.Name = "FlowControlDTR";
            this.FlowControlDTR.Size = new System.Drawing.Size(71, 19);
            this.FlowControlDTR.TabIndex = 9;
            this.FlowControlDTR.Text = "DTR/DSR";
            this.FlowControlDTR.UseVisualStyleBackColor = true;
            // 
            // FlowControlNone
            // 
            this.FlowControlNone.AutoSize = true;
            this.FlowControlNone.Checked = true;
            this.FlowControlNone.Location = new System.Drawing.Point(6, 30);
            this.FlowControlNone.Name = "FlowControlNone";
            this.FlowControlNone.Size = new System.Drawing.Size(48, 19);
            this.FlowControlNone.TabIndex = 8;
            this.FlowControlNone.TabStop = true;
            this.FlowControlNone.Text = "Brak";
            this.FlowControlNone.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.EnableRTS);
            this.groupBox7.Controls.Add(this.EnableDTR);
            this.groupBox7.Controls.Add(this.CTSLabel);
            this.groupBox7.Controls.Add(this.DSRLabel);
            this.groupBox7.Controls.Add(this.XOFFButton);
            this.groupBox7.Controls.Add(this.XONButton);
            this.groupBox7.Location = new System.Drawing.Point(6, 22);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(121, 165);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Sterowanie";
            // 
            // EnableRTS
            // 
            this.EnableRTS.Appearance = System.Windows.Forms.Appearance.Button;
            this.EnableRTS.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnableRTS.Location = new System.Drawing.Point(6, 55);
            this.EnableRTS.Name = "EnableRTS";
            this.EnableRTS.Size = new System.Drawing.Size(48, 23);
            this.EnableRTS.TabIndex = 12;
            this.EnableRTS.Text = "RTS";
            this.EnableRTS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnableRTS.UseVisualStyleBackColor = true;
            this.EnableRTS.CheckedChanged += new System.EventHandler(this.EnableRTS_CheckedChanged);
            // 
            // EnableDTR
            // 
            this.EnableDTR.Appearance = System.Windows.Forms.Appearance.Button;
            this.EnableDTR.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnableDTR.Location = new System.Drawing.Point(6, 22);
            this.EnableDTR.Name = "EnableDTR";
            this.EnableDTR.Size = new System.Drawing.Size(48, 23);
            this.EnableDTR.TabIndex = 11;
            this.EnableDTR.Text = "DTR";
            this.EnableDTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnableDTR.UseVisualStyleBackColor = true;
            this.EnableDTR.CheckedChanged += new System.EventHandler(this.EnableDTR_CheckedChanged);
            // 
            // CTSLabel
            // 
            this.CTSLabel.AutoSize = true;
            this.CTSLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CTSLabel.ForeColor = System.Drawing.Color.Red;
            this.CTSLabel.Location = new System.Drawing.Point(77, 55);
            this.CTSLabel.Name = "CTSLabel";
            this.CTSLabel.Size = new System.Drawing.Size(28, 15);
            this.CTSLabel.TabIndex = 5;
            this.CTSLabel.Text = "CTS";
            // 
            // DSRLabel
            // 
            this.DSRLabel.AutoSize = true;
            this.DSRLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DSRLabel.ForeColor = System.Drawing.Color.Red;
            this.DSRLabel.Location = new System.Drawing.Point(77, 26);
            this.DSRLabel.Name = "DSRLabel";
            this.DSRLabel.Size = new System.Drawing.Size(31, 15);
            this.DSRLabel.TabIndex = 4;
            this.DSRLabel.Text = "DSR";
            // 
            // XOFFButton
            // 
            this.XOFFButton.Location = new System.Drawing.Point(6, 129);
            this.XOFFButton.Name = "XOFFButton";
            this.XOFFButton.Size = new System.Drawing.Size(109, 23);
            this.XOFFButton.TabIndex = 3;
            this.XOFFButton.Text = "XOFF";
            this.XOFFButton.UseVisualStyleBackColor = true;
            this.XOFFButton.Click += new System.EventHandler(this.XOFFButton_Click);
            // 
            // XONButton
            // 
            this.XONButton.Location = new System.Drawing.Point(6, 100);
            this.XONButton.Name = "XONButton";
            this.XONButton.Size = new System.Drawing.Size(109, 23);
            this.XONButton.TabIndex = 2;
            this.XONButton.Text = "XON";
            this.XONButton.UseVisualStyleBackColor = true;
            this.XONButton.Click += new System.EventHandler(this.XONButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CustomTerminatorInput);
            this.groupBox5.Controls.Add(this.TerminatorSelectionCustom);
            this.groupBox5.Controls.Add(this.TerminatorSelectionCRLF);
            this.groupBox5.Controls.Add(this.TerminatorSelectionLF);
            this.groupBox5.Controls.Add(this.TerminatorSelectionCR);
            this.groupBox5.Controls.Add(this.TerminatorSelectionNone);
            this.groupBox5.Location = new System.Drawing.Point(6, 237);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(285, 130);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Terminator";
            // 
            // CustomTerminatorInput
            // 
            this.CustomTerminatorInput.Location = new System.Drawing.Point(179, 47);
            this.CustomTerminatorInput.Name = "CustomTerminatorInput";
            this.CustomTerminatorInput.Size = new System.Drawing.Size(86, 23);
            this.CustomTerminatorInput.TabIndex = 9;
            // 
            // TerminatorSelectionCustom
            // 
            this.TerminatorSelectionCustom.AutoSize = true;
            this.TerminatorSelectionCustom.Location = new System.Drawing.Point(179, 22);
            this.TerminatorSelectionCustom.Name = "TerminatorSelectionCustom";
            this.TerminatorSelectionCustom.Size = new System.Drawing.Size(63, 19);
            this.TerminatorSelectionCustom.TabIndex = 8;
            this.TerminatorSelectionCustom.Text = "Własny";
            this.TerminatorSelectionCustom.UseVisualStyleBackColor = true;
            // 
            // TerminatorSelectionCRLF
            // 
            this.TerminatorSelectionCRLF.AutoSize = true;
            this.TerminatorSelectionCRLF.Location = new System.Drawing.Point(12, 97);
            this.TerminatorSelectionCRLF.Name = "TerminatorSelectionCRLF";
            this.TerminatorSelectionCRLF.Size = new System.Drawing.Size(52, 19);
            this.TerminatorSelectionCRLF.TabIndex = 7;
            this.TerminatorSelectionCRLF.Text = "CRLF";
            this.TerminatorSelectionCRLF.UseVisualStyleBackColor = true;
            // 
            // TerminatorSelectionLF
            // 
            this.TerminatorSelectionLF.AutoSize = true;
            this.TerminatorSelectionLF.Location = new System.Drawing.Point(12, 72);
            this.TerminatorSelectionLF.Name = "TerminatorSelectionLF";
            this.TerminatorSelectionLF.Size = new System.Drawing.Size(37, 19);
            this.TerminatorSelectionLF.TabIndex = 6;
            this.TerminatorSelectionLF.Text = "LF";
            this.TerminatorSelectionLF.UseVisualStyleBackColor = true;
            // 
            // TerminatorSelectionCR
            // 
            this.TerminatorSelectionCR.AutoSize = true;
            this.TerminatorSelectionCR.Location = new System.Drawing.Point(12, 47);
            this.TerminatorSelectionCR.Name = "TerminatorSelectionCR";
            this.TerminatorSelectionCR.Size = new System.Drawing.Size(40, 19);
            this.TerminatorSelectionCR.TabIndex = 5;
            this.TerminatorSelectionCR.Text = "CR";
            this.TerminatorSelectionCR.UseVisualStyleBackColor = true;
            // 
            // TerminatorSelectionNone
            // 
            this.TerminatorSelectionNone.AutoSize = true;
            this.TerminatorSelectionNone.Checked = true;
            this.TerminatorSelectionNone.Location = new System.Drawing.Point(12, 22);
            this.TerminatorSelectionNone.Name = "TerminatorSelectionNone";
            this.TerminatorSelectionNone.Size = new System.Drawing.Size(48, 19);
            this.TerminatorSelectionNone.TabIndex = 4;
            this.TerminatorSelectionNone.TabStop = true;
            this.TerminatorSelectionNone.Text = "Brak";
            this.TerminatorSelectionNone.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BaudSelection);
            this.groupBox1.Controls.Add(this.PortSelection);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ParitySelectionOdd);
            this.groupBox4.Controls.Add(this.ParitySelectionNone);
            this.groupBox4.Controls.Add(this.ParitySelectionEven);
            this.groupBox4.Location = new System.Drawing.Point(133, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(146, 97);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bity parzystości";
            // 
            // ParitySelectionOdd
            // 
            this.ParitySelectionOdd.AutoSize = true;
            this.ParitySelectionOdd.Location = new System.Drawing.Point(6, 72);
            this.ParitySelectionOdd.Name = "ParitySelectionOdd";
            this.ParitySelectionOdd.Size = new System.Drawing.Size(86, 19);
            this.ParitySelectionOdd.TabIndex = 3;
            this.ParitySelectionOdd.Text = "Nieparzyste";
            this.ParitySelectionOdd.UseVisualStyleBackColor = true;
            // 
            // ParitySelectionNone
            // 
            this.ParitySelectionNone.AutoSize = true;
            this.ParitySelectionNone.Checked = true;
            this.ParitySelectionNone.Location = new System.Drawing.Point(6, 22);
            this.ParitySelectionNone.Name = "ParitySelectionNone";
            this.ParitySelectionNone.Size = new System.Drawing.Size(48, 19);
            this.ParitySelectionNone.TabIndex = 2;
            this.ParitySelectionNone.TabStop = true;
            this.ParitySelectionNone.Text = "Brak";
            this.ParitySelectionNone.UseVisualStyleBackColor = true;
            // 
            // ParitySelectionEven
            // 
            this.ParitySelectionEven.AutoSize = true;
            this.ParitySelectionEven.Location = new System.Drawing.Point(6, 47);
            this.ParitySelectionEven.Name = "ParitySelectionEven";
            this.ParitySelectionEven.Size = new System.Drawing.Size(68, 19);
            this.ParitySelectionEven.TabIndex = 1;
            this.ParitySelectionEven.Text = "Parzyste";
            this.ParitySelectionEven.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.StopBitSelection2);
            this.groupBox3.Controls.Add(this.StopBitSelection1);
            this.groupBox3.Location = new System.Drawing.Point(133, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 82);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bity stopu";
            // 
            // StopBitSelection2
            // 
            this.StopBitSelection2.AutoSize = true;
            this.StopBitSelection2.Location = new System.Drawing.Point(6, 47);
            this.StopBitSelection2.Name = "StopBitSelection2";
            this.StopBitSelection2.Size = new System.Drawing.Size(54, 19);
            this.StopBitSelection2.TabIndex = 2;
            this.StopBitSelection2.Text = "2 bity";
            this.StopBitSelection2.UseVisualStyleBackColor = true;
            // 
            // StopBitSelection1
            // 
            this.StopBitSelection1.AutoSize = true;
            this.StopBitSelection1.Checked = true;
            this.StopBitSelection1.Location = new System.Drawing.Point(6, 22);
            this.StopBitSelection1.Name = "StopBitSelection1";
            this.StopBitSelection1.Size = new System.Drawing.Size(48, 19);
            this.StopBitSelection1.TabIndex = 1;
            this.StopBitSelection1.TabStop = true;
            this.StopBitSelection1.Text = "1 bit";
            this.StopBitSelection1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Selection7Bit);
            this.groupBox2.Controls.Add(this.Selection8Bit);
            this.groupBox2.Location = new System.Drawing.Point(6, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 82);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liczba bitów";
            // 
            // Selection7Bit
            // 
            this.Selection7Bit.AutoSize = true;
            this.Selection7Bit.Location = new System.Drawing.Point(6, 47);
            this.Selection7Bit.Name = "Selection7Bit";
            this.Selection7Bit.Size = new System.Drawing.Size(64, 19);
            this.Selection7Bit.TabIndex = 1;
            this.Selection7Bit.Text = "7 bitów";
            this.Selection7Bit.UseVisualStyleBackColor = true;
            // 
            // Selection8Bit
            // 
            this.Selection8Bit.AutoSize = true;
            this.Selection8Bit.Checked = true;
            this.Selection8Bit.Location = new System.Drawing.Point(6, 22);
            this.Selection8Bit.Name = "Selection8Bit";
            this.Selection8Bit.Size = new System.Drawing.Size(64, 19);
            this.Selection8Bit.TabIndex = 0;
            this.Selection8Bit.TabStop = true;
            this.Selection8Bit.Text = "8 bitów";
            this.Selection8Bit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port";
            // 
            // BaudSelection
            // 
            this.BaudSelection.FormattingEnabled = true;
            this.BaudSelection.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.BaudSelection.Location = new System.Drawing.Point(6, 101);
            this.BaudSelection.Name = "BaudSelection";
            this.BaudSelection.Size = new System.Drawing.Size(121, 23);
            this.BaudSelection.TabIndex = 1;
            // 
            // PortSelection
            // 
            this.PortSelection.FormattingEnabled = true;
            this.PortSelection.Location = new System.Drawing.Point(6, 45);
            this.PortSelection.Name = "PortSelection";
            this.PortSelection.Size = new System.Drawing.Size(121, 23);
            this.PortSelection.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ModbusSlaveGroupBox);
            this.tabPage2.Controls.Add(this.ModbusMasterGroupBox);
            this.tabPage2.Controls.Add(this.ModbusPortBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(948, 572);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Zadanie 2 (MODBUS ASCII)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ModbusSlaveGroupBox
            // 
            this.ModbusSlaveGroupBox.Controls.Add(this.OpenSlaveButton);
            this.ModbusSlaveGroupBox.Controls.Add(this.CRCSlaveCheckBox);
            this.ModbusSlaveGroupBox.Controls.Add(this.label22);
            this.ModbusSlaveGroupBox.Controls.Add(this.ReceivedFrameHexButtonSlave);
            this.ModbusSlaveGroupBox.Controls.Add(this.InputDataToSendSlave);
            this.ModbusSlaveGroupBox.Controls.Add(this.label18);
            this.ModbusSlaveGroupBox.Controls.Add(this.SentFrameHexButtonSlave);
            this.ModbusSlaveGroupBox.Controls.Add(this.label17);
            this.ModbusSlaveGroupBox.Controls.Add(this.label19);
            this.ModbusSlaveGroupBox.Controls.Add(this.StatusFieldSlave);
            this.ModbusSlaveGroupBox.Controls.Add(this.label20);
            this.ModbusSlaveGroupBox.Controls.Add(this.label21);
            this.ModbusSlaveGroupBox.Controls.Add(this.CharTimeSelectionSlave);
            this.ModbusSlaveGroupBox.Controls.Add(this.ReceivedDataTextFieldSlave);
            this.ModbusSlaveGroupBox.Controls.Add(this.label16);
            this.ModbusSlaveGroupBox.Controls.Add(this.ReceivedFrameTextFieldSlave);
            this.ModbusSlaveGroupBox.Controls.Add(this.SentFrameTextFieldSlave);
            this.ModbusSlaveGroupBox.Controls.Add(this.SlaveAddressSelection);
            this.ModbusSlaveGroupBox.Enabled = false;
            this.ModbusSlaveGroupBox.Location = new System.Drawing.Point(10, 352);
            this.ModbusSlaveGroupBox.Name = "ModbusSlaveGroupBox";
            this.ModbusSlaveGroupBox.Size = new System.Drawing.Size(935, 214);
            this.ModbusSlaveGroupBox.TabIndex = 2;
            this.ModbusSlaveGroupBox.TabStop = false;
            this.ModbusSlaveGroupBox.Text = "Slave";
            // 
            // OpenSlaveButton
            // 
            this.OpenSlaveButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.OpenSlaveButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OpenSlaveButton.Location = new System.Drawing.Point(7, 165);
            this.OpenSlaveButton.Name = "OpenSlaveButton";
            this.OpenSlaveButton.Size = new System.Drawing.Size(120, 43);
            this.OpenSlaveButton.TabIndex = 32;
            this.OpenSlaveButton.Text = "Uruchom";
            this.OpenSlaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OpenSlaveButton.UseVisualStyleBackColor = true;
            this.OpenSlaveButton.CheckedChanged += new System.EventHandler(this.OpenSlaveButton_CheckedChanged);
            // 
            // CRCSlaveCheckBox
            // 
            this.CRCSlaveCheckBox.AutoSize = true;
            this.CRCSlaveCheckBox.Checked = true;
            this.CRCSlaveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CRCSlaveCheckBox.Location = new System.Drawing.Point(141, 189);
            this.CRCSlaveCheckBox.Name = "CRCSlaveCheckBox";
            this.CRCSlaveCheckBox.Size = new System.Drawing.Size(49, 19);
            this.CRCSlaveCheckBox.TabIndex = 24;
            this.CRCSlaveCheckBox.Text = "CRC";
            this.CRCSlaveCheckBox.UseVisualStyleBackColor = true;
            this.CRCSlaveCheckBox.CheckedChanged += new System.EventHandler(this.CRCSlaveCheckBox_CheckedChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(588, 39);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(92, 15);
            this.label22.TabIndex = 25;
            this.label22.Text = "Dane do wysyłki";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // ReceivedFrameHexButtonSlave
            // 
            this.ReceivedFrameHexButtonSlave.Location = new System.Drawing.Point(415, 113);
            this.ReceivedFrameHexButtonSlave.Name = "ReceivedFrameHexButtonSlave";
            this.ReceivedFrameHexButtonSlave.Size = new System.Drawing.Size(75, 23);
            this.ReceivedFrameHexButtonSlave.TabIndex = 31;
            this.ReceivedFrameHexButtonSlave.Text = "HEX";
            this.ReceivedFrameHexButtonSlave.UseVisualStyleBackColor = true;
            this.ReceivedFrameHexButtonSlave.Click += new System.EventHandler(this.ReceivedFrameHexButtonSlave_Click);
            // 
            // InputDataToSendSlave
            // 
            this.InputDataToSendSlave.Location = new System.Drawing.Point(587, 60);
            this.InputDataToSendSlave.Name = "InputDataToSendSlave";
            this.InputDataToSendSlave.Size = new System.Drawing.Size(190, 23);
            this.InputDataToSendSlave.TabIndex = 24;
            this.InputDataToSendSlave.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 15);
            this.label18.TabIndex = 25;
            this.label18.Text = "Status";
            // 
            // SentFrameHexButtonSlave
            // 
            this.SentFrameHexButtonSlave.Location = new System.Drawing.Point(415, 60);
            this.SentFrameHexButtonSlave.Name = "SentFrameHexButtonSlave";
            this.SentFrameHexButtonSlave.Size = new System.Drawing.Size(75, 23);
            this.SentFrameHexButtonSlave.TabIndex = 30;
            this.SentFrameHexButtonSlave.Text = "HEX";
            this.SentFrameHexButtonSlave.UseVisualStyleBackColor = true;
            this.SentFrameHexButtonSlave.Click += new System.EventHandler(this.SentFrameHexButtonSlave_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 15);
            this.label17.TabIndex = 25;
            this.label17.Text = "Czas znaku T (ms)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(220, 144);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 15);
            this.label19.TabIndex = 29;
            this.label19.Text = "Odebrane dane";
            // 
            // StatusFieldSlave
            // 
            this.StatusFieldSlave.Location = new System.Drawing.Point(7, 131);
            this.StatusFieldSlave.Name = "StatusFieldSlave";
            this.StatusFieldSlave.ReadOnly = true;
            this.StatusFieldSlave.Size = new System.Drawing.Size(120, 23);
            this.StatusFieldSlave.TabIndex = 24;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(219, 95);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 15);
            this.label20.TabIndex = 28;
            this.label20.Text = "Odebrana ramka";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(219, 42);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 15);
            this.label21.TabIndex = 27;
            this.label21.Text = "Wysłana ramka";
            // 
            // CharTimeSelectionSlave
            // 
            this.CharTimeSelectionSlave.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CharTimeSelectionSlave.Location = new System.Drawing.Point(7, 89);
            this.CharTimeSelectionSlave.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CharTimeSelectionSlave.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.CharTimeSelectionSlave.Name = "CharTimeSelectionSlave";
            this.CharTimeSelectionSlave.Size = new System.Drawing.Size(120, 23);
            this.CharTimeSelectionSlave.TabIndex = 24;
            this.CharTimeSelectionSlave.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ReceivedDataTextFieldSlave
            // 
            this.ReceivedDataTextFieldSlave.Location = new System.Drawing.Point(219, 165);
            this.ReceivedDataTextFieldSlave.Name = "ReceivedDataTextFieldSlave";
            this.ReceivedDataTextFieldSlave.ReadOnly = true;
            this.ReceivedDataTextFieldSlave.Size = new System.Drawing.Size(190, 23);
            this.ReceivedDataTextFieldSlave.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 15);
            this.label16.TabIndex = 25;
            this.label16.Text = "Adres";
            // 
            // ReceivedFrameTextFieldSlave
            // 
            this.ReceivedFrameTextFieldSlave.Location = new System.Drawing.Point(219, 113);
            this.ReceivedFrameTextFieldSlave.Name = "ReceivedFrameTextFieldSlave";
            this.ReceivedFrameTextFieldSlave.ReadOnly = true;
            this.ReceivedFrameTextFieldSlave.Size = new System.Drawing.Size(190, 23);
            this.ReceivedFrameTextFieldSlave.TabIndex = 25;
            // 
            // SentFrameTextFieldSlave
            // 
            this.SentFrameTextFieldSlave.Location = new System.Drawing.Point(220, 60);
            this.SentFrameTextFieldSlave.Name = "SentFrameTextFieldSlave";
            this.SentFrameTextFieldSlave.ReadOnly = true;
            this.SentFrameTextFieldSlave.Size = new System.Drawing.Size(189, 23);
            this.SentFrameTextFieldSlave.TabIndex = 24;
            this.SentFrameTextFieldSlave.TextChanged += new System.EventHandler(this.SentFrameTextFieldSlave_TextChanged);
            // 
            // SlaveAddressSelection
            // 
            this.SlaveAddressSelection.Location = new System.Drawing.Point(6, 46);
            this.SlaveAddressSelection.Maximum = new decimal(new int[] {
            247,
            0,
            0,
            0});
            this.SlaveAddressSelection.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SlaveAddressSelection.Name = "SlaveAddressSelection";
            this.SlaveAddressSelection.Size = new System.Drawing.Size(120, 23);
            this.SlaveAddressSelection.TabIndex = 24;
            this.SlaveAddressSelection.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ModbusMasterGroupBox
            // 
            this.ModbusMasterGroupBox.Controls.Add(this.ReceivedFrameHexButton);
            this.ModbusMasterGroupBox.Controls.Add(this.SentFrameHexButton);
            this.ModbusMasterGroupBox.Controls.Add(this.label15);
            this.ModbusMasterGroupBox.Controls.Add(this.label14);
            this.ModbusMasterGroupBox.Controls.Add(this.label13);
            this.ModbusMasterGroupBox.Controls.Add(this.label12);
            this.ModbusMasterGroupBox.Controls.Add(this.label11);
            this.ModbusMasterGroupBox.Controls.Add(this.label10);
            this.ModbusMasterGroupBox.Controls.Add(this.label9);
            this.ModbusMasterGroupBox.Controls.Add(this.label8);
            this.ModbusMasterGroupBox.Controls.Add(this.label7);
            this.ModbusMasterGroupBox.Controls.Add(this.label6);
            this.ModbusMasterGroupBox.Controls.Add(this.CRCMasterCheckBox);
            this.ModbusMasterGroupBox.Controls.Add(this.TransactionButton);
            this.ModbusMasterGroupBox.Controls.Add(this.StatusField);
            this.ModbusMasterGroupBox.Controls.Add(this.ReceivedDataField);
            this.ModbusMasterGroupBox.Controls.Add(this.ReceivedFrameField);
            this.ModbusMasterGroupBox.Controls.Add(this.SentFrameField);
            this.ModbusMasterGroupBox.Controls.Add(this.FunctionArgsInput);
            this.ModbusMasterGroupBox.Controls.Add(this.CharTimeSelection);
            this.ModbusMasterGroupBox.Controls.Add(this.RetransmitTimesSelection);
            this.ModbusMasterGroupBox.Controls.Add(this.TransactionTimeSelection);
            this.ModbusMasterGroupBox.Controls.Add(this.FunctionCodeSelection);
            this.ModbusMasterGroupBox.Controls.Add(this.SlaveAddressSelectionMaster);
            this.ModbusMasterGroupBox.Enabled = false;
            this.ModbusMasterGroupBox.Location = new System.Drawing.Point(6, 128);
            this.ModbusMasterGroupBox.Name = "ModbusMasterGroupBox";
            this.ModbusMasterGroupBox.Size = new System.Drawing.Size(935, 218);
            this.ModbusMasterGroupBox.TabIndex = 1;
            this.ModbusMasterGroupBox.TabStop = false;
            this.ModbusMasterGroupBox.Text = "Master";
            // 
            // ReceivedFrameHexButton
            // 
            this.ReceivedFrameHexButton.Location = new System.Drawing.Point(591, 93);
            this.ReceivedFrameHexButton.Name = "ReceivedFrameHexButton";
            this.ReceivedFrameHexButton.Size = new System.Drawing.Size(75, 23);
            this.ReceivedFrameHexButton.TabIndex = 23;
            this.ReceivedFrameHexButton.Text = "HEX";
            this.ReceivedFrameHexButton.UseVisualStyleBackColor = true;
            this.ReceivedFrameHexButton.Click += new System.EventHandler(this.ReceivedFrameHexButton_Click);
            // 
            // SentFrameHexButton
            // 
            this.SentFrameHexButton.Location = new System.Drawing.Point(591, 40);
            this.SentFrameHexButton.Name = "SentFrameHexButton";
            this.SentFrameHexButton.Size = new System.Drawing.Size(75, 23);
            this.SentFrameHexButton.TabIndex = 22;
            this.SentFrameHexButton.Text = "HEX";
            this.SentFrameHexButton.UseVisualStyleBackColor = true;
            this.SentFrameHexButton.Click += new System.EventHandler(this.SentFrameHexButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(736, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 15);
            this.label15.TabIndex = 21;
            this.label15.Text = "Status";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(396, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 15);
            this.label14.TabIndex = 20;
            this.label14.Text = "Odebrane dane";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(395, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 15);
            this.label13.TabIndex = 19;
            this.label13.Text = "Odebrana ramka";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(395, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "Wysłana ramka";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(223, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Czas znaku T (ms)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(223, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Argumenty funkcji";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Liczba retransmisji";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Czas transakcji (ms)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Funkcja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Slave (adres)";
            // 
            // CRCMasterCheckBox
            // 
            this.CRCMasterCheckBox.AutoSize = true;
            this.CRCMasterCheckBox.Checked = true;
            this.CRCMasterCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CRCMasterCheckBox.Location = new System.Drawing.Point(145, 193);
            this.CRCMasterCheckBox.Name = "CRCMasterCheckBox";
            this.CRCMasterCheckBox.Size = new System.Drawing.Size(49, 19);
            this.CRCMasterCheckBox.TabIndex = 11;
            this.CRCMasterCheckBox.Text = "CRC";
            this.CRCMasterCheckBox.UseVisualStyleBackColor = true;
            this.CRCMasterCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // TransactionButton
            // 
            this.TransactionButton.Location = new System.Drawing.Point(736, 93);
            this.TransactionButton.Name = "TransactionButton";
            this.TransactionButton.Size = new System.Drawing.Size(121, 76);
            this.TransactionButton.TabIndex = 10;
            this.TransactionButton.Text = "Transakcja";
            this.TransactionButton.UseVisualStyleBackColor = true;
            this.TransactionButton.Click += new System.EventHandler(this.TransactionButton_Click);
            // 
            // StatusField
            // 
            this.StatusField.Location = new System.Drawing.Point(736, 40);
            this.StatusField.Name = "StatusField";
            this.StatusField.ReadOnly = true;
            this.StatusField.Size = new System.Drawing.Size(120, 23);
            this.StatusField.TabIndex = 9;
            // 
            // ReceivedDataField
            // 
            this.ReceivedDataField.Location = new System.Drawing.Point(395, 145);
            this.ReceivedDataField.Name = "ReceivedDataField";
            this.ReceivedDataField.ReadOnly = true;
            this.ReceivedDataField.Size = new System.Drawing.Size(190, 23);
            this.ReceivedDataField.TabIndex = 8;
            // 
            // ReceivedFrameField
            // 
            this.ReceivedFrameField.Location = new System.Drawing.Point(395, 93);
            this.ReceivedFrameField.Name = "ReceivedFrameField";
            this.ReceivedFrameField.ReadOnly = true;
            this.ReceivedFrameField.Size = new System.Drawing.Size(190, 23);
            this.ReceivedFrameField.TabIndex = 7;
            // 
            // SentFrameField
            // 
            this.SentFrameField.Location = new System.Drawing.Point(396, 40);
            this.SentFrameField.Name = "SentFrameField";
            this.SentFrameField.ReadOnly = true;
            this.SentFrameField.Size = new System.Drawing.Size(189, 23);
            this.SentFrameField.TabIndex = 6;
            // 
            // FunctionArgsInput
            // 
            this.FunctionArgsInput.Location = new System.Drawing.Point(223, 93);
            this.FunctionArgsInput.Name = "FunctionArgsInput";
            this.FunctionArgsInput.Size = new System.Drawing.Size(120, 23);
            this.FunctionArgsInput.TabIndex = 5;
            // 
            // CharTimeSelection
            // 
            this.CharTimeSelection.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CharTimeSelection.Location = new System.Drawing.Point(223, 146);
            this.CharTimeSelection.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CharTimeSelection.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.CharTimeSelection.Name = "CharTimeSelection";
            this.CharTimeSelection.Size = new System.Drawing.Size(120, 23);
            this.CharTimeSelection.TabIndex = 4;
            this.CharTimeSelection.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // RetransmitTimesSelection
            // 
            this.RetransmitTimesSelection.Location = new System.Drawing.Point(223, 40);
            this.RetransmitTimesSelection.Name = "RetransmitTimesSelection";
            this.RetransmitTimesSelection.Size = new System.Drawing.Size(120, 23);
            this.RetransmitTimesSelection.TabIndex = 3;
            // 
            // TransactionTimeSelection
            // 
            this.TransactionTimeSelection.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.TransactionTimeSelection.Location = new System.Drawing.Point(6, 146);
            this.TransactionTimeSelection.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TransactionTimeSelection.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.TransactionTimeSelection.Name = "TransactionTimeSelection";
            this.TransactionTimeSelection.Size = new System.Drawing.Size(120, 23);
            this.TransactionTimeSelection.TabIndex = 2;
            this.TransactionTimeSelection.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // FunctionCodeSelection
            // 
            this.FunctionCodeSelection.Location = new System.Drawing.Point(6, 93);
            this.FunctionCodeSelection.Name = "FunctionCodeSelection";
            this.FunctionCodeSelection.Size = new System.Drawing.Size(120, 23);
            this.FunctionCodeSelection.TabIndex = 1;
            this.FunctionCodeSelection.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SlaveAddressSelectionMaster
            // 
            this.SlaveAddressSelectionMaster.Location = new System.Drawing.Point(6, 40);
            this.SlaveAddressSelectionMaster.Maximum = new decimal(new int[] {
            247,
            0,
            0,
            0});
            this.SlaveAddressSelectionMaster.Name = "SlaveAddressSelectionMaster";
            this.SlaveAddressSelectionMaster.Size = new System.Drawing.Size(120, 23);
            this.SlaveAddressSelectionMaster.TabIndex = 0;
            // 
            // ModbusPortBox
            // 
            this.ModbusPortBox.Controls.Add(this.OpenPortCheckBox);
            this.ModbusPortBox.Controls.Add(this.label5);
            this.ModbusPortBox.Controls.Add(this.StationComboBox);
            this.ModbusPortBox.Controls.Add(this.label4);
            this.ModbusPortBox.Controls.Add(this.BaudComboBox);
            this.ModbusPortBox.Controls.Add(this.label3);
            this.ModbusPortBox.Controls.Add(this.PortComboBox);
            this.ModbusPortBox.Location = new System.Drawing.Point(6, 6);
            this.ModbusPortBox.Name = "ModbusPortBox";
            this.ModbusPortBox.Size = new System.Drawing.Size(935, 116);
            this.ModbusPortBox.TabIndex = 0;
            this.ModbusPortBox.TabStop = false;
            this.ModbusPortBox.Text = "Port";
            // 
            // OpenPortCheckBox
            // 
            this.OpenPortCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.OpenPortCheckBox.Location = new System.Drawing.Point(395, 86);
            this.OpenPortCheckBox.Name = "OpenPortCheckBox";
            this.OpenPortCheckBox.Size = new System.Drawing.Size(121, 24);
            this.OpenPortCheckBox.TabIndex = 6;
            this.OpenPortCheckBox.Text = "Otwórz port";
            this.OpenPortCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OpenPortCheckBox.UseVisualStyleBackColor = true;
            this.OpenPortCheckBox.CheckedChanged += new System.EventHandler(this.OpenPortCheckBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(736, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rodzaj stacji";
            // 
            // StationComboBox
            // 
            this.StationComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Master",
            "Slave"});
            this.StationComboBox.FormattingEnabled = true;
            this.StationComboBox.Items.AddRange(new object[] {
            "Master",
            "Slave"});
            this.StationComboBox.Location = new System.Drawing.Point(736, 40);
            this.StationComboBox.Name = "StationComboBox";
            this.StationComboBox.Size = new System.Drawing.Size(121, 23);
            this.StationComboBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Baud rate";
            // 
            // BaudComboBox
            // 
            this.BaudComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "1000",
            "9600"});
            this.BaudComboBox.FormattingEnabled = true;
            this.BaudComboBox.Items.AddRange(new object[] {
            "1000",
            "9600"});
            this.BaudComboBox.Location = new System.Drawing.Point(395, 40);
            this.BaudComboBox.Name = "BaudComboBox";
            this.BaudComboBox.Size = new System.Drawing.Size(121, 23);
            this.BaudComboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Port";
            // 
            // PortComboBox
            // 
            this.PortComboBox.FormattingEnabled = true;
            this.PortComboBox.Location = new System.Drawing.Point(133, 40);
            this.PortComboBox.Name = "PortComboBox";
            this.PortComboBox.Size = new System.Drawing.Size(121, 23);
            this.PortComboBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 615);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ModbusSlaveGroupBox.ResumeLayout(false);
            this.ModbusSlaveGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharTimeSelectionSlave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlaveAddressSelection)).EndInit();
            this.ModbusMasterGroupBox.ResumeLayout(false);
            this.ModbusMasterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharTimeSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetransmitTimesSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionTimeSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunctionCodeSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlaveAddressSelectionMaster)).EndInit();
            this.ModbusPortBox.ResumeLayout(false);
            this.ModbusPortBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private GroupBox groupBox10;
        private TextBox SendTextbox;
        private GroupBox groupBox9;
        private Button CheckPing;
        private GroupBox groupBox6;
        private GroupBox groupBox8;
        private RadioButton FlowControlXONXOFF;
        private RadioButton FlowControlRTS;
        private RadioButton FlowControlDTR;
        private RadioButton FlowControlNone;
        private GroupBox groupBox7;
        private Label CTSLabel;
        private Label DSRLabel;
        private Button XOFFButton;
        private Button XONButton;
        private GroupBox groupBox5;
        private TextBox CustomTerminatorInput;
        private RadioButton TerminatorSelectionCustom;
        private RadioButton TerminatorSelectionCRLF;
        private RadioButton TerminatorSelectionLF;
        private RadioButton TerminatorSelectionCR;
        private RadioButton TerminatorSelectionNone;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private RadioButton ParitySelectionOdd;
        private RadioButton ParitySelectionNone;
        private RadioButton ParitySelectionEven;
        private GroupBox groupBox3;
        private RadioButton StopBitSelection2;
        private RadioButton StopBitSelection1;
        private GroupBox groupBox2;
        private RadioButton Selection7Bit;
        private RadioButton Selection8Bit;
        private Label label2;
        private Label label1;
        private ComboBox BaudSelection;
        private ComboBox PortSelection;
        private GroupBox groupBox12;
        private TextBox ReceiveTextbox;
        private Button SendButton;
        private CheckBox OpenDevice;
        private CheckBox EnableRTS;
        private CheckBox EnableDTR;
        private CheckBox EnablePing;
        private GroupBox ModbusPortBox;
        private CheckBox OpenPortCheckBox;
        private Label label5;
        private ComboBox StationComboBox;
        private Label label4;
        private ComboBox BaudComboBox;
        private Label label3;
        private ComboBox PortComboBox;
        private GroupBox ModbusSlaveGroupBox;
        private Label label22;
        private Button ReceivedFrameHexButtonSlave;
        private TextBox InputDataToSendSlave;
        private Label label18;
        private Button SentFrameHexButtonSlave;
        private Label label17;
        private Label label19;
        private TextBox StatusFieldSlave;
        private Label label20;
        private Label label21;
        private NumericUpDown CharTimeSelectionSlave;
        private TextBox ReceivedDataTextFieldSlave;
        private Label label16;
        private TextBox ReceivedFrameTextFieldSlave;
        private TextBox SentFrameTextFieldSlave;
        private NumericUpDown SlaveAddressSelection;
        private GroupBox ModbusMasterGroupBox;
        private Button ReceivedFrameHexButton;
        private Button SentFrameHexButton;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private CheckBox CRCMasterCheckBox;
        private Button TransactionButton;
        private TextBox StatusField;
        private TextBox ReceivedDataField;
        private TextBox ReceivedFrameField;
        private TextBox SentFrameField;
        private TextBox FunctionArgsInput;
        private NumericUpDown CharTimeSelection;
        private NumericUpDown RetransmitTimesSelection;
        private NumericUpDown TransactionTimeSelection;
        private NumericUpDown FunctionCodeSelection;
        private NumericUpDown SlaveAddressSelectionMaster;
        private CheckBox CRCSlaveCheckBox;
        private CheckBox OpenSlaveButton;
    }
}