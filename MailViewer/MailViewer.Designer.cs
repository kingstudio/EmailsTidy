namespace MailsViewer
{
    partial class MailViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailViewer));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.邮件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上一封邮件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下一封邮件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.附件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存附件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按文本查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlp_Mail = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Floder = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.l_Recipients = new System.Windows.Forms.Label();
            this.l_Send = new System.Windows.Forms.Label();
            this.l_Date = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_Title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtb_Body = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.wb_HtmlBody = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tlp_Mail.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Floder)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.邮件ToolStripMenuItem,
            this.附件ToolStripMenuItem,
            this.查看ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 邮件ToolStripMenuItem
            // 
            this.邮件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.上一封邮件ToolStripMenuItem,
            this.下一封邮件ToolStripMenuItem});
            this.邮件ToolStripMenuItem.Name = "邮件ToolStripMenuItem";
            this.邮件ToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.邮件ToolStripMenuItem.Text = "邮件(&M)";
            // 
            // 上一封邮件ToolStripMenuItem
            // 
            this.上一封邮件ToolStripMenuItem.Name = "上一封邮件ToolStripMenuItem";
            this.上一封邮件ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.上一封邮件ToolStripMenuItem.Text = "上一封邮件";
            // 
            // 下一封邮件ToolStripMenuItem
            // 
            this.下一封邮件ToolStripMenuItem.Name = "下一封邮件ToolStripMenuItem";
            this.下一封邮件ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.下一封邮件ToolStripMenuItem.Text = "下一封邮件";
            // 
            // 附件ToolStripMenuItem
            // 
            this.附件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存附件ToolStripMenuItem});
            this.附件ToolStripMenuItem.Name = "附件ToolStripMenuItem";
            this.附件ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.附件ToolStripMenuItem.Text = "附件(&A)";
            // 
            // 保存附件ToolStripMenuItem
            // 
            this.保存附件ToolStripMenuItem.Name = "保存附件ToolStripMenuItem";
            this.保存附件ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.保存附件ToolStripMenuItem.Text = "保存附件";
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.按文本查看ToolStripMenuItem,
            this.按ToolStripMenuItem});
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.查看ToolStripMenuItem.Text = "查看(&V)";
            // 
            // 按文本查看ToolStripMenuItem
            // 
            this.按文本查看ToolStripMenuItem.Name = "按文本查看ToolStripMenuItem";
            this.按文本查看ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.按文本查看ToolStripMenuItem.Text = "按文本查看";
            // 
            // 按ToolStripMenuItem
            // 
            this.按ToolStripMenuItem.Name = "按ToolStripMenuItem";
            this.按ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.按ToolStripMenuItem.Text = "按HTML查看";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "上一封邮件";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::MailsViewer.Properties.Resources.prev;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "下一封邮件";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tlp_Mail
            // 
            this.tlp_Mail.BackColor = System.Drawing.SystemColors.Control;
            this.tlp_Mail.ColumnCount = 1;
            this.tlp_Mail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Mail.Controls.Add(this.panel1, 0, 0);
            this.tlp_Mail.Controls.Add(this.panel2, 0, 1);
            this.tlp_Mail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Mail.Location = new System.Drawing.Point(0, 49);
            this.tlp_Mail.Name = "tlp_Mail";
            this.tlp_Mail.RowCount = 2;
            this.tlp_Mail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlp_Mail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Mail.Size = new System.Drawing.Size(784, 512);
            this.tlp_Mail.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.pb_Floder);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.l_Recipients);
            this.panel1.Controls.Add(this.l_Send);
            this.panel1.Controls.Add(this.l_Date);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.l_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 74);
            this.panel1.TabIndex = 0;
            // 
            // pb_Floder
            // 
            this.pb_Floder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Floder.Image = global::MailsViewer.Properties.Resources.up;
            this.pb_Floder.Location = new System.Drawing.Point(9, 5);
            this.pb_Floder.Name = "pb_Floder";
            this.pb_Floder.Size = new System.Drawing.Size(16, 16);
            this.pb_Floder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Floder.TabIndex = 1;
            this.pb_Floder.TabStop = false;
            this.pb_Floder.Click += new System.EventHandler(this.pb_Floder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(37, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "收件人：";
            // 
            // l_Recipients
            // 
            this.l_Recipients.AutoSize = true;
            this.l_Recipients.Location = new System.Drawing.Point(96, 53);
            this.l_Recipients.Name = "l_Recipients";
            this.l_Recipients.Size = new System.Drawing.Size(41, 12);
            this.l_Recipients.TabIndex = 0;
            this.l_Recipients.Text = "收件人";
            // 
            // l_Send
            // 
            this.l_Send.AutoSize = true;
            this.l_Send.Location = new System.Drawing.Point(96, 30);
            this.l_Send.Name = "l_Send";
            this.l_Send.Size = new System.Drawing.Size(41, 12);
            this.l_Send.TabIndex = 0;
            this.l_Send.Text = "发件人";
            // 
            // l_Date
            // 
            this.l_Date.AutoSize = true;
            this.l_Date.Location = new System.Drawing.Point(602, 30);
            this.l_Date.Name = "l_Date";
            this.l_Date.Size = new System.Drawing.Size(29, 12);
            this.l_Date.TabIndex = 0;
            this.l_Date.Text = "日期";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(555, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(37, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "发件人：";
            // 
            // l_Title
            // 
            this.l_Title.AutoSize = true;
            this.l_Title.Location = new System.Drawing.Point(37, 7);
            this.l_Title.Name = "l_Title";
            this.l_Title.Size = new System.Drawing.Size(101, 12);
            this.l_Title.TabIndex = 0;
            this.l_Title.Text = "标题标题标题标题";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 426);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtb_Body);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(770, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "文本格式";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtb_Body
            // 
            this.rtb_Body.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rtb_Body.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Body.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtb_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Body.Location = new System.Drawing.Point(3, 3);
            this.rtb_Body.Name = "rtb_Body";
            this.rtb_Body.ReadOnly = true;
            this.rtb_Body.ShowSelectionMargin = true;
            this.rtb_Body.Size = new System.Drawing.Size(764, 394);
            this.rtb_Body.TabIndex = 0;
            this.rtb_Body.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.wb_HtmlBody);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(770, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "HTML格式";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // wb_HtmlBody
            // 
            this.wb_HtmlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb_HtmlBody.Location = new System.Drawing.Point(3, 3);
            this.wb_HtmlBody.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_HtmlBody.Name = "wb_HtmlBody";
            this.wb_HtmlBody.Size = new System.Drawing.Size(764, 394);
            this.wb_HtmlBody.TabIndex = 0;
            // 
            // MailViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tlp_Mail);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MailViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "邮件阅读";
            this.Load += new System.EventHandler(this.MailViewer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tlp_Mail.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Floder)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 邮件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 附件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TableLayoutPanel tlp_Mail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Floder;
        private System.Windows.Forms.Label l_Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_Recipients;
        private System.Windows.Forms.Label l_Send;
        private System.Windows.Forms.Label l_Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtb_Body;
        private System.Windows.Forms.WebBrowser wb_HtmlBody;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 上一封邮件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下一封邮件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按文本查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存附件ToolStripMenuItem;
    }
}