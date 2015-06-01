using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBHelp;
using System.Data;
using System.Windows.Forms;

namespace DBClass
{
    public class Contact
    {
        List<ListViewItem> mailSendNames = new List<ListViewItem>();
        public Contact() { }

        public List<ListViewItem> getMailSendNames(string ad)
        {
            string sql = @"select ID, UserName, Features from contact where MailAddress = '" + ad + "'";

            Access ac = new Access();
            DataSet ds = ac.GetDataSet(sql);
            DataTable dt = ds.Tables[0];

            ListViewItem item = null;
            //遍历行
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
                    else if(i == 1)
                    {
                        item.SubItems.Add(dr[i].ToString());
                    }
                    else if(i == 2)
                    {
                        //签名、标题、内容
                        string fe = dr[i].ToString();
                        if (fe == "")
                        {
                            item.SubItems.Add("");
                            item.SubItems.Add("");
                            item.SubItems.Add("");
                            item.SubItems.Add("");
                        }
                        else
                        {
                            string[] ss = Common.getSendAndSignature(fe);
                            item.SubItems.Add(ss[0]);
                            item.SubItems.Add(ss[1]);
                            item.SubItems.Add(ss[2]);
                            item.SubItems.Add(ss[3]);
                        }
                    }
                }
                mailSendNames.Add(item);
            }
            return mailSendNames;
        }

    }
}
