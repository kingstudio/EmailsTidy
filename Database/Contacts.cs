using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBClass
{
    public class Contacts
    {
        List<ListViewItem> mailSendNames = new List<ListViewItem>();
        public Contacts() { }

        public string getUserNameBySend(string name, string address)
        {
            ListViewItem item = null;
            Contact co = new Contact ();
            mailSendNames = co.getMailSendNames(address);

            for (int i = 0; i < mailSendNames.Count; i++)
            {
                item = mailSendNames[i];
                if (address != "cafcjsk@163.com")
                {
                    return item.SubItems[1].Text;
                }
                if (checkSend(name, item))
                {
                    return item.SubItems[1].Text;
                }
            }
            return "";
        }

        public string getUserNameBySignature(string address, string body)
        {
            ListViewItem item = null;
            Contact co = new Contact();
            mailSendNames = co.getMailSendNames(address);

            for (int i = 0; i < mailSendNames.Count; i++)
            {
                item = mailSendNames[i];
                string sig = item.SubItems[3].Text;
                if (sig != "")
                {
                    if (checkSignature(sig, body))
                    {
                        return item.SubItems[1].Text;
                    }
                }
            }
            return "";
        }

        public string getUserNameByTitle(string address, string title)
        {
            ListViewItem item = null;
            Contact co = new Contact();
            mailSendNames = co.getMailSendNames(address);

            for (int i = 0; i < mailSendNames.Count; i++)
            {
                item = mailSendNames[i];
                string sig = item.SubItems[4].Text;
                Console.WriteLine(sig);
                if (sig != "")
                {
                    if (checkTitle(sig, title))
                    {
                        return item.SubItems[1].Text;
                    }
                }
            }
            return "";
        }

        public string getUserNameByContent(string address, string content)
        {
            ListViewItem item = null;
            Contact co = new Contact();
            mailSendNames = co.getMailSendNames(address);

            for (int i = 0; i < mailSendNames.Count; i++)
            {
                item = mailSendNames[i];
                string sig = item.SubItems[5].Text;
                if (sig != "")
                {
                    if (checkContent(sig, content))
                    {
                        return item.SubItems[1].Text;
                    }
                }
            }
            return "";
        }

        public bool checkSignature(string sig, string body)
        {
            sig = sig.ToLower();
            body = body.ToLower();
            if (body.IndexOf(sig) > -1)
                return true;
            return false;
        }

        public bool checkTitle(string ti, string title)
        {
            title = title.ToLower();
            ti = ti.ToLower();
            if (title.IndexOf(ti) > -1)
                return true;
            return false;
        }

        public bool checkContent(string co, string content)
        {
            content = content.ToLower();
            co = co.ToLower();
            if (content.IndexOf(co) > -1)
                return true;
            return false;
        }

        public bool checkSend(string s, ListViewItem lvi)
        {
            if (s == lvi.SubItems[2].Text)
                return true;
            return false;
        }

    }
}
