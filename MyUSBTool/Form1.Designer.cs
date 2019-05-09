namespace MyCAN
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BaudrateBox = new System.Windows.Forms.ComboBox();
            this.ModeBox = new System.Windows.Forms.ComboBox();
            this.OpenDev_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MyComPort = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comDataBit = new System.Windows.Forms.ComboBox();
            this.comStopBit = new System.Windows.Forms.ComboBox();
            this.comParity = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chkautoline = new System.Windows.Forms.CheckBox();
            this.tabcom = new System.Windows.Forms.TabPage();
            this.btnComClear = new System.Windows.Forms.Button();
            this.btnComSnd = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SendInfo = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TextShow = new System.Windows.Forms.TextBox();
            this.tabcan0 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.lbxInfo = new System.Windows.Forms.ListBox();
            this.消息收发 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.lbxRec = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CAN_WES_Control = new System.Windows.Forms.TabControl();
            this.tabcan1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.lbxRec1 = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.lbxInfo1 = new System.Windows.Forms.ListBox();
            this.button8 = new System.Windows.Forms.Button();
            this.InfoControl = new System.Windows.Forms.GroupBox();
            this.trbRed = new System.Windows.Forms.TrackBar();
            this.chkGreen = new System.Windows.Forms.CheckBox();
            this.chkBlue = new System.Windows.Forms.CheckBox();
            this.chkRed = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trbBlue = new System.Windows.Forms.TrackBar();
            this.trbGreen = new System.Windows.Forms.TrackBar();
            this.tabcom.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabcan0.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.消息收发.SuspendLayout();
            this.CAN_WES_Control.SuspendLayout();
            this.tabcan1.SuspendLayout();
            this.InfoControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // BaudrateBox
            // 
            this.BaudrateBox.FormattingEnabled = true;
            this.BaudrateBox.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200"});
            this.BaudrateBox.Location = new System.Drawing.Point(86, 62);
            this.BaudrateBox.Name = "BaudrateBox";
            this.BaudrateBox.Size = new System.Drawing.Size(97, 23);
            this.BaudrateBox.TabIndex = 0;
            // 
            // ModeBox
            // 
            this.ModeBox.FormattingEnabled = true;
            this.ModeBox.Location = new System.Drawing.Point(209, 39);
            this.ModeBox.Name = "ModeBox";
            this.ModeBox.Size = new System.Drawing.Size(97, 23);
            this.ModeBox.TabIndex = 1;
            // 
            // OpenDev_btn
            // 
            this.OpenDev_btn.Location = new System.Drawing.Point(209, 141);
            this.OpenDev_btn.Name = "OpenDev_btn";
            this.OpenDev_btn.Size = new System.Drawing.Size(97, 26);
            this.OpenDev_btn.TabIndex = 2;
            this.OpenDev_btn.Text = "打开设备";
            this.OpenDev_btn.UseVisualStyleBackColor = true;
            this.OpenDev_btn.Click += new System.EventHandler(this.OpenDev_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "波特率";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "工作模式";
            // 
            // MyComPort
            // 
            this.MyComPort.FormattingEnabled = true;
            this.MyComPort.Location = new System.Drawing.Point(86, 33);
            this.MyComPort.Name = "MyComPort";
            this.MyComPort.Size = new System.Drawing.Size(97, 23);
            this.MyComPort.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "串口号";
            // 
            // comDataBit
            // 
            this.comDataBit.FormattingEnabled = true;
            this.comDataBit.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.comDataBit.Location = new System.Drawing.Point(86, 91);
            this.comDataBit.Name = "comDataBit";
            this.comDataBit.Size = new System.Drawing.Size(97, 23);
            this.comDataBit.TabIndex = 11;
            // 
            // comStopBit
            // 
            this.comStopBit.FormattingEnabled = true;
            this.comStopBit.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comStopBit.Location = new System.Drawing.Point(86, 120);
            this.comStopBit.Name = "comStopBit";
            this.comStopBit.Size = new System.Drawing.Size(97, 23);
            this.comStopBit.TabIndex = 12;
            // 
            // comParity
            // 
            this.comParity.FormattingEnabled = true;
            this.comParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comParity.Location = new System.Drawing.Point(86, 149);
            this.comParity.Name = "comParity";
            this.comParity.Size = new System.Drawing.Size(97, 23);
            this.comParity.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "数据位";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "停止位";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "校验位";
            // 
            // chkautoline
            // 
            this.chkautoline.AutoSize = true;
            this.chkautoline.Location = new System.Drawing.Point(209, 68);
            this.chkautoline.Name = "chkautoline";
            this.chkautoline.Size = new System.Drawing.Size(89, 19);
            this.chkautoline.TabIndex = 17;
            this.chkautoline.Text = "自动换行";
            this.chkautoline.UseVisualStyleBackColor = true;
            // 
            // tabcom
            // 
            this.tabcom.Controls.Add(this.btnComClear);
            this.tabcom.Controls.Add(this.btnComSnd);
            this.tabcom.Controls.Add(this.groupBox5);
            this.tabcom.Controls.Add(this.groupBox4);
            this.tabcom.Location = new System.Drawing.Point(4, 25);
            this.tabcom.Name = "tabcom";
            this.tabcom.Padding = new System.Windows.Forms.Padding(3);
            this.tabcom.Size = new System.Drawing.Size(994, 438);
            this.tabcom.TabIndex = 2;
            this.tabcom.Text = "COM";
            this.tabcom.UseVisualStyleBackColor = true;
            // 
            // btnComClear
            // 
            this.btnComClear.Location = new System.Drawing.Point(863, 374);
            this.btnComClear.Name = "btnComClear";
            this.btnComClear.Size = new System.Drawing.Size(75, 37);
            this.btnComClear.TabIndex = 3;
            this.btnComClear.Text = "清空";
            this.btnComClear.UseVisualStyleBackColor = true;
            this.btnComClear.Click += new System.EventHandler(this.btnComClear_Click);
            // 
            // btnComSnd
            // 
            this.btnComSnd.Location = new System.Drawing.Point(863, 333);
            this.btnComSnd.Name = "btnComSnd";
            this.btnComSnd.Size = new System.Drawing.Size(75, 35);
            this.btnComSnd.TabIndex = 2;
            this.btnComSnd.Text = "发送";
            this.btnComSnd.UseVisualStyleBackColor = true;
            this.btnComSnd.Click += new System.EventHandler(this.btnComSnd_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SendInfo);
            this.groupBox5.Location = new System.Drawing.Point(6, 325);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(820, 100);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "发送";
            // 
            // SendInfo
            // 
            this.SendInfo.Location = new System.Drawing.Point(6, 24);
            this.SendInfo.Multiline = true;
            this.SendInfo.Name = "SendInfo";
            this.SendInfo.Size = new System.Drawing.Size(801, 70);
            this.SendInfo.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TextShow);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(982, 321);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "消息接收";
            // 
            // TextShow
            // 
            this.TextShow.Location = new System.Drawing.Point(6, 24);
            this.TextShow.Multiline = true;
            this.TextShow.Name = "TextShow";
            this.TextShow.Size = new System.Drawing.Size(970, 289);
            this.TextShow.TabIndex = 0;
            // 
            // tabcan0
            // 
            this.tabcan0.Controls.Add(this.groupBox1);
            this.tabcan0.Controls.Add(this.消息收发);
            this.tabcan0.Location = new System.Drawing.Point(4, 25);
            this.tabcan0.Name = "tabcan0";
            this.tabcan0.Padding = new System.Windows.Forms.Padding(3);
            this.tabcan0.Size = new System.Drawing.Size(994, 438);
            this.tabcan0.TabIndex = 0;
            this.tabcan0.Text = "CAN0";
            this.tabcan0.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.lbxInfo);
            this.groupBox1.Location = new System.Drawing.Point(6, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(969, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "日志信息";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(872, 169);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 35);
            this.button5.TabIndex = 1;
            this.button5.Text = "清空";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // lbxInfo
            // 
            this.lbxInfo.FormattingEnabled = true;
            this.lbxInfo.ItemHeight = 15;
            this.lbxInfo.Location = new System.Drawing.Point(6, 24);
            this.lbxInfo.Name = "lbxInfo";
            this.lbxInfo.Size = new System.Drawing.Size(957, 139);
            this.lbxInfo.TabIndex = 0;
            // 
            // 消息收发
            // 
            this.消息收发.Controls.Add(this.button4);
            this.消息收发.Controls.Add(this.lbxRec);
            this.消息收发.Controls.Add(this.button3);
            this.消息收发.Controls.Add(this.textBox9);
            this.消息收发.Controls.Add(this.textBox8);
            this.消息收发.Controls.Add(this.textBox7);
            this.消息收发.Controls.Add(this.textBox6);
            this.消息收发.Controls.Add(this.textBox5);
            this.消息收发.Controls.Add(this.textBox4);
            this.消息收发.Controls.Add(this.textBox3);
            this.消息收发.Controls.Add(this.label5);
            this.消息收发.Controls.Add(this.textBox2);
            this.消息收发.Controls.Add(this.label4);
            this.消息收发.Controls.Add(this.textBox1);
            this.消息收发.Location = new System.Drawing.Point(6, 6);
            this.消息收发.Name = "消息收发";
            this.消息收发.Size = new System.Drawing.Size(969, 207);
            this.消息收发.TabIndex = 0;
            this.消息收发.TabStop = false;
            this.消息收发.Text = "消息收发";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(872, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 27);
            this.button4.TabIndex = 13;
            this.button4.Text = "清空";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lbxRec
            // 
            this.lbxRec.FormattingEnabled = true;
            this.lbxRec.ItemHeight = 15;
            this.lbxRec.Location = new System.Drawing.Point(6, 55);
            this.lbxRec.Name = "lbxRec";
            this.lbxRec.Size = new System.Drawing.Size(958, 139);
            this.lbxRec.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(791, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 27);
            this.button3.TabIndex = 11;
            this.button3.Text = "发送";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(712, 22);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(61, 25);
            this.textBox9.TabIndex = 10;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(645, 22);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(61, 25);
            this.textBox8.TabIndex = 9;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(578, 22);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(61, 25);
            this.textBox7.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(511, 22);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(61, 25);
            this.textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(444, 22);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(61, 25);
            this.textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(377, 22);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(61, 25);
            this.textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(310, 22);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(61, 25);
            this.textBox3.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "DATA";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(243, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(61, 25);
            this.textBox2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "帧ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 0;
            // 
            // CAN_WES_Control
            // 
            this.CAN_WES_Control.Controls.Add(this.tabcom);
            this.CAN_WES_Control.Controls.Add(this.tabcan0);
            this.CAN_WES_Control.Controls.Add(this.tabcan1);
            this.CAN_WES_Control.Location = new System.Drawing.Point(30, 178);
            this.CAN_WES_Control.Name = "CAN_WES_Control";
            this.CAN_WES_Control.SelectedIndex = 0;
            this.CAN_WES_Control.Size = new System.Drawing.Size(1002, 467);
            this.CAN_WES_Control.TabIndex = 8;
            // 
            // tabcan1
            // 
            this.tabcan1.Controls.Add(this.groupBox3);
            this.tabcan1.Controls.Add(this.groupBox2);
            this.tabcan1.Location = new System.Drawing.Point(4, 25);
            this.tabcan1.Name = "tabcan1";
            this.tabcan1.Padding = new System.Windows.Forms.Padding(3);
            this.tabcan1.Size = new System.Drawing.Size(994, 438);
            this.tabcan1.TabIndex = 1;
            this.tabcan1.Text = "CAN1";
            this.tabcan1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(6, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(969, 208);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(969, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(60, 22);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 25);
            this.textBox18.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 1;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(243, 22);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(61, 25);
            this.textBox17.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 3;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(310, 22);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(61, 25);
            this.textBox16.TabIndex = 4;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(377, 22);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(61, 25);
            this.textBox15.TabIndex = 5;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(444, 22);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(61, 25);
            this.textBox14.TabIndex = 6;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(511, 22);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(61, 25);
            this.textBox13.TabIndex = 7;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(578, 22);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(61, 25);
            this.textBox12.TabIndex = 8;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(645, 22);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(61, 25);
            this.textBox11.TabIndex = 9;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(712, 22);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(61, 25);
            this.textBox10.TabIndex = 10;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(791, 17);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 27);
            this.button7.TabIndex = 11;
            this.button7.Text = "发送";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // lbxRec1
            // 
            this.lbxRec1.FormattingEnabled = true;
            this.lbxRec1.ItemHeight = 15;
            this.lbxRec1.Location = new System.Drawing.Point(6, 55);
            this.lbxRec1.Name = "lbxRec1";
            this.lbxRec1.Size = new System.Drawing.Size(958, 139);
            this.lbxRec1.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(872, 17);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 27);
            this.button6.TabIndex = 13;
            this.button6.Text = "清空";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // lbxInfo1
            // 
            this.lbxInfo1.FormattingEnabled = true;
            this.lbxInfo1.ItemHeight = 15;
            this.lbxInfo1.Location = new System.Drawing.Point(6, 24);
            this.lbxInfo1.Name = "lbxInfo1";
            this.lbxInfo1.Size = new System.Drawing.Size(957, 139);
            this.lbxInfo1.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(872, 169);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 35);
            this.button8.TabIndex = 1;
            this.button8.Text = "清空";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // InfoControl
            // 
            this.InfoControl.Controls.Add(this.trbGreen);
            this.InfoControl.Controls.Add(this.trbBlue);
            this.InfoControl.Controls.Add(this.trbRed);
            this.InfoControl.Controls.Add(this.chkGreen);
            this.InfoControl.Controls.Add(this.chkBlue);
            this.InfoControl.Controls.Add(this.chkRed);
            this.InfoControl.Location = new System.Drawing.Point(318, 15);
            this.InfoControl.Name = "InfoControl";
            this.InfoControl.Size = new System.Drawing.Size(704, 160);
            this.InfoControl.TabIndex = 18;
            this.InfoControl.TabStop = false;
            this.InfoControl.Text = "InfoControl";
            // 
            // trbRed
            // 
            this.trbRed.Location = new System.Drawing.Point(118, 18);
            this.trbRed.Maximum = 255;
            this.trbRed.Name = "trbRed";
            this.trbRed.Size = new System.Drawing.Size(212, 56);
            this.trbRed.TabIndex = 3;
            this.trbRed.CursorChanged += new System.EventHandler(this.trbRed_CursorChanged);
            this.trbRed.LocationChanged += new System.EventHandler(this.trbRed_LocationChanged);
            // 
            // chkGreen
            // 
            this.chkGreen.AutoSize = true;
            this.chkGreen.Location = new System.Drawing.Point(20, 75);
            this.chkGreen.Name = "chkGreen";
            this.chkGreen.Size = new System.Drawing.Size(69, 19);
            this.chkGreen.TabIndex = 2;
            this.chkGreen.Text = "Green";
            this.chkGreen.UseVisualStyleBackColor = true;
            this.chkGreen.CheckedChanged += new System.EventHandler(this.chkGreen_CheckedChanged);
            // 
            // chkBlue
            // 
            this.chkBlue.AutoSize = true;
            this.chkBlue.Location = new System.Drawing.Point(20, 53);
            this.chkBlue.Name = "chkBlue";
            this.chkBlue.Size = new System.Drawing.Size(61, 19);
            this.chkBlue.TabIndex = 1;
            this.chkBlue.Text = "Blue";
            this.chkBlue.UseVisualStyleBackColor = true;
            this.chkBlue.CheckedChanged += new System.EventHandler(this.chkBlue_CheckedChanged);
            // 
            // chkRed
            // 
            this.chkRed.AutoSize = true;
            this.chkRed.Checked = true;
            this.chkRed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRed.Location = new System.Drawing.Point(20, 28);
            this.chkRed.Name = "chkRed";
            this.chkRed.Size = new System.Drawing.Size(53, 19);
            this.chkRed.TabIndex = 0;
            this.chkRed.Text = "Red";
            this.chkRed.UseVisualStyleBackColor = true;
            this.chkRed.CheckedChanged += new System.EventHandler(this.chkRed_CheckedChanged);
            // 
            // trbBlue
            // 
            this.trbBlue.Location = new System.Drawing.Point(118, 53);
            this.trbBlue.Maximum = 255;
            this.trbBlue.Name = "trbBlue";
            this.trbBlue.Size = new System.Drawing.Size(212, 56);
            this.trbBlue.TabIndex = 5;
            // 
            // trbGreen
            // 
            this.trbGreen.Location = new System.Drawing.Point(118, 96);
            this.trbGreen.Maximum = 255;
            this.trbGreen.Name = "trbGreen";
            this.trbGreen.Size = new System.Drawing.Size(212, 56);
            this.trbGreen.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 669);
            this.Controls.Add(this.InfoControl);
            this.Controls.Add(this.chkautoline);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comParity);
            this.Controls.Add(this.comStopBit);
            this.Controls.Add(this.comDataBit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MyComPort);
            this.Controls.Add(this.CAN_WES_Control);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenDev_btn);
            this.Controls.Add(this.ModeBox);
            this.Controls.Add(this.BaudrateBox);
            this.Name = "Form1";
            this.Text = "WesCAN测试工具";
            this.tabcom.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabcan0.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.消息收发.ResumeLayout(false);
            this.消息收发.PerformLayout();
            this.CAN_WES_Control.ResumeLayout(false);
            this.tabcan1.ResumeLayout(false);
            this.InfoControl.ResumeLayout(false);
            this.InfoControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BaudrateBox;
        private System.Windows.Forms.ComboBox ModeBox;
        private System.Windows.Forms.Button OpenDev_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MyComPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comDataBit;
        private System.Windows.Forms.ComboBox comStopBit;
        private System.Windows.Forms.ComboBox comParity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkautoline;
        private System.Windows.Forms.TabPage tabcom;
        private System.Windows.Forms.Button btnComClear;
        private System.Windows.Forms.Button btnComSnd;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TextShow;
        private System.Windows.Forms.TabPage tabcan0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox lbxInfo;
        private System.Windows.Forms.GroupBox 消息收发;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox lbxRec;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl CAN_WES_Control;
        private System.Windows.Forms.TabPage tabcan1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListBox lbxRec1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox lbxInfo1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox SendInfo;
        private System.Windows.Forms.GroupBox InfoControl;
        private System.Windows.Forms.CheckBox chkGreen;
        private System.Windows.Forms.CheckBox chkBlue;
        private System.Windows.Forms.CheckBox chkRed;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trbRed;
        private System.Windows.Forms.TrackBar trbGreen;
        private System.Windows.Forms.TrackBar trbBlue;
    }
}

