using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBClass;

namespace MailRecord
{
    public partial class RecordEdit : Form
    {
        public ListViewItem _item = null;
        public string isFW = "";
        public string sendTo = "";

        public RecordEdit()
        {
            InitializeComponent();
        }

        public RecordEdit(ListViewItem item)
        {
            InitializeComponent();
            _item = item;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (!(checkBox1.Checked | checkBox2.Checked | checkBox3.Checked | checkBox4.Checked | checkBox5.Checked | checkBox6.Checked) ^ radioButton2.Checked)
            {
                MessageBox.Show("是否转发与发送单位选中的值相悖！", "转发错误");
                return;
            }
            if (tb_Title.Text == "" | cb_Conductor.Text == "")
            {
                MessageBox.Show("标题或者处理没有填写完整！", "未填完整");
                return;
            }

            updateItem();//更新item
            Record re = new Record();
            re.updateRecordByItem(_item);

            this.Close();
        }

        private void RecordEdit_Load(object sender, EventArgs e)
        {
            string[] ss = DBClass.Froms.GetAllFromsArray();
            cb_Conductor.Items.AddRange(ss);
            if (_item != null)
            {
                tb_Title.Text = _item.SubItems[2].Text;
                tb_FromName.Text = _item.SubItems[3].Text;
                tb_No.Text = _item.SubItems[4].Text;
                cb_Conductor.Text = _item.SubItems[6].Text;
                isFW = _item.SubItems[7].Text;
                sendTo = _item.SubItems[8].Text;
                tb_other.Text = _item.SubItems[9].Text;

                setIsFW(isFW);
                setSendTo(sendTo);
            }
        }

        private void updateItem()
        {
            if (radioButton1.Checked)
                isFW = "是";
            else
                isFW = "否";
            sendTo = getSendTo();

            _item.SubItems[2].Text = tb_Title.Text;
            _item.SubItems[3].Text = tb_FromName.Text;
            _item.SubItems[4].Text = tb_No.Text;
            _item.SubItems[6].Text = cb_Conductor.Text;
            _item.SubItems[7].Text = isFW;
            _item.SubItems[8].Text = sendTo;
            _item.SubItems[9].Text = tb_other.Text;
        }


        private void setIsFW(string isFW)
        {
            if (isFW == "是")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
        }


        private void setSendTo(string sendTo)
        {
            if (sendTo != "")
            {
                string[] ss = sendTo.Split(';');
                for (int i = 0; i < ss.Length; i++)
                {
                    if (ss[i] == "新津技术科")
                        checkBox1.Checked = true;
                    else if (ss[i] == "广汉技术科")
                        checkBox2.Checked = true;
                    else if (ss[i] == "洛阳技术科")
                        checkBox3.Checked = true;
                    else if (ss[i] == "绵阳技术科")
                        checkBox4.Checked = true;
                    else if (ss[i] == "遂宁技术科")
                        checkBox5.Checked = true;
                    else if (ss[i] == "修理厂技术科")
                        checkBox6.Checked = true;
                }
            }
        }
        private string getSendTo()
        {
            List<string> sendTo = new List<string>();
            if (checkBox1.Checked == true)
                sendTo.Add("新津技术科");
            if (checkBox2.Checked == true)
                sendTo.Add("广汉技术科");
            if (checkBox3.Checked == true)
                sendTo.Add("洛阳技术科");
            if (checkBox4.Checked == true)
                sendTo.Add("绵阳技术科");
            if (checkBox5.Checked == true)
                sendTo.Add("遂宁技术科");
            if (checkBox6.Checked == true)
                sendTo.Add("修理厂技术科");
            string[] ss = sendTo.ToArray();
            if (ss.Length > 0)
                return String.Join(";", ss);
            return "";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
