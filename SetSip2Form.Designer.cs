namespace Sip2Service
{
    partial class SetSip2Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboxVP = new System.Windows.Forms.ComboBox();
            this.txtLocationCode = new System.Windows.Forms.TextBox();
            this.labLocationCode = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBookCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbReader = new System.Windows.Forms.GroupBox();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.txtBQ = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.labBQ = new System.Windows.Forms.Label();
            this.txtReaderCode = new System.Windows.Forms.TextBox();
            this.txtBP = new System.Windows.Forms.TextBox();
            this.labPIN = new System.Windows.Forms.Label();
            this.labBP = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbReader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(297, 260);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 42);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Pink;
            this.btnReset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReset.Location = new System.Drawing.Point(402, 260);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(67, 42);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(74, 20);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 23);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "sip2Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(22, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "名称";
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
            this.groupBox1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(26, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(235, 199);
            this.groupBox1.TabIndex = 2;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboxVP);
            this.groupBox3.Controls.Add(this.txtLocationCode);
            this.groupBox3.Controls.Add(this.labLocationCode);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtUserName);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtPwd);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(283, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 228);
            this.groupBox3.TabIndex = 3;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(6, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Vendor Profile";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(33, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "UserName";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(36, 55);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Password";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBookCode);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(548, 192);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(257, 57);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Book";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(12, 24);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "图书条码";
            // 
            // gbReader
            // 
            this.gbReader.Controls.Add(this.txtPIN);
            this.gbReader.Controls.Add(this.txtBQ);
            this.gbReader.Controls.Add(this.label12);
            this.gbReader.Controls.Add(this.labBQ);
            this.gbReader.Controls.Add(this.txtReaderCode);
            this.gbReader.Controls.Add(this.txtBP);
            this.gbReader.Controls.Add(this.labPIN);
            this.gbReader.Controls.Add(this.labBP);
            this.gbReader.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbReader.Location = new System.Drawing.Point(548, 26);
            this.gbReader.Name = "gbReader";
            this.gbReader.Size = new System.Drawing.Size(257, 155);
            this.gbReader.TabIndex = 4;
            this.gbReader.TabStop = false;
            this.gbReader.Text = "Reader";
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
            // txtBQ
            // 
            this.txtBQ.Enabled = false;
            this.txtBQ.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBQ.Location = new System.Drawing.Point(166, 106);
            this.txtBQ.Margin = new System.Windows.Forms.Padding(2);
            this.txtBQ.Name = "txtBQ";
            this.txtBQ.Size = new System.Drawing.Size(68, 23);
            this.txtBQ.TabIndex = 3;
            this.txtBQ.Text = "5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(32, 29);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "读者证号";
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
            // txtReaderCode
            // 
            this.txtReaderCode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtReaderCode.Location = new System.Drawing.Point(102, 25);
            this.txtReaderCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtReaderCode.Name = "txtReaderCode";
            this.txtReaderCode.Size = new System.Drawing.Size(138, 23);
            this.txtReaderCode.TabIndex = 0;
            // 
            // txtBP
            // 
            this.txtBP.Enabled = false;
            this.txtBP.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBP.Location = new System.Drawing.Point(46, 107);
            this.txtBP.Margin = new System.Windows.Forms.Padding(2);
            this.txtBP.Name = "txtBP";
            this.txtBP.Size = new System.Drawing.Size(70, 23);
            this.txtBP.TabIndex = 2;
            this.txtBP.Text = "1";
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
            // SetSip2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 313);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbReader);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SetSip2Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配置Sip2Info";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbReader.ResumeLayout(false);
            this.gbReader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAP;
        private System.Windows.Forms.Label labAP;
        private System.Windows.Forms.TextBox txtAO;
        private System.Windows.Forms.Label labAO;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label labCharSet;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtCharset;
        private System.Windows.Forms.Label labIP;
        private System.Windows.Forms.Label labPort;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboxVP;
        private System.Windows.Forms.TextBox txtLocationCode;
        private System.Windows.Forms.Label labLocationCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBookCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbReader;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.TextBox txtBQ;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labBQ;
        private System.Windows.Forms.TextBox txtReaderCode;
        private System.Windows.Forms.TextBox txtBP;
        private System.Windows.Forms.Label labPIN;
        private System.Windows.Forms.Label labBP;
    }
}