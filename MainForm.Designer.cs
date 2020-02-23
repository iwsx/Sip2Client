namespace Sip2Service
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtReaderCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReaderBtn = new System.Windows.Forms.Button();
            this.SipBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SetSip2ServerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseSip2ServerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBookCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBookInfo = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAP = new System.Windows.Forms.TextBox();
            this.labAP = new System.Windows.Forms.Label();
            this.txtAO = new System.Windows.Forms.TextBox();
            this.labAO = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.labCharSet = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtCharset = new System.Windows.Forms.TextBox();
            this.labIP = new System.Windows.Forms.Label();
            this.labPort = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.labPIN = new System.Windows.Forms.Label();
            this.txtBP = new System.Windows.Forms.TextBox();
            this.labBP = new System.Windows.Forms.Label();
            this.txtBQ = new System.Windows.Forms.TextBox();
            this.labBQ = new System.Windows.Forms.Label();
            this.gbReader = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboxVP = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLocationCode = new System.Windows.Forms.TextBox();
            this.labLocationCode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labConnect = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbReader.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtReaderCode
            // 
            this.txtReaderCode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtReaderCode.Location = new System.Drawing.Point(102, 25);
            this.txtReaderCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtReaderCode.Name = "txtReaderCode";
            this.txtReaderCode.Size = new System.Drawing.Size(138, 23);
            this.txtReaderCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "读者证号";
            // 
            // ReaderBtn
            // 
            this.ReaderBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ReaderBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReaderBtn.Location = new System.Drawing.Point(996, 41);
            this.ReaderBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReaderBtn.Name = "ReaderBtn";
            this.ReaderBtn.Size = new System.Drawing.Size(124, 34);
            this.ReaderBtn.TabIndex = 5;
            this.ReaderBtn.Text = "查询读者信息";
            this.ReaderBtn.UseVisualStyleBackColor = false;
            this.ReaderBtn.Click += new System.EventHandler(this.ReaderInfo_Click);
            // 
            // SipBtn
            // 
            this.SipBtn.BackColor = System.Drawing.Color.Pink;
            this.SipBtn.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SipBtn.Location = new System.Drawing.Point(47, 189);
            this.SipBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SipBtn.Name = "SipBtn";
            this.SipBtn.Size = new System.Drawing.Size(124, 34);
            this.SipBtn.TabIndex = 5;
            this.SipBtn.Text = "连接Sip2Server";
            this.SipBtn.UseVisualStyleBackColor = false;
            this.SipBtn.Click += new System.EventHandler(this.SipBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tsmAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1188, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetSip2ServerMenu,
            this.chooseSip2ServerMenu});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(72, 24);
            this.toolStripMenuItem1.Text = "选项";
            // 
            // SetSip2ServerMenu
            // 
            this.SetSip2ServerMenu.Name = "SetSip2ServerMenu";
            this.SetSip2ServerMenu.Size = new System.Drawing.Size(188, 22);
            this.SetSip2ServerMenu.Text = "配置Sip2服务器";
            this.SetSip2ServerMenu.Click += new System.EventHandler(this.SetSip2ServerMenu_Click);
            // 
            // chooseSip2ServerMenu
            // 
            this.chooseSip2ServerMenu.Name = "chooseSip2ServerMenu";
            this.chooseSip2ServerMenu.Size = new System.Drawing.Size(188, 22);
            this.chooseSip2ServerMenu.Text = "选择Sip2服务器";
            this.chooseSip2ServerMenu.Click += new System.EventHandler(this.ChooseSip2ServerMenu_Click);
            // 
            // tsmAbout
            // 
            this.tsmAbout.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(52, 24);
            this.tsmAbout.Text = "关于";
            this.tsmAbout.Click += new System.EventHandler(this.tsmAbout_Click);
            // 
            // txtBookCode
            // 
            this.txtBookCode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBookCode.Location = new System.Drawing.Point(82, 21);
            this.txtBookCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookCode.Name = "txtBookCode";
            this.txtBookCode.Size = new System.Drawing.Size(154, 23);
            this.txtBookCode.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "图书条码";
            // 
            // btnBookInfo
            // 
            this.btnBookInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBookInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBookInfo.Location = new System.Drawing.Point(996, 96);
            this.btnBookInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookInfo.Name = "btnBookInfo";
            this.btnBookInfo.Size = new System.Drawing.Size(124, 34);
            this.btnBookInfo.TabIndex = 6;
            this.btnBookInfo.Text = "查询图书信息";
            this.btnBookInfo.UseVisualStyleBackColor = false;
            this.btnBookInfo.Click += new System.EventHandler(this.BtnBookInfo_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBorrow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBorrow.Location = new System.Drawing.Point(996, 148);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(124, 34);
            this.btnBorrow.TabIndex = 7;
            this.btnBorrow.Text = "借书";
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.BtnBorrow_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReturn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReturn.Location = new System.Drawing.Point(996, 201);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(124, 34);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "还书";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(32, 593);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 24);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "清空日志";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAP);
            this.groupBox1.Controls.Add(this.labAP);
            this.groupBox1.Controls.Add(this.txtAO);
            this.groupBox1.Controls.Add(this.labAO);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.labCharSet);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.txtCharset);
            this.groupBox1.Controls.Add(this.labIP);
            this.groupBox1.Controls.Add(this.labPort);
            this.groupBox1.Controls.Add(this.SipBtn);
            this.groupBox1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(36, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(235, 227);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sip2服务器配置";
            // 
            // txtAP
            // 
            this.txtAP.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAP.Location = new System.Drawing.Point(66, 121);
            this.txtAP.Margin = new System.Windows.Forms.Padding(2);
            this.txtAP.Name = "txtAP";
            this.txtAP.Size = new System.Drawing.Size(134, 23);
            this.txtAP.TabIndex = 3;
            // 
            // labAP
            // 
            this.labAP.AutoSize = true;
            this.labAP.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAP.Location = new System.Drawing.Point(34, 124);
            this.labAP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labAP.Name = "labAP";
            this.labAP.Size = new System.Drawing.Size(28, 20);
            this.labAP.TabIndex = 29;
            this.labAP.Text = "AP";
            // 
            // txtAO
            // 
            this.txtAO.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAO.Location = new System.Drawing.Point(66, 87);
            this.txtAO.Margin = new System.Windows.Forms.Padding(2);
            this.txtAO.Name = "txtAO";
            this.txtAO.Size = new System.Drawing.Size(134, 23);
            this.txtAO.TabIndex = 2;
            // 
            // labAO
            // 
            this.labAO.AutoSize = true;
            this.labAO.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAO.Location = new System.Drawing.Point(32, 84);
            this.labAO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labAO.Name = "labAO";
            this.labAO.Size = new System.Drawing.Size(30, 20);
            this.labAO.TabIndex = 23;
            this.labAO.Text = "AO";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIP.Location = new System.Drawing.Point(66, 21);
            this.txtIP.Margin = new System.Windows.Forms.Padding(2);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(134, 23);
            this.txtIP.TabIndex = 0;
            // 
            // labCharSet
            // 
            this.labCharSet.AutoSize = true;
            this.labCharSet.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCharSet.Location = new System.Drawing.Point(3, 156);
            this.labCharSet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCharSet.Name = "labCharSet";
            this.labCharSet.Size = new System.Drawing.Size(59, 20);
            this.labCharSet.TabIndex = 21;
            this.labCharSet.Text = "Charset";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPort.Location = new System.Drawing.Point(66, 53);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(134, 23);
            this.txtPort.TabIndex = 1;
            // 
            // txtCharset
            // 
            this.txtCharset.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCharset.Location = new System.Drawing.Point(66, 153);
            this.txtCharset.Margin = new System.Windows.Forms.Padding(2);
            this.txtCharset.Name = "txtCharset";
            this.txtCharset.Size = new System.Drawing.Size(134, 23);
            this.txtCharset.TabIndex = 4;
            // 
            // labIP
            // 
            this.labIP.AutoSize = true;
            this.labIP.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labIP.Location = new System.Drawing.Point(40, 24);
            this.labIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labIP.Name = "labIP";
            this.labIP.Size = new System.Drawing.Size(22, 20);
            this.labIP.TabIndex = 18;
            this.labIP.Text = "IP";
            // 
            // labPort
            // 
            this.labPort.AutoSize = true;
            this.labPort.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPort.Location = new System.Drawing.Point(25, 53);
            this.labPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labPort.Name = "labPort";
            this.labPort.Size = new System.Drawing.Size(37, 20);
            this.labPort.TabIndex = 19;
            this.labPort.Text = "Port";
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPwd.Location = new System.Drawing.Point(115, 56);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(2);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(115, 23);
            this.txtPwd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(36, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserName.Location = new System.Drawing.Point(115, 21);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(115, 23);
            this.txtUserName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(33, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "UserName";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMessage);
            this.groupBox2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(25, 264);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1147, 325);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "message";
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMessage.Location = new System.Drawing.Point(2, 21);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(1143, 302);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.Text = "";
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMsg_keyDown);
            // 
            // txtPIN
            // 
            this.txtPIN.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPIN.Location = new System.Drawing.Point(102, 66);
            this.txtPIN.Margin = new System.Windows.Forms.Padding(2);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(138, 23);
            this.txtPIN.TabIndex = 1;
            // 
            // labPIN
            // 
            this.labPIN.AutoSize = true;
            this.labPIN.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPIN.Location = new System.Drawing.Point(8, 69);
            this.labPIN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labPIN.Name = "labPIN";
            this.labPIN.Size = new System.Drawing.Size(89, 20);
            this.labPIN.TabIndex = 24;
            this.labPIN.Text = "PIN（密码）";
            // 
            // txtBP
            // 
            this.txtBP.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBP.Location = new System.Drawing.Point(46, 107);
            this.txtBP.Margin = new System.Windows.Forms.Padding(2);
            this.txtBP.Name = "txtBP";
            this.txtBP.Size = new System.Drawing.Size(70, 23);
            this.txtBP.TabIndex = 2;
            this.txtBP.Text = "1";
            // 
            // labBP
            // 
            this.labBP.AutoSize = true;
            this.labBP.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBP.Location = new System.Drawing.Point(12, 108);
            this.labBP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labBP.Name = "labBP";
            this.labBP.Size = new System.Drawing.Size(27, 20);
            this.labBP.TabIndex = 26;
            this.labBP.Text = "BP";
            // 
            // txtBQ
            // 
            this.txtBQ.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBQ.Location = new System.Drawing.Point(166, 106);
            this.txtBQ.Margin = new System.Windows.Forms.Padding(2);
            this.txtBQ.Name = "txtBQ";
            this.txtBQ.Size = new System.Drawing.Size(68, 23);
            this.txtBQ.TabIndex = 3;
            this.txtBQ.Text = "5";
            // 
            // labBQ
            // 
            this.labBQ.AutoSize = true;
            this.labBQ.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBQ.Location = new System.Drawing.Point(129, 108);
            this.labBQ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labBQ.Name = "labBQ";
            this.labBQ.Size = new System.Drawing.Size(29, 20);
            this.labBQ.TabIndex = 28;
            this.labBQ.Text = "BQ";
            // 
            // gbReader
            // 
            this.gbReader.Controls.Add(this.txtPIN);
            this.gbReader.Controls.Add(this.txtBQ);
            this.gbReader.Controls.Add(this.label1);
            this.gbReader.Controls.Add(this.labBQ);
            this.gbReader.Controls.Add(this.txtReaderCode);
            this.gbReader.Controls.Add(this.txtBP);
            this.gbReader.Controls.Add(this.labPIN);
            this.gbReader.Controls.Add(this.labBP);
            this.gbReader.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbReader.Location = new System.Drawing.Point(656, 32);
            this.gbReader.Name = "gbReader";
            this.gbReader.Size = new System.Drawing.Size(257, 155);
            this.gbReader.TabIndex = 3;
            this.gbReader.TabStop = false;
            this.gbReader.Text = "Reader";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboxVP);
            this.groupBox3.Controls.Add(this.btnLogin);
            this.groupBox3.Controls.Add(this.txtLocationCode);
            this.groupBox3.Controls.Add(this.labLocationCode);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtUserName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtPwd);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(338, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 228);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Login Information";
            // 
            // cboxVP
            // 
            this.cboxVP.FormattingEnabled = true;
            this.cboxVP.Items.AddRange(new object[] {
            "Envisionware",
            "Comprise",
            "3M",
            "ITG"});
            this.cboxVP.Location = new System.Drawing.Point(113, 91);
            this.cboxVP.Name = "cboxVP";
            this.cboxVP.Size = new System.Drawing.Size(117, 25);
            this.cboxVP.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Pink;
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.Location = new System.Drawing.Point(55, 188);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(124, 34);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "管理员登录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLocationCode
            // 
            this.txtLocationCode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLocationCode.Location = new System.Drawing.Point(113, 127);
            this.txtLocationCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocationCode.Name = "txtLocationCode";
            this.txtLocationCode.Size = new System.Drawing.Size(117, 23);
            this.txtLocationCode.TabIndex = 3;
            // 
            // labLocationCode
            // 
            this.labLocationCode.AutoSize = true;
            this.labLocationCode.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labLocationCode.Location = new System.Drawing.Point(7, 126);
            this.labLocationCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labLocationCode.Name = "labLocationCode";
            this.labLocationCode.Size = new System.Drawing.Size(102, 20);
            this.labLocationCode.TabIndex = 31;
            this.labLocationCode.Text = "LocationCode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(6, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Vendor Profile";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBookCode);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(656, 198);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(257, 57);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Book";
            // 
            // labConnect
            // 
            this.labConnect.AutoSize = true;
            this.labConnect.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labConnect.Location = new System.Drawing.Point(146, 595);
            this.labConnect.Name = "labConnect";
            this.labConnect.Size = new System.Drawing.Size(104, 19);
            this.labConnect.TabIndex = 23;
            this.labConnect.Text = "Not Connected";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1188, 626);
            this.Controls.Add(this.labConnect);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbReader);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.btnBookInfo);
            this.Controls.Add(this.ReaderBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sip2Client";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbReader.ResumeLayout(false);
            this.gbReader.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtReaderCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReaderBtn;
        private System.Windows.Forms.Button SipBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SetSip2ServerMenu;
        private System.Windows.Forms.ToolStripMenuItem chooseSip2ServerMenu;
        private System.Windows.Forms.TextBox txtBookCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBookInfo;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAO;
        private System.Windows.Forms.Label labAO;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label labCharSet;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtCharset;
        private System.Windows.Forms.Label labIP;
        private System.Windows.Forms.Label labPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Label labPIN;
        private System.Windows.Forms.TextBox txtBP;
        private System.Windows.Forms.Label labBP;
        private System.Windows.Forms.TextBox txtBQ;
        private System.Windows.Forms.Label labBQ;
        private System.Windows.Forms.GroupBox gbReader;
        private System.Windows.Forms.TextBox txtAP;
        private System.Windows.Forms.Label labAP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLocationCode;
        private System.Windows.Forms.Label labLocationCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox cboxVP;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.Label labConnect;
    }
}

