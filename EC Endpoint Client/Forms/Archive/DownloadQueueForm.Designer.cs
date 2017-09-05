using System.Drawing;

namespace EC_Endpoint_Client.Forms
{
    partial class DownloadQueueForm
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
            this.GetDQTabPage = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tb_serviceCode = new System.Windows.Forms.TextBox();
            this.btn_SaveDQList = new System.Windows.Forms.Button();
            this.btn_ShowDQList = new System.Windows.Forms.Button();
            this.btn_GetDQList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_PurgeItem = new System.Windows.Forms.Button();
            this.tb_archRef = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tb_languageId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_saveArchFormTask = new System.Windows.Forms.Button();
            this.btn_showArchivedFormTask = new System.Windows.Forms.Button();
            this.btn_getArchFormTask = new System.Windows.Forms.Button();
            this.tb_archRef2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.uscGetFormsetPdf = new EC_Endpoint_Client.Forms.Archive.UserControls.GetFormsetPdf();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_test = new System.Windows.Forms.Button();
            this.servicePanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // servicePanel
            // 
            this.servicePanel.Controls.Add(this.tabControl1);
            // 
            // GetDQTabPage
            // 
            this.GetDQTabPage.Location = new System.Drawing.Point(0, 0);
            this.GetDQTabPage.Name = "GetDQTabPage";
            this.GetDQTabPage.Size = new System.Drawing.Size(200, 100);
            this.GetDQTabPage.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(425, 369);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tb_serviceCode);
            this.tabPage1.Controls.Add(this.btn_SaveDQList);
            this.tabPage1.Controls.Add(this.btn_ShowDQList);
            this.tabPage1.Controls.Add(this.btn_GetDQList);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GetDownloadQueueItems";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tb_serviceCode
            // 
            this.tb_serviceCode.Location = new System.Drawing.Point(80, 8);
            this.tb_serviceCode.Name = "tb_serviceCode";
            this.tb_serviceCode.Size = new System.Drawing.Size(114, 20);
            this.tb_serviceCode.TabIndex = 2;
            // 
            // btn_SaveDQList
            // 
            this.btn_SaveDQList.Location = new System.Drawing.Point(270, 64);
            this.btn_SaveDQList.Name = "btn_SaveDQList";
            this.btn_SaveDQList.Size = new System.Drawing.Size(144, 23);
            this.btn_SaveDQList.TabIndex = 1;
            this.btn_SaveDQList.Text = "Save Result";
            this.btn_SaveDQList.UseVisualStyleBackColor = true;
            this.btn_SaveDQList.Click += new System.EventHandler(this.btn_SaveDQList_Click);
            // 
            // btn_ShowDQList
            // 
            this.btn_ShowDQList.Location = new System.Drawing.Point(270, 35);
            this.btn_ShowDQList.Name = "btn_ShowDQList";
            this.btn_ShowDQList.Size = new System.Drawing.Size(144, 23);
            this.btn_ShowDQList.TabIndex = 1;
            this.btn_ShowDQList.Text = "Show Result";
            this.btn_ShowDQList.UseVisualStyleBackColor = true;
            this.btn_ShowDQList.Click += new System.EventHandler(this.btn_ShowDQList_Click);
            // 
            // btn_GetDQList
            // 
            this.btn_GetDQList.Location = new System.Drawing.Point(270, 6);
            this.btn_GetDQList.Name = "btn_GetDQList";
            this.btn_GetDQList.Size = new System.Drawing.Size(144, 23);
            this.btn_GetDQList.TabIndex = 1;
            this.btn_GetDQList.Text = "Invoke Service";
            this.btn_GetDQList.UseVisualStyleBackColor = true;
            this.btn_GetDQList.Click += new System.EventHandler(this.btn_GetDQList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ServiceCode";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_PurgeItem);
            this.tabPage2.Controls.Add(this.tb_archRef);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PurgeItem";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_PurgeItem
            // 
            this.btn_PurgeItem.Location = new System.Drawing.Point(270, 6);
            this.btn_PurgeItem.Name = "btn_PurgeItem";
            this.btn_PurgeItem.Size = new System.Drawing.Size(144, 23);
            this.btn_PurgeItem.TabIndex = 2;
            this.btn_PurgeItem.Text = "Invoke Service";
            this.btn_PurgeItem.UseVisualStyleBackColor = true;
            this.btn_PurgeItem.Click += new System.EventHandler(this.btn_PurgeItem_Click);
            // 
            // tb_archRef
            // 
            this.tb_archRef.Location = new System.Drawing.Point(105, 8);
            this.tb_archRef.Name = "tb_archRef";
            this.tb_archRef.Size = new System.Drawing.Size(117, 20);
            this.tb_archRef.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ArchiveReference";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tb_languageId);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.btn_saveArchFormTask);
            this.tabPage3.Controls.Add(this.btn_showArchivedFormTask);
            this.tabPage3.Controls.Add(this.btn_getArchFormTask);
            this.tabPage3.Controls.Add(this.tb_archRef2);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(417, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "GetArchivedFormTask";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tb_languageId
            // 
            this.tb_languageId.Location = new System.Drawing.Point(105, 32);
            this.tb_languageId.Name = "tb_languageId";
            this.tb_languageId.Size = new System.Drawing.Size(117, 20);
            this.tb_languageId.TabIndex = 7;
            this.tb_languageId.Text = "1044";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "LanguageId";
            // 
            // btn_saveArchFormTask
            // 
            this.btn_saveArchFormTask.Location = new System.Drawing.Point(270, 64);
            this.btn_saveArchFormTask.Name = "btn_saveArchFormTask";
            this.btn_saveArchFormTask.Size = new System.Drawing.Size(145, 23);
            this.btn_saveArchFormTask.TabIndex = 5;
            this.btn_saveArchFormTask.Text = "Save Result";
            this.btn_saveArchFormTask.UseVisualStyleBackColor = true;
            this.btn_saveArchFormTask.Click += new System.EventHandler(this.btn_saveArchFormTask_Click);
            // 
            // btn_showArchivedFormTask
            // 
            this.btn_showArchivedFormTask.Location = new System.Drawing.Point(270, 35);
            this.btn_showArchivedFormTask.Name = "btn_showArchivedFormTask";
            this.btn_showArchivedFormTask.Size = new System.Drawing.Size(144, 23);
            this.btn_showArchivedFormTask.TabIndex = 5;
            this.btn_showArchivedFormTask.Text = "Show Result";
            this.btn_showArchivedFormTask.UseVisualStyleBackColor = true;
            this.btn_showArchivedFormTask.Click += new System.EventHandler(this.btn_showArchivedFormTask_Click);
            // 
            // btn_getArchFormTask
            // 
            this.btn_getArchFormTask.Location = new System.Drawing.Point(270, 6);
            this.btn_getArchFormTask.Name = "btn_getArchFormTask";
            this.btn_getArchFormTask.Size = new System.Drawing.Size(144, 23);
            this.btn_getArchFormTask.TabIndex = 4;
            this.btn_getArchFormTask.Text = "Invoke Service";
            this.btn_getArchFormTask.UseVisualStyleBackColor = true;
            this.btn_getArchFormTask.Click += new System.EventHandler(this.btn_getArchFormTask_Click);
            // 
            // tb_archRef2
            // 
            this.tb_archRef2.Location = new System.Drawing.Point(105, 8);
            this.tb_archRef2.Name = "tb_archRef2";
            this.tb_archRef2.Size = new System.Drawing.Size(117, 20);
            this.tb_archRef2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "ArchiveReference";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.uscGetFormsetPdf);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(417, 343);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "GetFormSetPdf";
            // 
            // uscGetFormsetPdf
            // 
            this.uscGetFormsetPdf.ArchiveReference = "";
            this.uscGetFormsetPdf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscGetFormsetPdf.LanguageId = 1044;
            this.uscGetFormsetPdf.Location = new System.Drawing.Point(3, 3);
            this.uscGetFormsetPdf.Name = "uscGetFormsetPdf";
            this.uscGetFormsetPdf.Size = new System.Drawing.Size(411, 337);
            this.uscGetFormsetPdf.TabIndex = 0;
            this.uscGetFormsetPdf.InvokeClick += new System.EventHandler(this.btn_GetFormSetPdf_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_test);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(417, 343);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Test";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(7, 7);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(75, 23);
            this.btn_test.TabIndex = 0;
            this.btn_test.Text = "Test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // DownloadQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Name = "DownloadQueueForm";
            this.Text = "DownloadQueueForm";
            this.servicePanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage GetDQTabPage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tb_serviceCode;
        private System.Windows.Forms.Button btn_SaveDQList;
        private System.Windows.Forms.Button btn_ShowDQList;
        private System.Windows.Forms.Button btn_GetDQList;
        private System.Windows.Forms.Button btn_PurgeItem;
        private System.Windows.Forms.TextBox tb_archRef;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_archRef2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_getArchFormTask;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Button btn_saveArchFormTask;
        private System.Windows.Forms.Button btn_showArchivedFormTask;
        private System.Windows.Forms.TextBox tb_languageId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage5;
        private Archive.UserControls.GetFormsetPdf uscGetFormsetPdf;
    }
}