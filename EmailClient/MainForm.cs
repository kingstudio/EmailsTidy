using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// 添加命名空间
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Net.Sockets;
using System.IO;
using jmail;
using System.Collections;
using System.Globalization;
//自己的类
using DBHelp;
using AutoUpdate;
using System.Web;
using System.Text.RegularExpressions;
using MailRecord;
using Common;
using DBClass;
using MailsViewer;
using System.Threading;

namespace EmailClient
{
    public partial class MainForm : Form
    {
        // 定义邮件发送类
        private SmtpClient smtpClient;
        private TcpClient tcpClient;
        private NetworkStream networkStream;
        private StreamReader streamReader;
        private StreamWriter streamWriter;


        // 下面是Dimac Jmail组件中的对象
        // 用来接收邮件
        // 定义 POP3Class这个类时需要设置下Jmail程序集的“嵌入互操作类型”属性为flase
        // 因为Jmail 是一个COM组件， 这样就存在.net平台下的代码（托管代码）与非托管代码的交互问题，也就是互操作性问题的
        // Visual Studio 默认的方式把加入的COM组件的“嵌入互操作类型”属性设置为true
        // 设置为true的含义就是编译过程中不引入互操作程序集， 只在托管代码中引入互操作类型，以至于编译过程中找不到该类的类型
        // 因为POP3Class类在引入的.Net类库中没有定义，它只在互操作程序集Jmail中定义的，所以要通过编译必须把“嵌入互操作类型”设置为false
        // 设置为false的含义就是引入互操作程序集到项目中，这样POP3Class类就可以到Jamil找到相应的类型了， 微软默认把“嵌入互操作类型”设置为true,
        // 也是有它的原因的——原因是微软希望减轻将COM 互操作程序集与您的应用程序一起部署的负担。
        // 有了以上的分析，大家应该可以明白“为什么”把这个属性设置为false后就不报错了
        // 如果大家还有什么疑问的话，可以看看CLR via C#的第一章来了解CLR的执行模型，同时也欢迎大家留言和我讨论

        // 定义接收邮件对象
        private POP3Class popClient;

        // 定义邮件信息接口
        private jmail.Message messageMail;

        // 定义邮件附件集合接口
        private Attachments attachments;

        // 定义邮件附件接口
        private jmail.Attachment attachment;

        //定义初始化数据
        private Config con = new Config();

        private List<ListViewItem> m_hListViewItems;
        private ListViewItem item;
        private MySorter mySorter;

        public string recieveDefault = "";
        public string recieveTime = "";
        public string recieveAll = "";
        public string recieveDate = "";
        int lastID;

        public MainForm()
        {
            InitializeComponent();
            m_hListViewItems = new List<ListViewItem>();
            mySorter = new MySorter();
        }

        public List<ListViewItem> GetAllListViewItems()
        {
            Mails ma = new Mails();
            return ma.GetAllMails();
        }

        public List<ListViewItem> GetAllListViewItems(POP3Class popClient)
        {
            List<ListViewItem> items = new List<ListViewItem>();
            ListViewItem item = null;
            string s_dt = DESEncrypt.Decrypt(this.recieveDate);
            Console.WriteLine(s_dt);
            DateTime dt_MAX;
            try
            {
                dt_MAX = Convert.ToDateTime(s_dt);
            }
            catch (Exception ex)
            {
                dt_MAX = DateTime.ParseExact(s_dt, "yyyy/M/d", System.Globalization.CultureInfo.CurrentCulture);
            }
            string s_m_dt = m_hListViewItems[0].SubItems[4].Text.Split(' ')[0];
            Console.WriteLine(s_m_dt);
            DateTime dt_Mail_MAX;
            try
            {
                dt_Mail_MAX = Convert.ToDateTime(s_m_dt);
            }
            catch (Exception ex)
            {
                dt_Mail_MAX = DateTime.ParseExact(s_m_dt, "yyyy/M/d", System.Globalization.CultureInfo.CurrentCulture);
            }
            dt_Mail_MAX = dt_Mail_MAX.AddDays(-3);
            Console.WriteLine(dt_Mail_MAX);

            for (int i = popClient.Count; i > 0; i--)
            {
                try
                {
                    messageMail = popClient.Messages[i];
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                    continue;
                }
                Console.WriteLine(recieveAll);
                if (recieveAll == "false")
                {
                    DateTime dt = Convert.ToDateTime(messageMail.Date.ToString());
                    Console.WriteLine(dt);
                    if (dt < dt_MAX || dt < dt_Mail_MAX)
                    {
                        Console.WriteLine("跳出收邮件");
                        break;
                    }
                }
                if (!(Mails.getCountByMailID(popClient.GetMessageUID(i)) > 0))
                {

                    item = new ListViewItem();
                    string cRecUser = "";
                    jmail.Recipients Rpents = messageMail.Recipients;
                    for (int m = 0; m < Rpents.Count; m++)
                    {
                        string email = Rpents[m].EMail;
                        string name = Rpents[m].Name;
                        if (null == name)
                        {
                            Console.WriteLine(email);
                            if (email.IndexOf('<') > -1)
                            {
                                string[] strss = email.Split('<');
                                name = strss[0].Trim();
                                name = name.Replace(",", "，");
                                name = name.TrimStart('"');
                                name = name.TrimEnd('"');
                                name = name.Replace("'", "");
                                email = strss[1].Trim();
                                email = email.TrimEnd('>');
                            }
                            else
                            {
                                name = email;
                                name = name.Replace("'", "");
                            }
                        }
                        Regex r = new Regex("^\\s*([A-Za-z0-9_-]+(\\.\\w+)*@(\\w+\\.)+\\w{2,5})\\s*$");
                        if (r.IsMatch(email))
                        {
                            cRecUser += name + "<" + email + ">,";
                        }
                    }
                    item.SubItems[0].Text = cRecUser.Replace("'", "");
                    item.SubItems.Add(messageMail.Headers.GetHeader("From"));
                    string subject = messageMail.Headers.GetHeader("Subject");
                    Console.WriteLine(subject);
                    item.SubItems.Add(DBClass.Common.Decoder(subject));
                    item.SubItems.Add(messageMail.Date.ToString());
                    attachments = messageMail.Attachments;
                    if (attachments.Count > 0)
                    {
                        item.SubItems.Add(attachments.Count.ToString());
                    }
                    else
                    {
                        item.SubItems.Add("无");
                    }
                    item.SubItems.Add(messageMail.Body);
                    item.SubItems.Add(messageMail.HTMLBody);

                    Access ac = new Access();
                    string sql = @"insert into mail([MailID], [Recipients], [From], [Subject], [RecieveDate], [Attachment], [Body], [BodyHtml], [IsRecord], [Status]) values ('" + popClient.GetMessageUID(i) + "', '" + item.SubItems[0].Text + "', '" + item.SubItems[1].Text + "', '" + DBClass.Common.ReplaceSQLChar(item.SubItems[2].Text) + "', '" + item.SubItems[3].Text + "', '" + item.SubItems[4].Text + "', '" + DBClass.Common.ReplaceSQLChar(item.SubItems[5].Text) + "', '" + HttpUtility.HtmlEncode(item.SubItems[6].Text) + "', false, 0)";
                    ac.ExecuteNonQueryAndGetIdentity(sql);

                }

                Console.WriteLine("一次");
            }

            Mails ma = new Mails();
            items = ma.GetAllMails();

            return items;
        }

        private void getMailList()
        {
            login();//先登录

            // 实例化邮件接收类POP3Class
            popClient = new POP3Class();
            // 连接服务器
            popClient.Connect(con.userName, con.passWord, con.popAddress, Convert.ToInt32(con.popPort));
            if (popClient != null)
            {
                if (popClient.Count > 0)
                {
                    this.m_hListViewItems = this.GetAllListViewItems(popClient);
                }
            }
            popClient.Disconnect();
        }

        private void LoadListViewItems(List<ListViewItem> items)
        {
            if (items == null)
            {
                tssl_Information.Text = "当前总共记录数为：0";
                return;
            }

            lv_MailList.VirtualListSize = items.Count;
            lv_MailList.VirtualMode = true;
            lv_MailList.RetrieveVirtualItem += new RetrieveVirtualItemEventHandler(listView_RetrieveVirtualItem);

            tssl_Information.Text = "当前总共记录数为：" + items.Count;
        }

        void listView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            e.Item = m_hListViewItems[e.ItemIndex];
        }

        private void tsmi_Account_Click(object sender, EventArgs e)
        {
            AccountForm account = new AccountForm(this);
            account.ShowDialog();
        }

        private void tsb_Receive_Click(object sender, EventArgs e)
        {
            if (tsb_Receive.Text == "接收")
            {
                tsb_Receive.Image = EmailClient.Properties.Resources.stop;
                tsb_Receive.Text = "停止";
                if (bw_LoadData.IsBusy != true)
                {
                    bw_LoadData.RunWorkerAsync();
                }
            }
            else
            {
                tsb_Receive.Image = EmailClient.Properties.Resources.receive;
                tsb_Receive.Text = "接收";
                bw_LoadData.CancelAsync();
            }

        }

        private void login()
        {
            if (tcpClient != null)
            {
                tcpClient.Close();
            }
            if (smtpClient != null)
            {
                smtpClient.Dispose();
            }
            // 与POP3服务器建立TCP连接
            // 建立连接后把服务器上的邮件下载到本地
            // 设置当前界面的光标为等待光标（就是我们看到的一个动的圆形）
            try
            {
                // POP3服务器通过监听TCP110端口来提供POP3服务的
                // 向POP3服务器发出tcp请求
                tcpClient = new TcpClient(con.popAddress, Convert.ToInt32(con.popPort));
                Console.WriteLine("正在连接...");
            }
            catch (InvalidCastException e)
            {
                throw (e);
            }

            // 连接成功的情况
            networkStream = tcpClient.GetStream();
            streamReader = new StreamReader(networkStream, Encoding.Default);
            streamWriter = new StreamWriter(networkStream, Encoding.Default);
            streamWriter.AutoFlush = true;
            string str;
            // 读取服务器返回的响应连接信息
            str = GetResponse();
            if (CheckResponse(str) == false)
            {
                Console.WriteLine("服务器拒接了连接请求");
                return;
            }
            // 如果服务器接收请求
            // 向服务器发送凭证——用户名和密码

            // 向服务器发送用户名，请求确认
            Console.WriteLine("核实用户名阶段...");
            SendToServer("USER " + con.userName);
            str = GetResponse();
            if (CheckResponse(str) == false)
            {
                Console.WriteLine("用户名错误.");
                return;
            }

            // 用户名审核通过后再发送密码等待确认
            // 向服务器发送密码，请求确认
            SendToServer("PASS " + con.passWord);
            str = GetResponse();
            if (CheckResponse(str) == false)
            {
                Console.WriteLine("密码错误！");
                return;
            }

            Console.WriteLine("身份验证成功，可以开始会话");
            // 向服务器发送LIST 命令，请求获得邮件列表和大小
            Console.WriteLine("获取邮件....");
            SendToServer("LIST");
            str = GetResponse();
            if (CheckResponse(str) == false)
            {
                Console.WriteLine("获取邮件列表失败");
                return;
            }

            Console.WriteLine("邮件获取成功");


            // 登陆成功后实例化邮件发送对象，以便后面完成发送邮件的操作
            // 实例化邮件发送类（SmtpClient）对象
            if (smtpClient == null)
            {
                smtpClient = new SmtpClient();
                smtpClient.Host = con.smtpAddress;
                smtpClient.Port = Convert.ToInt32(con.smtpPort);

                // 不使用默认凭证，即需要认证登陆
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(con.userName, con.passWord);
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            }

            // 登陆成功后，自动接收新邮件
            // 开始接收邮件

            Console.WriteLine("登陆成功!");

        }
        #region 处理与POP3服务器交互事件
        // 获取服务器响应的信息
        private string GetResponse()
        {
            string str = null;
            try
            {
                str = streamReader.ReadLine();
                if (str == null)
                {
                    Console.WriteLine("连接失败——服务器没有响应");
                }
                else
                {
                    Console.WriteLine("收到：[" + str + "]");
                    if (str.StartsWith("-ERR"))
                    {
                        str = null;
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("连接失败：[" + err.Message + "]");
            }

            return str;
        }

        // 检查响应信息
        private bool CheckResponse(string responseString)
        {
            if (responseString == null)
            {
                return false;
            }
            else
            {
                if (responseString.StartsWith("+OK"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // 向服务器发送命令
        private bool SendToServer(string str)
        {
            try
            {
                // 这里必须使用WriteLine方法的，因为POP3协议中定义的命令是以回车换行结束的
                // 如果客户端发送的命令没有以回车换行结束，POP3服务器就不能识别，也就不能响应客户端的请求了
                // 如果想用Write方法，则str输入的参数字符中必须包含“\r\n”,也就是回车换行字符串。
                streamWriter.WriteLine(str);
                streamWriter.Flush();
                Console.WriteLine("发送：[" + str + "]");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("发送失败：[" + ex.Message + "]");
                return false;
            }
        }

        #endregion

        private void bw_LoadData_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                getMailList();
            }
            catch (InvalidCastException ex)
            {
                throw (ex);
            }
        }

        private void bw_LoadData_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bw_LoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            LoadListViewItems(this.m_hListViewItems);
            tsb_Receive.Image = EmailClient.Properties.Resources.receive;
            tsb_Receive.Text = "接收";
        }

        private void bw_AutoTidy_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                AutoTidy at = new AutoTidy();
                at.Dotidy(lastID);
            }
            catch (InvalidCastException ex)
            {
                throw (ex);
            }
        }

        private void bw_AutoTidy_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tsb_AutoTidy.Image = EmailClient.Properties.Resources.tidy;
            tsb_AutoTidy.Text = "自动整理";
            //重新加载
            this.m_hListViewItems = this.GetAllListViewItems();
            LoadListViewItems(this.m_hListViewItems);
        }

        private void bw_AutoTidy_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 20);
            lv_MailList.SmallImageList = imgList;


            lv_MailList.Columns.Add("ID", 0, HorizontalAlignment.Left);
            lv_MailList.Columns.Add("收件人", 200, HorizontalAlignment.Left);
            lv_MailList.Columns.Add("发件人", 100, HorizontalAlignment.Left);
            lv_MailList.Columns.Add("邮件主题", 550, HorizontalAlignment.Left);
            lv_MailList.Columns.Add("时间", 120, HorizontalAlignment.Left);
            lv_MailList.Columns.Add("附件", 50, HorizontalAlignment.Left);
            lv_MailList.Columns.Add("状态", 50, HorizontalAlignment.Left);

            this.m_hListViewItems = this.GetAllListViewItems();
            LoadListViewItems(this.m_hListViewItems);

            //Common.changeListView(lv_MailList);//改变名称


            initial();
        }

        public void initial()
        {
            //邮箱登录
            //login();

            string Current;
            string filePath;
            Current = System.IO.Directory.GetCurrentDirectory();//获取当前根目录
            filePath = Current + "/config.ini";
            if (!System.IO.File.Exists(filePath))
            {
                System.IO.File.Create(filePath);//创建该文件  
            }

            IniConfig ini = new IniConfig(filePath);

            //读取邮件
            recieveDefault = ini.ReadValue("Setting", "recieveDefault");
            recieveTime = ini.ReadValue("Setting", "recieveTime");
            recieveAll = ini.ReadValue("Setting", "recieveAll");
            recieveDate = ini.ReadValue("Setting", "recieveDate");
            string lID = ini.ReadValue("Setting", "lastID");
            lID = lID == "" ? DBClass.Common.getLastID() : lID;
            lID = lID == "" ? "6601" : lID;
            lastID = Convert.ToInt32(lID);

        }

        private void lv_MailList_ColumnClick(object sender, ColumnClickEventArgs e)
        {

            if (e.Column == mySorter.ColumnIndex)
            {
                mySorter.SortOrder = (
                    mySorter.SortOrder == SortOrder.Descending ?
                    SortOrder.Ascending : SortOrder.Descending);
            }
            else
            {
                mySorter.SortOrder = SortOrder.Ascending;
                mySorter.ColumnIndex = e.Column;
            }

            m_hListViewItems.Sort(mySorter);

            lv_MailList.Invalidate();
        }

        private void lv_MailList_DoubleClick(object sender, EventArgs e)
        {
            // 登陆成功后 popClient的连接就一直保持着，因此无须重复连接
            if (lv_MailList.SelectedIndices.Count == 0)
            {
                MessageBox.Show("请先选择阅读的邮件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int index = m_hListViewItems[lv_MailList.SelectedIndices[0]].Index;
            string id = lv_MailList.Items[index].SubItems[0].Text;
            Console.WriteLine("ID:" + id);
            MailViewer viewer = new MailViewer(id);
            viewer.Show();
        }

        private void tsmi_CheckUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdate autoupdate = new FrmUpdate();
            autoupdate.Show();
        }

        private void tsmi_Address_Click(object sender, EventArgs e)
        {
            ContactForm cf = new ContactForm();
            cf.Show();
        }

        private void tsmi_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lv_MailList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tsb_AutoTidy_Click(object sender, EventArgs e)
        {
            if (tsb_AutoTidy.Text == "自动整理")
            {
                tsb_AutoTidy.Image = EmailClient.Properties.Resources.stop;
                tsb_AutoTidy.Text = "停止整理";

                if (bw_AutoTidy.IsBusy != true)
                {
                    bw_AutoTidy.RunWorkerAsync();
                }
            }
            else
            {
                tsb_AutoTidy.Image = EmailClient.Properties.Resources.tidy;
                tsb_AutoTidy.Text = "自动整理";
                bw_AutoTidy.CancelAsync();
            }
        }

        private void tsmi_MailRecord_Click(object sender, EventArgs e)
        {
            RecordForm re = new RecordForm();
            re.Show();
        }

        private void tsmi_tidyCurrent_Click(object sender, EventArgs e)
        {
            if (lv_MailList.SelectedIndices.Count == 0)
            {
                MessageBox.Show("请先选择阅读的邮件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int index = m_hListViewItems[lv_MailList.SelectedIndices[0]].Index;
            string id = lv_MailList.Items[index].SubItems[0].Text;
            Mails ma = new Mails();
            ma.setMailSendAndFromName(id, lastID);

            this.m_hListViewItems = this.GetAllListViewItems();
            LoadListViewItems(this.m_hListViewItems);
        }

        private void tsmi_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog=new OpenFileDialog();
            openFileDialog.InitialDirectory=System.IO.Directory.GetCurrentDirectory();
            openFileDialog.Filter="邮件文件|*.eml|所有文件|*.*";
            openFileDialog.RestoreDirectory=true;
            openFileDialog.FilterIndex=1;

            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                string fName=openFileDialog.FileName;
                loadEMLByCDO(fName);
            }
        }

        private void loadEML(string sFile)
        {
            try
            {
                FileStream fs = File.Open(sFile, FileMode.Open, FileAccess.ReadWrite);
                EMLReader reader = new EMLReader(fs);
                fs.Close();
                fs.Dispose();

                Console.WriteLine(reader.From);
                Console.WriteLine(reader.Date);
                Console.WriteLine(reader.To);
                Console.WriteLine(reader.CC);

            }
            catch (System.IO.IOException err)
            {
                Console.WriteLine("File " + sFile + " is currently in use.");
            }
        }

        private void loadEMLByCDO(string sFile)
        {
            string file = sFile;
            CDO.Message oMsg = new CDO.Message();
            ADODB.Stream stm = null;
            //读取EML文件到CDO.MESSAGE，做分析的话，实际是用了下面的部分

            try
            {
                stm = new ADODB.Stream();
                stm.Open(System.Reflection.Missing.Value,
                ADODB.ConnectModeEnum.adModeUnknown,
                ADODB.StreamOpenOptionsEnum.adOpenStreamUnspecified,
                "", "");
                stm.Type = ADODB.StreamTypeEnum.adTypeBinary;//二进制方式读入

                stm.LoadFromFile(file); //将EML读入数据流

                oMsg.DataSource.OpenObject(stm, "_stream"); //将EML数据流载入到CDO.Message，要做解析的话，后面就可以了。

                item = new ListViewItem();
                item.SubItems[0].Text = "";
                item.SubItems.Add("");
                item.SubItems.Add(oMsg.To + "," + oMsg.CC);
                item.SubItems.Add(oMsg.From);
                item.SubItems.Add(oMsg.Subject);
                item.SubItems.Add(oMsg.ReceivedTime.ToString("yyyy/MM/dd hh:mm:ss"));
                item.SubItems.Add(oMsg.Attachments.Count.ToString());
                item.SubItems.Add(oMsg.TextBody);
                item.SubItems.Add(oMsg.HTMLBody);
                item.SubItems.Add("0");
                item.SubItems.Add("0");
                item.SubItems.Add(DBClass.Common.getContacts(oMsg.To + "," + oMsg.CC));
                item.SubItems.Add(DBClass.Common.getContactName(oMsg.From));
                
                MailViewer viewer = new MailViewer(item);
                viewer.Show();

                /*
                CDO.IBodyParts ip = oMsg.Attachments;
                int count = oMsg.Attachments.Count;
                if (count != 0)
                {
                    for (int i = 1; i <= count; i++)
                    {

                        ////获取到附件的文件名称+后缀
                        object FileName = oMsg.Attachments[i].FileName;
                        //object fileContext=oMsg.Attachments[i].GetStream();
                        //内容
                        oMsg.Attachments[i].SaveToFile(@"" + System.IO.Directory.GetCurrentDirectory() + FileName);
                        //ip.GetEnumerator().Current;
                    }
                    MessageBox.Show("下载完成，保存到："+System.IO.Directory.GetCurrentDirectory());
                }
                else
                {
                    MessageBox.Show("没有附件");
                }
                */
            }
            catch (IOException ex)
            {

            }
            finally
            {
                stm.Close();
            }
        }

        private void tsmi_Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            openFileDialog.Filter = "邮件文件|*.eml|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fName = openFileDialog.FileName;
                loadEMLByCDO(fName);
                Access ac = new Access();
                string sql = @"insert into mail([MailID], [Recipients], [From], [Subject], [RecieveDate], [Attachment], [Body], [BodyHtml], [IsRecord], [Status]) values ('', '" + item.SubItems[2].Text + "', '" + item.SubItems[3].Text + "', '" + DBClass.Common.ReplaceSQLChar(item.SubItems[4].Text) + "', '" + item.SubItems[5].Text + "', '" + item.SubItems[6].Text + "', '" + DBClass.Common.ReplaceSQLChar(item.SubItems[7].Text) + "', '" + HttpUtility.HtmlEncode(item.SubItems[8].Text) + "', false, 0)";
                ac.ExecuteNonQueryAndGetIdentity(sql);

                this.m_hListViewItems = this.GetAllListViewItems();
                LoadListViewItems(this.m_hListViewItems);
            }

        }

        private void tsmi_deleteCurrent_Click(object sender, EventArgs e)
        {
            if (lv_MailList.SelectedIndices.Count > 0)
            {
                //有选中
                DialogResult dr = MessageBox.Show("当前操作将删除此项目，数据将从数据库中删除，无法撤消！", "确认删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    //删除通讯录
                    int index = m_hListViewItems[lv_MailList.SelectedIndices[0]].Index;
                    string id = lv_MailList.Items[index].SubItems[0].Text;
                    Console.WriteLine("将:" + id + "拖入回收站");
                    Mails ma = new Mails();
                    ma.setRecordFasleAndDelete(id);

                    Console.WriteLine("将MID:" + id + "删除");
                    Record re = new Record();
                    re.deleteRecord(id);

                    m_hListViewItems.Remove(m_hListViewItems[lv_MailList.SelectedIndices[0]]);
                    lv_MailList.VirtualListSize = m_hListViewItems.Count;
                    lv_MailList.Invalidate();
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
    }
}
