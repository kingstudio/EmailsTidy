using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;

namespace EmailClient
{
    public partial class AccountForm : Form
    {
        public string userName = "";
        public string passWord = "";
        public string email = "";
        public string name = "";
        public string popAddress = "";
        public string popPort = "";
        public string smtpAddress = "";
        public string smtpPort = "";
        public string recieveDefault = "";
        public string recieveTime = "";
        public string recieveAll = "";
        public string recieveDate = "";

        MainForm _main = null;
        public AccountForm()
        {
            InitializeComponent();
            initialization();
        }

        public AccountForm(MainForm main)
        {
            InitializeComponent();
            initialization();
            _main = main;
        }

        public void initialization()
        {
            string Current;
            string filePath;
            Current = System.IO.Directory.GetCurrentDirectory();//获取当前根目录
            filePath = Current + "/config.ini";
            if (!System.IO.File.Exists(filePath))
            {
                System.IO.File.Create(filePath);//创建该文件  
            }

            IniConfig ini = new IniConfig(filePath);

            // 读取ini
            userName = ini.ReadValue("Setting", "userName");
            passWord = ini.ReadValue("Setting", "passWord");
            email = ini.ReadValue("Setting", "email");
            name = ini.ReadValue("Setting", "name");
            popAddress = ini.ReadValue("Setting", "popAddress");
            popPort = ini.ReadValue("Setting", "popPort");
            smtpAddress = ini.ReadValue("Setting", "smtpAddress");
            smtpPort = ini.ReadValue("Setting", "smtpPort");
            //读取邮件
            recieveDefault = ini.ReadValue("Setting", "recieveDefault");
            recieveTime = ini.ReadValue("Setting", "recieveTime");
            recieveAll = ini.ReadValue("Setting", "recieveAll");
            recieveDate = ini.ReadValue("Setting", "recieveDate");

            tb_UserName.Text = this.userName == "" ? "" : DESEncrypt.Decrypt(this.userName);
            tb_PassWord.Text = this.passWord == "" ? "" : DESEncrypt.Decrypt(this.passWord);
            tb_Name.Text = this.name == "" ? "" : DESEncrypt.Decrypt(this.name);
            tb_Email.Text = this.email == "" ? "" : DESEncrypt.Decrypt(this.email);
            tb_PopAddress.Text = this.popAddress == "" ? "" : DESEncrypt.Decrypt(this.popAddress);
            tb_PopPort.Text = this.popPort == "" ? "" : DESEncrypt.Decrypt(this.popPort);
            tb_SmtpAddress.Text = this.smtpAddress == "" ? "" : DESEncrypt.Decrypt(this.smtpAddress);
            tb_SmtpPort.Text = this.smtpPort == "" ? "" : DESEncrypt.Decrypt(this.smtpPort);
            if (recieveDefault == "true")
            {
                rb_Default.Checked = true;
                rb_SetTime.Checked = false;
            }
            else
            {
                rb_Default.Checked = false;
                rb_SetTime.Checked = true;
                cb_SetTime.Enabled = true;
                btn_SetTime.Enabled = true;
                cb_SetTime.Text = this.recieveTime == "" ? "" : DESEncrypt.Decrypt(this.recieveTime);
            }
            if (recieveAll == "true")
            {
                rb_All.Checked = true;
                rb_SetDate.Checked = false;
            }
            else
            {
                rb_All.Checked = false;
                rb_SetDate.Checked = true;
                dtp_SetDate.Checked = true;
                dtp_SetDate.Text = this.recieveDate == "" ? "" : DESEncrypt.Decrypt(this.recieveDate);
            }
            
        }


        private void saveIni()
        {
            string Current;
            string filePath;
            Current = System.IO.Directory.GetCurrentDirectory();//获取当前根目录
            filePath = Current + "/config.ini";

            IniConfig ini = new IniConfig(filePath);
            // 写入ini
            ini.Writue("Setting", "userName", DESEncrypt.Encrypt(tb_UserName.Text));
            ini.Writue("Setting", "passWord",DESEncrypt.Encrypt(tb_PassWord.Text));
            ini.Writue("Setting", "name", DESEncrypt.Encrypt(tb_Name.Text));
            ini.Writue("Setting", "email", DESEncrypt.Encrypt(tb_Email.Text));
            ini.Writue("Setting", "popAddress", DESEncrypt.Encrypt(tb_PopAddress.Text));
            ini.Writue("Setting", "popPort", DESEncrypt.Encrypt(tb_PopPort.Text));
            ini.Writue("Setting", "smtpAddress", DESEncrypt.Encrypt(tb_SmtpAddress.Text));
            ini.Writue("Setting", "smtpPort", DESEncrypt.Encrypt(tb_SmtpPort.Text));
            //接收邮件
            ini.Writue("Setting", "recieveDefault", rb_Default.Checked == true ? "true" : "false");
            ini.Writue("Setting", "recieveTime", rb_Default.Checked == true ? DESEncrypt.Encrypt(tb_Default.Text) : DESEncrypt.Encrypt(cb_SetTime.Text));
            ini.Writue("Setting", "recieveAll", rb_All.Checked == true ? "true" : "false");
            ini.Writue("Setting", "recieveDate", rb_All.Checked == true ? DESEncrypt.Encrypt("1753/1/1") : DESEncrypt.Encrypt(dtp_SetDate.Text));

        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            saveIni();
            if (_main != null)
            {
                _main.initial();
            }

            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rb_SetTime_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_SetTime.Checked == true)
            {
                cb_SetTime.Enabled = true;
                btn_SetTime.Enabled = true;
                cb_SetTime.Text = "5";
            }
            else
            {
                cb_SetTime.Enabled = false;
                btn_SetTime.Enabled = false;
                cb_SetTime.Text = "";
            }
        }

        private void rb_SetDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_SetDate.Checked == true)
            {
                dtp_SetDate.Enabled = true;
            }
            else
            {
                dtp_SetDate.Enabled = false;
            }

        }

        private void AccountForm_Load(object sender, EventArgs e)
        {

        }

    }
}
