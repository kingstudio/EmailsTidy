using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//自己的类
using DBHelp;
using System.Text.RegularExpressions;

namespace EmailClient
{
    public partial class ContactForm : Form
    {

        public ContactForm()
        {
            InitializeComponent();
        }
        
        private void tsmi_Add_Click(object sender, EventArgs e)
        {
            tb_ID.Text = "";
            tb_UserName.Text = "";
            tb_MailAddress.Text = "";
            tb_Feature.Text = "";
            cb_IsNew.Checked = true;
        }

        private void tsmi_Update_Click(object sender, EventArgs e)
        {
            fillSelectRowData();
        }

        private void tsmi_Delete_Click(object sender, EventArgs e)
        {
            if (lv_Contact.SelectedItems.Count > 0)
            {
                //有选中
                DialogResult dr = MessageBox.Show("当前操作将删除此项目，数据将从数据库中删除，无法撤消！", "确认删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    Access ac = new Access();
                    //删除通讯录
                    string id = lv_Contact.SelectedItems[0].SubItems[0].Text;
                    Console.WriteLine("删除:"+id);
                    string sql = @"delete from contact where ID = " + id;
                    ac.ExecuteNonQuery(sql);
                    lv_Contact.Items.Remove(lv_Contact.SelectedItems[0]);
                }
                else
                {
                    Console.WriteLine("取消删除！");
                }
            }
            else
            {
                MessageBox.Show("未选中删除的项目，无法执行删除操作！", "删除出错！");                
            }
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {

            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 20);
            lv_Contact.SmallImageList = imgList;


            lv_Contact.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lv_Contact.Columns.Add("姓名", 80, HorizontalAlignment.Left);
            lv_Contact.Columns.Add("邮箱地址", 160, HorizontalAlignment.Left);
            lv_Contact.Columns.Add("分类规则", 100, HorizontalAlignment.Left);
            GetAllListViewItems();
        }

        public void GetAllListViewItems()
        {
            ListViewItem item = null;
            Access ac = new Access();
            DataSet ds = ac.GetDataSet("select * from contact order by ID ASC");
            DataTable dt = ds.Tables[0];

            Console.WriteLine(dt.Rows.Count);
            //遍历行
            lv_Contact.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                //遍历列
                item = new ListViewItem();
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (i == 0)
                    {
                        item.SubItems[0].Text = dr[i].ToString();
                    }
                    else
                    {
                        item.SubItems.Add(dr[i].ToString());
                    }
                }
                lv_Contact.Items.Add(item);
            }
        }

        private void cb_IsNew_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_IsNew.Checked == true)
            {
                tb_ID.Text = "";
            }
        }

        private void lv_Contact_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            fillSelectRowData();
        }

        private void fillSelectRowData()
        {
            tb_ID.Text = lv_Contact.SelectedItems[0].SubItems[0].Text;
            tb_UserName.Text = lv_Contact.SelectedItems[0].SubItems[1].Text;
            tb_MailAddress.Text = lv_Contact.SelectedItems[0].SubItems[2].Text;
            tb_Feature.Text = lv_Contact.SelectedItems[0].SubItems[3].Text;
            cb_IsNew.Checked = false;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            Access ac = new Access();
            if (cb_IsNew.Checked == true)
            {
                //新增通讯录

                //检验输入合法性
                if (tb_UserName.Text == "")
                {
                    MessageBox.Show("姓名未填写完整，无法执行新增操作！", "新增出错！");
                    return;
                }
                if (tb_MailAddress.Text == "")
                {
                    MessageBox.Show("邮箱地址未填写完整，无法执行新增操作！", "新增出错！");
                    return;
                }
                Regex r = new Regex("^\\s*([A-Za-z0-9_-]+(\\.\\w+)*@(\\w+\\.)+\\w{2,5})\\s*$");
                if (!r.IsMatch(tb_MailAddress.Text))
                {
                    MessageBox.Show("邮箱地址填写不合法，无法执行新增操作！", "新增出错！");
                    return;
                }
                string sql = @"insert into contact([UserName], [MailAddress], [Features]) values ('" + tb_UserName.Text + "', '" + tb_MailAddress.Text + "', '" + tb_Feature.Text + "')";
                ac.ExecuteNonQueryAndGetIdentity(sql);
            }
            else 
            {
                //修改通讯录
                if (tb_ID.Text == "")
                {
                    MessageBox.Show("未选中新增选框，无法执行新增操作！", "新增出错！");
                    return;
                }
                //检验输入合法性
                if (tb_UserName.Text == "")
                {
                    MessageBox.Show("姓名未填写完整，无法执行修改操作！", "修改出错！");
                    return;
                }
                if (tb_MailAddress.Text == "")
                {
                    MessageBox.Show("邮箱地址未填写完整，无法执行修改操作！", "修改出错！");
                    return;
                }
                Regex r = new Regex("^\\s*([A-Za-z0-9_-]+(\\.\\w+)*@(\\w+\\.)+\\w{2,5})\\s*$");
                if (!r.IsMatch(tb_MailAddress.Text))
                {
                    MessageBox.Show("邮箱地址填写不合法，无法执行修改操作！", "修改出错！");
                    return;
                }

                    string sql = @"update contact set UserName='" + tb_UserName.Text + "', MailAddress='" + tb_MailAddress.Text + "', Features='" + tb_Feature.Text + "' where ID = " + tb_ID.Text;
                    ac.ExecuteNonQueryAndGetIdentity(sql);
            }
            GetAllListViewItems();//刷新当前数据
        }
    }
}
