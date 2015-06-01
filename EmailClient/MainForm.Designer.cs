
namespace EmailClient
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ms_Menu = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Import = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_Recieve = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Send = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.查看VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Address = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Account = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_MailRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_CheckUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助主题ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_ToolBar = new System.Windows.Forms.ToolStrip();
            this.tsb_Receive = new System.Windows.Forms.ToolStripButton();
            this.tsb_AutoTidy = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ss_Bottom = new System.Windows.Forms.StatusStrip();
            this.tspb_LoadData = new System.Windows.Forms.ToolStripProgressBar();
            this.tssl_Information = new System.Windows.Forms.ToolStripStatusLabel();
            this.lv_MailList = new System.Windows.Forms.ListView();
            this.cms_right = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_tidyCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_deleteCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.bw_LoadData = new System.ComponentModel.BackgroundWorker();
            this.bw_AutoTidy = new System.ComponentModel.BackgroundWorker();
            this.ms_Menu.SuspendLayout();
            this.ts_ToolBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ss_Bottom.SuspendLayout();
            this.cms_right.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_Menu
            // 
            this.ms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.查看VToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.ms_Menu.Location = new System.Drawing.Point(0, 0);
            this.ms_Menu.Name = "ms_Menu";
            this.ms_Menu.Size = new System.Drawing.Size(784, 24);
            this.ms_Menu.TabIndex = 0;
            this.ms_Menu.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Open,
            this.tsmi_Import,
            this.toolStripMenuItem2,
            this.tsmi_Recieve,
            this.tsmi_Send,
            this.toolStripSeparator1,
            this.tsmi_Exit});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // tsmi_Open
            // 
            this.tsmi_Open.Name = "tsmi_Open";
            this.tsmi_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmi_Open.Size = new System.Drawing.Size(144, 22);
            this.tsmi_Open.Text = "打开";
            this.tsmi_Open.Click += new System.EventHandler(this.tsmi_Open_Click);
            // 
            // tsmi_Import
            // 
            this.tsmi_Import.Name = "tsmi_Import";
            this.tsmi_Import.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.tsmi_Import.Size = new System.Drawing.Size(144, 22);
            this.tsmi_Import.Text = "导入";
            this.tsmi_Import.Click += new System.EventHandler(this.tsmi_Import_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(141, 6);
            // 
            // tsmi_Recieve
            // 
            this.tsmi_Recieve.Name = "tsmi_Recieve";
            this.tsmi_Recieve.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.tsmi_Recieve.Size = new System.Drawing.Size(144, 22);
            this.tsmi_Recieve.Text = "接收";
            // 
            // tsmi_Send
            // 
            this.tsmi_Send.Name = "tsmi_Send";
            this.tsmi_Send.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmi_Send.Size = new System.Drawing.Size(144, 22);
            this.tsmi_Send.Text = "发送";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // tsmi_Exit
            // 
            this.tsmi_Exit.Name = "tsmi_Exit";
            this.tsmi_Exit.Size = new System.Drawing.Size(144, 22);
            this.tsmi_Exit.Text = "退出";
            this.tsmi_Exit.Click += new System.EventHandler(this.tsmi_Exit_Click);
            // 
            // 查看VToolStripMenuItem
            // 
            this.查看VToolStripMenuItem.Name = "查看VToolStripMenuItem";
            this.查看VToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.查看VToolStripMenuItem.Text = "查看(&V)";
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Address,
            this.tsmi_Account,
            this.tsmi_MailRecord});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.工具TToolStripMenuItem.Text = "工具(&T)";
            // 
            // tsmi_Address
            // 
            this.tsmi_Address.Name = "tsmi_Address";
            this.tsmi_Address.Size = new System.Drawing.Size(122, 22);
            this.tsmi_Address.Text = "通讯录";
            this.tsmi_Address.Click += new System.EventHandler(this.tsmi_Address_Click);
            // 
            // tsmi_Account
            // 
            this.tsmi_Account.Name = "tsmi_Account";
            this.tsmi_Account.Size = new System.Drawing.Size(122, 22);
            this.tsmi_Account.Text = "帐号管理";
            this.tsmi_Account.Click += new System.EventHandler(this.tsmi_Account_Click);
            // 
            // tsmi_MailRecord
            // 
            this.tsmi_MailRecord.Name = "tsmi_MailRecord";
            this.tsmi_MailRecord.Size = new System.Drawing.Size(122, 22);
            this.tsmi_MailRecord.Text = "邮件记录";
            this.tsmi_MailRecord.Click += new System.EventHandler(this.tsmi_MailRecord_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_CheckUpdate,
            this.帮助主题ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // tsmi_CheckUpdate
            // 
            this.tsmi_CheckUpdate.Name = "tsmi_CheckUpdate";
            this.tsmi_CheckUpdate.Size = new System.Drawing.Size(134, 22);
            this.tsmi_CheckUpdate.Text = "检查新版本";
            this.tsmi_CheckUpdate.Click += new System.EventHandler(this.tsmi_CheckUpdate_Click);
            // 
            // 帮助主题ToolStripMenuItem
            // 
            this.帮助主题ToolStripMenuItem.Name = "帮助主题ToolStripMenuItem";
            this.帮助主题ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.帮助主题ToolStripMenuItem.Text = "帮助主题";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // ts_ToolBar
            // 
            this.ts_ToolBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ts_ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Receive,
            this.tsb_AutoTidy});
            this.ts_ToolBar.Location = new System.Drawing.Point(0, 24);
            this.ts_ToolBar.Name = "ts_ToolBar";
            this.ts_ToolBar.Size = new System.Drawing.Size(784, 31);
            this.ts_ToolBar.TabIndex = 1;
            this.ts_ToolBar.Text = "toolStrip1";
            // 
            // tsb_Receive
            // 
            this.tsb_Receive.Image = global::EmailClient.Properties.Resources.receive;
            this.tsb_Receive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Receive.Name = "tsb_Receive";
            this.tsb_Receive.Size = new System.Drawing.Size(59, 28);
            this.tsb_Receive.Text = "接收";
            this.tsb_Receive.Click += new System.EventHandler(this.tsb_Receive_Click);
            // 
            // tsb_AutoTidy
            // 
            this.tsb_AutoTidy.Image = global::EmailClient.Properties.Resources.tidy;
            this.tsb_AutoTidy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_AutoTidy.Name = "tsb_AutoTidy";
            this.tsb_AutoTidy.Size = new System.Drawing.Size(83, 28);
            this.tsb_AutoTidy.Text = "自动整理";
            this.tsb_AutoTidy.Click += new System.EventHandler(this.tsb_AutoTidy_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ss_Bottom);
            this.panel1.Controls.Add(this.lv_MailList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 506);
            this.panel1.TabIndex = 2;
            // 
            // ss_Bottom
            // 
            this.ss_Bottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspb_LoadData,
            this.tssl_Information});
            this.ss_Bottom.Location = new System.Drawing.Point(0, 484);
            this.ss_Bottom.Name = "ss_Bottom";
            this.ss_Bottom.Size = new System.Drawing.Size(784, 22);
            this.ss_Bottom.TabIndex = 1;
            this.ss_Bottom.Text = "statusStrip1";
            // 
            // tspb_LoadData
            // 
            this.tspb_LoadData.Name = "tspb_LoadData";
            this.tspb_LoadData.Size = new System.Drawing.Size(300, 16);
            this.tspb_LoadData.Step = 1;
            // 
            // tssl_Information
            // 
            this.tssl_Information.Name = "tssl_Information";
            this.tssl_Information.Size = new System.Drawing.Size(0, 17);
            // 
            // lv_MailList
            // 
            this.lv_MailList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_MailList.ContextMenuStrip = this.cms_right;
            this.lv_MailList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_MailList.FullRowSelect = true;
            this.lv_MailList.GridLines = true;
            this.lv_MailList.Location = new System.Drawing.Point(0, 0);
            this.lv_MailList.Name = "lv_MailList";
            this.lv_MailList.Size = new System.Drawing.Size(784, 506);
            this.lv_MailList.TabIndex = 0;
            this.lv_MailList.UseCompatibleStateImageBehavior = false;
            this.lv_MailList.View = System.Windows.Forms.View.Details;
            this.lv_MailList.VirtualMode = true;
            this.lv_MailList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lv_MailList_ColumnClick);
            this.lv_MailList.SelectedIndexChanged += new System.EventHandler(this.lv_MailList_SelectedIndexChanged);
            this.lv_MailList.DoubleClick += new System.EventHandler(this.lv_MailList_DoubleClick);
            // 
            // cms_right
            // 
            this.cms_right.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_tidyCurrent,
            this.toolStripMenuItem1,
            this.tsmi_deleteCurrent});
            this.cms_right.Name = "cms_right";
            this.cms_right.Size = new System.Drawing.Size(153, 76);
            this.cms_right.Text = "右键菜单";
            // 
            // tsmi_tidyCurrent
            // 
            this.tsmi_tidyCurrent.Name = "tsmi_tidyCurrent";
            this.tsmi_tidyCurrent.Size = new System.Drawing.Size(152, 22);
            this.tsmi_tidyCurrent.Text = "整理记录";
            this.tsmi_tidyCurrent.Click += new System.EventHandler(this.tsmi_tidyCurrent_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmi_deleteCurrent
            // 
            this.tsmi_deleteCurrent.Name = "tsmi_deleteCurrent";
            this.tsmi_deleteCurrent.Size = new System.Drawing.Size(152, 22);
            this.tsmi_deleteCurrent.Text = "删除记录";
            this.tsmi_deleteCurrent.Click += new System.EventHandler(this.tsmi_deleteCurrent_Click);
            // 
            // bw_LoadData
            // 
            this.bw_LoadData.WorkerSupportsCancellation = true;
            this.bw_LoadData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_LoadData_DoWork);
            this.bw_LoadData.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_LoadData_ProgressChanged);
            this.bw_LoadData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_LoadData_RunWorkerCompleted);
            // 
            // bw_AutoTidy
            // 
            this.bw_AutoTidy.WorkerSupportsCancellation = true;
            this.bw_AutoTidy.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_AutoTidy_DoWork);
            this.bw_AutoTidy.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_AutoTidy_ProgressChanged);
            this.bw_AutoTidy.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_AutoTidy_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ts_ToolBar);
            this.Controls.Add(this.ms_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_Menu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "邮件系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ms_Menu.ResumeLayout(false);
            this.ms_Menu.PerformLayout();
            this.ts_ToolBar.ResumeLayout(false);
            this.ts_ToolBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ss_Bottom.ResumeLayout(false);
            this.ss_Bottom.PerformLayout();
            this.cms_right.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_Menu;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Recieve;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Send;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Exit;
        private System.Windows.Forms.ToolStripMenuItem 查看VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Address;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Account;
        private System.Windows.Forms.ToolStripMenuItem tsmi_MailRecord;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_CheckUpdate;
        private System.Windows.Forms.ToolStripMenuItem 帮助主题ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ts_ToolBar;
        private System.Windows.Forms.ToolStripButton tsb_Receive;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip ss_Bottom;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Information;
        private System.Windows.Forms.ListView lv_MailList;
        private System.ComponentModel.BackgroundWorker bw_LoadData;
        private System.Windows.Forms.ToolStripProgressBar tspb_LoadData;
        private System.Windows.Forms.ToolStripButton tsb_AutoTidy;
        private System.ComponentModel.BackgroundWorker bw_AutoTidy;
        private System.Windows.Forms.ContextMenuStrip cms_right;
        private System.Windows.Forms.ToolStripMenuItem tsmi_tidyCurrent;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_deleteCurrent;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Open;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Import;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}

