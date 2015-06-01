using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBHelp;
using System.Data;
using System.Windows.Forms;

namespace DBClass
{
    public class Mails
    {
        List<ListViewItem> allMails = new List<ListViewItem>();

        public Mails() { }

        public List<ListViewItem> GetAllMails()
        {
            ListViewItem item = null;
            Access ac = new Access();
            DataSet ds = ac.GetDataSet("select * from mail where status > -1 order by recievedate DESC");
            DataTable dt = ds.Tables[0];

            Console.WriteLine(dt.Rows.Count);
            //遍历行
            foreach (DataRow dr in dt.Rows)
            {
                //遍历列
                item = new ListViewItem();
                for (int i = 0; i < dt.Columns.Count - 6; i++)
                {
                    if (i == 0)
                    {
                        item.SubItems[0].Text = dr[i].ToString();
                    }
                    else if (i == 1)
                    {
                        //不操作
                    }
                    else if (i == 2)
                    {
                        string rec = dr[11].ToString();
                        if (rec == "")
                        {
                            item.SubItems.Add(Common.getContacts(dr[i].ToString()));
                        }
                        else
                        {
                            item.SubItems.Add(rec);
                        }
                    }
                    else if (i == 3)
                    {
                        string fro = dr[12].ToString();
                        if (fro == "")
                        {
                            string na = Common.getContactName(dr[i].ToString());
                            if (na == "")
                            {
                                na = Common.getContactName(Common.getContactMail(dr[i].ToString()),dr[0].ToString());
                            }
                            item.SubItems.Add(na);
                        }
                        else
                        {
                            item.SubItems.Add(fro);
                        }
                    }
                    else
                    {
                        item.SubItems.Add(dr[i].ToString());
                    }
                }
                //增加status
                item.SubItems.Add(dr[10].ToString());
                allMails.Add(item);
            }
            return allMails;
        }

        public List<ListViewItem> GetMailsBySQL(string sql)
        {
            ListViewItem item = null;
            Access ac = new Access();
            DataSet ds = ac.GetDataSet(sql);
            DataTable dt = ds.Tables[0];

            Console.WriteLine(dt.Rows.Count);
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
                    else
                    {
                        item.SubItems.Add(dr[i].ToString());
                    }
                }
                allMails.Add(item);
            }
            return allMails;
        }

        public static ListViewItem getMailById(string id)
        {
            ListViewItem item = null;
            Access ac = new Access();
            DataSet ds = ac.GetDataSet("select * from mail where id = " + id);
            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
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

            }
            return item;
        }

        public string getContentById(string id)
        {
            string s = "";
            Access ac = new Access();
            DataSet ds = ac.GetDataSet("select * from mail where id = "+id);
            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                string body = dr[7].ToString();
                string bodyHtml = dr[8].ToString();

                if (body != "")
                    return body;
                else
                    return bodyHtml;
            }
            return s;
        }

        public void setRecordFasle(string id)
        {
            Access ac = new Access();
            string sql = @"update mail set IsRecord = false where ID = " + id;
            ac.ExecuteNonQuery(sql);
        }

        public void setRecordFasleAndDelete(string id)
        {
            Access ac = new Access();
            string sql = @"update mail set IsRecord = false, status = -1 where ID = " + id;
            ac.ExecuteNonQuery(sql);
        }

        public void setRecordTrue(string id)
        {
            Access ac = new Access();
            string sql = @"update mail set IsRecord = true where ID = " + id;
            ac.ExecuteNonQuery(sql);
        }

        public void setMailSendAndFromName(string id, int lastID)
        {
            ListViewItem item = getMailById(id);

            string rec = Common.getContacts(item.SubItems[2].Text);
            string fro = Common.getContactName(item.SubItems[3].Text);
            string ad = Common.getContactMail(item.SubItems[3].Text);//邮件地址
            if (fro == "")
            {
                fro = Common.getContactName(ad, id);
            }

            Access ac = new Access();
            string sql = @"update mail set status = 1, IsRecord = true, RecipientsName = '" + rec + "', FromName = '" + fro + "'  where ID = " + id;
            ac.ExecuteNonQuery(sql);

            //增加记录
            Record re = new Record();
            re.CreateRecord(id, lastID);
        }

        public static int getCountByMailID(string mailID)
        {
            Access ac = new Access();
            string sql = @"select * from mail where MailID = '" + mailID + "'";
            return ac.GetDataSet(sql).Tables[0].Rows.Count;
        }

    }
}
