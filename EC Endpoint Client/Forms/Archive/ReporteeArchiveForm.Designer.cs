namespace EC_Endpoint_Client.Forms.Archive
{
    partial class ReporteeArchiveForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.getArchFTctrl = new EC_Endpoint_Client.UserControls.ActionHolderControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.getArchivedLookupController = new EC_Endpoint_Client.UserControls.ActionHolderControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.getAttachmentDataController = new EC_Endpoint_Client.UserControls.ActionHolderControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.getArchivedCorrespondenceController = new EC_Endpoint_Client.UserControls.ActionHolderControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.testController = new EC_Endpoint_Client.UserControls.ActionHolderControl();
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
            this.tabPage1.Controls.Add(this.getArchFTctrl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GetArchivedFormTask";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // getArchFTctrl
            // 
            this.getArchFTctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getArchFTctrl.Location = new System.Drawing.Point(3, 3);
            this.getArchFTctrl.Name = "getArchFTctrl";
            this.getArchFTctrl.Size = new System.Drawing.Size(411, 337);
            this.getArchFTctrl.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.getArchivedLookupController);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GetArchivedLookup";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // getArchivedLookupController
            // 
            this.getArchivedLookupController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getArchivedLookupController.Location = new System.Drawing.Point(3, 3);
            this.getArchivedLookupController.Name = "getArchivedLookupController";
            this.getArchivedLookupController.Size = new System.Drawing.Size(411, 337);
            this.getArchivedLookupController.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.getAttachmentDataController);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(417, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "GetAttachmentData";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // getAttachmentDataController
            // 
            this.getAttachmentDataController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getAttachmentDataController.Location = new System.Drawing.Point(3, 3);
            this.getAttachmentDataController.Name = "getAttachmentDataController";
            this.getAttachmentDataController.Size = new System.Drawing.Size(411, 337);
            this.getAttachmentDataController.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.getArchivedCorrespondenceController);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(417, 343);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "GetArchivedCorrespondence";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // getArchivedCorrespondenceController
            // 
            this.getArchivedCorrespondenceController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getArchivedCorrespondenceController.Location = new System.Drawing.Point(3, 3);
            this.getArchivedCorrespondenceController.Name = "getArchivedCorrespondenceController";
            this.getArchivedCorrespondenceController.Size = new System.Drawing.Size(411, 337);
            this.getArchivedCorrespondenceController.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.testController);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(417, 343);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Test";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // testController
            // 
            this.testController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testController.Location = new System.Drawing.Point(3, 3);
            this.testController.Name = "testController";
            this.testController.Size = new System.Drawing.Size(411, 337);
            this.testController.TabIndex = 0;
            // 
            // ReporteeArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Name = "ReporteeArchiveForm";
            this.Text = "ReporteeArchiveForm";
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

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private EC_Endpoint_Client.UserControls.ActionHolderControl getArchFTctrl;
        private EC_Endpoint_Client.UserControls.ActionHolderControl getArchivedLookupController;
        private EC_Endpoint_Client.UserControls.ActionHolderControl getAttachmentDataController;
        private EC_Endpoint_Client.UserControls.ActionHolderControl testController;
        private System.Windows.Forms.TabPage tabPage5;
        private EC_Endpoint_Client.UserControls.ActionHolderControl getArchivedCorrespondenceController;
    }
}