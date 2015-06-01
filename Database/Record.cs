using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBHelp;
using System.Data;
using Database;

namespace DBClass
{
    public class Record
    {
        List<ListViewItem> record = new List<ListViewItem>();

        public Record() { }

        public void CreateRecord(string id, int lastID)
        {
            ListViewItem item = Mails.getMailById(id);
            if (!checkRecordById(id))
            {
                string recipients = item.SubItems[11].Text;
                string froms = item.SubItems[12].Text;
                string title = item.SubItems[4].Text;
                string recieveDate = item.SubItems[5].Text;
                string sendto = "";
                string oth = "";
                bool isfw = false;
                string[] allFroms = Recipients.GetAllRecipientsArray();
                string [] recis = recipients.Split(';');
                string no = Common.getNoByTitle(title);
                string fromName = Common.getFromName(title);

                if (Common.checkArrayInArray(allFroms, recis))
                {
                    isfw = true;
                    string[] sameAndDiff = Common.getSameAndDiffArray(allFroms, recis);
                    sendto = sameAndDiff[0];
                    createLinks(id, sendto);//Links表加上收件人的索引
                    oth = sameAndDiff[1];
                }
                else
                {
                    oth = recipients;
                }

                Access ac = new Access();
                string sql = @"insert into record([MID], [SID], [FromName], [No], [Title], [Conductor], [IsFW], [SendTo], [Other], [RecieveDate]) values (" + id + "," + lastID + ", '" + fromName + "', '" + no + "', '" + title + "', '" + froms + "', " + isfw + ", '" + sendto + "', '" + oth + "', '" + recieveDate + "')";
                ac.ExecuteNonQueryAndGetIdentity(sql);
            }
        }


        public List<ListViewItem> GetRecordBySQL(string sql)
        {
            ListViewItem item = null;
            Access ac = new Access();
            DataSet ds = ac.GetDataSet(sql);
            DataTable dt = ds.Tables[0];
            //遍历行
            foreach (DataRow dr in dt.Rows)
            {
                item = new ListViewItem();
                item.SubItems[0].Text = dr[1].ToString();
                item.SubItems.Add(dr[2].ToString());
                item.SubItems.Add(dr[3].ToString());
                item.SubItems.Add(dr[4].ToString());
                item.SubItems.Add(dr[5].ToString());
                item.SubItems.Add(dr[6].ToString());
                item.SubItems.Add(dr[7].ToString());
                item.SubItems.Add(Convert.ToBoolean(dr[8].ToString())?"是":"否");
                item.SubItems.Add(dr[9].ToString());
                item.SubItems.Add(dr[10].ToString());

                record.Add(item);
            }
            return record;

        }

        private void createLinks(string id, string sendTo)
        {
            string[] se = sendTo.Split(';');
            string sid;
            for (int i = 0; i < se.Length; i++)
            {
                Console.WriteLine(se[i]);
                sid = Recipients.getIDByName(se[i]);
                if(!Links.checkLinks(id, sid))
                    Links.createLinks(id, sid);
            }
        }

        public bool checkRecordById(string id)
        {
            Access ac = new Access();
            DataSet ds = ac.GetDataSet("select * from record where MID = " + id);
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        public string getLastID()
        {
            Access ac = new Access();
            DataSet ds = ac.GetDataSet("select SID from record where SID <> ''  order by recievedate DESC");
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count > 0)
                return dt.Rows[0][0].ToString();
            return "";
        }

        public void deleteRecord(string id)
        {
            Access ac = new Access();
            string sql = @"delete from record where MID = " + id;
            ac.ExecuteNonQuery(sql);
        }

        public string[] getSID(string id)
        {
            string [] ss = new string[2];
            Access ac = new Access();
            DataSet ds = ac.GetDataSet("select SID, recievedate from record where MID = " + id);
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count > 0)
            {
                ss[0] = dt.Rows[0][0].ToString();
                ss[1] = dt.Rows[0][1].ToString();
                return ss;
            }
            return ss;
        }

        public int reNumber(int lid, string s_dt)
        {
            int LastID = lid;
            string id;
            Access ac = new Access();
            DataSet ds = ac.GetDataSet("select MID  from record where recievedate > #" + s_dt + "#  order by recievedate ASC");
            DataTable dt = ds.Tables[0];
            int n = dt.Rows.Count;
            //Console.WriteLine(n);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    id = dt.Rows[i][0].ToString();
                    setRecordSID(id, ++LastID);
                    //Console.WriteLine(id + "" + LastID);
                }
            }
            return LastID;
        }

        public void setRecordSID(string id, int lid)
        {
            Access ac = new Access();
            string sql = @"update record set SID = " + lid + " where MID = " + id;
            ac.ExecuteNonQuery(sql);
        }

        public void updateRecordByItem(ListViewItem _item)
        {
            string mid = _item.SubItems[0].Text;
            string title = _item.SubItems[2].Text;
            string fromName = _item.SubItems[3].Text;
            string no = _item.SubItems[4].Text;
            string conductor = _item.SubItems[6].Text;
            string isFW = _item.SubItems[7].Text;
            if (isFW == "是")
                isFW = "true";
            else
                isFW = "false";
            string sendTo = _item.SubItems[8].Text;
            string other = _item.SubItems[9].Text;
            Access ac = new Access();
            string sql = @"update record set Title = '" + title + "', FromName = '" + fromName + "', [No] = '" + no + "', Conductor = '" + conductor + "', IsFW = " + isFW + ", SendTo = '" + sendTo + "', Other = '" + other + "' where MID = " + mid;
            Console.WriteLine(sql);
            ac.ExecuteNonQuery(sql);
        }

    }
}
