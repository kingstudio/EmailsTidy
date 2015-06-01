using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBHelp;
using System.Data;
using System.Windows.Forms;
using DBClass;

namespace Common
{
    public class AutoTidy
    {
        public Access ac;
        private List<ListViewItem> m_hListViewItems;
        private string[] m_allFromMails;
        public AutoTidy()
        {
            ac = new Access();            
        }

        public string[] getAllFromMails()
        {
            DataSet ds = ac.GetDataSet("select * from [allFromMail]");
            DataTable dt = ds.Tables[0];
            //定义数组长度
            m_allFromMails = new string[dt.Rows.Count];

            //遍历行
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                m_allFromMails[i] = dr[0].ToString();
            }
            return m_allFromMails;
        }

        public void Dotidy(int lastID)
        {
            ListViewItem item = null;            
            Mails ma = new Mails();
            m_hListViewItems = ma.GetMailsBySQL("select * from mail where status = 0 order by recievedate ASC");

            this.getAllFromMails();//给m_allFromMails赋值

            for (int i = 0; i < m_hListViewItems.Count; i++)
            {
                item = m_hListViewItems[i];
                string id = item.SubItems[0].Text;
                //判断发件人是否为要统计发件人范围内的人
                if (DBClass.Common.checkStringInArray(DBClass.Common.getContactMail(item.SubItems[3].Text), m_allFromMails))
                {
                    //若需要整理，先识别发件人和收件人
                    ma.setMailSendAndFromName(id, ++lastID);
                }
                else
                {
                    ma.setRecordFasleAndDelete(id);
                }
            }
            saveLastID(lastID);
        }


        private void saveLastID(int lid)
        {
            string Current;
            string filePath;
            Current = System.IO.Directory.GetCurrentDirectory();//获取当前根目录
            filePath = Current + "/config.ini";

            IniConfig ini = new IniConfig(filePath);
            // 写入ini
            ini.Writue("Setting", "LastID", Convert.ToString(lid));

        }
    }
}
