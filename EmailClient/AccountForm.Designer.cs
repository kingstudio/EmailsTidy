namespace EmailClient
{
    partial class AccountForm
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_SmtpPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_SmtpAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_PopPort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_PopAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_PassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtp_SetDate = new System.Windows.Forms.DateTimePicker();
            this.rb_SetDate = new System.Windows.Forms.RadioButton();
            this.rb_All = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_Default = new System.Windows.Forms.TextBox();
            this.btn_SetTime = new System.Windows.Forms.Button();
            this.cb_SetTime = new System.Windows.Forms.ComboBox();
            this.rb_SetTime = new System.Windows.Forms.RadioButton();
            this.rb_Default = new System.Windows.Forms.RadioButton();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(12, 12);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(403, 348);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(22, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(377, 340);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "常规设置";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_SmtpPort);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tb_SmtpAddress);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(6, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 87);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送服务器(SMTP)";
            // 
            // tb_SmtpPort
            // 
            this.tb_SmtpPort.Location = new System.Drawing.Point(111, 48);
            this.tb_SmtpPort.Name = "tb_SmtpPort";
            this.tb_SmtpPort.Size = new System.Drawing.Size(240, 21);
            this.tb_SmtpPort.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "端口：";
            // 
            // tb_SmtpAddress
            // 
            this.tb_SmtpAddress.Location = new System.Drawing.Point(111, 21);
            this.tb_SmtpAddress.Name = "tb_SmtpAddress";
            this.tb_SmtpAddress.Size = new System.Drawing.Size(240, 21);
            this.tb_SmtpAddress.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "地址：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_PopPort);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb_PopAddress);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(6, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 85);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收服务器(POP3)";
            // 
            // tb_PopPort
            // 
            this.tb_PopPort.Location = new System.Drawing.Point(111, 48);
            this.tb_PopPort.Name = "tb_PopPort";
            this.tb_PopPort.Size = new System.Drawing.Size(240, 21);
            this.tb_PopPort.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "端口：";
            // 
            // tb_PopAddress
            // 
            this.tb_PopAddress.Location = new System.Drawing.Point(111, 21);
            this.tb_PopAddress.Name = "tb_PopAddress";
            this.tb_PopAddress.Size = new System.Drawing.Size(240, 21);
            this.tb_PopAddress.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "地址：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_Name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_Email);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_PassWord);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_UserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 135);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "帐号信息";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(111, 102);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(240, 21);
            this.tb_Name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "您的姓名：";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(111, 75);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(240, 21);
            this.tb_Email.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "邮箱地址：";
            // 
            // tb_PassWord
            // 
            this.tb_PassWord.Location = new System.Drawing.Point(111, 48);
            this.tb_PassWord.Name = "tb_PassWord";
            this.tb_PassWord.PasswordChar = '*';
            this.tb_PassWord.Size = new System.Drawing.Size(240, 21);
            this.tb_PassWord.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "邮箱密码：";
            // 
            // tb_UserName
            // 
            this.tb_UserName.Location = new System.Drawing.Point(111, 21);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(240, 21);
            this.tb_UserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "登录用户名：";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(22, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(377, 340);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "邮件接收";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtp_SetDate);
            this.groupBox5.Controls.Add(this.rb_SetDate);
            this.groupBox5.Controls.Add(this.rb_All);
            this.groupBox5.Location = new System.Drawing.Point(6, 87);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(363, 73);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "收取特定日子之后的邮件";
            // 
            // dtp_SetDate
            // 
            this.dtp_SetDate.Enabled = false;
            this.dtp_SetDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_SetDate.Location = new System.Drawing.Point(182, 41);
            this.dtp_SetDate.Name = "dtp_SetDate";
            this.dtp_SetDate.Size = new System.Drawing.Size(175, 21);
            this.dtp_SetDate.TabIndex = 1;
            // 
            // rb_SetDate
            // 
            this.rb_SetDate.AutoSize = true;
            this.rb_SetDate.Location = new System.Drawing.Point(7, 43);
            this.rb_SetDate.Name = "rb_SetDate";
            this.rb_SetDate.Size = new System.Drawing.Size(167, 16);
            this.rb_SetDate.TabIndex = 0;
            this.rb_SetDate.Text = "仅接收指定日期之后的邮件";
            this.rb_SetDate.UseVisualStyleBackColor = true;
            this.rb_SetDate.CheckedChanged += new System.EventHandler(this.rb_SetDate_CheckedChanged);
            // 
            // rb_All
            // 
            this.rb_All.AutoSize = true;
            this.rb_All.Checked = true;
            this.rb_All.Location = new System.Drawing.Point(7, 21);
            this.rb_All.Name = "rb_All";
            this.rb_All.Size = new System.Drawing.Size(95, 16);
            this.rb_All.TabIndex = 0;
            this.rb_All.TabStop = true;
            this.rb_All.Text = "接收所有邮件";
            this.rb_All.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_Default);
            this.groupBox4.Controls.Add(this.btn_SetTime);
            this.groupBox4.Controls.Add(this.cb_SetTime);
            this.groupBox4.Controls.Add(this.rb_SetTime);
            this.groupBox4.Controls.Add(this.rb_Default);
            this.groupBox4.Location = new System.Drawing.Point(6, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(363, 73);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "自动接收邮件";
            // 
            // tb_Default
            // 
            this.tb_Default.Location = new System.Drawing.Point(182, 19);
            this.tb_Default.Name = "tb_Default";
            this.tb_Default.Size = new System.Drawing.Size(94, 21);
            this.tb_Default.TabIndex = 3;
            this.tb_Default.Text = "5";
            this.tb_Default.Visible = false;
            // 
            // btn_SetTime
            // 
            this.btn_SetTime.Enabled = false;
            this.btn_SetTime.Location = new System.Drawing.Point(283, 40);
            this.btn_SetTime.Name = "btn_SetTime";
            this.btn_SetTime.Size = new System.Drawing.Size(75, 23);
            this.btn_SetTime.TabIndex = 2;
            this.btn_SetTime.Text = "默认值";
            this.btn_SetTime.UseVisualStyleBackColor = true;
            // 
            // cb_SetTime
            // 
            this.cb_SetTime.Enabled = false;
            this.cb_SetTime.FormattingEnabled = true;
            this.cb_SetTime.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.cb_SetTime.Location = new System.Drawing.Point(182, 41);
            this.cb_SetTime.Name = "cb_SetTime";
            this.cb_SetTime.Size = new System.Drawing.Size(94, 20);
            this.cb_SetTime.TabIndex = 1;
            // 
            // rb_SetTime
            // 
            this.rb_SetTime.AutoSize = true;
            this.rb_SetTime.Location = new System.Drawing.Point(7, 43);
            this.rb_SetTime.Name = "rb_SetTime";
            this.rb_SetTime.Size = new System.Drawing.Size(167, 16);
            this.rb_SetTime.TabIndex = 0;
            this.rb_SetTime.Text = "设定收信间隔时间（分钟）";
            this.rb_SetTime.UseVisualStyleBackColor = true;
            this.rb_SetTime.CheckedChanged += new System.EventHandler(this.rb_SetTime_CheckedChanged);
            // 
            // rb_Default
            // 
            this.rb_Default.AutoSize = true;
            this.rb_Default.Checked = true;
            this.rb_Default.Location = new System.Drawing.Point(7, 21);
            this.rb_Default.Name = "rb_Default";
            this.rb_Default.Size = new System.Drawing.Size(95, 16);
            this.rb_Default.TabIndex = 0;
            this.rb_Default.TabStop = true;
            this.rb_Default.Text = "使用默认设置";
            this.rb_Default.UseVisualStyleBackColor = true;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(259, 366);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 14;
            this.btn_Ok.Text = "确定(&O)";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(340, 366);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "取消(&C)";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 398);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "帐号管理";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_SmtpPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_SmtpAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_PopPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_PopAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_PassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_SetTime;
        private System.Windows.Forms.ComboBox cb_SetTime;
        private System.Windows.Forms.RadioButton rb_SetTime;
        private System.Windows.Forms.RadioButton rb_Default;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox tb_Default;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtp_SetDate;
        private System.Windows.Forms.RadioButton rb_SetDate;
        private System.Windows.Forms.RadioButton rb_All;


    }
}