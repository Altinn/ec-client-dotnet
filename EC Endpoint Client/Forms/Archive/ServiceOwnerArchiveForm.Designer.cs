namespace EC_Endpoint_Client.Forms.Archive
{
    partial class ServiceOwnerArchiveForm
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.getArchivedFormTaskController = new EC_Endpoint_Client.UserControls.ActionHolderControl();
            this.testController = new EC_Endpoint_Client.UserControls.ActionHolderControl();
            this.servicePanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(425, 369);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.getArchivedFormTaskController);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GetArchivedFormTask";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.testController);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Test";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // getArchivedFormTaskController
            // 
            this.getArchivedFormTaskController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getArchivedFormTaskController.Location = new System.Drawing.Point(3, 3);
            this.getArchivedFormTaskController.Name = "getArchivedFormTaskController";
            this.getArchivedFormTaskController.Size = new System.Drawing.Size(411, 337);
            this.getArchivedFormTaskController.TabIndex = 0;
            // 
            // testController
            // 
            this.testController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testController.Location = new System.Drawing.Point(3, 3);
            this.testController.Name = "testController";
            this.testController.Size = new System.Drawing.Size(411, 337);
            this.testController.TabIndex = 0;
            // 
            // ServiceOwnerArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Name = "ServiceOwnerArchiveForm";
            this.Text = "ServiceOwnerArchiveForm";
            this.servicePanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private EC_Endpoint_Client.UserControls.ActionHolderControl getArchivedFormTaskController;
        private EC_Endpoint_Client.UserControls.ActionHolderControl testController;
    }
}