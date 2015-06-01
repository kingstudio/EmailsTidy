namespace EmailClient
{
    partial class ContactForm
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lv_Contact = new System.Windows.Forms.ListView();
            this.cms_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.cb_IsNew = new System.Windows.Forms.CheckBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tb_Feature = new System.Windows.Forms.TextBox();
            this.tb_MailAddress = new System.Windows.Forms.TextBox();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cms_Menu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(623, 443);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lv_Contact);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 437);
            this.panel1.TabIndex = 0;
            // 
            // lv_Contact
            // 
            this.lv_Contact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_Contact.ContextMenuStrip = this.cms_Menu;
            this.lv_Contact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Contact.FullRowSelect = true;
            this.lv_Contact.GridLines = true;
            this.lv_Contact.Location = new System.Drawing.Point(0, 0);
            this.lv_Contact.Name = "lv_Contact";
            this.lv_Contact.Size = new System.Drawing.Size(373, 437);
            this.lv_Contact.TabIndex = 0;
            this.lv_Contact.UseCompatibleStateImageBehavior = false;
            this.lv_Contact.View = System.Windows.Forms.View.Details;
            this.lv_Contact.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_Contact_MouseDoubleClick);
            // 
            // cms_Menu
            // 
            this.cms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Add,
            this.tsmi_Update,
            this.toolStripMenuItem1,
            this.tsmi_Delete});
            this.cms_Menu.Name = "cms_Menu";
            this.cms_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cms_Menu.Size = new System.Drawing.Size(99, 76);
            // 
            // tsmi_Add
            // 
            this.tsmi_Add.Name = "tsmi_Add";
            this.tsmi_Add.Size = new System.Drawing.Size(98, 22);
            this.tsmi_Add.Text = "新增";
            this.tsmi_Add.Click += new System.EventHandler(this.tsmi_Add_Click);
            // 
            // tsmi_Update
            // 
            this.tsmi_Update.Name = "tsmi_Update";
            this.tsmi_Update.Size = new System.Drawing.Size(98, 22);
            this.tsmi_Update.Text = "修改";
            this.tsmi_Update.Click += new System.EventHandler(this.tsmi_Update_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(95, 6);
            // 
            // tsmi_Delete
            // 
            this.tsmi_Delete.Name = "tsmi_Delete";
            this.tsmi_Delete.Size = new System.Drawing.Size(98, 22);
            this.tsmi_Delete.Text = "删除";
            this.tsmi_Delete.Click += new System.EventHandler(this.tsmi_Delete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tb_ID);
            this.panel2.Controls.Add(this.cb_IsNew);
            this.panel2.Controls.Add(this.btn_Ok);
            this.panel2.Controls.Add(this.btn_Cancel);
            this.panel2.Controls.Add(this.tb_Feature);
            this.panel2.Controls.Add(this.tb_MailAddress);
            this.panel2.Controls.Add(this.tb_UserName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(382, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 437);
            this.panel2.TabIndex = 1;
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(73, 288);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(156, 21);
            this.tb_ID.TabIndex = 4;
            this.tb_ID.Visible = false;
            // 
            // cb_IsNew
            // 
            this.cb_IsNew.AutoSize = true;
            this.cb_IsNew.Location = new System.Drawing.Point(73, 265);
            this.cb_IsNew.Name = "cb_IsNew";
            this.cb_IsNew.Size = new System.Drawing.Size(36, 16);
            this.cb_IsNew.TabIndex = 3;
            this.cb_IsNew.Text = "是";
            this.cb_IsNew.UseVisualStyleBackColor = true;
            this.cb_IsNew.CheckedChanged += new System.EventHandler(this.cb_IsNew_CheckedChanged);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(73, 414);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 2;
            this.btn_Ok.Text = "确定";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(154, 414);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // tb_Feature
            // 
            this.tb_Feature.Location = new System.Drawing.Point(73, 77);
            this.tb_Feature.Multiline = true;
            this.tb_Feature.Name = "tb_Feature";
            this.tb_Feature.Size = new System.Drawing.Size(156, 129);
            this.tb_Feature.TabIndex = 1;
            // 
            // tb_MailAddress
            // 
            this.tb_MailAddress.Location = new System.Drawing.Point(73, 40);
            this.tb_MailAddress.Name = "tb_MailAddress";
            this.tb_MailAddress.Size = new System.Drawing.Size(156, 21);
            this.tb_MailAddress.TabIndex = 1;
            // 
            // tb_UserName
            // 
            this.tb_UserName.Location = new System.Drawing.Point(73, 6);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(156, 21);
            this.tb_UserName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(71, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 43);
            this.label5.TabIndex = 0;
            this.label5.Text = "[示例]Send=王裕林;Signature=王裕林;";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "是否新增：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "分类规则：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "邮箱地址：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 443);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContactForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通讯录";
            this.Load += new System.EventHandler(this.ContactForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.cms_Menu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lv_Contact;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox tb_Feature;
        private System.Windows.Forms.TextBox tb_MailAddress;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_IsNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip cms_Menu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Add;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Update;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Delete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ID;
    }
}