using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Web;
using DBClass;

namespace MailsViewer
{
    public partial class MailViewer : Form
    {
        string mailID = "";//你要赋值的变量
        ListViewItem item = null;

        public MailViewer()
        {
            InitializeComponent();
        }

        public MailViewer(string ID)
        {
            InitializeComponent();
            this.mailID = ID;
            item = new ListViewItem();
            this.item = Mails.getMailById(ID);
        }

        public MailViewer(ListViewItem _item)
        {
            InitializeComponent();
            this.item = _item;
        }

        private void MailViewer_Load(object sender, EventArgs e)
        {
            l_Title.Text = this.item.SubItems[4].Text;
            l_Date.Text = this.item.SubItems[5].Text;
            l_Recipients.Text = this.item.SubItems[11].Text == "" ? DBClass.Common.getContacts(this.item.SubItems[2].Text) : this.item.SubItems[11].Text;
            l_Send.Text = this.item.SubItems[12].Text == "" ? DBClass.Common.getContactName(this.item.SubItems[3].Text) : this.item.SubItems[12].Text;
            rtb_Body.Text = this.item.SubItems[7].Text;
            SetHtmlMail(HttpUtility.HtmlDecode(this.item.SubItems[8].Text));
        }

        private void SetHtmlMail(string htmlBody)
        {
            string path = Application.StartupPath + "/mail.html";
            if (!System.IO.File.Exists(path))
            {
                System.IO.File.Create(path);//创建该文件  
            }
            WriteHtmlFile(path, htmlBody);
            wb_HtmlBody.Navigate(path);
        }

        public void WriteHtmlFile(string path, string body)
        {
            //----------生成htm文件------------------―― 
            try
            {
                using (StreamWriter sw = new StreamWriter("mail.html", false, System.Text.Encoding.GetEncoding("utf-8"))) //保存地址
                {
                    sw.WriteLine(body);
                    sw.Flush();
                    sw.Close();
                }
            }
            catch
            {
                //Response.Write("The file could not be wirte:");
            }
        }

        private void pb_Floder_Click(object sender, EventArgs e)
        {
            if (tlp_Mail.RowStyles[0].Height == 80)
            {
                pb_Floder.Image = MailsViewer.Properties.Resources.down;
                tlp_Mail.RowStyles[0].Height = 30;
            }
            else
            {
                pb_Floder.Image = MailsViewer.Properties.Resources.up;
                tlp_Mail.RowStyles[0].Height = 80;
            }
        }

    }
}
