using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using DBHelp;

namespace DBClass
{
    public class Froms
    {
        List<ListViewItem> allFroms = new List<ListViewItem>();

        public Froms() { }

        public List<ListViewItem> GetAllFroms()
        {
            ListViewItem item = null;
            Access ac = new Access();
            DataSet ds = ac.GetDataSet("select * from froms");
            DataTable dt = ds.Tables[0];
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
                allFroms.Add(item);
            }
            return allFroms;        
        }

        public static string [] GetAllFromsArray()
        {
            List<string> list = new List<string>();

            Access ac = new Access();
            DataSet ds = ac.GetDataSet("select [UserName] from froms");
            DataTable dt = ds.Tables[0];
            //遍历行
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr[0].ToString());
            }
            return list.ToArray();
        }

        public static string getIDByName(string name)
        {
            string re = "";
            Access ac = new Access();
            DataSet ds = ac.GetDataSet("select * from froms where UserName = '"+name+"'");
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count > 0)
                re = dt.Rows[0][0].ToString();
            return re;
        }
    }
}
