using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBClass;
using Common;
using MailsViewer;
using System.IO;
using System.Drawing.Printing;


namespace MailRecord
{
    public partial class RecordForm : Form
    {
        int curr = 1;
        List<ListViewItem> record = new List<ListViewItem>();
        private MySorter mySorter;
        private AsposeWordApp WordApp;
        private AsposePdfApp PdfApp;

        //PrintDocument类是实现打印功能的核心，它封装了打印有关的属性、事件、和方法
        PrintDocument printDocument = new PrintDocument();


        public RecordForm()
        {
            InitializeComponent();
            mySorter = new MySorter();
        }

        private void RecordForm_Load(object sender, EventArgs e)
        {
            resizeWindows();
            //上个月起始时间与结束时间
            FillLastMonthStartAndEnd(curr);

            loadFroms();
            loadRecipients();

            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 20);
            lv_Record.SmallImageList = imgList;

            lv_Record.Dock = DockStyle.Fill;
            lv_Record.Columns.Add("MID", 0, HorizontalAlignment.Left);
            lv_Record.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lv_Record.Columns.Add("标题/内容", 300, HorizontalAlignment.Left);
            lv_Record.Columns.Add("来文单位", 80, HorizontalAlignment.Left);
            lv_Record.Columns.Add("编号", 80, HorizontalAlignment.Left);
            lv_Record.Columns.Add("日期", 120, HorizontalAlignment.Left);
            lv_Record.Columns.Add("处理人", 50, HorizontalAlignment.Left);
            lv_Record.Columns.Add("转发", 50, HorizontalAlignment.Left);
            lv_Record.Columns.Add("收件人", 100, HorizontalAlignment.Left);
            lv_Record.Columns.Add("备注", 100, HorizontalAlignment.Left);


        }

        private void RecordForm_Resize(object sender, EventArgs e)
        {
            resizeWindows();
        }

        private void loadFroms()
        {
            TreeNode fr = tv_select.Nodes[0];
            Froms frs = new Froms();

            List<ListViewItem> allFroms = frs.GetAllFroms();

            Console.WriteLine(allFroms.Count);

            for (int i = 0; i < allFroms.Count; i++)
            {
                ListViewItem item = allFroms[i];
                TreeNode nodeSon = fr.Nodes.Add(item.SubItems[1].Text);
                nodeSon.Tag = item.SubItems[0].Text;
            }
        }

        private void loadRecipients()
        {
            TreeNode fr = tv_select.Nodes[1];
            Recipients recis = new Recipients();

            List<ListViewItem> allRecis = recis.GetAllRecipients();

            Console.WriteLine(allRecis.Count);

            for (int i = 0; i < allRecis.Count; i++)
            {
                ListViewItem item = allRecis[i];
                TreeNode nodeSon = fr.Nodes.Add(item.SubItems[1].Text);
                nodeSon.Tag = item.SubItems[0].Text;
            }
        }

        private void FillLastMonthStartAndEnd(int i)
        {
            DateTime lastMonthBegin = DateTime.Now.AddMonths(-i).AddDays(1 - DateTime.Now.Day);
            DateTime lastMonthEnd = DateTime.Now.AddMonths(-i + 1).AddDays(1 - DateTime.Now.Day);
            //DateTime lastMonthEnd = DateTime.Now.AddMonths(-i + 1).AddDays(-DateTime.Now.Day);

            dtp_from.Value = lastMonthBegin;
            dtp_To.Value = lastMonthEnd;
        }

        private void resizeWindows()
        {
            //左侧
            splitContainer1.SplitterDistance = 120;
            //控件居中
            l_time.Top = (p_top.Height - l_time.Height) / 2;
            dtp_from.Top = (p_top.Height - dtp_from.Height) / 2;
            l_middle.Top = (p_top.Height - l_middle.Height) / 2;
            dtp_To.Top = (p_top.Height - dtp_To.Height) / 2;
            cb_dt_switch.Top = (p_top.Height - cb_dt_switch.Height) / 2;
            tb_keywords.Top = (p_top.Height - tb_keywords.Height) / 2;
            b_query.Top = (p_top.Height - b_query.Height) / 2;
            //控件居右
            b_query.Left = p_top.Width - b_query.Width - 10;
            tb_keywords.Left = b_query.Left - tb_keywords.Width - 10;
        }

        private void tsb_next_Click(object sender, EventArgs e)
        {
            curr--;
            FillLastMonthStartAndEnd(curr);
        }

        private void tsb_prev_Click(object sender, EventArgs e)
        {
            curr++;
            FillLastMonthStartAndEnd(curr);
        }

        private void tv_select_DoubleClick(object sender, EventArgs e)
        {
            string sql = getSQL();
            Console.WriteLine(sql);
            loadData(sql);
        }

        public void loadData(string sql)
        {
            List<ListViewItem> records = new List<ListViewItem>();
            if (sql != "")
            {
                Record re = new Record();
                records = re.GetRecordBySQL(sql);
                if (records.Count > 0)
                {
                    this.record.Clear();
                    this.record = records;
                    LoadListViewItems(this.record);
                }
                else
                {
                    MessageBox.Show("没有找到相关记录！");
                }
            }
        }

        private string getSQL()
        {
            string start = dtp_from.Text;
            string end = dtp_To.Text;
            string sql = "";
            string key = tb_keywords.Text;
            if(cb_dt_switch.Checked)
                sql = @" recievedate between #" + start + "# and #" + end + "# ";
            if (key != "")
                sql += (sql == "" ? @" ([title] like '%" + key + "%' or [No] like '%" + key + "%') " : @" and (title like '%" + key + "%' or [No] like '%" + key + "%') ");

            if (tv_select.SelectedNode.Text == "发件人" | tv_select.SelectedNode.Text == "收件人")
            {
                if(sql !="")
                    sql = @"select * from record where " + sql + "order by recievedate ASC";
                else
                    sql = @"select * from record  order by recievedate ASC";

            }
            else
            {
                if (tv_select.SelectedNode.Parent.Text == "发件人")
                {
                    string na = tv_select.SelectedNode.Text.ToString();
                    if(sql != "")
                    sql = @"select * from record where Conductor = '" + na + "' and " + sql + " order by recievedate ASC";
                    else
                        sql = @"select * from record where Conductor = '" + na + "' order by recievedate ASC";

                }
                else if (tv_select.SelectedNode.Parent.Text == "收件人")
                {
                    string id = tv_select.SelectedNode.Tag.ToString();
                    if (sql != "")
                        sql = @"select * from allRecords where ReciID = " + id + " and " + sql + " order by recievedate ASC";
                    else
                        sql = @"select * from allRecords where ReciID = " + id + " order by recievedate ASC";
                }
            }
            return sql;
        }

        private void LoadListViewItems(List<ListViewItem> items)
        {
            lv_Record.VirtualListSize = items.Count;
            lv_Record.VirtualMode = true;
            lv_Record.RetrieveVirtualItem += new RetrieveVirtualItemEventHandler(listView_RetrieveVirtualItem);
            lv_Record.Invalidate();
        }

        void listView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            e.Item = record[e.ItemIndex];
        }

        private void lv_Record_ColumnClick(object sender, ColumnClickEventArgs e)
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

            record.Sort(mySorter);

            lv_Record.Invalidate();
        }

        private void lv_Record_DoubleClick(object sender, EventArgs e)
        {

            if (lv_Record.SelectedIndices.Count == 0)
            {
                MessageBox.Show("请先选择阅读的邮件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int index = record[lv_Record.SelectedIndices[0]].Index;
            string id = lv_Record.Items[index].SubItems[0].Text;
            Console.WriteLine("ID:" + id);
            MailViewer viewer = new MailViewer(id);
            viewer.Show();
        }

        private void b_query_Click(object sender, EventArgs e)
        {
            string sql = getSQL();
            Console.WriteLine(sql);
            loadData(sql);
        }

        private void tsb_SaveAsWord_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string start = dtp_from.Text;
            DateTime dt = DateTime.Parse(start);
            string fileName = dt.Year + "年" + dt.Month + "月";
            //创建WORD的对象类
            this.WordApp = new AsposeWordApp();
            this.WordApp.Docversion = 2003;
            //打开word
            this.WordApp.Open();
            this.WordApp.Builder();
            this.WordApp.setPaperSize("A4H");
            //标题
            string title = getTitle(1, fileName);
            this.WordApp.InsertText(title, 15, true, "center");
            this.WordApp.InsertRecordTable(this.record);
            this.WordApp.SetFooter();
            string strFileName = System.IO.Directory.GetCurrentDirectory() + "/export";
            if (Directory.Exists(strFileName) == false)//如果不存在就创建file文件夹
            {
                Directory.CreateDirectory(strFileName);
            }
            strFileName = System.IO.Directory.GetCurrentDirectory() + "/export/" + fileName;
            if (Directory.Exists(strFileName) == false)//如果不存在就创建file文件夹
            {
                Directory.CreateDirectory(strFileName);
            }

            strFileName += "/"+title.Replace('/', '_') + ".doc";
            this.WordApp.SaveAs(strFileName);
            this.Cursor = Cursors.Default;
        }
        
        private void tsb_SaveAsPDF_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string start = dtp_from.Text;
            DateTime dt = DateTime.Parse(start);
            string fileName = dt.Year + "年" + dt.Month + "月";
            //创建WORD的对象类
            this.PdfApp = new AsposePdfApp();
            this.PdfApp.Author = "Kingstudio";
            this.PdfApp.Subject = "Kingstudio";
            //打开word
            this.PdfApp.Open();
            this.PdfApp.setPaperSize("A4H");
            //标题
            string title = getTitle(2, fileName);
            this.PdfApp.InsertText(title, 15, true, "center");
            this.PdfApp.insertTable(this.record);
            this.PdfApp.SetFooter(fileName+getSelectName());
            string strFileName = System.IO.Directory.GetCurrentDirectory() + "/export";
            if (Directory.Exists(strFileName) == false)//如果不存在就创建file文件夹
            {
                Directory.CreateDirectory(strFileName);
            }
            strFileName = System.IO.Directory.GetCurrentDirectory() + "/export/" + fileName;
            if (Directory.Exists(strFileName) == false)//如果不存在就创建file文件夹
            {
                Directory.CreateDirectory(strFileName);
            }
            strFileName += "/" + title.Replace('/', '_') + ".pdf";
            this.PdfApp.SaveAs(strFileName);

            this.Cursor = Cursors.Default;
        }

        private string getTitle(int type, string fileName)
        {
            string key = tb_keywords.Text;
            string title = fileName;
            if (type == 1)
            {
                if (tv_select.SelectedNode.Text == "发件人" || tv_select.SelectedNode.Text == "收件人")
                {
                    title += "发文总记录";
                }
                else
                {
                    if (tv_select.SelectedNode.Parent.Text == "发件人" || tv_select.SelectedNode.Parent.Text == "收件人")
                    {
                        title += tv_select.SelectedNode.Text + "发文记录";
                    }
                }
            }
            else
            {
                if (tv_select.SelectedNode.Text == "发件人" || tv_select.SelectedNode.Text == "收件人")
                {
                    title += "机务处技术科发文回执";
                }
                else
                {
                    if (tv_select.SelectedNode.Parent.Text == "发件人" || tv_select.SelectedNode.Parent.Text == "收件人")
                    {
                        title += "机务处技术科发文回执 - " + tv_select.SelectedNode.Text;
                    }
                }
            }
            if (key != "")
                title += "（关键词：" + key + ")";
            return title;
        }

        private string getSelectName()
        {
            string re="";
            if (tv_select.SelectedNode.Text == "发件人" || tv_select.SelectedNode.Text == "收件人")
            {
                re += "所有单位";
            }
            else
            {
                if (tv_select.SelectedNode.Parent.Text == "发件人" || tv_select.SelectedNode.Parent.Text == "收件人")
                {
                    re +=  tv_select.SelectedNode.Text;
                }
            }
            return re;
        }
        private void tsmi_Delete_Click(object sender, EventArgs e)
        {
            if (lv_Record.SelectedIndices.Count > 0)
            {
                //有选中
                DialogResult dr = MessageBox.Show("当前操作将删除此项目，数据将从数据库中删除，无法撤消！", "确认删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    //删除通讯录
                    int index = record[lv_Record.SelectedIndices[0]].Index;
                    string id = lv_Record.Items[index].SubItems[0].Text;
                    Console.WriteLine("将:" + id + "拖入回收站");
                    Mails ma = new Mails();
                    ma.setRecordFasleAndDelete(id);

                    Console.WriteLine("将MID:" + id + "删除");
                    Record re = new Record();
                    re.deleteRecord(id);

                    record.Remove(record[lv_Record.SelectedIndices[0]]);
                    lv_Record.VirtualListSize = record.Count;
                    lv_Record.Invalidate();
                }
                else
                {
                    Console.WriteLine("取消删除！");
                }
            }
        }

        private void tsmi_Renumber_Click(object sender, EventArgs e)
        {
            if (lv_Record.SelectedIndices.Count > 0)
            {
                //有选中
                DialogResult dr = MessageBox.Show("当前操作将以此项为基准为之后项目ID重新排序，无法撤消！", "确认ID重新排序", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    int index = record[lv_Record.SelectedIndices[0]].Index;
                    string id = lv_Record.Items[index].SubItems[0].Text;

                    Record re = new Record();
                    string [] ss = re.getSID(id);
                    string LastID = ss[0];
                    string s_DT = ss[1];
                    Console.WriteLine(LastID);
                    Console.WriteLine(s_DT);
                    if (LastID == "")
                    {
                        MessageBox.Show("当前项的ID为空，不能为基准。", "编号出错");
                    }
                    else
                    {
                        int lid = Convert.ToInt32(LastID);
                        int Last_ID = re.reNumber(lid, s_DT);
                        saveLastID(Last_ID);
                    }
                }
                else
                {
                    Console.WriteLine("取消ID重新排序！");
                }
            }

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

        private void tsmi_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmi_Update_Click(object sender, EventArgs e)
        {
            if (lv_Record.SelectedIndices.Count > 0)
            {
                //修改记录
                RecordEdit re = new RecordEdit(record[lv_Record.SelectedIndices[0]]);
                re.ShowDialog();
            }
        }

        private void tsb_Margin_Click(object sender, EventArgs e)
        {
            // Initialize the dialog's PrinterSettings property to hold user
            // defined printer settings.
            pageSetupDialog1.PageSettings =
                new System.Drawing.Printing.PageSettings();

            // Initialize dialog's PrinterSettings property to hold user
            // set printer settings.
            pageSetupDialog1.PrinterSettings =
                new System.Drawing.Printing.PrinterSettings();

            //Do not show the network in the printer dialog.
            pageSetupDialog1.ShowNetwork = false;

            //Show the dialog storing the result.
            DialogResult result = pageSetupDialog1.ShowDialog();

            // If the result is OK, display selected settings in
            // ListBox1. These values can be used when printing the
            // document.
            if (result == DialogResult.OK)
            {
                object[] results = new object[]{ 
				pageSetupDialog1.PageSettings.Margins, 
				pageSetupDialog1.PageSettings.PaperSize, 
				pageSetupDialog1.PageSettings.Landscape, 
				pageSetupDialog1.PrinterSettings.PrinterName, 
				pageSetupDialog1.PrinterSettings.PrintRange};
                //ListBox1.Items.AddRange(results);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void tsb_Printer_Click(object sender, EventArgs e)
        {

        }

        private void cb_dt_switch_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_dt_switch.Checked == true)
            {
                dtp_from.Enabled = true;
                dtp_To.Enabled = true;
            }
            else
            {
                dtp_from.Enabled = false;
                dtp_To.Enabled = false;
            }
        }
    }
}
