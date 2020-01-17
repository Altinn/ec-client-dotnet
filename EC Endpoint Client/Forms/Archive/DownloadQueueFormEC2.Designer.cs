namespace EC_Endpoint_Client.Forms.Archive
{
    partial class DownloadQueueFormEC2
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
            this.getDqi = new EC_Endpoint_Client.UserControls.ActionHolderControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.uscGetFormsetPdf = new EC_Endpoint_Client.Forms.Archive.UserControls.GetFormsetPdf();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_test = new System.Windows.Forms.Button();
            this.purgeItemCtrl = new EC_Endpoint_Client.UserControls.ActionHolderControl();
            this.getArchivedFTctrl = new EC_Endpoint_Client.UserControls.ActionHolderControl();
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
            this.tabPage1.Controls.Add(this.getDqi);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GetDownloadQueueItems";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // getDqi
            // 
            this.getDqi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getDqi.Location = new System.Drawing.Point(3, 3);
            this.getDqi.Name = "getDqi";
            this.getDqi.Size = new System.Drawing.Size(411, 337);
            this.getDqi.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.purgeItemCtrl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PurgeItem";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.getArchivedFTctrl);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(417, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "GetArchivedFormTask";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // purgeItemCtrl
            // 
            this.purgeItemCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purgeItemCtrl.Location = new System.Drawing.Point(3, 3);
            this.purgeItemCtrl.Name = "purgeItemCtrl";
            this.purgeItemCtrl.Size = new System.Drawing.Size(411, 337);
            this.purgeItemCtrl.TabIndex = 0;
            // 
            // getArchivedFTctrl
            // 
            this.getArchivedFTctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getArchivedFTctrl.Location = new System.Drawing.Point(3, 3);
            this.getArchivedFTctrl.Name = "getArchivedFTctrl";
            this.getArchivedFTctrl.Size = new System.Drawing.Size(411, 337);
            this.getArchivedFTctrl.TabIndex = 0;
            // 
            // DownloadQueueFormEC2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Name = "DownloadQueueFormEC2";
            this.Text = "DownloadQueueFormEC2";
            this.servicePanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage GetDQTabPage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.TabPage tabPage5;
        private Archive.UserControls.GetFormsetPdf uscGetFormsetPdf;
        private EC_Endpoint_Client.UserControls.ActionHolderControl getDqi;
        private EC_Endpoint_Client.UserControls.ActionHolderControl purgeItemCtrl;
        private EC_Endpoint_Client.UserControls.ActionHolderControl getArchivedFTctrl;
    }
}