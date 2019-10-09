namespace serialport
{
    partial class serialport
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serialport));
            this.comport = new System.IO.Ports.SerialPort(this.components);
            this.timerReceived = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.skinLabel12 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel10 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel11 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.cmbDataBits = new CCWin.SkinControl.SkinComboBox();
            this.cmbParity = new CCWin.SkinControl.SkinComboBox();
            this.cmbStopBits = new CCWin.SkinControl.SkinComboBox();
            this.cmbBaudRate = new CCWin.SkinControl.SkinComboBox();
            this.cmbPortName = new CCWin.SkinControl.SkinComboBox();
            this.btn_Send = new CCWin.SkinControl.SkinButton();
            this.btn_Open = new CCWin.SkinControl.SkinButton();
            this.btn_F5 = new CCWin.SkinControl.SkinButton();
            this.btn_About = new CCWin.SkinControl.SkinButton();
            this.btn_Edit = new CCWin.SkinControl.SkinButton();
            this.chkSendHex = new CCWin.SkinControl.SkinCheckBox();
            this.chkRecvHex = new CCWin.SkinControl.SkinCheckBox();
            this.skinLabel45 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel44 = new CCWin.SkinControl.SkinLabel();
            this.txtReceived = new CCWin.SkinControl.RtfRichTextBox();
            this.btn_SpiltSendStr = new CCWin.SkinControl.SkinButton();
            this.btn_addVerify = new CCWin.SkinControl.SkinButton();
            this.skinLabel41 = new CCWin.SkinControl.SkinLabel();
            this.txt_timeSend = new System.Windows.Forms.TextBox();
            this.skinLabel42 = new CCWin.SkinControl.SkinLabel();
            this.timerSend = new System.Windows.Forms.Timer(this.components);
            this.txt_TimeOutNum = new System.Windows.Forms.TextBox();
            this.skinLabel46 = new CCWin.SkinControl.SkinLabel();
            this.txt_gjz = new System.Windows.Forms.TextBox();
            this.skinLabel47 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel48 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel49 = new CCWin.SkinControl.SkinLabel();
            this.lbl_SendNum = new CCWin.SkinControl.SkinLabel();
            this.lbl_RevNum = new CCWin.SkinControl.SkinLabel();
            this.skinLabel54 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.lbl_DataCount = new CCWin.SkinControl.SkinLabel();
            this.gb_extension = new CCWin.SkinControl.SkinGroupBox();
            this.pl_extension = new System.Windows.Forms.Panel();
            this.skinCheckBox1 = new CCWin.SkinControl.SkinCheckBox();
            this.DataGridView1 = new CCWin.SkinControl.SkinDataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Export = new System.Windows.Forms.Button();
            this.check_All = new CCWin.SkinControl.SkinCheckBox();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_ForeachSend = new CCWin.SkinControl.SkinCheckBox();
            this.gbPortSettings = new CCWin.SkinControl.SkinGroupBox();
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPage1 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage2 = new CCWin.SkinControl.SkinTabPage();
            this.btn_Open2 = new CCWin.SkinControl.SkinButton();
            this.cmbParity2 = new CCWin.SkinControl.SkinComboBox();
            this.cmbPortName2 = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel28 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel29 = new CCWin.SkinControl.SkinLabel();
            this.cmbStopBits2 = new CCWin.SkinControl.SkinComboBox();
            this.cmbDataBits2 = new CCWin.SkinControl.SkinComboBox();
            this.cmbBaudRate2 = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel31 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel32 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel33 = new CCWin.SkinControl.SkinLabel();
            this.skinTabPage3 = new CCWin.SkinControl.SkinTabPage();
            this.btn_Open3 = new CCWin.SkinControl.SkinButton();
            this.cmbParity3 = new CCWin.SkinControl.SkinComboBox();
            this.cmbPortName3 = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel35 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel36 = new CCWin.SkinControl.SkinLabel();
            this.cmbStopBits3 = new CCWin.SkinControl.SkinComboBox();
            this.cmbDataBits3 = new CCWin.SkinControl.SkinComboBox();
            this.cmbBaudRate3 = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel38 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel39 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel50 = new CCWin.SkinControl.SkinLabel();
            this.skinGroupBox5 = new CCWin.SkinControl.SkinGroupBox();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.txt_MeterAddr = new System.Windows.Forms.TextBox();
            this.txt_VendorCode = new System.Windows.Forms.TextBox();
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.txt_SendNumber = new System.Windows.Forms.TextBox();
            this.skinLabel21 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel22 = new CCWin.SkinControl.SkinLabel();
            this.cbo_timeSend = new CCWin.SkinControl.SkinCheckBox();
            this.cbo_gjz = new CCWin.SkinControl.SkinCheckBox();
            this.btn_Ccombination = new CCWin.SkinControl.SkinButton();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox2 = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel14 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel15 = new CCWin.SkinControl.SkinLabel();
            this.skinGroupBox4 = new CCWin.SkinControl.SkinGroupBox();
            this.cbo_Res1 = new CCWin.SkinControl.SkinCheckBox();
            this.txt_Pad1 = new System.Windows.Forms.TextBox();
            this.skinLabel18 = new CCWin.SkinControl.SkinLabel();
            this.txt_leng1 = new System.Windows.Forms.TextBox();
            this.skinLabel16 = new CCWin.SkinControl.SkinLabel();
            this.cbo_Hex1 = new CCWin.SkinControl.SkinCheckBox();
            this.skinGroupBox6 = new CCWin.SkinControl.SkinGroupBox();
            this.cbo_Res2 = new CCWin.SkinControl.SkinCheckBox();
            this.txt_Pad2 = new System.Windows.Forms.TextBox();
            this.skinLabel13 = new CCWin.SkinControl.SkinLabel();
            this.txt_leng2 = new System.Windows.Forms.TextBox();
            this.skinLabel17 = new CCWin.SkinControl.SkinLabel();
            this.cbo_Hex2 = new CCWin.SkinControl.SkinCheckBox();
            this.skinGroupBox7 = new CCWin.SkinControl.SkinGroupBox();
            this.cbo_Res3 = new CCWin.SkinControl.SkinCheckBox();
            this.txt_Pad3 = new System.Windows.Forms.TextBox();
            this.skinLabel19 = new CCWin.SkinControl.SkinLabel();
            this.txt_leng3 = new System.Windows.Forms.TextBox();
            this.skinLabel20 = new CCWin.SkinControl.SkinLabel();
            this.cbo_Hex3 = new CCWin.SkinControl.SkinCheckBox();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.txt_Data3 = new System.Windows.Forms.TextBox();
            this.txt_Data2 = new System.Windows.Forms.TextBox();
            this.txt_Data1 = new System.Windows.Forms.TextBox();
            this.txt_gdData = new System.Windows.Forms.TextBox();
            this.skinGroupBox9 = new CCWin.SkinControl.SkinGroupBox();
            this.btn_SendClear = new CCWin.SkinControl.SkinButton();
            this.txt_SubLength = new System.Windows.Forms.TextBox();
            this.skinLabel23 = new CCWin.SkinControl.SkinLabel();
            this.txt_Focus = new System.Windows.Forms.TextBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.txt_Send = new CCWin.SkinControl.RtfRichTextBox();
            this.skinGroupBox10 = new CCWin.SkinControl.SkinGroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkHidden3 = new CCWin.SkinControl.SkinCheckBox();
            this.skinLabel52 = new CCWin.SkinControl.SkinLabel();
            this.chkRecvHex3 = new CCWin.SkinControl.SkinCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkHidden2 = new CCWin.SkinControl.SkinCheckBox();
            this.skinLabel24 = new CCWin.SkinControl.SkinLabel();
            this.chkRecvHex2 = new CCWin.SkinControl.SkinCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkHidden = new CCWin.SkinControl.SkinCheckBox();
            this.skinLabel53 = new CCWin.SkinControl.SkinLabel();
            this.txtReceived3 = new CCWin.SkinControl.RtfRichTextBox();
            this.txtReceived2 = new CCWin.SkinControl.RtfRichTextBox();
            this.btn_Clear = new CCWin.SkinControl.SkinButton();
            this.btn_extension = new CCWin.SkinControl.SkinButton();
            this.skinGroupBox8 = new CCWin.SkinControl.SkinGroupBox();
            this.skinLabel56 = new CCWin.SkinControl.SkinLabel();
            this.lbl_SendNum3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel58 = new CCWin.SkinControl.SkinLabel();
            this.lbl_RevNum3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel25 = new CCWin.SkinControl.SkinLabel();
            this.lbl_SendNum2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel51 = new CCWin.SkinControl.SkinLabel();
            this.lbl_RevNum2 = new CCWin.SkinControl.SkinLabel();
            this.rdo_comPort3 = new CCWin.SkinControl.SkinRadioButton();
            this.rdo_comPort2 = new CCWin.SkinControl.SkinRadioButton();
            this.rdo_comPort1 = new CCWin.SkinControl.SkinRadioButton();
            this.btn_RecAddHeight = new CCWin.SkinControl.SkinButton();
            this.comport2 = new System.IO.Ports.SerialPort(this.components);
            this.comport3 = new System.IO.Ports.SerialPort(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.timerReceived2 = new System.Windows.Forms.Timer(this.components);
            this.timerReceived3 = new System.Windows.Forms.Timer(this.components);
            this.cbo_com1 = new CCWin.SkinControl.SkinCheckBox();
            this.cbo_com2 = new CCWin.SkinControl.SkinCheckBox();
            this.cbo_com3 = new CCWin.SkinControl.SkinCheckBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.cbo_sync = new CCWin.SkinControl.SkinCheckBox();
            this.skinLabel43 = new CCWin.SkinControl.SkinLabel();
            this.btn_dqData = new CCWin.SkinControl.SkinButton();
            this.btn_szTime = new CCWin.SkinControl.SkinButton();
            this.btn_dqTime = new CCWin.SkinControl.SkinButton();
            this.btn_shData = new CCWin.SkinControl.SkinButton();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_asyn = new CCWin.SkinControl.SkinButton();
            this.txt_OldMeterAddr = new System.Windows.Forms.TextBox();
            this.txt_DataNum = new System.Windows.Forms.TextBox();
            this.skinGroupBox3 = new CCWin.SkinControl.SkinGroupBox();
            this.btn_ex = new CCWin.SkinControl.SkinButton();
            this.gb_extension.SuspendLayout();
            this.pl_extension.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.gbPortSettings.SuspendLayout();
            this.skinTabControl1.SuspendLayout();
            this.skinTabPage1.SuspendLayout();
            this.skinTabPage2.SuspendLayout();
            this.skinTabPage3.SuspendLayout();
            this.skinGroupBox5.SuspendLayout();
            this.skinGroupBox2.SuspendLayout();
            this.skinGroupBox4.SuspendLayout();
            this.skinGroupBox6.SuspendLayout();
            this.skinGroupBox7.SuspendLayout();
            this.skinGroupBox1.SuspendLayout();
            this.skinGroupBox9.SuspendLayout();
            this.skinGroupBox10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.skinGroupBox8.SuspendLayout();
            this.skinGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comport
            // 
            this.comport.DataBits = 7;
            this.comport.Parity = System.IO.Ports.Parity.Even;
            this.comport.StopBits = System.IO.Ports.StopBits.Two;
            this.comport.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timerReceived
            // 
            this.timerReceived.Interval = 1000;
            this.timerReceived.Tick += new System.EventHandler(this.timerReceived_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Location = new System.Drawing.Point(4, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 48;
            this.label10.Text = "串口一:";
            // 
            // skinLabel12
            // 
            this.skinLabel12.AutoSize = true;
            this.skinLabel12.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel12.BorderColor = System.Drawing.Color.White;
            this.skinLabel12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel12.ForeColor = System.Drawing.Color.Black;
            this.skinLabel12.Location = new System.Drawing.Point(441, 19);
            this.skinLabel12.Name = "skinLabel12";
            this.skinLabel12.Size = new System.Drawing.Size(47, 17);
            this.skinLabel12.TabIndex = 122;
            this.skinLabel12.Text = "数据位:";
            // 
            // skinLabel9
            // 
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.ForeColor = System.Drawing.Color.Black;
            this.skinLabel9.Location = new System.Drawing.Point(111, 19);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(47, 17);
            this.skinLabel9.TabIndex = 119;
            this.skinLabel9.Text = "停止位:";
            // 
            // skinLabel10
            // 
            this.skinLabel10.AutoSize = true;
            this.skinLabel10.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel10.BorderColor = System.Drawing.Color.White;
            this.skinLabel10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel10.ForeColor = System.Drawing.Color.Black;
            this.skinLabel10.Location = new System.Drawing.Point(331, 19);
            this.skinLabel10.Name = "skinLabel10";
            this.skinLabel10.Size = new System.Drawing.Size(47, 17);
            this.skinLabel10.TabIndex = 120;
            this.skinLabel10.Text = "校验位:";
            // 
            // skinLabel11
            // 
            this.skinLabel11.AutoSize = true;
            this.skinLabel11.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel11.BorderColor = System.Drawing.Color.White;
            this.skinLabel11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel11.ForeColor = System.Drawing.Color.Black;
            this.skinLabel11.Location = new System.Drawing.Point(221, 19);
            this.skinLabel11.Name = "skinLabel11";
            this.skinLabel11.Size = new System.Drawing.Size(47, 17);
            this.skinLabel11.TabIndex = 121;
            this.skinLabel11.Text = "波特率:";
            // 
            // skinLabel8
            // 
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.ForeColor = System.Drawing.Color.Black;
            this.skinLabel8.Location = new System.Drawing.Point(1, 19);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(47, 17);
            this.skinLabel8.TabIndex = 118;
            this.skinLabel8.Text = "串口号:";
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.BackColor = System.Drawing.Color.White;
            this.cmbDataBits.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbDataBits.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbDataBits.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDataBits.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cmbDataBits.Location = new System.Drawing.Point(488, 12);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(63, 24);
            this.cmbDataBits.TabIndex = 112;
            this.cmbDataBits.Text = "8";
            this.cmbDataBits.WaterText = "";
            // 
            // cmbParity
            // 
            this.cmbParity.BackColor = System.Drawing.Color.White;
            this.cmbParity.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbParity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbParity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbParity.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.cmbParity.Location = new System.Drawing.Point(378, 12);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(63, 24);
            this.cmbParity.TabIndex = 110;
            this.cmbParity.Text = "Even";
            this.cmbParity.WaterText = "";
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.BackColor = System.Drawing.Color.White;
            this.cmbStopBits.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbStopBits.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbStopBits.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStopBits.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbStopBits.Location = new System.Drawing.Point(158, 12);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(63, 24);
            this.cmbStopBits.TabIndex = 106;
            this.cmbStopBits.Text = "1";
            this.cmbStopBits.WaterText = "";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.BackColor = System.Drawing.Color.White;
            this.cmbBaudRate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbBaudRate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbBaudRate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBaudRate.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "28800",
            "36000",
            "115200"});
            this.cmbBaudRate.Location = new System.Drawing.Point(268, 12);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(63, 24);
            this.cmbBaudRate.TabIndex = 108;
            this.cmbBaudRate.Text = "2400";
            this.cmbBaudRate.WaterText = "";
            // 
            // cmbPortName
            // 
            this.cmbPortName.BackColor = System.Drawing.Color.White;
            this.cmbPortName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbPortName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbPortName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPortName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Location = new System.Drawing.Point(48, 12);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(63, 24);
            this.cmbPortName.TabIndex = 105;
            this.cmbPortName.WaterText = "";
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btn_Send.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Send.DownBack = null;
            this.btn_Send.Enabled = false;
            this.btn_Send.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Send.Location = new System.Drawing.Point(461, 85);
            this.btn_Send.MouseBack = null;
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.NormlBack = null;
            this.btn_Send.Size = new System.Drawing.Size(82, 28);
            this.btn_Send.TabIndex = 7;
            this.btn_Send.Text = "发送";
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btn_Open.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Open.DownBack = null;
            this.btn_Open.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Open.Location = new System.Drawing.Point(554, 11);
            this.btn_Open.MouseBack = null;
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.NormlBack = null;
            this.btn_Open.Size = new System.Drawing.Size(82, 28);
            this.btn_Open.TabIndex = 1;
            this.btn_Open.TabStop = false;
            this.btn_Open.Text = "&O打开端口";
            this.btn_Open.UseVisualStyleBackColor = false;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_F5
            // 
            this.btn_F5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btn_F5.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_F5.DownBack = null;
            this.btn_F5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_F5.Location = new System.Drawing.Point(566, 17);
            this.btn_F5.MouseBack = null;
            this.btn_F5.Name = "btn_F5";
            this.btn_F5.NormlBack = null;
            this.btn_F5.Size = new System.Drawing.Size(82, 28);
            this.btn_F5.TabIndex = 2;
            this.btn_F5.Text = "刷新端口";
            this.btn_F5.UseVisualStyleBackColor = false;
            this.btn_F5.Click += new System.EventHandler(this.btn_F5_Click);
            // 
            // btn_About
            // 
            this.btn_About.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btn_About.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_About.DownBack = null;
            this.btn_About.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_About.Location = new System.Drawing.Point(837, 665);
            this.btn_About.MouseBack = null;
            this.btn_About.Name = "btn_About";
            this.btn_About.NormlBack = null;
            this.btn_About.Size = new System.Drawing.Size(82, 28);
            this.btn_About.TabIndex = 100;
            this.btn_About.Text = "关于";
            this.btn_About.UseVisualStyleBackColor = false;
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btn_Edit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Edit.DownBack = null;
            this.btn_Edit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Edit.Location = new System.Drawing.Point(922, 665);
            this.btn_Edit.MouseBack = null;
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.NormlBack = null;
            this.btn_Edit.Size = new System.Drawing.Size(82, 28);
            this.btn_Edit.TabIndex = 102;
            this.btn_Edit.Text = "保存并退出";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // chkSendHex
            // 
            this.chkSendHex.AutoSize = true;
            this.chkSendHex.BackColor = System.Drawing.Color.Transparent;
            this.chkSendHex.Checked = true;
            this.chkSendHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSendHex.ControlState = CCWin.SkinClass.ControlState.Focused;
            this.chkSendHex.DownBack = null;
            this.chkSendHex.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkSendHex.Location = new System.Drawing.Point(10, 16);
            this.chkSendHex.MouseBack = null;
            this.chkSendHex.Name = "chkSendHex";
            this.chkSendHex.NormlBack = null;
            this.chkSendHex.SelectedDownBack = null;
            this.chkSendHex.SelectedMouseBack = null;
            this.chkSendHex.SelectedNormlBack = null;
            this.chkSendHex.Size = new System.Drawing.Size(75, 21);
            this.chkSendHex.TabIndex = 102;
            this.chkSendHex.Text = "HEX发送";
            this.chkSendHex.UseVisualStyleBackColor = false;
            // 
            // chkRecvHex
            // 
            this.chkRecvHex.AutoSize = true;
            this.chkRecvHex.BackColor = System.Drawing.Color.Transparent;
            this.chkRecvHex.Checked = true;
            this.chkRecvHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRecvHex.ControlState = CCWin.SkinClass.ControlState.Focused;
            this.chkRecvHex.DownBack = null;
            this.chkRecvHex.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkRecvHex.Location = new System.Drawing.Point(52, 3);
            this.chkRecvHex.MouseBack = null;
            this.chkRecvHex.Name = "chkRecvHex";
            this.chkRecvHex.NormlBack = null;
            this.chkRecvHex.SelectedDownBack = null;
            this.chkRecvHex.SelectedMouseBack = null;
            this.chkRecvHex.SelectedNormlBack = null;
            this.chkRecvHex.Size = new System.Drawing.Size(51, 21);
            this.chkRecvHex.TabIndex = 103;
            this.chkRecvHex.Text = "HEX";
            this.chkRecvHex.UseVisualStyleBackColor = false;
            // 
            // skinLabel45
            // 
            this.skinLabel45.AutoSize = true;
            this.skinLabel45.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel45.BorderColor = System.Drawing.Color.White;
            this.skinLabel45.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel45.Location = new System.Drawing.Point(4, 50);
            this.skinLabel45.Name = "skinLabel45";
            this.skinLabel45.Size = new System.Drawing.Size(59, 17);
            this.skinLabel45.TabIndex = 146;
            this.skinLabel45.Text = "厂商代码:";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(4, 22);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(59, 17);
            this.skinLabel1.TabIndex = 117;
            this.skinLabel1.Text = "表头地址:";
            // 
            // skinLabel44
            // 
            this.skinLabel44.AutoSize = true;
            this.skinLabel44.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel44.BorderColor = System.Drawing.Color.White;
            this.skinLabel44.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel44.Location = new System.Drawing.Point(17, 78);
            this.skinLabel44.Name = "skinLabel44";
            this.skinLabel44.Size = new System.Drawing.Size(47, 17);
            this.skinLabel44.TabIndex = 171;
            this.skinLabel44.Text = "前导码:";
            // 
            // txtReceived
            // 
            this.txtReceived.BackColor = System.Drawing.SystemColors.Window;
            this.txtReceived.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtReceived.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.txtReceived.Location = new System.Drawing.Point(3, 42);
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(330, 352);
            this.txtReceived.TabIndex = 16;
            this.txtReceived.Text = "";
            this.txtReceived.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            this.txtReceived.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReceived_KeyDown);
            this.txtReceived.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtReceived_MouseDoubleClick);
            // 
            // btn_SpiltSendStr
            // 
            this.btn_SpiltSendStr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btn_SpiltSendStr.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_SpiltSendStr.DownBack = null;
            this.btn_SpiltSendStr.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SpiltSendStr.Location = new System.Drawing.Point(461, 16);
            this.btn_SpiltSendStr.MouseBack = null;
            this.btn_SpiltSendStr.Name = "btn_SpiltSendStr";
            this.btn_SpiltSendStr.NormlBack = null;
            this.btn_SpiltSendStr.Size = new System.Drawing.Size(82, 22);
            this.btn_SpiltSendStr.TabIndex = 148;
            this.btn_SpiltSendStr.Text = "格式化";
            this.btn_SpiltSendStr.UseVisualStyleBackColor = false;
            this.btn_SpiltSendStr.Click += new System.EventHandler(this.btn_SpiltSendStr_Click);
            // 
            // btn_addVerify
            // 
            this.btn_addVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btn_addVerify.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_addVerify.DownBack = null;
            this.btn_addVerify.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_addVerify.Location = new System.Drawing.Point(461, 62);
            this.btn_addVerify.MouseBack = null;
            this.btn_addVerify.Name = "btn_addVerify";
            this.btn_addVerify.NormlBack = null;
            this.btn_addVerify.Size = new System.Drawing.Size(82, 22);
            this.btn_addVerify.TabIndex = 149;
            this.btn_addVerify.Text = "计算校验和";
            this.btn_addVerify.UseVisualStyleBackColor = false;
            this.btn_addVerify.Click += new System.EventHandler(this.btn_addVerify_Click);
            // 
            // skinLabel41
            // 
            this.skinLabel41.AutoSize = true;
            this.skinLabel41.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel41.BorderColor = System.Drawing.Color.White;
            this.skinLabel41.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel41.Location = new System.Drawing.Point(15, 20);
            this.skinLabel41.Name = "skinLabel41";
            this.skinLabel41.Size = new System.Drawing.Size(59, 17);
            this.skinLabel41.TabIndex = 168;
            this.skinLabel41.Text = "重复周期:";
            // 
            // txt_timeSend
            // 
            this.txt_timeSend.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_timeSend.Location = new System.Drawing.Point(74, 18);
            this.txt_timeSend.MaxLength = 10;
            this.txt_timeSend.Name = "txt_timeSend";
            this.txt_timeSend.Size = new System.Drawing.Size(38, 25);
            this.txt_timeSend.TabIndex = 169;
            this.txt_timeSend.Text = "3000";
            this.txt_timeSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_timeSend_KeyPress);
            // 
            // skinLabel42
            // 
            this.skinLabel42.AutoSize = true;
            this.skinLabel42.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel42.BorderColor = System.Drawing.Color.White;
            this.skinLabel42.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel42.Location = new System.Drawing.Point(114, 21);
            this.skinLabel42.Name = "skinLabel42";
            this.skinLabel42.Size = new System.Drawing.Size(32, 17);
            this.skinLabel42.TabIndex = 170;
            this.skinLabel42.Text = "毫秒";
            // 
            // timerSend
            // 
            this.timerSend.Interval = 1000;
            this.timerSend.Tick += new System.EventHandler(this.timerSend_Tick);
            // 
            // txt_TimeOutNum
            // 
            this.txt_TimeOutNum.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_TimeOutNum.Location = new System.Drawing.Point(490, 670);
            this.txt_TimeOutNum.MaxLength = 10;
            this.txt_TimeOutNum.Name = "txt_TimeOutNum";
            this.txt_TimeOutNum.Size = new System.Drawing.Size(39, 25);
            this.txt_TimeOutNum.TabIndex = 174;
            this.txt_TimeOutNum.Text = "20";
            this.txt_TimeOutNum.Visible = false;
            this.txt_TimeOutNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TimeOutNum_KeyPress);
            // 
            // skinLabel46
            // 
            this.skinLabel46.AutoSize = true;
            this.skinLabel46.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel46.BorderColor = System.Drawing.Color.White;
            this.skinLabel46.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel46.Location = new System.Drawing.Point(-32, -3);
            this.skinLabel46.Name = "skinLabel46";
            this.skinLabel46.Size = new System.Drawing.Size(59, 17);
            this.skinLabel46.TabIndex = 173;
            this.skinLabel46.Text = "超时时间:";
            this.skinLabel46.Visible = false;
            // 
            // txt_gjz
            // 
            this.txt_gjz.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_gjz.Location = new System.Drawing.Point(-25, -11);
            this.txt_gjz.MaxLength = 10;
            this.txt_gjz.Name = "txt_gjz";
            this.txt_gjz.Size = new System.Drawing.Size(69, 25);
            this.txt_gjz.TabIndex = 176;
            this.txt_gjz.Visible = false;
            // 
            // skinLabel47
            // 
            this.skinLabel47.AutoSize = true;
            this.skinLabel47.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel47.BorderColor = System.Drawing.Color.White;
            this.skinLabel47.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel47.Location = new System.Drawing.Point(492, 670);
            this.skinLabel47.Name = "skinLabel47";
            this.skinLabel47.Size = new System.Drawing.Size(47, 17);
            this.skinLabel47.TabIndex = 175;
            this.skinLabel47.Text = "关键字:";
            this.skinLabel47.Visible = false;
            // 
            // skinLabel48
            // 
            this.skinLabel48.AutoSize = true;
            this.skinLabel48.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel48.BorderColor = System.Drawing.Color.White;
            this.skinLabel48.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel48.Location = new System.Drawing.Point(496, 674);
            this.skinLabel48.Name = "skinLabel48";
            this.skinLabel48.Size = new System.Drawing.Size(20, 17);
            this.skinLabel48.TabIndex = 177;
            this.skinLabel48.Text = "秒";
            this.skinLabel48.Visible = false;
            // 
            // skinLabel49
            // 
            this.skinLabel49.AutoSize = true;
            this.skinLabel49.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel49.BorderColor = System.Drawing.Color.White;
            this.skinLabel49.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel49.Location = new System.Drawing.Point(4, 50);
            this.skinLabel49.Name = "skinLabel49";
            this.skinLabel49.Size = new System.Drawing.Size(35, 17);
            this.skinLabel49.TabIndex = 178;
            this.skinLabel49.Text = "发送:";
            // 
            // lbl_SendNum
            // 
            this.lbl_SendNum.AutoSize = true;
            this.lbl_SendNum.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SendNum.BorderColor = System.Drawing.Color.White;
            this.lbl_SendNum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SendNum.Location = new System.Drawing.Point(40, 50);
            this.lbl_SendNum.Name = "lbl_SendNum";
            this.lbl_SendNum.Size = new System.Drawing.Size(15, 17);
            this.lbl_SendNum.TabIndex = 182;
            this.lbl_SendNum.Text = "0";
            this.lbl_SendNum.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbl_SendNum_MouseDoubleClick);
            // 
            // lbl_RevNum
            // 
            this.lbl_RevNum.AutoSize = true;
            this.lbl_RevNum.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RevNum.BorderColor = System.Drawing.Color.White;
            this.lbl_RevNum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_RevNum.Location = new System.Drawing.Point(40, 72);
            this.lbl_RevNum.Name = "lbl_RevNum";
            this.lbl_RevNum.Size = new System.Drawing.Size(15, 17);
            this.lbl_RevNum.TabIndex = 184;
            this.lbl_RevNum.Text = "0";
            this.lbl_RevNum.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbl_RevNum_MouseDoubleClick);
            // 
            // skinLabel54
            // 
            this.skinLabel54.AutoSize = true;
            this.skinLabel54.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel54.BorderColor = System.Drawing.Color.White;
            this.skinLabel54.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel54.Location = new System.Drawing.Point(4, 72);
            this.skinLabel54.Name = "skinLabel54";
            this.skinLabel54.Size = new System.Drawing.Size(35, 17);
            this.skinLabel54.TabIndex = 183;
            this.skinLabel54.Text = "接收:";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinLabel4.Location = new System.Drawing.Point(153, 18);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(35, 17);
            this.skinLabel4.TabIndex = 186;
            this.skinLabel4.Text = "长度:";
            // 
            // lbl_DataCount
            // 
            this.lbl_DataCount.AutoSize = true;
            this.lbl_DataCount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DataCount.BorderColor = System.Drawing.Color.White;
            this.lbl_DataCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_DataCount.Location = new System.Drawing.Point(189, 18);
            this.lbl_DataCount.Name = "lbl_DataCount";
            this.lbl_DataCount.Size = new System.Drawing.Size(15, 17);
            this.lbl_DataCount.TabIndex = 187;
            this.lbl_DataCount.Text = "0";
            // 
            // gb_extension
            // 
            this.gb_extension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.gb_extension.BorderColor = System.Drawing.Color.Black;
            this.gb_extension.Controls.Add(this.pl_extension);
            this.gb_extension.ForeColor = System.Drawing.Color.Black;
            this.gb_extension.Location = new System.Drawing.Point(487, 146);
            this.gb_extension.Name = "gb_extension";
            this.gb_extension.RectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.gb_extension.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.gb_extension.Size = new System.Drawing.Size(516, 518);
            this.gb_extension.TabIndex = 10;
            this.gb_extension.TabStop = false;
            this.gb_extension.Text = "扩展";
            this.gb_extension.TitleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.gb_extension.TitleRectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.gb_extension.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.gb_extension.Visible = false;
            // 
            // pl_extension
            // 
            this.pl_extension.AutoScroll = true;
            this.pl_extension.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pl_extension.Controls.Add(this.skinCheckBox1);
            this.pl_extension.Controls.Add(this.DataGridView1);
            this.pl_extension.Controls.Add(this.btn_Export);
            this.pl_extension.Controls.Add(this.check_All);
            this.pl_extension.Controls.Add(this.btn_Import);
            this.pl_extension.Controls.Add(this.btn_ForeachSend);
            this.pl_extension.Location = new System.Drawing.Point(3, 13);
            this.pl_extension.Name = "pl_extension";
            this.pl_extension.Size = new System.Drawing.Size(511, 500);
            this.pl_extension.TabIndex = 0;
            // 
            // skinCheckBox1
            // 
            this.skinCheckBox1.AutoSize = true;
            this.skinCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox1.DownBack = null;
            this.skinCheckBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox1.Location = new System.Drawing.Point(167, 7);
            this.skinCheckBox1.MouseBack = null;
            this.skinCheckBox1.Name = "skinCheckBox1";
            this.skinCheckBox1.NormlBack = null;
            this.skinCheckBox1.SelectedDownBack = null;
            this.skinCheckBox1.SelectedMouseBack = null;
            this.skinCheckBox1.SelectedNormlBack = null;
            this.skinCheckBox1.Size = new System.Drawing.Size(99, 21);
            this.skinCheckBox1.TabIndex = 427;
            this.skinCheckBox1.Text = "全选发送状态";
            this.skinCheckBox1.UseVisualStyleBackColor = false;
            this.skinCheckBox1.CheckedChanged += new System.EventHandler(this.skinCheckBox1_CheckedChanged);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView1.ColumnFont = null;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DataGridView1.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DataGridView1.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataGridView1.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridView1.Location = new System.Drawing.Point(3, 30);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView1.RowTemplate.Height = 23;
            this.DataGridView1.Size = new System.Drawing.Size(506, 466);
            this.DataGridView1.TabIndex = 426;
            this.DataGridView1.TitleBack = null;
            this.DataGridView1.TitleBackColorBegin = System.Drawing.Color.White;
            this.DataGridView1.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            this.DataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyDown);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "发送";
            this.Column6.Name = "Column6";
            this.Column6.Width = 30;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "HEX";
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "字符串[双击注释]";
            this.Column2.Name = "Column2";
            this.Column2.Width = 206;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "点击发送";
            this.Column3.Name = "Column3";
            this.Column3.Width = 115;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "顺序";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 25;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "延时ms";
            this.Column5.Name = "Column5";
            this.Column5.Width = 40;
            // 
            // btn_Export
            // 
            this.btn_Export.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_Export.Location = new System.Drawing.Point(440, 1);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(66, 27);
            this.btn_Export.TabIndex = 425;
            this.btn_Export.Text = "导出Excel";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // check_All
            // 
            this.check_All.AutoSize = true;
            this.check_All.BackColor = System.Drawing.Color.Transparent;
            this.check_All.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.check_All.DownBack = null;
            this.check_All.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check_All.Location = new System.Drawing.Point(86, 7);
            this.check_All.MouseBack = null;
            this.check_All.Name = "check_All";
            this.check_All.NormlBack = null;
            this.check_All.SelectedDownBack = null;
            this.check_All.SelectedMouseBack = null;
            this.check_All.SelectedNormlBack = null;
            this.check_All.Size = new System.Drawing.Size(75, 21);
            this.check_All.TabIndex = 424;
            this.check_All.Text = "全选HEX";
            this.check_All.UseVisualStyleBackColor = false;
            this.check_All.CheckedChanged += new System.EventHandler(this.check_All_CheckedChanged);
            // 
            // btn_Import
            // 
            this.btn_Import.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_Import.Location = new System.Drawing.Point(374, 1);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(66, 27);
            this.btn_Import.TabIndex = 207;
            this.btn_Import.Text = "导入Excel";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_ForeachSend
            // 
            this.btn_ForeachSend.AutoSize = true;
            this.btn_ForeachSend.BackColor = System.Drawing.Color.Transparent;
            this.btn_ForeachSend.ControlState = CCWin.SkinClass.ControlState.Focused;
            this.btn_ForeachSend.DownBack = null;
            this.btn_ForeachSend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ForeachSend.Location = new System.Drawing.Point(5, 7);
            this.btn_ForeachSend.MouseBack = null;
            this.btn_ForeachSend.Name = "btn_ForeachSend";
            this.btn_ForeachSend.NormlBack = null;
            this.btn_ForeachSend.SelectedDownBack = null;
            this.btn_ForeachSend.SelectedMouseBack = null;
            this.btn_ForeachSend.SelectedNormlBack = null;
            this.btn_ForeachSend.Size = new System.Drawing.Size(75, 21);
            this.btn_ForeachSend.TabIndex = 175;
            this.btn_ForeachSend.Text = "循环发送";
            this.btn_ForeachSend.UseVisualStyleBackColor = false;
            this.btn_ForeachSend.CheckedChanged += new System.EventHandler(this.btn_ForeachSend_CheckedChanged);
            // 
            // gbPortSettings
            // 
            this.gbPortSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.gbPortSettings.BorderColor = System.Drawing.Color.Black;
            this.gbPortSettings.Controls.Add(this.skinTabControl1);
            this.gbPortSettings.ForeColor = System.Drawing.Color.Black;
            this.gbPortSettings.Location = new System.Drawing.Point(7, 36);
            this.gbPortSettings.Name = "gbPortSettings";
            this.gbPortSettings.RectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.gbPortSettings.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.gbPortSettings.Size = new System.Drawing.Size(647, 100);
            this.gbPortSettings.TabIndex = 2;
            this.gbPortSettings.TabStop = false;
            this.gbPortSettings.Text = "串口设置";
            this.gbPortSettings.TitleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.gbPortSettings.TitleRectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.gbPortSettings.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skinTabControl1
            // 
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Controls.Add(this.skinTabPage1);
            this.skinTabControl1.Controls.Add(this.skinTabPage2);
            this.skinTabControl1.Controls.Add(this.skinTabPage3);
            this.skinTabControl1.HeadBack = null;
            this.skinTabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl1.ItemSize = new System.Drawing.Size(66, 36);
            this.skinTabControl1.Location = new System.Drawing.Point(4, 15);
            this.skinTabControl1.Name = "skinTabControl1";
            this.skinTabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowDown")));
            this.skinTabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowHover")));
            this.skinTabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseHover")));
            this.skinTabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseNormal")));
            this.skinTabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageDown")));
            this.skinTabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageHover")));
            this.skinTabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl1.PageNorml = null;
            this.skinTabControl1.SelectedIndex = 1;
            this.skinTabControl1.Size = new System.Drawing.Size(640, 77);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl1.TabIndex = 175;
            // 
            // skinTabPage1
            // 
            this.skinTabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.skinTabPage1.Controls.Add(this.btn_Open);
            this.skinTabPage1.Controls.Add(this.cmbParity);
            this.skinTabPage1.Controls.Add(this.cmbPortName);
            this.skinTabPage1.Controls.Add(this.skinLabel9);
            this.skinTabPage1.Controls.Add(this.skinLabel8);
            this.skinTabPage1.Controls.Add(this.cmbStopBits);
            this.skinTabPage1.Controls.Add(this.cmbDataBits);
            this.skinTabPage1.Controls.Add(this.cmbBaudRate);
            this.skinTabPage1.Controls.Add(this.skinLabel10);
            this.skinTabPage1.Controls.Add(this.skinLabel11);
            this.skinTabPage1.Controls.Add(this.skinLabel12);
            this.skinTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage1.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage1.Name = "skinTabPage1";
            this.skinTabPage1.Size = new System.Drawing.Size(640, 41);
            this.skinTabPage1.TabIndex = 0;
            this.skinTabPage1.TabItemImage = null;
            this.skinTabPage1.Text = "串口一";
            // 
            // skinTabPage2
            // 
            this.skinTabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.skinTabPage2.Controls.Add(this.btn_Open2);
            this.skinTabPage2.Controls.Add(this.cmbParity2);
            this.skinTabPage2.Controls.Add(this.cmbPortName2);
            this.skinTabPage2.Controls.Add(this.skinLabel28);
            this.skinTabPage2.Controls.Add(this.skinLabel29);
            this.skinTabPage2.Controls.Add(this.cmbStopBits2);
            this.skinTabPage2.Controls.Add(this.cmbDataBits2);
            this.skinTabPage2.Controls.Add(this.cmbBaudRate2);
            this.skinTabPage2.Controls.Add(this.skinLabel31);
            this.skinTabPage2.Controls.Add(this.skinLabel32);
            this.skinTabPage2.Controls.Add(this.skinLabel33);
            this.skinTabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage2.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage2.Name = "skinTabPage2";
            this.skinTabPage2.Size = new System.Drawing.Size(640, 41);
            this.skinTabPage2.TabIndex = 1;
            this.skinTabPage2.TabItemImage = null;
            this.skinTabPage2.Text = "串口二";
            // 
            // btn_Open2
            // 
            this.btn_Open2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btn_Open2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Open2.DownBack = null;
            this.btn_Open2.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_Open2.Location = new System.Drawing.Point(554, 11);
            this.btn_Open2.MouseBack = null;
            this.btn_Open2.Name = "btn_Open2";
            this.btn_Open2.NormlBack = null;
            this.btn_Open2.Size = new System.Drawing.Size(82, 28);
            this.btn_Open2.TabIndex = 125;
            this.btn_Open2.TabStop = false;
            this.btn_Open2.Text = "&O打开端口";
            this.btn_Open2.UseVisualStyleBackColor = false;
            this.btn_Open2.Click += new System.EventHandler(this.btn_Open2_Click);
            // 
            // cmbParity2
            // 
            this.cmbParity2.BackColor = System.Drawing.Color.White;
            this.cmbParity2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbParity2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbParity2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbParity2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cmbParity2.FormattingEnabled = true;
            this.cmbParity2.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.cmbParity2.Location = new System.Drawing.Point(378, 12);
            this.cmbParity2.Name = "cmbParity2";
            this.cmbParity2.Size = new System.Drawing.Size(63, 24);
            this.cmbParity2.TabIndex = 130;
            this.cmbParity2.Text = "Even";
            this.cmbParity2.WaterText = "";
            // 
            // cmbPortName2
            // 
            this.cmbPortName2.BackColor = System.Drawing.Color.White;
            this.cmbPortName2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbPortName2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbPortName2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPortName2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cmbPortName2.FormattingEnabled = true;
            this.cmbPortName2.Location = new System.Drawing.Point(48, 12);
            this.cmbPortName2.Name = "cmbPortName2";
            this.cmbPortName2.Size = new System.Drawing.Size(63, 24);
            this.cmbPortName2.TabIndex = 127;
            this.cmbPortName2.WaterText = "";
            // 
            // skinLabel28
            // 
            this.skinLabel28.AutoSize = true;
            this.skinLabel28.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel28.BorderColor = System.Drawing.Color.White;
            this.skinLabel28.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinLabel28.Location = new System.Drawing.Point(111, 19);
            this.skinLabel28.Name = "skinLabel28";
            this.skinLabel28.Size = new System.Drawing.Size(47, 17);
            this.skinLabel28.TabIndex = 133;
            this.skinLabel28.Text = "停止位:";
            // 
            // skinLabel29
            // 
            this.skinLabel29.AutoSize = true;
            this.skinLabel29.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel29.BorderColor = System.Drawing.Color.White;
            this.skinLabel29.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinLabel29.Location = new System.Drawing.Point(1, 19);
            this.skinLabel29.Name = "skinLabel29";
            this.skinLabel29.Size = new System.Drawing.Size(47, 17);
            this.skinLabel29.TabIndex = 132;
            this.skinLabel29.Text = "串口号:";
            // 
            // cmbStopBits2
            // 
            this.cmbStopBits2.BackColor = System.Drawing.Color.White;
            this.cmbStopBits2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbStopBits2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbStopBits2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStopBits2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cmbStopBits2.FormattingEnabled = true;
            this.cmbStopBits2.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbStopBits2.Location = new System.Drawing.Point(158, 12);
            this.cmbStopBits2.Name = "cmbStopBits2";
            this.cmbStopBits2.Size = new System.Drawing.Size(63, 24);
            this.cmbStopBits2.TabIndex = 128;
            this.cmbStopBits2.Text = "1";
            this.cmbStopBits2.WaterText = "";
            // 
            // cmbDataBits2
            // 
            this.cmbDataBits2.BackColor = System.Drawing.Color.White;
            this.cmbDataBits2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbDataBits2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbDataBits2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDataBits2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cmbDataBits2.FormattingEnabled = true;
            this.cmbDataBits2.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cmbDataBits2.Location = new System.Drawing.Point(488, 12);
            this.cmbDataBits2.Name = "cmbDataBits2";
            this.cmbDataBits2.Size = new System.Drawing.Size(63, 24);
            this.cmbDataBits2.TabIndex = 131;
            this.cmbDataBits2.Text = "8";
            this.cmbDataBits2.WaterText = "";
            // 
            // cmbBaudRate2
            // 
            this.cmbBaudRate2.BackColor = System.Drawing.Color.White;
            this.cmbBaudRate2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbBaudRate2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbBaudRate2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBaudRate2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cmbBaudRate2.FormattingEnabled = true;
            this.cmbBaudRate2.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "28800",
            "36000",
            "115200"});
            this.cmbBaudRate2.Location = new System.Drawing.Point(268, 12);
            this.cmbBaudRate2.Name = "cmbBaudRate2";
            this.cmbBaudRate2.Size = new System.Drawing.Size(63, 24);
            this.cmbBaudRate2.TabIndex = 129;
            this.cmbBaudRate2.Text = "2400";
            this.cmbBaudRate2.WaterText = "";
            // 
            // skinLabel31
            // 
            this.skinLabel31.AutoSize = true;
            this.skinLabel31.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel31.BorderColor = System.Drawing.Color.White;
            this.skinLabel31.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinLabel31.Location = new System.Drawing.Point(331, 19);
            this.skinLabel31.Name = "skinLabel31";
            this.skinLabel31.Size = new System.Drawing.Size(47, 17);
            this.skinLabel31.TabIndex = 134;
            this.skinLabel31.Text = "校验位:";
            // 
            // skinLabel32
            // 
            this.skinLabel32.AutoSize = true;
            this.skinLabel32.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel32.BorderColor = System.Drawing.Color.White;
            this.skinLabel32.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinLabel32.Location = new System.Drawing.Point(221, 19);
            this.skinLabel32.Name = "skinLabel32";
            this.skinLabel32.Size = new System.Drawing.Size(47, 17);
            this.skinLabel32.TabIndex = 135;
            this.skinLabel32.Text = "波特率:";
            // 
            // skinLabel33
            // 
            this.skinLabel33.AutoSize = true;
            this.skinLabel33.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel33.BorderColor = System.Drawing.Color.White;
            this.skinLabel33.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinLabel33.Location = new System.Drawing.Point(441, 19);
            this.skinLabel33.Name = "skinLabel33";
            this.skinLabel33.Size = new System.Drawing.Size(47, 17);
            this.skinLabel33.TabIndex = 136;
            this.skinLabel33.Text = "数据位:";
            // 
            // skinTabPage3
            // 
            this.skinTabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.skinTabPage3.Controls.Add(this.btn_Open3);
            this.skinTabPage3.Controls.Add(this.cmbParity3);
            this.skinTabPage3.Controls.Add(this.cmbPortName3);
            this.skinTabPage3.Controls.Add(this.skinLabel35);
            this.skinTabPage3.Controls.Add(this.skinLabel36);
            this.skinTabPage3.Controls.Add(this.cmbStopBits3);
            this.skinTabPage3.Controls.Add(this.cmbDataBits3);
            this.skinTabPage3.Controls.Add(this.cmbBaudRate3);
            this.skinTabPage3.Controls.Add(this.skinLabel38);
            this.skinTabPage3.Controls.Add(this.skinLabel39);
            this.skinTabPage3.Controls.Add(this.skinLabel50);
            this.skinTabPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage3.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage3.Name = "skinTabPage3";
            this.skinTabPage3.Size = new System.Drawing.Size(640, 41);
            this.skinTabPage3.TabIndex = 2;
            this.skinTabPage3.TabItemImage = null;
            this.skinTabPage3.Text = "串口三";
            // 
            // btn_Open3
            // 
            this.btn_Open3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btn_Open3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Open3.DownBack = null;
            this.btn_Open3.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_Open3.Location = new System.Drawing.Point(554, 11);
            this.btn_Open3.MouseBack = null;
            this.btn_Open3.Name = "btn_Open3";
            this.btn_Open3.NormlBack = null;
            this.btn_Open3.Size = new System.Drawing.Size(82, 28);
            this.btn_Open3.TabIndex = 125;
            this.btn_Open3.TabStop = false;
            this.btn_Open3.Text = "&O打开端口";
            this.btn_Open3.UseVisualStyleBackColor = false;
            this.btn_Open3.Click += new System.EventHandler(this.btn_Open3_Click);
            // 
            // cmbParity3
            // 
            this.cmbParity3.BackColor = System.Drawing.Color.White;
            this.cmbParity3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbParity3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbParity3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbParity3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cmbParity3.FormattingEnabled = true;
            this.cmbParity3.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.cmbParity3.Location = new System.Drawing.Point(378, 12);
            this.cmbParity3.Name = "cmbParity3";
            this.cmbParity3.Size = new System.Drawing.Size(63, 24);
            this.cmbParity3.TabIndex = 130;
            this.cmbParity3.Text = "Even";
            this.cmbParity3.WaterText = "";
            // 
            // cmbPortName3
            // 
            this.cmbPortName3.BackColor = System.Drawing.Color.White;
            this.cmbPortName3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbPortName3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbPortName3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPortName3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cmbPortName3.FormattingEnabled = true;
            this.cmbPortName3.Location = new System.Drawing.Point(48, 12);
            this.cmbPortName3.Name = "cmbPortName3";
            this.cmbPortName3.Size = new System.Drawing.Size(63, 24);
            this.cmbPortName3.TabIndex = 127;
            this.cmbPortName3.WaterText = "";
            // 
            // skinLabel35
            // 
            this.skinLabel35.AutoSize = true;
            this.skinLabel35.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel35.BorderColor = System.Drawing.Color.White;
            this.skinLabel35.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinLabel35.Location = new System.Drawing.Point(111, 19);
            this.skinLabel35.Name = "skinLabel35";
            this.skinLabel35.Size = new System.Drawing.Size(47, 17);
            this.skinLabel35.TabIndex = 133;
            this.skinLabel35.Text = "停止位:";
            // 
            // skinLabel36
            // 
            this.skinLabel36.AutoSize = true;
            this.skinLabel36.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel36.BorderColor = System.Drawing.Color.White;
            this.skinLabel36.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinLabel36.Location = new System.Drawing.Point(1, 19);
            this.skinLabel36.Name = "skinLabel36";
            this.skinLabel36.Size = new System.Drawing.Size(47, 17);
            this.skinLabel36.TabIndex = 132;
            this.skinLabel36.Text = "串口号:";
            // 
            // cmbStopBits3
            // 
            this.cmbStopBits3.BackColor = System.Drawing.Color.White;
            this.cmbStopBits3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbStopBits3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbStopBits3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStopBits3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cmbStopBits3.FormattingEnabled = true;
            this.cmbStopBits3.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbStopBits3.Location = new System.Drawing.Point(158, 12);
            this.cmbStopBits3.Name = "cmbStopBits3";
            this.cmbStopBits3.Size = new System.Drawing.Size(63, 24);
            this.cmbStopBits3.TabIndex = 128;
            this.cmbStopBits3.Text = "1";
            this.cmbStopBits3.WaterText = "";
            // 
            // cmbDataBits3
            // 
            this.cmbDataBits3.BackColor = System.Drawing.Color.White;
            this.cmbDataBits3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbDataBits3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbDataBits3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDataBits3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cmbDataBits3.FormattingEnabled = true;
            this.cmbDataBits3.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cmbDataBits3.Location = new System.Drawing.Point(488, 12);
            this.cmbDataBits3.Name = "cmbDataBits3";
            this.cmbDataBits3.Size = new System.Drawing.Size(63, 24);
            this.cmbDataBits3.TabIndex = 131;
            this.cmbDataBits3.Text = "8";
            this.cmbDataBits3.WaterText = "";
            // 
            // cmbBaudRate3
            // 
            this.cmbBaudRate3.BackColor = System.Drawing.Color.White;
            this.cmbBaudRate3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbBaudRate3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.cmbBaudRate3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBaudRate3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cmbBaudRate3.FormattingEnabled = true;
            this.cmbBaudRate3.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "28800",
            "36000",
            "115200"});
            this.cmbBaudRate3.Location = new System.Drawing.Point(268, 12);
            this.cmbBaudRate3.Name = "cmbBaudRate3";
            this.cmbBaudRate3.Size = new System.Drawing.Size(63, 24);
            this.cmbBaudRate3.TabIndex = 129;
            this.cmbBaudRate3.Text = "2400";
            this.cmbBaudRate3.WaterText = "";
            // 
            // skinLabel38
            // 
            this.skinLabel38.AutoSize = true;
            this.skinLabel38.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel38.BorderColor = System.Drawing.Color.White;
            this.skinLabel38.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinLabel38.Location = new System.Drawing.Point(331, 19);
            this.skinLabel38.Name = "skinLabel38";
            this.skinLabel38.Size = new System.Drawing.Size(47, 17);
            this.skinLabel38.TabIndex = 134;
            this.skinLabel38.Text = "校验位:";
            // 
            // skinLabel39
            // 
            this.skinLabel39.AutoSize = true;
            this.skinLabel39.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel39.BorderColor = System.Drawing.Color.White;
            this.skinLabel39.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinLabel39.Location = new System.Drawing.Point(221, 19);
            this.skinLabel39.Name = "skinLabel39";
            this.skinLabel39.Size = new System.Drawing.Size(47, 17);
            this.skinLabel39.TabIndex = 135;
            this.skinLabel39.Text = "波特率:";
            // 
            // skinLabel50
            // 
            this.skinLabel50.AutoSize = true;
            this.skinLabel50.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel50.BorderColor = System.Drawing.Color.White;
            this.skinLabel50.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinLabel50.Location = new System.Drawing.Point(441, 19);
            this.skinLabel50.Name = "skinLabel50";
            this.skinLabel50.Size = new System.Drawing.Size(47, 17);
            this.skinLabel50.TabIndex = 136;
            this.skinLabel50.Text = "数据位:";
            // 
            // skinGroupBox5
            // 
            this.skinGroupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.skinGroupBox5.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox5.Controls.Add(this.txt_Code);
            this.skinGroupBox5.Controls.Add(this.txt_MeterAddr);
            this.skinGroupBox5.Controls.Add(this.skinLabel1);
            this.skinGroupBox5.Controls.Add(this.txt_VendorCode);
            this.skinGroupBox5.Controls.Add(this.skinLabel44);
            this.skinGroupBox5.Controls.Add(this.skinLabel45);
            this.skinGroupBox5.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox5.Location = new System.Drawing.Point(840, 36);
            this.skinGroupBox5.Name = "skinGroupBox5";
            this.skinGroupBox5.RectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.skinGroupBox5.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox5.Size = new System.Drawing.Size(163, 100);
            this.skinGroupBox5.TabIndex = 2;
            this.skinGroupBox5.TabStop = false;
            this.skinGroupBox5.Text = "基本参数设置";
            this.skinGroupBox5.TitleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.skinGroupBox5.TitleRectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.skinGroupBox5.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // txt_Code
            // 
            this.txt_Code.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Code.Location = new System.Drawing.Point(65, 71);
            this.txt_Code.MaxLength = 16;
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(55, 23);
            this.txt_Code.TabIndex = 193;
            // 
            // txt_MeterAddr
            // 
            this.txt_MeterAddr.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_MeterAddr.Location = new System.Drawing.Point(65, 15);
            this.txt_MeterAddr.MaxLength = 16;
            this.txt_MeterAddr.Name = "txt_MeterAddr";
            this.txt_MeterAddr.Size = new System.Drawing.Size(94, 23);
            this.txt_MeterAddr.TabIndex = 191;
            // 
            // txt_VendorCode
            // 
            this.txt_VendorCode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_VendorCode.Location = new System.Drawing.Point(65, 43);
            this.txt_VendorCode.MaxLength = 16;
            this.txt_VendorCode.Name = "txt_VendorCode";
            this.txt_VendorCode.Size = new System.Drawing.Size(55, 23);
            this.txt_VendorCode.TabIndex = 192;
            this.txt_VendorCode.Text = "0000";
            // 
            // skinGroupBox2
            // 
            this.skinGroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.skinGroupBox2.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox2.Controls.Add(this.txt_SendNumber);
            this.skinGroupBox2.Controls.Add(this.skinLabel21);
            this.skinGroupBox2.Controls.Add(this.skinLabel22);
            this.skinGroupBox2.Controls.Add(this.txt_timeSend);
            this.skinGroupBox2.Controls.Add(this.skinLabel41);
            this.skinGroupBox2.Controls.Add(this.skinLabel42);
            this.skinGroupBox2.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox2.Location = new System.Drawing.Point(288, 10);
            this.skinGroupBox2.Name = "skinGroupBox2";
            this.skinGroupBox2.RectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.skinGroupBox2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox2.Size = new System.Drawing.Size(170, 75);
            this.skinGroupBox2.TabIndex = 1;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = "重复发送设置";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.skinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // txt_SendNumber
            // 
            this.txt_SendNumber.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_SendNumber.Location = new System.Drawing.Point(74, 43);
            this.txt_SendNumber.Name = "txt_SendNumber";
            this.txt_SendNumber.Size = new System.Drawing.Size(38, 25);
            this.txt_SendNumber.TabIndex = 172;
            this.txt_SendNumber.Text = "9999";
            this.txt_SendNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SendNumber_KeyPress);
            // 
            // skinLabel21
            // 
            this.skinLabel21.AutoSize = true;
            this.skinLabel21.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel21.BorderColor = System.Drawing.Color.White;
            this.skinLabel21.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel21.Location = new System.Drawing.Point(15, 45);
            this.skinLabel21.Name = "skinLabel21";
            this.skinLabel21.Size = new System.Drawing.Size(59, 17);
            this.skinLabel21.TabIndex = 171;
            this.skinLabel21.Text = "发送次数:";
            // 
            // skinLabel22
            // 
            this.skinLabel22.AutoSize = true;
            this.skinLabel22.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel22.BorderColor = System.Drawing.Color.White;
            this.skinLabel22.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel22.Location = new System.Drawing.Point(114, 45);
            this.skinLabel22.Name = "skinLabel22";
            this.skinLabel22.Size = new System.Drawing.Size(20, 17);
            this.skinLabel22.TabIndex = 173;
            this.skinLabel22.Text = "次";
            // 
            // cbo_timeSend
            // 
            this.cbo_timeSend.AutoSize = true;
            this.cbo_timeSend.BackColor = System.Drawing.Color.Transparent;
            this.cbo_timeSend.ControlState = CCWin.SkinClass.ControlState.Focused;
            this.cbo_timeSend.DownBack = null;
            this.cbo_timeSend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_timeSend.Location = new System.Drawing.Point(81, 16);
            this.cbo_timeSend.MouseBack = null;
            this.cbo_timeSend.Name = "cbo_timeSend";
            this.cbo_timeSend.NormlBack = null;
            this.cbo_timeSend.SelectedDownBack = null;
            this.cbo_timeSend.SelectedMouseBack = null;
            this.cbo_timeSend.SelectedNormlBack = null;
            this.cbo_timeSend.Size = new System.Drawing.Size(75, 21);
            this.cbo_timeSend.TabIndex = 150;
            this.cbo_timeSend.Text = "重复发送";
            this.cbo_timeSend.UseVisualStyleBackColor = false;
            this.cbo_timeSend.CheckedChanged += new System.EventHandler(this.cbo_timeSend_CheckedChanged);
            // 
            // cbo_gjz
            // 
            this.cbo_gjz.AutoSize = true;
            this.cbo_gjz.BackColor = System.Drawing.Color.Transparent;
            this.cbo_gjz.ControlState = CCWin.SkinClass.ControlState.Focused;
            this.cbo_gjz.DownBack = null;
            this.cbo_gjz.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_gjz.Location = new System.Drawing.Point(-61, -6);
            this.cbo_gjz.MouseBack = null;
            this.cbo_gjz.Name = "cbo_gjz";
            this.cbo_gjz.NormlBack = null;
            this.cbo_gjz.SelectedDownBack = null;
            this.cbo_gjz.SelectedMouseBack = null;
            this.cbo_gjz.SelectedNormlBack = null;
            this.cbo_gjz.Size = new System.Drawing.Size(111, 21);
            this.cbo_gjz.TabIndex = 190;
            this.cbo_gjz.Text = "关键字过滤接收";
            this.cbo_gjz.UseVisualStyleBackColor = false;
            this.cbo_gjz.Visible = false;
            // 
            // btn_Ccombination
            // 
            this.btn_Ccombination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btn_Ccombination.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Ccombination.DownBack = null;
            this.btn_Ccombination.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Ccombination.Location = new System.Drawing.Point(8, 55);
            this.btn_Ccombination.MouseBack = null;
            this.btn_Ccombination.Name = "btn_Ccombination";
            this.btn_Ccombination.NormlBack = null;
            this.btn_Ccombination.Size = new System.Drawing.Size(104, 59);
            this.btn_Ccombination.TabIndex = 15;
            this.btn_Ccombination.Text = "组帧";
            this.btn_Ccombination.UseVisualStyleBackColor = false;
            this.btn_Ccombination.Click += new System.EventHandler(this.btn_CustomData_Click);
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(7, 31);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(59, 17);
            this.skinLabel6.TabIndex = 149;
            this.skinLabel6.Text = "固定字节:";
            // 
            // skinTextBox2
            // 
            this.skinTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(207)))));
            this.skinTextBox2.DownBack = null;
            this.skinTextBox2.Enabled = false;
            this.skinTextBox2.Icon = null;
            this.skinTextBox2.IconIsButton = false;
            this.skinTextBox2.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox2.IsPasswordChat = '\0';
            this.skinTextBox2.IsSystemPasswordChar = false;
            this.skinTextBox2.Lines = new string[0];
            this.skinTextBox2.Location = new System.Drawing.Point(84, 541);
            this.skinTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox2.MaxLength = 32767;
            this.skinTextBox2.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox2.MouseBack = null;
            this.skinTextBox2.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox2.Multiline = true;
            this.skinTextBox2.Name = "skinTextBox2";
            this.skinTextBox2.NormlBack = null;
            this.skinTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox2.ReadOnly = false;
            this.skinTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox2.Size = new System.Drawing.Size(1007, 97);
            // 
            // 
            // 
            this.skinTextBox2.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox2.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox2.SkinTxt.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTextBox2.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox2.SkinTxt.Multiline = true;
            this.skinTextBox2.SkinTxt.Name = "BaseText";
            this.skinTextBox2.SkinTxt.Size = new System.Drawing.Size(997, 87);
            this.skinTextBox2.SkinTxt.TabIndex = 0;
            this.skinTextBox2.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(207)))));
            this.skinTextBox2.SkinTxt.WaterText = "";
            this.skinTextBox2.TabIndex = 146;
            this.skinTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox2.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(207)))));
            this.skinTextBox2.WaterText = "";
            this.skinTextBox2.WordWrap = true;
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(143, 31);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(42, 17);
            this.skinLabel7.TabIndex = 151;
            this.skinLabel7.Text = "数据1:";
            // 
            // skinLabel14
            // 
            this.skinLabel14.AutoSize = true;
            this.skinLabel14.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel14.BorderColor = System.Drawing.Color.White;
            this.skinLabel14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel14.Location = new System.Drawing.Point(241, 31);
            this.skinLabel14.Name = "skinLabel14";
            this.skinLabel14.Size = new System.Drawing.Size(42, 17);
            this.skinLabel14.TabIndex = 192;
            this.skinLabel14.Text = "数据2:";
            // 
            // skinLabel15
            // 
            this.skinLabel15.AutoSize = true;
            this.skinLabel15.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel15.BorderColor = System.Drawing.Color.White;
            this.skinLabel15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel15.Location = new System.Drawing.Point(339, 31);
            this.skinLabel15.Name = "skinLabel15";
            this.skinLabel15.Size = new System.Drawing.Size(42, 17);
            this.skinLabel15.TabIndex = 195;
            this.skinLabel15.Text = "数据3:";
            // 
            // skinGroupBox4
            // 
            this.skinGroupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.skinGroupBox4.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox4.Controls.Add(this.cbo_Res1);
            this.skinGroupBox4.Controls.Add(this.txt_Pad1);
            this.skinGroupBox4.Controls.Add(this.skinLabel18);
            this.skinGroupBox4.Controls.Add(this.txt_leng1);
            this.skinGroupBox4.Controls.Add(this.skinLabel16);
            this.skinGroupBox4.Controls.Add(this.cbo_Hex1);
            this.skinGroupBox4.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox4.Location = new System.Drawing.Point(113, 49);
            this.skinGroupBox4.Name = "skinGroupBox4";
            this.skinGroupBox4.RectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.skinGroupBox4.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox4.Size = new System.Drawing.Size(109, 65);
            this.skinGroupBox4.TabIndex = 195;
            this.skinGroupBox4.TabStop = false;
            this.skinGroupBox4.Text = "数据1";
            this.skinGroupBox4.TitleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.skinGroupBox4.TitleRectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.skinGroupBox4.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // cbo_Res1
            // 
            this.cbo_Res1.AutoSize = true;
            this.cbo_Res1.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Res1.ControlState = CCWin.SkinClass.ControlState.Focused;
            this.cbo_Res1.DownBack = null;
            this.cbo_Res1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_Res1.Location = new System.Drawing.Point(58, 38);
            this.cbo_Res1.MouseBack = null;
            this.cbo_Res1.Name = "cbo_Res1";
            this.cbo_Res1.NormlBack = null;
            this.cbo_Res1.SelectedDownBack = null;
            this.cbo_Res1.SelectedMouseBack = null;
            this.cbo_Res1.SelectedNormlBack = null;
            this.cbo_Res1.Size = new System.Drawing.Size(51, 21);
            this.cbo_Res1.TabIndex = 201;
            this.cbo_Res1.Text = "反转";
            this.cbo_Res1.UseVisualStyleBackColor = false;
            // 
            // txt_Pad1
            // 
            this.txt_Pad1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txt_Pad1.Location = new System.Drawing.Point(32, 37);
            this.txt_Pad1.MaxLength = 10;
            this.txt_Pad1.Name = "txt_Pad1";
            this.txt_Pad1.Size = new System.Drawing.Size(26, 23);
            this.txt_Pad1.TabIndex = 200;
            this.txt_Pad1.Text = "0";
            this.txt_Pad1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Pad1_KeyPress);
            // 
            // skinLabel18
            // 
            this.skinLabel18.AutoSize = true;
            this.skinLabel18.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel18.BorderColor = System.Drawing.Color.White;
            this.skinLabel18.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinLabel18.Location = new System.Drawing.Point(2, 41);
            this.skinLabel18.Name = "skinLabel18";
            this.skinLabel18.Size = new System.Drawing.Size(35, 17);
            this.skinLabel18.TabIndex = 199;
            this.skinLabel18.Text = "补位:";
            // 
            // txt_leng1
            // 
            this.txt_leng1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txt_leng1.Location = new System.Drawing.Point(32, 13);
            this.txt_leng1.MaxLength = 10;
            this.txt_leng1.Name = "txt_leng1";
            this.txt_leng1.Size = new System.Drawing.Size(26, 23);
            this.txt_leng1.TabIndex = 191;
            this.txt_leng1.Text = "2";
            this.txt_leng1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_leng1_KeyPress);
            // 
            // skinLabel16
            // 
            this.skinLabel16.AutoSize = true;
            this.skinLabel16.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel16.BorderColor = System.Drawing.Color.White;
            this.skinLabel16.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinLabel16.Location = new System.Drawing.Point(2, 17);
            this.skinLabel16.Name = "skinLabel16";
            this.skinLabel16.Size = new System.Drawing.Size(35, 17);
            this.skinLabel16.TabIndex = 190;
            this.skinLabel16.Text = "长度:";
            // 
            // cbo_Hex1
            // 
            this.cbo_Hex1.AutoSize = true;
            this.cbo_Hex1.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Hex1.ControlState = CCWin.SkinClass.ControlState.Focused;
            this.cbo_Hex1.DownBack = null;
            this.cbo_Hex1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_Hex1.Location = new System.Drawing.Point(58, 14);
            this.cbo_Hex1.MouseBack = null;
            this.cbo_Hex1.Name = "cbo_Hex1";
            this.cbo_Hex1.NormlBack = null;
            this.cbo_Hex1.SelectedDownBack = null;
            this.cbo_Hex1.SelectedMouseBack = null;
            this.cbo_Hex1.SelectedNormlBack = null;
            this.cbo_Hex1.Size = new System.Drawing.Size(51, 21);
            this.cbo_Hex1.TabIndex = 197;
            this.cbo_Hex1.Text = "HEX";
            this.cbo_Hex1.UseVisualStyleBackColor = false;
            // 
            // skinGroupBox6
            // 
            this.skinGroupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.skinGroupBox6.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox6.Controls.Add(this.cbo_Res2);
            this.skinGroupBox6.Controls.Add(this.txt_Pad2);
            this.skinGroupBox6.Controls.Add(this.skinLabel13);
            this.skinGroupBox6.Controls.Add(this.txt_leng2);
            this.skinGroupBox6.Controls.Add(this.skinLabel17);
            this.skinGroupBox6.Controls.Add(this.cbo_Hex2);
            this.skinGroupBox6.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox6.Location = new System.Drawing.Point(223, 49);
            this.skinGroupBox6.Name = "skinGroupBox6";
            this.skinGroupBox6.RectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.skinGroupBox6.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox6.Size = new System.Drawing.Size(109, 65);
            this.skinGroupBox6.TabIndex = 202;
            this.skinGroupBox6.TabStop = false;
            this.skinGroupBox6.Text = "数据2";
            this.skinGroupBox6.TitleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.skinGroupBox6.TitleRectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.skinGroupBox6.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // cbo_Res2
            // 
            this.cbo_Res2.AutoSize = true;
            this.cbo_Res2.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Res2.ControlState = CCWin.SkinClass.ControlState.Focused;
            this.cbo_Res2.DownBack = null;
            this.cbo_Res2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_Res2.Location = new System.Drawing.Point(59, 38);
            this.cbo_Res2.MouseBack = null;
            this.cbo_Res2.Name = "cbo_Res2";
            this.cbo_Res2.NormlBack = null;
            this.cbo_Res2.SelectedDownBack = null;
            this.cbo_Res2.SelectedMouseBack = null;
            this.cbo_Res2.SelectedNormlBack = null;
            this.cbo_Res2.Size = new System.Drawing.Size(51, 21);
            this.cbo_Res2.TabIndex = 201;
            this.cbo_Res2.Text = "反转";
            this.cbo_Res2.UseVisualStyleBackColor = false;
            // 
            // txt_Pad2
            // 
            this.txt_Pad2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txt_Pad2.Location = new System.Drawing.Point(33, 37);
            this.txt_Pad2.MaxLength = 10;
            this.txt_Pad2.Name = "txt_Pad2";
            this.txt_Pad2.Size = new System.Drawing.Size(26, 23);
            this.txt_Pad2.TabIndex = 200;
            this.txt_Pad2.Text = "0";
            this.txt_Pad2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Pad2_KeyPress);
            // 
            // skinLabel13
            // 
            this.skinLabel13.AutoSize = true;
            this.skinLabel13.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel13.BorderColor = System.Drawing.Color.White;
            this.skinLabel13.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinLabel13.Location = new System.Drawing.Point(2, 41);
            this.skinLabel13.Name = "skinLabel13";
            this.skinLabel13.Size = new System.Drawing.Size(35, 17);
            this.skinLabel13.TabIndex = 199;
            this.skinLabel13.Text = "补位:";
            // 
            // txt_leng2
            // 
            this.txt_leng2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txt_leng2.Location = new System.Drawing.Point(33, 13);
            this.txt_leng2.MaxLength = 10;
            this.txt_leng2.Name = "txt_leng2";
            this.txt_leng2.Size = new System.Drawing.Size(26, 23);
            this.txt_leng2.TabIndex = 191;
            this.txt_leng2.Text = "2";
            this.txt_leng2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_leng2_KeyPress);
            // 
            // skinLabel17
            // 
            this.skinLabel17.AutoSize = true;
            this.skinLabel17.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel17.BorderColor = System.Drawing.Color.White;
            this.skinLabel17.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinLabel17.Location = new System.Drawing.Point(2, 17);
            this.skinLabel17.Name = "skinLabel17";
            this.skinLabel17.Size = new System.Drawing.Size(35, 17);
            this.skinLabel17.TabIndex = 190;
            this.skinLabel17.Text = "长度:";
            // 
            // cbo_Hex2
            // 
            this.cbo_Hex2.AutoSize = true;
            this.cbo_Hex2.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Hex2.ControlState = CCWin.SkinClass.ControlState.Focused;
            this.cbo_Hex2.DownBack = null;
            this.cbo_Hex2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_Hex2.Location = new System.Drawing.Point(59, 14);
            this.cbo_Hex2.MouseBack = null;
            this.cbo_Hex2.Name = "cbo_Hex2";
            this.cbo_Hex2.NormlBack = null;
            this.cbo_Hex2.SelectedDownBack = null;
            this.cbo_Hex2.SelectedMouseBack = null;
            this.cbo_Hex2.SelectedNormlBack = null;
            this.cbo_Hex2.Size = new System.Drawing.Size(51, 21);
            this.cbo_Hex2.TabIndex = 197;
            this.cbo_Hex2.Text = "HEX";
            this.cbo_Hex2.UseVisualStyleBackColor = false;
            // 
            // skinGroupBox7
            // 
            this.skinGroupBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.skinGroupBox7.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox7.Controls.Add(this.cbo_Res3);
            this.skinGroupBox7.Controls.Add(this.txt_Pad3);
            this.skinGroupBox7.Controls.Add(this.skinLabel19);
            this.skinGroupBox7.Controls.Add(this.txt_leng3);
            this.skinGroupBox7.Controls.Add(this.skinLabel20);
            this.skinGroupBox7.Controls.Add(this.cbo_Hex3);
            this.skinGroupBox7.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox7.Location = new System.Drawing.Point(333, 49);
            this.skinGroupBox7.Name = "skinGroupBox7";
            this.skinGroupBox7.RectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.skinGroupBox7.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox7.Size = new System.Drawing.Size(109, 65);
            this.skinGroupBox7.TabIndex = 203;
            this.skinGroupBox7.TabStop = false;
            this.skinGroupBox7.Text = "数据3";
            this.skinGroupBox7.TitleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.skinGroupBox7.TitleRectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.skinGroupBox7.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // cbo_Res3
            // 
            this.cbo_Res3.AutoSize = true;
            this.cbo_Res3.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Res3.ControlState = CCWin.SkinClass.ControlState.Focused;
            this.cbo_Res3.DownBack = null;
            this.cbo_Res3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_Res3.Location = new System.Drawing.Point(59, 38);
            this.cbo_Res3.MouseBack = null;
            this.cbo_Res3.Name = "cbo_Res3";
            this.cbo_Res3.NormlBack = null;
            this.cbo_Res3.SelectedDownBack = null;
            this.cbo_Res3.SelectedMouseBack = null;
            this.cbo_Res3.SelectedNormlBack = null;
            this.cbo_Res3.Size = new System.Drawing.Size(51, 21);
            this.cbo_Res3.TabIndex = 201;
            this.cbo_Res3.Text = "反转";
            this.cbo_Res3.UseVisualStyleBackColor = false;
            // 
            // txt_Pad3
            // 
            this.txt_Pad3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txt_Pad3.Location = new System.Drawing.Point(33, 37);
            this.txt_Pad3.MaxLength = 10;
            this.txt_Pad3.Name = "txt_Pad3";
            this.txt_Pad3.Size = new System.Drawing.Size(26, 23);
            this.txt_Pad3.TabIndex = 200;
            this.txt_Pad3.Text = "0";
            this.txt_Pad3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Pad3_KeyPress);
            // 
            // skinLabel19
            // 
            this.skinLabel19.AutoSize = true;
            this.skinLabel19.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel19.BorderColor = System.Drawing.Color.White;
            this.skinLabel19.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinLabel19.Location = new System.Drawing.Point(2, 41);
            this.skinLabel19.Name = "skinLabel19";
            this.skinLabel19.Size = new System.Drawing.Size(35, 17);
            this.skinLabel19.TabIndex = 199;
            this.skinLabel19.Text = "补位:";
            // 
            // txt_leng3
            // 
            this.txt_leng3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txt_leng3.Location = new System.Drawing.Point(33, 13);
            this.txt_leng3.MaxLength = 10;
            this.txt_leng3.Name = "txt_leng3";
            this.txt_leng3.Size = new System.Drawing.Size(26, 23);
            this.txt_leng3.TabIndex = 191;
            this.txt_leng3.Text = "2";
            this.txt_leng3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_leng3_KeyPress);
            // 
            // skinLabel20
            // 
            this.skinLabel20.AutoSize = true;
            this.skinLabel20.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel20.BorderColor = System.Drawing.Color.White;
            this.skinLabel20.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinLabel20.Location = new System.Drawing.Point(2, 17);
            this.skinLabel20.Name = "skinLabel20";
            this.skinLabel20.Size = new System.Drawing.Size(35, 17);
            this.skinLabel20.TabIndex = 190;
            this.skinLabel20.Text = "长度:";
            // 
            // cbo_Hex3
            // 
            this.cbo_Hex3.AutoSize = true;
            this.cbo_Hex3.BackColor = System.Drawing.Color.Transparent;
            this.cbo_Hex3.ControlState = CCWin.SkinClass.ControlState.Focused;
            this.cbo_Hex3.DownBack = null;
            this.cbo_Hex3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_Hex3.Location = new System.Drawing.Point(59, 14);
            this.cbo_Hex3.MouseBack = null;
            this.cbo_Hex3.Name = "cbo_Hex3";
            this.cbo_Hex3.NormlBack = null;
            this.cbo_Hex3.SelectedDownBack = null;
            this.cbo_Hex3.SelectedMouseBack = null;
            this.cbo_Hex3.SelectedNormlBack = null;
            this.cbo_Hex3.Size = new System.Drawing.Size(51, 21);
            this.cbo_Hex3.TabIndex = 197;
            this.cbo_Hex3.Text = "HEX";
            this.cbo_Hex3.UseVisualStyleBackColor = false;
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox1.Controls.Add(this.txt_Data3);
            this.skinGroupBox1.Controls.Add(this.txt_Data2);
            this.skinGroupBox1.Controls.Add(this.txt_Data1);
            this.skinGroupBox1.Controls.Add(this.skinGroupBox7);
            this.skinGroupBox1.Controls.Add(this.txt_gdData);
            this.skinGroupBox1.Controls.Add(this.skinGroupBox6);
            this.skinGroupBox1.Controls.Add(this.skinGroupBox4);
            this.skinGroupBox1.Controls.Add(this.skinLabel15);
            this.skinGroupBox1.Controls.Add(this.skinLabel14);
            this.skinGroupBox1.Controls.Add(this.skinLabel7);
            this.skinGroupBox1.Controls.Add(this.skinTextBox2);
            this.skinGroupBox1.Controls.Add(this.btn_Ccombination);
            this.skinGroupBox1.Controls.Add(this.skinLabel6);
            this.skinGroupBox1.Font = new System.Drawing.Font("宋体", 9F);
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox1.Location = new System.Drawing.Point(557, 146);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(446, 121);
            this.skinGroupBox1.TabIndex = 100;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "组帧说明 前导码+68+表类型+厂商代码+固定字节+数据1+数据2+数据3+校验和+16";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // txt_Data3
            // 
            this.txt_Data3.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Data3.Location = new System.Drawing.Point(376, 23);
            this.txt_Data3.MaxLength = 200;
            this.txt_Data3.Name = "txt_Data3";
            this.txt_Data3.Size = new System.Drawing.Size(62, 25);
            this.txt_Data3.TabIndex = 198;
            // 
            // txt_Data2
            // 
            this.txt_Data2.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Data2.Location = new System.Drawing.Point(278, 23);
            this.txt_Data2.MaxLength = 200;
            this.txt_Data2.Name = "txt_Data2";
            this.txt_Data2.Size = new System.Drawing.Size(62, 25);
            this.txt_Data2.TabIndex = 197;
            // 
            // txt_Data1
            // 
            this.txt_Data1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Data1.Location = new System.Drawing.Point(180, 23);
            this.txt_Data1.MaxLength = 200;
            this.txt_Data1.Name = "txt_Data1";
            this.txt_Data1.Size = new System.Drawing.Size(62, 25);
            this.txt_Data1.TabIndex = 196;
            // 
            // txt_gdData
            // 
            this.txt_gdData.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_gdData.Location = new System.Drawing.Point(62, 23);
            this.txt_gdData.MaxLength = 200;
            this.txt_gdData.Name = "txt_gdData";
            this.txt_gdData.Size = new System.Drawing.Size(82, 25);
            this.txt_gdData.TabIndex = 195;
            // 
            // skinGroupBox9
            // 
            this.skinGroupBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.skinGroupBox9.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox9.Controls.Add(this.btn_ex);
            this.skinGroupBox9.Controls.Add(this.btn_SendClear);
            this.skinGroupBox9.Controls.Add(this.txt_SubLength);
            this.skinGroupBox9.Controls.Add(this.skinLabel23);
            this.skinGroupBox9.Controls.Add(this.txt_Focus);
            this.skinGroupBox9.Controls.Add(this.skinLabel5);
            this.skinGroupBox9.Controls.Add(this.cbo_timeSend);
            this.skinGroupBox9.Controls.Add(this.txt_Send);
            this.skinGroupBox9.Controls.Add(this.skinGroupBox2);
            this.skinGroupBox9.Controls.Add(this.btn_Send);
            this.skinGroupBox9.Controls.Add(this.btn_SpiltSendStr);
            this.skinGroupBox9.Controls.Add(this.btn_addVerify);
            this.skinGroupBox9.Controls.Add(this.chkSendHex);
            this.skinGroupBox9.Controls.Add(this.skinLabel4);
            this.skinGroupBox9.Controls.Add(this.lbl_DataCount);
            this.skinGroupBox9.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox9.Location = new System.Drawing.Point(7, 146);
            this.skinGroupBox9.Name = "skinGroupBox9";
            this.skinGroupBox9.RectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.skinGroupBox9.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox9.Size = new System.Drawing.Size(549, 121);
            this.skinGroupBox9.TabIndex = 174;
            this.skinGroupBox9.TabStop = false;
            this.skinGroupBox9.Text = "发送区";
            this.skinGroupBox9.TitleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.skinGroupBox9.TitleRectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.skinGroupBox9.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // btn_SendClear
            // 
            this.btn_SendClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btn_SendClear.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_SendClear.DownBack = null;
            this.btn_SendClear.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SendClear.Location = new System.Drawing.Point(228, 14);
            this.btn_SendClear.MouseBack = null;
            this.btn_SendClear.Name = "btn_SendClear";
            this.btn_SendClear.NormlBack = null;
            this.btn_SendClear.Size = new System.Drawing.Size(57, 21);
            this.btn_SendClear.TabIndex = 195;
            this.btn_SendClear.Text = "清空";
            this.btn_SendClear.UseVisualStyleBackColor = false;
            this.btn_SendClear.Click += new System.EventHandler(this.btn_SendClear_Click);
            // 
            // txt_SubLength
            // 
            this.txt_SubLength.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_SubLength.Location = new System.Drawing.Point(417, 88);
            this.txt_SubLength.MaxLength = 10;
            this.txt_SubLength.Name = "txt_SubLength";
            this.txt_SubLength.Size = new System.Drawing.Size(40, 25);
            this.txt_SubLength.TabIndex = 193;
            this.txt_SubLength.Text = "0";
            this.txt_SubLength.TextChanged += new System.EventHandler(this.txt_SubLength_TextChanged);
            this.txt_SubLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SubLength_KeyPress);
            // 
            // skinLabel23
            // 
            this.skinLabel23.AutoSize = true;
            this.skinLabel23.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel23.BorderColor = System.Drawing.Color.White;
            this.skinLabel23.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel23.Location = new System.Drawing.Point(361, 93);
            this.skinLabel23.Name = "skinLabel23";
            this.skinLabel23.Size = new System.Drawing.Size(59, 17);
            this.skinLabel23.TabIndex = 194;
            this.skinLabel23.Text = "截取长度:";
            // 
            // txt_Focus
            // 
            this.txt_Focus.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Focus.Location = new System.Drawing.Point(319, 88);
            this.txt_Focus.MaxLength = 10;
            this.txt_Focus.Name = "txt_Focus";
            this.txt_Focus.Size = new System.Drawing.Size(42, 25);
            this.txt_Focus.TabIndex = 174;
            this.txt_Focus.Text = "0";
            this.txt_Focus.TextChanged += new System.EventHandler(this.txt_Focus_TextChanged);
            this.txt_Focus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Focus_KeyPress);
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(287, 93);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(35, 17);
            this.skinLabel5.TabIndex = 192;
            this.skinLabel5.Text = "焦点:";
            // 
            // txt_Send
            // 
            this.txt_Send.AutoWordSelection = true;
            this.txt_Send.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Send.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Send.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.txt_Send.Location = new System.Drawing.Point(7, 37);
            this.txt_Send.Name = "txt_Send";
            this.txt_Send.Size = new System.Drawing.Size(277, 76);
            this.txt_Send.TabIndex = 6;
            this.txt_Send.Text = "";
            this.txt_Send.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            this.txt_Send.Click += new System.EventHandler(this.txt_Send_Click);
            this.txt_Send.TextChanged += new System.EventHandler(this.txt_Send_TextChanged);
            this.txt_Send.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Send_KeyDown);
            // 
            // skinGroupBox10
            // 
            this.skinGroupBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.skinGroupBox10.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox10.Controls.Add(this.panel3);
            this.skinGroupBox10.Controls.Add(this.panel2);
            this.skinGroupBox10.Controls.Add(this.panel1);
            this.skinGroupBox10.Controls.Add(this.txtReceived3);
            this.skinGroupBox10.Controls.Add(this.txtReceived2);
            this.skinGroupBox10.Controls.Add(this.txtReceived);
            this.skinGroupBox10.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox10.Location = new System.Drawing.Point(7, 268);
            this.skinGroupBox10.Name = "skinGroupBox10";
            this.skinGroupBox10.RectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.skinGroupBox10.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox10.Size = new System.Drawing.Size(996, 396);
            this.skinGroupBox10.TabIndex = 50;
            this.skinGroupBox10.TabStop = false;
            this.skinGroupBox10.Text = "接收区";
            this.skinGroupBox10.TitleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.skinGroupBox10.TitleRectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.skinGroupBox10.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkHidden3);
            this.panel3.Controls.Add(this.skinLabel52);
            this.panel3.Controls.Add(this.chkRecvHex3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(663, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 27);
            this.panel3.TabIndex = 186;
            // 
            // chkHidden3
            // 
            this.chkHidden3.AutoSize = true;
            this.chkHidden3.BackColor = System.Drawing.Color.Transparent;
            this.chkHidden3.Checked = true;
            this.chkHidden3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHidden3.ControlState = CCWin.SkinClass.ControlState.Focused;
            this.chkHidden3.DownBack = null;
            this.chkHidden3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkHidden3.Location = new System.Drawing.Point(102, 3);
            this.chkHidden3.MouseBack = null;
            this.chkHidden3.Name = "chkHidden3";
            this.chkHidden3.NormlBack = null;
            this.chkHidden3.SelectedDownBack = null;
            this.chkHidden3.SelectedMouseBack = null;
            this.chkHidden3.SelectedNormlBack = null;
            this.chkHidden3.Size = new System.Drawing.Size(75, 21);
            this.chkHidden3.TabIndex = 193;
            this.chkHidden3.Text = "显示发送";
            this.chkHidden3.UseVisualStyleBackColor = false;
            // 
            // skinLabel52
            // 
            this.skinLabel52.AutoSize = true;
            this.skinLabel52.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel52.BorderColor = System.Drawing.Color.White;
            this.skinLabel52.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel52.Location = new System.Drawing.Point(175, 637);
            this.skinLabel52.Name = "skinLabel52";
            this.skinLabel52.Size = new System.Drawing.Size(32, 17);
            this.skinLabel52.TabIndex = 174;
            this.skinLabel52.Text = "测试";
            // 
            // chkRecvHex3
            // 
            this.chkRecvHex3.AutoSize = true;
            this.chkRecvHex3.BackColor = System.Drawing.Color.Transparent;
            this.chkRecvHex3.Checked = true;
            this.chkRecvHex3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRecvHex3.ControlState = CCWin.SkinClass.ControlState.Focused;
            this.chkRecvHex3.DownBack = null;
            this.chkRecvHex3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkRecvHex3.Location = new System.Drawing.Point(51, 3);
            this.chkRecvHex3.MouseBack = null;
            this.chkRecvHex3.Name = "chkRecvHex3";
            this.chkRecvHex3.NormlBack = null;
            this.chkRecvHex3.SelectedDownBack = null;
            this.chkRecvHex3.SelectedMouseBack = null;
            this.chkRecvHex3.SelectedNormlBack = null;
            this.chkRecvHex3.Size = new System.Drawing.Size(51, 21);
            this.chkRecvHex3.TabIndex = 103;
            this.chkRecvHex3.Text = "HEX";
            this.chkRecvHex3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 48;
            this.label2.Text = "串口三:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkHidden2);
            this.panel2.Controls.Add(this.skinLabel24);
            this.panel2.Controls.Add(this.chkRecvHex2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(334, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 27);
            this.panel2.TabIndex = 185;
            // 
            // chkHidden2
            // 
            this.chkHidden2.AutoSize = true;
            this.chkHidden2.BackColor = System.Drawing.Color.Transparent;
            this.chkHidden2.Checked = true;
            this.chkHidden2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHidden2.ControlState = CCWin.SkinClass.ControlState.Focused;
            this.chkHidden2.DownBack = null;
            this.chkHidden2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkHidden2.Location = new System.Drawing.Point(102, 3);
            this.chkHidden2.MouseBack = null;
            this.chkHidden2.Name = "chkHidden2";
            this.chkHidden2.NormlBack = null;
            this.chkHidden2.SelectedDownBack = null;
            this.chkHidden2.SelectedMouseBack = null;
            this.chkHidden2.SelectedNormlBack = null;
            this.chkHidden2.Size = new System.Drawing.Size(75, 21);
            this.chkHidden2.TabIndex = 176;
            this.chkHidden2.Text = "显示发送";
            this.chkHidden2.UseVisualStyleBackColor = false;
            // 
            // skinLabel24
            // 
            this.skinLabel24.AutoSize = true;
            this.skinLabel24.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel24.BorderColor = System.Drawing.Color.White;
            this.skinLabel24.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel24.Location = new System.Drawing.Point(175, 637);
            this.skinLabel24.Name = "skinLabel24";
            this.skinLabel24.Size = new System.Drawing.Size(32, 17);
            this.skinLabel24.TabIndex = 174;
            this.skinLabel24.Text = "测试";
            // 
            // chkRecvHex2
            // 
            this.chkRecvHex2.AutoSize = true;
            this.chkRecvHex2.BackColor = System.Drawing.Color.Transparent;
            this.chkRecvHex2.Checked = true;
            this.chkRecvHex2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRecvHex2.ControlState = CCWin.SkinClass.ControlState.Focused;
            this.chkRecvHex2.DownBack = null;
            this.chkRecvHex2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkRecvHex2.Location = new System.Drawing.Point(51, 3);
            this.chkRecvHex2.MouseBack = null;
            this.chkRecvHex2.Name = "chkRecvHex2";
            this.chkRecvHex2.NormlBack = null;
            this.chkRecvHex2.SelectedDownBack = null;
            this.chkRecvHex2.SelectedMouseBack = null;
            this.chkRecvHex2.SelectedNormlBack = null;
            this.chkRecvHex2.Size = new System.Drawing.Size(51, 21);
            this.chkRecvHex2.TabIndex = 103;
            this.chkRecvHex2.Text = "HEX";
            this.chkRecvHex2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 48;
            this.label1.Text = "串口二:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkHidden);
            this.panel1.Controls.Add(this.skinLabel53);
            this.panel1.Controls.Add(this.chkRecvHex);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(5, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 27);
            this.panel1.TabIndex = 175;
            // 
            // chkHidden
            // 
            this.chkHidden.AutoSize = true;
            this.chkHidden.BackColor = System.Drawing.Color.Transparent;
            this.chkHidden.Checked = true;
            this.chkHidden.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHidden.ControlState = CCWin.SkinClass.ControlState.Focused;
            this.chkHidden.DownBack = null;
            this.chkHidden.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkHidden.Location = new System.Drawing.Point(104, 3);
            this.chkHidden.MouseBack = null;
            this.chkHidden.Name = "chkHidden";
            this.chkHidden.NormlBack = null;
            this.chkHidden.SelectedDownBack = null;
            this.chkHidden.SelectedMouseBack = null;
            this.chkHidden.SelectedNormlBack = null;
            this.chkHidden.Size = new System.Drawing.Size(75, 21);
            this.chkHidden.TabIndex = 175;
            this.chkHidden.Text = "显示发送";
            this.chkHidden.UseVisualStyleBackColor = false;
            // 
            // skinLabel53
            // 
            this.skinLabel53.AutoSize = true;
            this.skinLabel53.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel53.BorderColor = System.Drawing.Color.White;
            this.skinLabel53.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel53.Location = new System.Drawing.Point(175, 637);
            this.skinLabel53.Name = "skinLabel53";
            this.skinLabel53.Size = new System.Drawing.Size(32, 17);
            this.skinLabel53.TabIndex = 174;
            this.skinLabel53.Text = "测试";
            // 
            // txtReceived3
            // 
            this.txtReceived3.BackColor = System.Drawing.SystemColors.Window;
            this.txtReceived3.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtReceived3.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.txtReceived3.Location = new System.Drawing.Point(663, 42);
            this.txtReceived3.Name = "txtReceived3";
            this.txtReceived3.Size = new System.Drawing.Size(330, 352);
            this.txtReceived3.TabIndex = 192;
            this.txtReceived3.Text = "";
            this.txtReceived3.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            this.txtReceived3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReceived3_KeyDown);
            this.txtReceived3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtReceived3_MouseDoubleClick);
            // 
            // txtReceived2
            // 
            this.txtReceived2.BackColor = System.Drawing.SystemColors.Window;
            this.txtReceived2.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtReceived2.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.txtReceived2.Location = new System.Drawing.Point(333, 42);
            this.txtReceived2.Name = "txtReceived2";
            this.txtReceived2.Size = new System.Drawing.Size(330, 352);
            this.txtReceived2.TabIndex = 191;
            this.txtReceived2.Text = "";
            this.txtReceived2.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            this.txtReceived2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReceived2_KeyDown);
            this.txtReceived2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtReceived2_MouseDoubleClick);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btn_Clear.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Clear.DownBack = null;
            this.btn_Clear.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Clear.Location = new System.Drawing.Point(201, 665);
            this.btn_Clear.MouseBack = null;
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.NormlBack = null;
            this.btn_Clear.Size = new System.Drawing.Size(82, 28);
            this.btn_Clear.TabIndex = 101;
            this.btn_Clear.Text = "清空";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click_1);
            // 
            // btn_extension
            // 
            this.btn_extension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btn_extension.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_extension.DownBack = null;
            this.btn_extension.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_extension.Location = new System.Drawing.Point(752, 665);
            this.btn_extension.MouseBack = null;
            this.btn_extension.Name = "btn_extension";
            this.btn_extension.NormlBack = null;
            this.btn_extension.Size = new System.Drawing.Size(82, 28);
            this.btn_extension.TabIndex = 207;
            this.btn_extension.Text = "扩展";
            this.btn_extension.UseVisualStyleBackColor = false;
            this.btn_extension.Click += new System.EventHandler(this.btn_extension_Click);
            // 
            // skinGroupBox8
            // 
            this.skinGroupBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.skinGroupBox8.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox8.Controls.Add(this.skinLabel56);
            this.skinGroupBox8.Controls.Add(this.lbl_SendNum3);
            this.skinGroupBox8.Controls.Add(this.skinLabel58);
            this.skinGroupBox8.Controls.Add(this.lbl_RevNum3);
            this.skinGroupBox8.Controls.Add(this.skinLabel25);
            this.skinGroupBox8.Controls.Add(this.lbl_SendNum2);
            this.skinGroupBox8.Controls.Add(this.skinLabel51);
            this.skinGroupBox8.Controls.Add(this.lbl_RevNum2);
            this.skinGroupBox8.Controls.Add(this.rdo_comPort3);
            this.skinGroupBox8.Controls.Add(this.rdo_comPort2);
            this.skinGroupBox8.Controls.Add(this.rdo_comPort1);
            this.skinGroupBox8.Controls.Add(this.skinLabel49);
            this.skinGroupBox8.Controls.Add(this.lbl_SendNum);
            this.skinGroupBox8.Controls.Add(this.skinLabel54);
            this.skinGroupBox8.Controls.Add(this.lbl_RevNum);
            this.skinGroupBox8.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox8.Location = new System.Drawing.Point(655, 36);
            this.skinGroupBox8.Name = "skinGroupBox8";
            this.skinGroupBox8.RectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.skinGroupBox8.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox8.Size = new System.Drawing.Size(184, 100);
            this.skinGroupBox8.TabIndex = 196;
            this.skinGroupBox8.TabStop = false;
            this.skinGroupBox8.Text = "选择发送串口";
            this.skinGroupBox8.TitleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.skinGroupBox8.TitleRectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.skinGroupBox8.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skinLabel56
            // 
            this.skinLabel56.AutoSize = true;
            this.skinLabel56.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel56.BorderColor = System.Drawing.Color.White;
            this.skinLabel56.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel56.Location = new System.Drawing.Point(126, 50);
            this.skinLabel56.Name = "skinLabel56";
            this.skinLabel56.Size = new System.Drawing.Size(35, 17);
            this.skinLabel56.TabIndex = 189;
            this.skinLabel56.Text = "发送:";
            // 
            // lbl_SendNum3
            // 
            this.lbl_SendNum3.AutoSize = true;
            this.lbl_SendNum3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SendNum3.BorderColor = System.Drawing.Color.White;
            this.lbl_SendNum3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SendNum3.Location = new System.Drawing.Point(162, 50);
            this.lbl_SendNum3.Name = "lbl_SendNum3";
            this.lbl_SendNum3.Size = new System.Drawing.Size(15, 17);
            this.lbl_SendNum3.TabIndex = 190;
            this.lbl_SendNum3.Text = "0";
            this.lbl_SendNum3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbl_SendNum3_MouseDoubleClick);
            // 
            // skinLabel58
            // 
            this.skinLabel58.AutoSize = true;
            this.skinLabel58.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel58.BorderColor = System.Drawing.Color.White;
            this.skinLabel58.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel58.Location = new System.Drawing.Point(126, 72);
            this.skinLabel58.Name = "skinLabel58";
            this.skinLabel58.Size = new System.Drawing.Size(35, 17);
            this.skinLabel58.TabIndex = 191;
            this.skinLabel58.Text = "接收:";
            // 
            // lbl_RevNum3
            // 
            this.lbl_RevNum3.AutoSize = true;
            this.lbl_RevNum3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RevNum3.BorderColor = System.Drawing.Color.White;
            this.lbl_RevNum3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_RevNum3.Location = new System.Drawing.Point(162, 72);
            this.lbl_RevNum3.Name = "lbl_RevNum3";
            this.lbl_RevNum3.Size = new System.Drawing.Size(15, 17);
            this.lbl_RevNum3.TabIndex = 192;
            this.lbl_RevNum3.Text = "0";
            this.lbl_RevNum3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbl_RevNum3_MouseDoubleClick);
            // 
            // skinLabel25
            // 
            this.skinLabel25.AutoSize = true;
            this.skinLabel25.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel25.BorderColor = System.Drawing.Color.White;
            this.skinLabel25.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel25.Location = new System.Drawing.Point(64, 50);
            this.skinLabel25.Name = "skinLabel25";
            this.skinLabel25.Size = new System.Drawing.Size(35, 17);
            this.skinLabel25.TabIndex = 185;
            this.skinLabel25.Text = "发送:";
            // 
            // lbl_SendNum2
            // 
            this.lbl_SendNum2.AutoSize = true;
            this.lbl_SendNum2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SendNum2.BorderColor = System.Drawing.Color.White;
            this.lbl_SendNum2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SendNum2.Location = new System.Drawing.Point(100, 50);
            this.lbl_SendNum2.Name = "lbl_SendNum2";
            this.lbl_SendNum2.Size = new System.Drawing.Size(15, 17);
            this.lbl_SendNum2.TabIndex = 186;
            this.lbl_SendNum2.Text = "0";
            this.lbl_SendNum2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbl_SendNum2_MouseDoubleClick);
            // 
            // skinLabel51
            // 
            this.skinLabel51.AutoSize = true;
            this.skinLabel51.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel51.BorderColor = System.Drawing.Color.White;
            this.skinLabel51.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel51.Location = new System.Drawing.Point(64, 72);
            this.skinLabel51.Name = "skinLabel51";
            this.skinLabel51.Size = new System.Drawing.Size(35, 17);
            this.skinLabel51.TabIndex = 187;
            this.skinLabel51.Text = "接收:";
            // 
            // lbl_RevNum2
            // 
            this.lbl_RevNum2.AutoSize = true;
            this.lbl_RevNum2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RevNum2.BorderColor = System.Drawing.Color.White;
            this.lbl_RevNum2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_RevNum2.Location = new System.Drawing.Point(100, 72);
            this.lbl_RevNum2.Name = "lbl_RevNum2";
            this.lbl_RevNum2.Size = new System.Drawing.Size(15, 17);
            this.lbl_RevNum2.TabIndex = 188;
            this.lbl_RevNum2.Text = "0";
            this.lbl_RevNum2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbl_RevNum2_MouseDoubleClick);
            // 
            // rdo_comPort3
            // 
            this.rdo_comPort3.AutoSize = true;
            this.rdo_comPort3.BackColor = System.Drawing.Color.Transparent;
            this.rdo_comPort3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.rdo_comPort3.DownBack = null;
            this.rdo_comPort3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_comPort3.Location = new System.Drawing.Point(117, 21);
            this.rdo_comPort3.MouseBack = null;
            this.rdo_comPort3.Name = "rdo_comPort3";
            this.rdo_comPort3.NormlBack = null;
            this.rdo_comPort3.SelectedDownBack = null;
            this.rdo_comPort3.SelectedMouseBack = null;
            this.rdo_comPort3.SelectedNormlBack = null;
            this.rdo_comPort3.Size = new System.Drawing.Size(62, 21);
            this.rdo_comPort3.TabIndex = 2;
            this.rdo_comPort3.Text = "串口三";
            this.rdo_comPort3.UseVisualStyleBackColor = false;
            // 
            // rdo_comPort2
            // 
            this.rdo_comPort2.AutoSize = true;
            this.rdo_comPort2.BackColor = System.Drawing.Color.Transparent;
            this.rdo_comPort2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.rdo_comPort2.DownBack = null;
            this.rdo_comPort2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_comPort2.Location = new System.Drawing.Point(59, 21);
            this.rdo_comPort2.MouseBack = null;
            this.rdo_comPort2.Name = "rdo_comPort2";
            this.rdo_comPort2.NormlBack = null;
            this.rdo_comPort2.SelectedDownBack = null;
            this.rdo_comPort2.SelectedMouseBack = null;
            this.rdo_comPort2.SelectedNormlBack = null;
            this.rdo_comPort2.Size = new System.Drawing.Size(62, 21);
            this.rdo_comPort2.TabIndex = 1;
            this.rdo_comPort2.Text = "串口二";
            this.rdo_comPort2.UseVisualStyleBackColor = false;
            // 
            // rdo_comPort1
            // 
            this.rdo_comPort1.AutoSize = true;
            this.rdo_comPort1.BackColor = System.Drawing.Color.Transparent;
            this.rdo_comPort1.Checked = true;
            this.rdo_comPort1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.rdo_comPort1.DownBack = null;
            this.rdo_comPort1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_comPort1.Location = new System.Drawing.Point(1, 21);
            this.rdo_comPort1.MouseBack = null;
            this.rdo_comPort1.Name = "rdo_comPort1";
            this.rdo_comPort1.NormlBack = null;
            this.rdo_comPort1.SelectedDownBack = null;
            this.rdo_comPort1.SelectedMouseBack = null;
            this.rdo_comPort1.SelectedNormlBack = null;
            this.rdo_comPort1.Size = new System.Drawing.Size(62, 21);
            this.rdo_comPort1.TabIndex = 0;
            this.rdo_comPort1.TabStop = true;
            this.rdo_comPort1.Text = "串口一";
            this.rdo_comPort1.UseVisualStyleBackColor = false;
            // 
            // btn_RecAddHeight
            // 
            this.btn_RecAddHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btn_RecAddHeight.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_RecAddHeight.DownBack = null;
            this.btn_RecAddHeight.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_RecAddHeight.Location = new System.Drawing.Point(286, 665);
            this.btn_RecAddHeight.MouseBack = null;
            this.btn_RecAddHeight.Name = "btn_RecAddHeight";
            this.btn_RecAddHeight.NormlBack = null;
            this.btn_RecAddHeight.Size = new System.Drawing.Size(82, 28);
            this.btn_RecAddHeight.TabIndex = 209;
            this.btn_RecAddHeight.Text = "展开";
            this.btn_RecAddHeight.UseVisualStyleBackColor = false;
            this.btn_RecAddHeight.Click += new System.EventHandler(this.btn_RecAddHeight_Click);
            // 
            // comport2
            // 
            this.comport2.DataBits = 7;
            this.comport2.Parity = System.IO.Ports.Parity.Even;
            this.comport2.StopBits = System.IO.Ports.StopBits.Two;
            this.comport2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // comport3
            // 
            this.comport3.DataBits = 7;
            this.comport3.Parity = System.IO.Ports.Parity.Even;
            this.comport3.StopBits = System.IO.Ports.StopBits.Two;
            this.comport3.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort3_DataReceived);
            // 
            // timerReceived2
            // 
            this.timerReceived2.Interval = 1000;
            this.timerReceived2.Tick += new System.EventHandler(this.timerReceived2_Tick);
            // 
            // timerReceived3
            // 
            this.timerReceived3.Interval = 1000;
            this.timerReceived3.Tick += new System.EventHandler(this.timerReceived3_Tick);
            // 
            // cbo_com1
            // 
            this.cbo_com1.AutoSize = true;
            this.cbo_com1.BackColor = System.Drawing.Color.Transparent;
            this.cbo_com1.Checked = true;
            this.cbo_com1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbo_com1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cbo_com1.DownBack = null;
            this.cbo_com1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_com1.Location = new System.Drawing.Point(7, 669);
            this.cbo_com1.MouseBack = null;
            this.cbo_com1.Name = "cbo_com1";
            this.cbo_com1.NormlBack = null;
            this.cbo_com1.SelectedDownBack = null;
            this.cbo_com1.SelectedMouseBack = null;
            this.cbo_com1.SelectedNormlBack = null;
            this.cbo_com1.Size = new System.Drawing.Size(63, 21);
            this.cbo_com1.TabIndex = 210;
            this.cbo_com1.Text = "串口一";
            this.cbo_com1.UseVisualStyleBackColor = false;
            // 
            // cbo_com2
            // 
            this.cbo_com2.AutoSize = true;
            this.cbo_com2.BackColor = System.Drawing.Color.Transparent;
            this.cbo_com2.Checked = true;
            this.cbo_com2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbo_com2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cbo_com2.DownBack = null;
            this.cbo_com2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_com2.Location = new System.Drawing.Point(70, 669);
            this.cbo_com2.MouseBack = null;
            this.cbo_com2.Name = "cbo_com2";
            this.cbo_com2.NormlBack = null;
            this.cbo_com2.SelectedDownBack = null;
            this.cbo_com2.SelectedMouseBack = null;
            this.cbo_com2.SelectedNormlBack = null;
            this.cbo_com2.Size = new System.Drawing.Size(63, 21);
            this.cbo_com2.TabIndex = 211;
            this.cbo_com2.Text = "串口二";
            this.cbo_com2.UseVisualStyleBackColor = false;
            // 
            // cbo_com3
            // 
            this.cbo_com3.AutoSize = true;
            this.cbo_com3.BackColor = System.Drawing.Color.Transparent;
            this.cbo_com3.Checked = true;
            this.cbo_com3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbo_com3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cbo_com3.DownBack = null;
            this.cbo_com3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_com3.Location = new System.Drawing.Point(133, 669);
            this.cbo_com3.MouseBack = null;
            this.cbo_com3.Name = "cbo_com3";
            this.cbo_com3.NormlBack = null;
            this.cbo_com3.SelectedDownBack = null;
            this.cbo_com3.SelectedMouseBack = null;
            this.cbo_com3.SelectedNormlBack = null;
            this.cbo_com3.Size = new System.Drawing.Size(63, 21);
            this.cbo_com3.TabIndex = 212;
            this.cbo_com3.Text = "串口三";
            this.cbo_com3.UseVisualStyleBackColor = false;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(26, 63);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(59, 17);
            this.skinLabel2.TabIndex = 121;
            this.skinLabel2.Text = "表头时间:";
            // 
            // cbo_sync
            // 
            this.cbo_sync.AutoSize = true;
            this.cbo_sync.BackColor = System.Drawing.Color.Transparent;
            this.cbo_sync.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cbo_sync.DownBack = null;
            this.cbo_sync.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_sync.Location = new System.Drawing.Point(298, 59);
            this.cbo_sync.MouseBack = null;
            this.cbo_sync.Name = "cbo_sync";
            this.cbo_sync.NormlBack = null;
            this.cbo_sync.SelectedDownBack = null;
            this.cbo_sync.SelectedMouseBack = null;
            this.cbo_sync.SelectedNormlBack = null;
            this.cbo_sync.Size = new System.Drawing.Size(75, 21);
            this.cbo_sync.TabIndex = 23;
            this.cbo_sync.Text = "网络校时";
            this.cbo_sync.UseVisualStyleBackColor = false;
            this.cbo_sync.CheckedChanged += new System.EventHandler(this.cbo_sync_CheckedChanged);
            // 
            // skinLabel43
            // 
            this.skinLabel43.AutoSize = true;
            this.skinLabel43.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel43.BorderColor = System.Drawing.Color.White;
            this.skinLabel43.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel43.Location = new System.Drawing.Point(26, 31);
            this.skinLabel43.Name = "skinLabel43";
            this.skinLabel43.Size = new System.Drawing.Size(71, 17);
            this.skinLabel43.TabIndex = 144;
            this.skinLabel43.Text = "旧表头地址:";
            // 
            // btn_dqData
            // 
            this.btn_dqData.BackColor = System.Drawing.Color.Transparent;
            this.btn_dqData.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_dqData.DownBack = null;
            this.btn_dqData.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_dqData.Location = new System.Drawing.Point(375, 20);
            this.btn_dqData.MouseBack = null;
            this.btn_dqData.Name = "btn_dqData";
            this.btn_dqData.NormlBack = null;
            this.btn_dqData.Size = new System.Drawing.Size(95, 28);
            this.btn_dqData.TabIndex = 19;
            this.btn_dqData.Text = "读取数据";
            this.btn_dqData.UseVisualStyleBackColor = false;
            this.btn_dqData.Click += new System.EventHandler(this.btn_dqData_Click);
            // 
            // btn_szTime
            // 
            this.btn_szTime.BackColor = System.Drawing.Color.Transparent;
            this.btn_szTime.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_szTime.DownBack = null;
            this.btn_szTime.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_szTime.Location = new System.Drawing.Point(476, 52);
            this.btn_szTime.MouseBack = null;
            this.btn_szTime.Name = "btn_szTime";
            this.btn_szTime.NormlBack = null;
            this.btn_szTime.Size = new System.Drawing.Size(95, 28);
            this.btn_szTime.TabIndex = 25;
            this.btn_szTime.Text = "设置时间";
            this.btn_szTime.UseVisualStyleBackColor = false;
            this.btn_szTime.Click += new System.EventHandler(this.btn_szTime_Click);
            // 
            // btn_dqTime
            // 
            this.btn_dqTime.BackColor = System.Drawing.Color.Transparent;
            this.btn_dqTime.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_dqTime.DownBack = null;
            this.btn_dqTime.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_dqTime.Location = new System.Drawing.Point(375, 52);
            this.btn_dqTime.MouseBack = null;
            this.btn_dqTime.Name = "btn_dqTime";
            this.btn_dqTime.NormlBack = null;
            this.btn_dqTime.Size = new System.Drawing.Size(95, 28);
            this.btn_dqTime.TabIndex = 24;
            this.btn_dqTime.Text = "读取时间";
            this.btn_dqTime.UseVisualStyleBackColor = false;
            this.btn_dqTime.Click += new System.EventHandler(this.btn_dqTime_Click);
            // 
            // btn_shData
            // 
            this.btn_shData.BackColor = System.Drawing.Color.Transparent;
            this.btn_shData.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_shData.DownBack = null;
            this.btn_shData.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_shData.Location = new System.Drawing.Point(476, 20);
            this.btn_shData.MouseBack = null;
            this.btn_shData.Name = "btn_shData";
            this.btn_shData.NormlBack = null;
            this.btn_shData.Size = new System.Drawing.Size(95, 28);
            this.btn_shData.TabIndex = 20;
            this.btn_shData.Text = "设置数据";
            this.btn_shData.UseVisualStyleBackColor = false;
            this.btn_shData.Click += new System.EventHandler(this.btn_shData_Click);
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(235, 31);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(47, 17);
            this.skinLabel3.TabIndex = 145;
            this.skinLabel3.Text = "表数据:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(86, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 21);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // btn_asyn
            // 
            this.btn_asyn.BackColor = System.Drawing.Color.Transparent;
            this.btn_asyn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_asyn.DownBack = null;
            this.btn_asyn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_asyn.Location = new System.Drawing.Point(248, 59);
            this.btn_asyn.MouseBack = null;
            this.btn_asyn.Name = "btn_asyn";
            this.btn_asyn.NormlBack = null;
            this.btn_asyn.Size = new System.Drawing.Size(46, 21);
            this.btn_asyn.TabIndex = 22;
            this.btn_asyn.Text = "同步";
            this.btn_asyn.UseVisualStyleBackColor = false;
            this.btn_asyn.Click += new System.EventHandler(this.btn_asyn_Click);
            // 
            // txt_OldMeterAddr
            // 
            this.txt_OldMeterAddr.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_OldMeterAddr.Location = new System.Drawing.Point(94, 23);
            this.txt_OldMeterAddr.MaxLength = 16;
            this.txt_OldMeterAddr.Name = "txt_OldMeterAddr";
            this.txt_OldMeterAddr.Size = new System.Drawing.Size(139, 25);
            this.txt_OldMeterAddr.TabIndex = 194;
            // 
            // txt_DataNum
            // 
            this.txt_DataNum.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_DataNum.Location = new System.Drawing.Point(279, 23);
            this.txt_DataNum.MaxLength = 10;
            this.txt_DataNum.Name = "txt_DataNum";
            this.txt_DataNum.Size = new System.Drawing.Size(86, 25);
            this.txt_DataNum.TabIndex = 194;
            this.txt_DataNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DataNum_KeyPress);
            // 
            // skinGroupBox3
            // 
            this.skinGroupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.skinGroupBox3.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox3.Controls.Add(this.txt_DataNum);
            this.skinGroupBox3.Controls.Add(this.txt_OldMeterAddr);
            this.skinGroupBox3.Controls.Add(this.btn_asyn);
            this.skinGroupBox3.Controls.Add(this.dateTimePicker1);
            this.skinGroupBox3.Controls.Add(this.skinLabel3);
            this.skinGroupBox3.Controls.Add(this.btn_shData);
            this.skinGroupBox3.Controls.Add(this.cbo_gjz);
            this.skinGroupBox3.Controls.Add(this.btn_dqTime);
            this.skinGroupBox3.Controls.Add(this.btn_szTime);
            this.skinGroupBox3.Controls.Add(this.btn_dqData);
            this.skinGroupBox3.Controls.Add(this.skinLabel46);
            this.skinGroupBox3.Controls.Add(this.skinLabel43);
            this.skinGroupBox3.Controls.Add(this.txt_gjz);
            this.skinGroupBox3.Controls.Add(this.cbo_sync);
            this.skinGroupBox3.Controls.Add(this.skinLabel2);
            this.skinGroupBox3.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox3.Location = new System.Drawing.Point(490, 673);
            this.skinGroupBox3.Name = "skinGroupBox3";
            this.skinGroupBox3.RectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.skinGroupBox3.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox3.Size = new System.Drawing.Size(66, 13);
            this.skinGroupBox3.TabIndex = 2;
            this.skinGroupBox3.TabStop = false;
            this.skinGroupBox3.Text = "表头命令";
            this.skinGroupBox3.TitleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.skinGroupBox3.TitleRectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.skinGroupBox3.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox3.Visible = false;
            // 
            // btn_ex
            // 
            this.btn_ex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btn_ex.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_ex.DownBack = null;
            this.btn_ex.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ex.Location = new System.Drawing.Point(461, 39);
            this.btn_ex.MouseBack = null;
            this.btn_ex.Name = "btn_ex";
            this.btn_ex.NormlBack = null;
            this.btn_ex.Size = new System.Drawing.Size(82, 22);
            this.btn_ex.TabIndex = 213;
            this.btn_ex.Text = "格式转换";
            this.btn_ex.UseVisualStyleBackColor = false;
            this.btn_ex.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // serialport
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 11.5F);
            this.ClientSize = new System.Drawing.Size(1011, 699);
            this.Controls.Add(this.btn_F5);
            this.Controls.Add(this.gb_extension);
            this.Controls.Add(this.cbo_com3);
            this.Controls.Add(this.btn_RecAddHeight);
            this.Controls.Add(this.cbo_com2);
            this.Controls.Add(this.btn_extension);
            this.Controls.Add(this.cbo_com1);
            this.Controls.Add(this.skinLabel47);
            this.Controls.Add(this.skinLabel48);
            this.Controls.Add(this.txt_TimeOutNum);
            this.Controls.Add(this.skinGroupBox3);
            this.Controls.Add(this.skinGroupBox1);
            this.Controls.Add(this.skinGroupBox8);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.skinGroupBox10);
            this.Controls.Add(this.skinGroupBox9);
            this.Controls.Add(this.skinGroupBox5);
            this.Controls.Add(this.gbPortSettings);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_About);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MdiBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.Name = "serialport";
            this.Text = "多串口调试工具";
            this.Load += new System.EventHandler(this.serialport_Load);
            this.gb_extension.ResumeLayout(false);
            this.pl_extension.ResumeLayout(false);
            this.pl_extension.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.gbPortSettings.ResumeLayout(false);
            this.skinTabControl1.ResumeLayout(false);
            this.skinTabPage1.ResumeLayout(false);
            this.skinTabPage1.PerformLayout();
            this.skinTabPage2.ResumeLayout(false);
            this.skinTabPage2.PerformLayout();
            this.skinTabPage3.ResumeLayout(false);
            this.skinTabPage3.PerformLayout();
            this.skinGroupBox5.ResumeLayout(false);
            this.skinGroupBox5.PerformLayout();
            this.skinGroupBox2.ResumeLayout(false);
            this.skinGroupBox2.PerformLayout();
            this.skinGroupBox4.ResumeLayout(false);
            this.skinGroupBox4.PerformLayout();
            this.skinGroupBox6.ResumeLayout(false);
            this.skinGroupBox6.PerformLayout();
            this.skinGroupBox7.ResumeLayout(false);
            this.skinGroupBox7.PerformLayout();
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.skinGroupBox9.ResumeLayout(false);
            this.skinGroupBox9.PerformLayout();
            this.skinGroupBox10.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.skinGroupBox8.ResumeLayout(false);
            this.skinGroupBox8.PerformLayout();
            this.skinGroupBox3.ResumeLayout(false);
            this.skinGroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.IO.Ports.SerialPort comport;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Timer timerReceived;
        private CCWin.SkinControl.SkinButton btn_Send;
        private CCWin.SkinControl.SkinButton btn_Open;
        private CCWin.SkinControl.SkinButton btn_F5;
        private CCWin.SkinControl.SkinButton btn_Edit;
        private CCWin.SkinControl.SkinButton btn_About;
        private CCWin.SkinControl.SkinCheckBox chkSendHex;
        private CCWin.SkinControl.SkinCheckBox chkRecvHex;
        private CCWin.SkinControl.SkinComboBox cmbPortName;
        private CCWin.SkinControl.SkinComboBox cmbDataBits;
        private CCWin.SkinControl.SkinComboBox cmbParity;
        private CCWin.SkinControl.SkinComboBox cmbStopBits;
        private CCWin.SkinControl.SkinComboBox cmbBaudRate;
        private CCWin.SkinControl.SkinLabel skinLabel12;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private CCWin.SkinControl.SkinLabel skinLabel10;
        private CCWin.SkinControl.SkinLabel skinLabel11;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        public CCWin.SkinControl.RtfRichTextBox txtReceived;
        private CCWin.SkinControl.SkinButton btn_SpiltSendStr;
        private CCWin.SkinControl.SkinButton btn_addVerify;
        private CCWin.SkinControl.SkinLabel skinLabel41;
        private System.Windows.Forms.TextBox txt_timeSend;
        private CCWin.SkinControl.SkinLabel skinLabel42;
        public System.Windows.Forms.Timer timerSend;
        private CCWin.SkinControl.SkinLabel skinLabel44;
        private System.Windows.Forms.TextBox txt_TimeOutNum;
        private CCWin.SkinControl.SkinLabel skinLabel46;
        private System.Windows.Forms.TextBox txt_gjz;
        private CCWin.SkinControl.SkinLabel skinLabel47;
        private CCWin.SkinControl.SkinLabel skinLabel48;
        private CCWin.SkinControl.SkinLabel skinLabel49;
        private CCWin.SkinControl.SkinLabel lbl_SendNum;
        private CCWin.SkinControl.SkinLabel lbl_RevNum;
        private CCWin.SkinControl.SkinLabel skinLabel54;
        private CCWin.SkinControl.SkinLabel skinLabel45;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel lbl_DataCount;
        private CCWin.SkinControl.SkinGroupBox gbPortSettings;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox5;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox2;
        private CCWin.SkinControl.SkinCheckBox cbo_gjz;
        private CCWin.SkinControl.SkinButton btn_Ccombination;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        public CCWin.SkinControl.SkinTextBox skinTextBox2;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLabel skinLabel14;
        private CCWin.SkinControl.SkinLabel skinLabel15;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox4;
        private CCWin.SkinControl.SkinCheckBox cbo_Res1;
        private System.Windows.Forms.TextBox txt_Pad1;
        private CCWin.SkinControl.SkinLabel skinLabel18;
        private System.Windows.Forms.TextBox txt_leng1;
        private CCWin.SkinControl.SkinLabel skinLabel16;
        private CCWin.SkinControl.SkinCheckBox cbo_Hex1;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox6;
        private CCWin.SkinControl.SkinCheckBox cbo_Res2;
        private System.Windows.Forms.TextBox txt_Pad2;
        private CCWin.SkinControl.SkinLabel skinLabel13;
        private System.Windows.Forms.TextBox txt_leng2;
        private CCWin.SkinControl.SkinLabel skinLabel17;
        private CCWin.SkinControl.SkinCheckBox cbo_Hex2;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox7;
        private CCWin.SkinControl.SkinCheckBox cbo_Res3;
        private System.Windows.Forms.TextBox txt_Pad3;
        private CCWin.SkinControl.SkinLabel skinLabel19;
        private System.Windows.Forms.TextBox txt_leng3;
        private CCWin.SkinControl.SkinLabel skinLabel20;
        private CCWin.SkinControl.SkinCheckBox cbo_Hex3;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinCheckBox cbo_timeSend;
        private System.Windows.Forms.TextBox txt_SendNumber;
        private CCWin.SkinControl.SkinLabel skinLabel21;
        private CCWin.SkinControl.SkinLabel skinLabel22;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox9;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox10;
        private CCWin.SkinControl.SkinButton btn_Clear;
        public CCWin.SkinControl.RtfRichTextBox txt_Send;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private System.Windows.Forms.TextBox txt_Focus;
        private System.Windows.Forms.TextBox txt_SubLength;
        private CCWin.SkinControl.SkinLabel skinLabel23;
        private System.Windows.Forms.TextBox txt_MeterAddr;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.TextBox txt_VendorCode;
        private System.Windows.Forms.TextBox txt_Data3;
        private System.Windows.Forms.TextBox txt_Data2;
        private System.Windows.Forms.TextBox txt_Data1;
        private System.Windows.Forms.TextBox txt_gdData;
        private CCWin.SkinControl.SkinButton btn_extension;
        private CCWin.SkinControl.SkinGroupBox gb_extension;
        private System.Windows.Forms.Panel pl_extension;
        private CCWin.SkinControl.SkinTabControl skinTabControl1;
        private CCWin.SkinControl.SkinTabPage skinTabPage1;
        private CCWin.SkinControl.SkinTabPage skinTabPage2;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox8;
        private CCWin.SkinControl.SkinComboBox cmbParity2;
        private CCWin.SkinControl.SkinComboBox cmbPortName2;
        private CCWin.SkinControl.SkinLabel skinLabel28;
        private CCWin.SkinControl.SkinLabel skinLabel29;
        private CCWin.SkinControl.SkinComboBox cmbStopBits2;
        private CCWin.SkinControl.SkinComboBox cmbDataBits2;
        private CCWin.SkinControl.SkinComboBox cmbBaudRate2;
        private CCWin.SkinControl.SkinLabel skinLabel31;
        private CCWin.SkinControl.SkinLabel skinLabel32;
        private CCWin.SkinControl.SkinLabel skinLabel33;
        private CCWin.SkinControl.SkinRadioButton rdo_comPort1;
        private CCWin.SkinControl.SkinRadioButton rdo_comPort2;
        private CCWin.SkinControl.SkinRadioButton rdo_comPort3;
        private CCWin.SkinControl.SkinTabPage skinTabPage3;
        private CCWin.SkinControl.SkinButton btn_Open3;
        private CCWin.SkinControl.SkinComboBox cmbParity3;
        private CCWin.SkinControl.SkinComboBox cmbPortName3;
        private CCWin.SkinControl.SkinLabel skinLabel35;
        private CCWin.SkinControl.SkinLabel skinLabel36;
        private CCWin.SkinControl.SkinComboBox cmbStopBits3;
        private CCWin.SkinControl.SkinComboBox cmbDataBits3;
        private CCWin.SkinControl.SkinComboBox cmbBaudRate3;
        private CCWin.SkinControl.SkinLabel skinLabel38;
        private CCWin.SkinControl.SkinLabel skinLabel39;
        private CCWin.SkinControl.SkinLabel skinLabel50;
        private CCWin.SkinControl.SkinButton btn_RecAddHeight;
        private CCWin.SkinControl.SkinButton btn_Open2;
        public CCWin.SkinControl.RtfRichTextBox txtReceived3;
        public CCWin.SkinControl.RtfRichTextBox txtReceived2;
        private System.Windows.Forms.Panel panel1;
        private CCWin.SkinControl.SkinLabel skinLabel53;
        private System.Windows.Forms.Panel panel3;
        private CCWin.SkinControl.SkinLabel skinLabel52;
        private CCWin.SkinControl.SkinCheckBox chkRecvHex3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private CCWin.SkinControl.SkinLabel skinLabel24;
        private CCWin.SkinControl.SkinCheckBox chkRecvHex2;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinCheckBox btn_ForeachSend;
        private System.Windows.Forms.Button btn_Import;
        private CCWin.SkinControl.SkinCheckBox check_All;
        private System.Windows.Forms.Button btn_Export;
        private CCWin.SkinControl.SkinLabel skinLabel56;
        private CCWin.SkinControl.SkinLabel lbl_SendNum3;
        private CCWin.SkinControl.SkinLabel skinLabel58;
        private CCWin.SkinControl.SkinLabel lbl_RevNum3;
        private CCWin.SkinControl.SkinLabel skinLabel25;
        private CCWin.SkinControl.SkinLabel lbl_SendNum2;
        private CCWin.SkinControl.SkinLabel skinLabel51;
        private CCWin.SkinControl.SkinLabel lbl_RevNum2;
        public System.IO.Ports.SerialPort comport2;
        public System.IO.Ports.SerialPort comport3;
        private CCWin.SkinControl.SkinDataGridView DataGridView1;
        private CCWin.SkinControl.SkinCheckBox chkHidden3;
        private CCWin.SkinControl.SkinCheckBox chkHidden2;
        private CCWin.SkinControl.SkinCheckBox chkHidden;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        public System.Windows.Forms.Timer timerReceived2;
        public System.Windows.Forms.Timer timerReceived3;
        private CCWin.SkinControl.SkinCheckBox cbo_com1;
        private CCWin.SkinControl.SkinCheckBox cbo_com2;
        private CCWin.SkinControl.SkinCheckBox cbo_com3;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox1;
        private CCWin.SkinControl.SkinButton btn_SendClear;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinCheckBox cbo_sync;
        private CCWin.SkinControl.SkinLabel skinLabel43;
        private CCWin.SkinControl.SkinButton btn_dqData;
        private CCWin.SkinControl.SkinButton btn_szTime;
        private CCWin.SkinControl.SkinButton btn_dqTime;
        private CCWin.SkinControl.SkinButton btn_shData;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private CCWin.SkinControl.SkinButton btn_asyn;
        private System.Windows.Forms.TextBox txt_OldMeterAddr;
        private System.Windows.Forms.TextBox txt_DataNum;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private CCWin.SkinControl.SkinButton btn_ex;
    }
}

