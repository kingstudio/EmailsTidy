using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DBClass
{
    public class Common
    {
        public static string ReplaceSQLChar(string str)
        {
            if (str == String.Empty)
                return String.Empty; 
            str = str.Replace("'", "‘");
            str = str.Replace(";", "；");
            str = str.Replace(",", "，");
            str = str.Replace("?", "？");
            str = str.Replace("<", "＜");
            str = str.Replace(">", "＞");
            str = str.Replace("(", "（");
            str = str.Replace(")", "）");
            str = str.Replace("@", "＠");
            str = str.Replace("=", "＝");
            str = str.Replace("+", "＋");
            str = str.Replace("*", "＊");
            str = str.Replace("&", "＆");
            str = str.Replace("#", "＃");
            str = str.Replace("%", "％");
            str = str.Replace("$", "￥");
            return str;
        }

        public static string getContacts(string source)
        {
            string co = "";
            try
            {
                string[] strss = source.Split(',');
                foreach (string str in strss)
                {
                    if (str.Trim() != "")
                        co = co + getContact(str) + ";";
                }
            }
            catch (InvalidCastException e)
            {
                throw (e);
            }


            return co;
        }

        public static string getContact(string source)
        {
            string co = "";
            string name = "";
            string email = "";
            try
            {
                if (source.IndexOf('<') > -1)
                {
                    string[] strss = source.Split('<');
                    name = strss[0].Trim();
                    name = name.TrimStart('"');
                    name = name.TrimEnd('"');
                    email = strss[1].Trim();
                    email = email.TrimEnd('>');
                }
                else
                {
                    name = source;
                }
            }
            catch (InvalidCastException e)
            {
                throw (e);
            }
            co = Decoder(name);

            Contacts cons = new Contacts();
            string cos = cons.getUserNameBySend(co, email);

            return cos == "" ? co : cos;
        }

        public static string getContactName(string source)
        {
            string co = "";
            string name = "";
            string email = "";
            try
            {
                if (source.IndexOf('<') > -1)
                {
                    string[] strss = source.Split('<');
                    name = strss[0].Trim();
                    name = name.TrimStart('"');
                    name = name.TrimEnd('"');
                    email = strss[1].Trim();
                    email = email.TrimEnd('>');
                }
                else
                {
                    name = source;
                }
            }
            catch (InvalidCastException e)
            {
                throw (e);
            }
            co = Decoder(name);

            Contacts cons = new Contacts();
            co = cons.getUserNameBySend(co, email);

            return co;
        }

        public static string getContactName(string address, string id)
        {
            string co = "";
            //Console.WriteLine("开始运行签名查询");

            ListViewItem it = Mails.getMailById(id);

            Contacts cons = new Contacts();
            co = cons.getUserNameBySignature(address, it.SubItems[7].Text);

            if (co == "")
            {
                Console.WriteLine(it.SubItems[4].Text);
                co = cons.getUserNameByTitle(address, it.SubItems[4].Text);
            }

            if (co == "")
            {
                Console.WriteLine(it.SubItems[7].Text);
                co = cons.getUserNameByContent(address, it.SubItems[7].Text);
            }

            return co;
        }

        public static string getContactMail(string source)
        {
            string name = "";
            string email = "";
            try
            {
                if (source.IndexOf('<') > -1)
                {
                    string[] strss = source.Split('<');
                    email = strss[1].Trim();
                    email = email.TrimStart('<');
                    email = email.TrimEnd('>');
                }
                else
                {
                    name = source;
                }
            }
            catch (InvalidCastException e)
            {
                throw (e);
            }
            return email;
        }

        public static string Decoder(string source)
        {
            if (checkSubject(source))
            {
                string strlast = "";
                try
                {
                    string[] strss = source.Split('?');
                    Console.WriteLine(strss[3]);

                    if (strss[2].ToLower() == "q")
                    {
                        DecodeQP decode = new DecodeQP();
                        strlast = decode.ConvertHexContent(strss[3], Encoding.GetEncoding(tinyCharset(strss[1])), 0);
                    }
                    else if (strss[2].ToLower() == "b")
                    {
                        try
                        {
                            string temp = strss[3];
                            if (temp.Length % 4 != 0)
                            {
                                temp = temp.Substring(0, temp.Length - 1);
                            }
                            Console.WriteLine(temp);
                            byte[] outputb = Convert.FromBase64String(temp);
                            strlast = Encoding.GetEncoding(tinyCharset(strss[1])).GetString(outputb);
                        }

                        catch (InvalidCastException e)
                        {
                            throw (e);
                        }
                    }
                    else
                    {
                        byte[] outputb = Convert.FromBase64String(strss[3]);
                        strlast = Encoding.GetEncoding(tinyCharset(strss[1])).GetString(outputb);
                    }
                    Console.WriteLine(strlast);
                }
                catch (InvalidCastException e)
                {
                    throw (e);
                }
                return strlast;
            }
            else
            {
                //IdentifyEncoding ide = new IdentifyEncoding();
                //string code = ide.GetEncodingName(IdentifyEncoding.ToSByteArray(System.Text.Encoding.GetEncoding("UTF-8").GetBytes(source)));
                //Console.WriteLine(code);
                //Byte[] outputb = System.Text.Encoding.GetEncoding(code).GetBytes(source);
                //source = System.Text.Encoding.GetEncoding("UTF-8").GetString(outputb);
                return source;
            }
        }

        public static string[] getSendAndSignature(string source)
        {
            string[] co = new string[4];
            string send = "";
            string signature = "";
            string title = "";
            string content = "";
            try
            {
                if (source.IndexOf(';') > -1)
                {
                    string[] strss = source.Split(';');
                    for (int i = 0; i < strss.Length; i++)
                    {
                        if (strss[i] != "")
                        {
                            string[] ss = strss[i].Split('=');
                            if (ss[0] == "Send")
                            {
                                send = ss[1];
                            }
                            else if (ss[0] == "Signature")
                            {
                                signature = ss[1];
                            }
                            else if (ss[0] == "Title")
                            {
                                title = ss[1];
                            }
                            else if (ss[0] == "Content")
                            {
                                content = ss[1];
                            }
                        }
                    }
                }
                else
                {
                    string[] ss = source.Split('=');
                    if (ss[0] == "Send")
                    {
                        send = ss[1];
                    }
                    else if (ss[0] == "Signature")
                    {
                        signature = ss[1];
                    }
                    else if (ss[0] == "Title")
                    {
                        title = ss[1];
                    }
                    else if (ss[0] == "Content")
                    {
                        content = ss[1];
                    }
                }
            }
            catch (InvalidCastException e)
            {
                throw (e);
            }
            co[0] = send;
            co[1] = signature;
            co[2] = title;
            co[3] = content;

            //Console.WriteLine(send);
            //Console.WriteLine(signature);
            return co;
        }

        private static string tinyCharset(string charset)
        {
            charset = charset.ToUpper();
            if (charset == "UTF8")
                return "UTF-8";
            return charset;
        }

        private static bool checkSubject(string subject)
        {
            subject = subject.ToLower();
            string[] f = new string[] { "utf-8", "utf8", "gbk", "gb2312", "big5" };
            for (int i = 0; i < f.Count(); i++)
            {
                if (subject.IndexOf(f[i]) > -1)
                    return true;
            }
            return false;
        }

        public static void changeListView(ListView lv)
        {
            for (int i = 0; i < lv.Items.Count; i++)
            {
                string rec = lv.Items[i].SubItems[0].Text;
                string fro = lv.Items[i].SubItems[1].Text;

                rec = Common.getContacts(rec);
                fro = Common.getContacts(fro);

                lv.Items[i].SubItems[0].Text = rec;
                lv.Items[i].SubItems[1].Text = fro;

            }
        }

        public static bool checkStringInArray(string s, string[] ss)
        {
            for (int i = 0; i < ss.Length; i++)
            {
                if (s == ss[i])
                    return true;
            }
            return false;
        }

        public static bool checkArrayInArray(string[] s1, string[] s2)
        {
            for (int m = 0; m < s2.Length; m++)
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s2[m] == s1[i])
                        return true;
                }
            }
            return false;
        }

        public static string[] getSameAndDiffArray(string[] s1, string[] s2)
        {
            string[] re = new string [2];
            List<string> rec = new List<string>();
            List<string> oth = new List<string>();
            int n = 0;
            bool flag = false;
            for (int m = 0; m < s2.Length; m++)
            {
                flag = false;
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s2[m] == s1[i])
                    {
                        flag = true;
                        rec.Add(s2[m]);
                        break;
                    }
                }
                if (!flag)
                {
                    if (s2[m] != "发文登记")
                        oth.Add(s2[m]);
                }
            }
            re[0] = string.Join(";", rec.ToArray());
            re[1] = string.Join(";", oth.ToArray());
            return re;
        }

        public static string getNoByTitle(string title)
        {
            string re = "";
            Match match = Regex.Match(title, @"\d{4}JSK\d{3}");
            if (match.Success)
            {
                re = match.Groups[0].Value;
            }
            else
            {
                match = Regex.Match(title, @"MA600[A-Za-z0-9_ -]+");
                if (match.Success)
                {
                    re = match.Groups[0].Value;
                }
                else
                {
                    match = Regex.Match(title, @"(SB|JWC|CFED|EMC|CAD|TB|CEB|CSL|BHT|GHN)[A-Za-z0-9_ -]+");
                    if (match.Success)
                    {
                        re = match.Groups[0].Value;
                    }
                    else
                    {
                        match = Regex.Match(title, @"\d{2}-\d{4}");
                        if (match.Success)
                        {
                            re = match.Groups[0].Value;
                        }
                    }
                }
            }
            return re;
        }

        public static string getFromName(string title)
        {
            title = title.ToUpper();
            string re = "";
            Match match = Regex.Match(title, @"(AVIALL|SIKORSKY|LYCOMING|GARMIN)");
            if (match.Success)
            {
                re = match.Groups[0].Value;
            }
            else
            {
                match = Regex.Match(title, @"MA600");
                if (match.Success)
                {
                    re = "西飞";
                }
                else
                {
                    re = "机务处";
                }
            }
            return re;
        }

        public static string getLastID()
        {
            Record rec = new Record();
            return rec.getLastID();
        }
    }
}
