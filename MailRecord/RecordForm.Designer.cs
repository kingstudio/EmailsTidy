namespace MailRecord
{
    partial class RecordForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("发件人");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("收件人");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.页面设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.筛选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上一个月ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下一个月ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_prev = new System.Windows.Forms.ToolStripButton();
            this.tsb_next = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_SaveAsWord = new System.Windows.Forms.ToolStripButton();
            this.tsb_SaveAsPDF = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Margin = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsb_Printer = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tv_select = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.p_top = new System.Windows.Forms.Panel();
            this.cb_dt_switch = new System.Windows.Forms.CheckBox();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.l_middle = new System.Windows.Forms.Label();
            this.l_time = new System.Windows.Forms.Label();
            this.tb_keywords = new System.Windows.Forms.TextBox();
            this.b_query = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lv_Record = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_Renumber = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.p_top.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.筛选ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存ToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.页面设置ToolStripMenuItem,
            this.打印ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.退出ToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.另存为ToolStripMenuItem.Text = "另存为";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(119, 6);
            // 
            // 页面设置ToolStripMenuItem
            // 
            this.页面设置ToolStripMenuItem.Name = "页面设置ToolStripMenuItem";
            this.页面设置ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.页面设置ToolStripMenuItem.Text = "页面设置";
            // 
            // 打印ToolStripMenuItem
            // 
            this.打印ToolStripMenuItem.Name = "打印ToolStripMenuItem";
            this.打印ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.打印ToolStripMenuItem.Text = "打印";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(119, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 筛选ToolStripMenuItem
            // 
            this.筛选ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.上一个月ToolStripMenuItem,
            this.下一个月ToolStripMenuItem});
            this.筛选ToolStripMenuItem.Name = "筛选ToolStripMenuItem";
            this.筛选ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.筛选ToolStripMenuItem.Text = "筛选(&L)";
            // 
            // 上一个月ToolStripMenuItem
            // 
            this.上一个月ToolStripMenuItem.Name = "上一个月ToolStripMenuItem";
            this.上一个月ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.上一个月ToolStripMenuItem.Text = "上一个月";
            // 
            // 下一个月ToolStripMenuItem
            // 
            this.下一个月ToolStripMenuItem.Name = "下一个月ToolStripMenuItem";
            this.下一个月ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.下一个月ToolStripMenuItem.Text = "下一个月";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_prev,
            this.tsb_next,
            this.toolStripSeparator1,
            this.tsb_SaveAsWord,
            this.tsb_SaveAsPDF,
            this.toolStripSeparator2,
            this.tsb_Margin,
            this.toolStripButton1,
            this.tsb_Printer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_prev
            // 
            this.tsb_prev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_prev.Image = global::MailRecord.Properties.Resources.back;
            this.tsb_prev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_prev.Name = "tsb_prev";
            this.tsb_prev.Size = new System.Drawing.Size(23, 22);
            this.tsb_prev.Text = "上一个月";
            this.tsb_prev.Click += new System.EventHandler(this.tsb_prev_Click);
            // 
            // tsb_next
            // 
            this.tsb_next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_next.Image = global::MailRecord.Properties.Resources.prev;
            this.tsb_next.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_next.Name = "tsb_next";
            this.tsb_next.Size = new System.Drawing.Size(23, 22);
            this.tsb_next.Text = "下一个月";
            this.tsb_next.Click += new System.EventHandler(this.tsb_next_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_SaveAsWord
            // 
            this.tsb_SaveAsWord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_SaveAsWord.Image = global::MailRecord.Properties.Resources.word;
            this.tsb_SaveAsWord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_SaveAsWord.Name = "tsb_SaveAsWord";
            this.tsb_SaveAsWord.Size = new System.Drawing.Size(23, 22);
            this.tsb_SaveAsWord.Text = "导出WORD";
            this.tsb_SaveAsWord.Click += new System.EventHandler(this.tsb_SaveAsWord_Click);
            // 
            // tsb_SaveAsPDF
            // 
            this.tsb_SaveAsPDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_SaveAsPDF.Image = global::MailRecord.Properties.Resources.pdf;
            this.tsb_SaveAsPDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_SaveAsPDF.Name = "tsb_SaveAsPDF";
            this.tsb_SaveAsPDF.Size = new System.Drawing.Size(23, 22);
            this.tsb_SaveAsPDF.Text = "导出PDF";
            this.tsb_SaveAsPDF.Click += new System.EventHandler(this.tsb_SaveAsPDF_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_Margin
            // 
            this.tsb_Margin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Margin.Image = global::MailRecord.Properties.Resources.margins;
            this.tsb_Margin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Margin.Name = "tsb_Margin";
            this.tsb_Margin.Size = new System.Drawing.Size(23, 22);
            this.tsb_Margin.Text = "页面设置";
            this.tsb_Margin.Click += new System.EventHandler(this.tsb_Margin_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::MailRecord.Properties.Resources.preview;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "打印预览";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsb_Printer
            // 
            this.tsb_Printer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Printer.Image = global::MailRecord.Properties.Resources.printer;
            this.tsb_Printer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Printer.Name = "tsb_Printer";
            this.tsb_Printer.Size = new System.Drawing.Size(23, 22);
            this.tsb_Printer.Text = "打印";
            this.tsb_Printer.Click += new System.EventHandler(this.tsb_Printer_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tv_select);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(784, 512);
            this.splitContainer1.SplitterDistance = 172;
            this.splitContainer1.TabIndex = 2;
            // 
            // tv_select
            // 
            this.tv_select.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tv_select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_select.Location = new System.Drawing.Point(0, 0);
            this.tv_select.Name = "tv_select";
            treeNode1.Name = "tn_Send";
            treeNode1.Tag = "34";
            treeNode1.Text = "发件人";
            treeNode2.Name = "tn_Reci";
            treeNode2.Text = "收件人";
            this.tv_select.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.tv_select.Size = new System.Drawing.Size(172, 512);
            this.tv_select.TabIndex = 0;
            this.tv_select.DoubleClick += new System.EventHandler(this.tv_select_DoubleClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer2.Panel1.Controls.Add(this.p_top);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer2.Panel2.Controls.Add(this.listBox1);
            this.splitContainer2.Panel2.Controls.Add(this.lv_Record);
            this.splitContainer2.Size = new System.Drawing.Size(608, 512);
            this.splitContainer2.SplitterDistance = 30;
            this.splitContainer2.TabIndex = 0;
            // 
            // p_top
            // 
            this.p_top.Controls.Add(this.cb_dt_switch);
            this.p_top.Controls.Add(this.dtp_To);
            this.p_top.Controls.Add(this.dtp_from);
            this.p_top.Controls.Add(this.l_middle);
            this.p_top.Controls.Add(this.l_time);
            this.p_top.Controls.Add(this.tb_keywords);
            this.p_top.Controls.Add(this.b_query);
            this.p_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_top.Location = new System.Drawing.Point(0, 0);
            this.p_top.Name = "p_top";
            this.p_top.Size = new System.Drawing.Size(608, 30);
            this.p_top.TabIndex = 0;
            // 
            // cb_dt_switch
            // 
            this.cb_dt_switch.AutoSize = true;
            this.cb_dt_switch.Checked = true;
            this.cb_dt_switch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_dt_switch.Location = new System.Drawing.Point(230, 7);
            this.cb_dt_switch.Name = "cb_dt_switch";
            this.cb_dt_switch.Size = new System.Drawing.Size(48, 16);
            this.cb_dt_switch.TabIndex = 4;
            this.cb_dt_switch.Text = "启用";
            this.cb_dt_switch.UseVisualStyleBackColor = true;
            this.cb_dt_switch.CheckedChanged += new System.EventHandler(this.cb_dt_switch_CheckedChanged);
            // 
            // dtp_To
            // 
            this.dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_To.Location = new System.Drawing.Point(142, 5);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(81, 21);
            this.dtp_To.TabIndex = 3;
            // 
            // dtp_from
            // 
            this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_from.Location = new System.Drawing.Point(40, 5);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(81, 21);
            this.dtp_from.TabIndex = 3;
            // 
            // l_middle
            // 
            this.l_middle.AutoSize = true;
            this.l_middle.Location = new System.Drawing.Point(125, 9);
            this.l_middle.Name = "l_middle";
            this.l_middle.Size = new System.Drawing.Size(11, 12);
            this.l_middle.TabIndex = 2;
            this.l_middle.Text = "-";
            // 
            // l_time
            // 
            this.l_time.AutoSize = true;
            this.l_time.Location = new System.Drawing.Point(4, 9);
            this.l_time.Name = "l_time";
            this.l_time.Size = new System.Drawing.Size(29, 12);
            this.l_time.TabIndex = 2;
            this.l_time.Text = "时间";
            // 
            // tb_keywords
            // 
            this.tb_keywords.Location = new System.Drawing.Point(395, 5);
            this.tb_keywords.Name = "tb_keywords";
            this.tb_keywords.Size = new System.Drawing.Size(129, 21);
            this.tb_keywords.TabIndex = 1;
            // 
            // b_query
            // 
            this.b_query.Location = new System.Drawing.Point(530, 4);
            this.b_query.Name = "b_query";
            this.b_query.Size = new System.Drawing.Size(75, 23);
            this.b_query.TabIndex = 0;
            this.b_query.Text = "查询";
            this.b_query.UseVisualStyleBackColor = true;
            this.b_query.Click += new System.EventHandler(this.b_query_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(25, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(183, 124);
            this.listBox1.TabIndex = 1;
            this.listBox1.Visible = false;
            // 
            // lv_Record
            // 
            this.lv_Record.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_Record.ContextMenuStrip = this.contextMenuStrip1;
            this.lv_Record.FullRowSelect = true;
            this.lv_Record.GridLines = true;
            this.lv_Record.Location = new System.Drawing.Point(232, 20);
            this.lv_Record.Name = "lv_Record";
            this.lv_Record.Size = new System.Drawing.Size(225, 194);
            this.lv_Record.TabIndex = 0;
            this.lv_Record.UseCompatibleStateImageBehavior = false;
            this.lv_Record.View = System.Windows.Forms.View.Details;
            this.lv_Record.VirtualMode = true;
            this.lv_Record.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lv_Record_ColumnClick);
            this.lv_Record.DoubleClick += new System.EventHandler(this.lv_Record_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Update,
            this.tsmi_Delete,
            this.toolStripMenuItem3,
            this.tsmi_Renumber,
            this.toolStripMenuItem4,
            this.tsmi_Exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(219, 104);
            // 
            // tsmi_Update
            // 
            this.tsmi_Update.Name = "tsmi_Update";
            this.tsmi_Update.Size = new System.Drawing.Size(218, 22);
            this.tsmi_Update.Text = "编辑";
            this.tsmi_Update.Click += new System.EventHandler(this.tsmi_Update_Click);
            // 
            // tsmi_Delete
            // 
            this.tsmi_Delete.Name = "tsmi_Delete";
            this.tsmi_Delete.Size = new System.Drawing.Size(218, 22);
            this.tsmi_Delete.Text = "删除";
            this.tsmi_Delete.Click += new System.EventHandler(this.tsmi_Delete_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(215, 6);
            // 
            // tsmi_Renumber
            // 
            this.tsmi_Renumber.Name = "tsmi_Renumber";
            this.tsmi_Renumber.Size = new System.Drawing.Size(218, 22);
            this.tsmi_Renumber.Text = "重新编号（以此项为基点）";
            this.tsmi_Renumber.Click += new System.EventHandler(this.tsmi_Renumber_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(215, 6);
            // 
            // tsmi_Exit
            // 
            this.tsmi_Exit.Name = "tsmi_Exit";
            this.tsmi_Exit.Size = new System.Drawing.Size(218, 22);
            this.tsmi_Exit.Text = "退出";
            this.tsmi_Exit.Click += new System.EventHandler(this.tsmi_Exit_Click);
            // 
            // RecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "邮件记录";
            this.Load += new System.EventHandler(this.RecordForm_Load);
            this.Resize += new System.EventHandler(this.RecordForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.p_top.ResumeLayout(false);
            this.p_top.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tv_select;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel p_top;
        private System.Windows.Forms.TextBox tb_keywords;
        private System.Windows.Forms.Button b_query;
        private System.Windows.Forms.DateTimePicker dtp_To;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Label l_middle;
        private System.Windows.Forms.Label l_time;
        private System.Windows.Forms.ListView lv_Record;
        private System.Windows.Forms.ToolStripButton tsb_next;
        private System.Windows.Forms.ToolStripButton tsb_prev;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 筛选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上一个月ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下一个月ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 页面设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb_SaveAsWord;
        private System.Windows.Forms.ToolStripButton tsb_SaveAsPDF;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsb_Printer;
        private System.Windows.Forms.ToolStripButton tsb_Margin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Renumber;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Update;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Exit;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox cb_dt_switch;
    }
}

