namespace EC_Endpoint_Client.Forms.Archive
{
    partial class ArchiveCommonAgencyForm
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.getServiceOwnerArchiveReporteeElements = new EC_Endpoint_Client.UserControls.ActionHolderControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.testController = new EC_Endpoint_Client.UserControls.ActionHolderControl();
            this.servicePanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(609, 9);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(609, 35);
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(706, 6);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(706, 32);
            // 
            // pg_objectViewer
            // 
            this.pg_objectViewer.Size = new System.Drawing.Size(388, 371);
            // 
            // servicePanel
            // 
            this.servicePanel.Controls.Add(this.tabControl1);
            this.servicePanel.Size = new System.Drawing.Size(425, 371);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(425, 371);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.getServiceOwnerArchiveReporteeElements);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 345);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "GetServiceOwnerArchiveReporteeElements";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // getServiceOwnerArchiveReporteeElements
            // 
            this.getServiceOwnerArchiveReporteeElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getServiceOwnerArchiveReporteeElements.Location = new System.Drawing.Point(3, 3);
            this.getServiceOwnerArchiveReporteeElements.Name = "getServiceOwnerArchiveReporteeElements";
            this.getServiceOwnerArchiveReporteeElements.Size = new System.Drawing.Size(411, 339);
            this.getServiceOwnerArchiveReporteeElements.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.testController);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 345);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Test";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // testController
            // 
            this.testController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testController.Location = new System.Drawing.Point(3, 3);
            this.testController.Name = "testController";
            this.testController.Size = new System.Drawing.Size(411, 339);
            this.testController.TabIndex = 0;
            // 
            // ArchiveCommonAgencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 465);
            this.Name = "ArchiveCommonAgencyForm";
            this.Text = "ArchiveCommonAgency";
            this.servicePanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private EC_Endpoint_Client.UserControls.ActionHolderControl getServiceOwnerArchiveReporteeElements;
        private EC_Endpoint_Client.UserControls.ActionHolderControl testController;
    }
}