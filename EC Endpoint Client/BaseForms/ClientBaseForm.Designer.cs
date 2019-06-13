using System.Windows.Forms;

namespace EC_Endpoint_Client.BaseForms
{
    public partial class ClientBaseForm : Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.ms_client = new System.Windows.Forms.MenuStrip();
            this.certificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soapMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_endPointConfigurationName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_viewedObject = new System.Windows.Forms.Label();
            this.pg_objectViewer = new System.Windows.Forms.PropertyGrid();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbl_SelectedCertificate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.servicePanel = new System.Windows.Forms.Panel();
            this.ms_client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(651, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // tb_userName
            // 
            this.tb_userName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_userName.Location = new System.Drawing.Point(712, 6);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(100, 20);
            this.tb_userName.TabIndex = 50;
            // 
            // tb_password
            // 
            this.tb_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_password.Location = new System.Drawing.Point(712, 32);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(100, 20);
            this.tb_password.TabIndex = 51;
            // 
            // ms_client
            // 
            this.ms_client.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.certificateToolStripMenuItem,
            this.soapMessagesToolStripMenuItem});
            this.ms_client.Location = new System.Drawing.Point(0, 0);
            this.ms_client.Name = "ms_client";
            this.ms_client.Size = new System.Drawing.Size(824, 24);
            this.ms_client.TabIndex = 2;
            this.ms_client.Text = "menuStrip1";
            // 
            // certificateToolStripMenuItem
            // 
            this.certificateToolStripMenuItem.Name = "certificateToolStripMenuItem";
            this.certificateToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.certificateToolStripMenuItem.Text = "Certificate";
            this.certificateToolStripMenuItem.Click += new System.EventHandler(this.certificateToolStripMenuItem_Click);
            // 
            // soapMessagesToolStripMenuItem
            // 
            this.soapMessagesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.requestToolStripMenuItem,
            this.replyToolStripMenuItem});
            this.soapMessagesToolStripMenuItem.Enabled = false;
            this.soapMessagesToolStripMenuItem.Name = "soapMessagesToolStripMenuItem";
            this.soapMessagesToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.soapMessagesToolStripMenuItem.Text = "Soap Messages";
            // 
            // requestToolStripMenuItem
            // 
            this.requestToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.showToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.requestToolStripMenuItem.Name = "requestToolStripMenuItem";
            this.requestToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.requestToolStripMenuItem.Text = "Request";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // replyToolStripMenuItem
            // 
            this.replyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem1,
            this.saveToolStripMenuItem1});
            this.replyToolStripMenuItem.Name = "replyToolStripMenuItem";
            this.replyToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.replyToolStripMenuItem.Text = "Reply";
            // 
            // showToolStripMenuItem1
            // 
            this.showToolStripMenuItem1.Name = "showToolStripMenuItem1";
            this.showToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem1.Text = "Show";
            this.showToolStripMenuItem1.Click += new System.EventHandler(this.showToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // cb_endPointConfigurationName
            // 
            this.cb_endPointConfigurationName.FormattingEnabled = true;
            this.cb_endPointConfigurationName.Location = new System.Drawing.Point(73, 6);
            this.cb_endPointConfigurationName.Name = "cb_endPointConfigurationName";
            this.cb_endPointConfigurationName.Size = new System.Drawing.Size(132, 21);
            this.cb_endPointConfigurationName.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "EndPoints";
            // 
            // lbl_viewedObject
            // 
            this.lbl_viewedObject.AutoSize = true;
            this.lbl_viewedObject.Location = new System.Drawing.Point(70, 39);
            this.lbl_viewedObject.Name = "lbl_viewedObject";
            this.lbl_viewedObject.Size = new System.Drawing.Size(88, 13);
            this.lbl_viewedObject.TabIndex = 6;
            this.lbl_viewedObject.Text = "lbl_viewedObject";
            // 
            // pg_objectViewer
            // 
            this.pg_objectViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pg_objectViewer.Location = new System.Drawing.Point(0, 0);
            this.pg_objectViewer.Name = "pg_objectViewer";
            this.pg_objectViewer.Size = new System.Drawing.Size(389, 369);
            this.pg_objectViewer.TabIndex = 52;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 67);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pg_objectViewer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.servicePanel);
            this.splitContainer1.Size = new System.Drawing.Size(818, 369);
            this.splitContainer1.SplitterDistance = 389;
            this.splitContainer1.TabIndex = 9;
            // 
            // lbl_SelectedCertificate
            // 
            this.lbl_SelectedCertificate.AutoSize = true;
            this.lbl_SelectedCertificate.Location = new System.Drawing.Point(211, 9);
            this.lbl_SelectedCertificate.Name = "lbl_SelectedCertificate";
            this.lbl_SelectedCertificate.Size = new System.Drawing.Size(60, 13);
            this.lbl_SelectedCertificate.TabIndex = 52;
            this.lbl_SelectedCertificate.Text = "Certificate: ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_SelectedCertificate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_viewedObject);
            this.panel1.Controls.Add(this.tb_userName);
            this.panel1.Controls.Add(this.cb_endPointConfigurationName);
            this.panel1.Controls.Add(this.tb_password);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 58);
            this.panel1.TabIndex = 53;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(824, 439);
            this.tableLayoutPanel1.TabIndex = 54;
            // 
            // servicePanel
            // 
            this.servicePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.servicePanel.Location = new System.Drawing.Point(0, 0);
            this.servicePanel.Name = "servicePanel";
            this.servicePanel.Size = new System.Drawing.Size(425, 369);
            this.servicePanel.TabIndex = 0;
            // 
            // ClientBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ms_client);
            this.MainMenuStrip = this.ms_client;
            this.Name = "ClientBaseForm";
            this.Text = "ClientBaseForm";
            this.ms_client.ResumeLayout(false);
            this.ms_client.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tb_userName;
        public System.Windows.Forms.TextBox tb_password;
        public System.Windows.Forms.MenuStrip ms_client;
        public System.Windows.Forms.ComboBox cb_endPointConfigurationName;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbl_viewedObject;
        public System.Windows.Forms.ToolStripMenuItem certificateToolStripMenuItem;
        public System.Windows.Forms.PropertyGrid pg_objectViewer;
        private System.Windows.Forms.ToolStripMenuItem soapMessagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.Label lbl_SelectedCertificate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        protected System.Windows.Forms.SplitContainer splitContainer1;
        protected System.Windows.Forms.Panel servicePanel;
    }
}