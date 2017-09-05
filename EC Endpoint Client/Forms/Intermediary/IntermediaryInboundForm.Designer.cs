namespace EC_Endpoint_Client.Forms.Intermediary
{
    partial class IntermediaryInboundForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_SaveFTReceipt = new System.Windows.Forms.Button();
            this.btn_ShowFTReceipt = new System.Windows.Forms.Button();
            this.btn_SubmitFormTask = new System.Windows.Forms.Button();
            this.btn_LoadFTShipment = new System.Windows.Forms.Button();
            this.btn_SaveFTShipment = new System.Windows.Forms.Button();
            this.btn_ShowFTShip = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_SaveSignReceipt = new System.Windows.Forms.Button();
            this.btn_showSignReceipt = new System.Windows.Forms.Button();
            this.btn_CompleteAndSign = new System.Windows.Forms.Button();
            this.btn_LoadShipment = new System.Windows.Forms.Button();
            this.btn_SaveShipment = new System.Windows.Forms.Button();
            this.btn_ShowCompleteSignShipment = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_ShowSubmissionStatus = new System.Windows.Forms.Button();
            this.btn_GetSubmissionStatus = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_Test = new System.Windows.Forms.Button();
            this.servicePanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btn_SaveFTReceipt);
            this.tabPage1.Controls.Add(this.btn_ShowFTReceipt);
            this.tabPage1.Controls.Add(this.btn_SubmitFormTask);
            this.tabPage1.Controls.Add(this.btn_LoadFTShipment);
            this.tabPage1.Controls.Add(this.btn_SaveFTShipment);
            this.tabPage1.Controls.Add(this.btn_ShowFTShip);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SubmitFormTask";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Attachment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_SaveFTReceipt
            // 
            this.btn_SaveFTReceipt.Location = new System.Drawing.Point(300, 64);
            this.btn_SaveFTReceipt.Name = "btn_SaveFTReceipt";
            this.btn_SaveFTReceipt.Size = new System.Drawing.Size(112, 23);
            this.btn_SaveFTReceipt.TabIndex = 0;
            this.btn_SaveFTReceipt.Text = "Save Receipt";
            this.btn_SaveFTReceipt.UseVisualStyleBackColor = true;
            this.btn_SaveFTReceipt.Click += new System.EventHandler(this.btn_SaveFTReceipt_Click);
            // 
            // btn_ShowFTReceipt
            // 
            this.btn_ShowFTReceipt.Location = new System.Drawing.Point(300, 35);
            this.btn_ShowFTReceipt.Name = "btn_ShowFTReceipt";
            this.btn_ShowFTReceipt.Size = new System.Drawing.Size(112, 23);
            this.btn_ShowFTReceipt.TabIndex = 0;
            this.btn_ShowFTReceipt.Text = "Show Receipt";
            this.btn_ShowFTReceipt.UseVisualStyleBackColor = true;
            this.btn_ShowFTReceipt.Click += new System.EventHandler(this.btn_ShowFTReceipt_Click);
            // 
            // btn_SubmitFormTask
            // 
            this.btn_SubmitFormTask.Location = new System.Drawing.Point(300, 6);
            this.btn_SubmitFormTask.Name = "btn_SubmitFormTask";
            this.btn_SubmitFormTask.Size = new System.Drawing.Size(112, 23);
            this.btn_SubmitFormTask.TabIndex = 0;
            this.btn_SubmitFormTask.Text = "Invoke Method";
            this.btn_SubmitFormTask.UseVisualStyleBackColor = true;
            this.btn_SubmitFormTask.Click += new System.EventHandler(this.btn_SubmitFormTask_Click);
            // 
            // btn_LoadFTShipment
            // 
            this.btn_LoadFTShipment.Location = new System.Drawing.Point(6, 64);
            this.btn_LoadFTShipment.Name = "btn_LoadFTShipment";
            this.btn_LoadFTShipment.Size = new System.Drawing.Size(114, 23);
            this.btn_LoadFTShipment.TabIndex = 0;
            this.btn_LoadFTShipment.Text = "Load Shipment";
            this.btn_LoadFTShipment.UseVisualStyleBackColor = true;
            this.btn_LoadFTShipment.Click += new System.EventHandler(this.btn_LoadFTShipment_Click);
            // 
            // btn_SaveFTShipment
            // 
            this.btn_SaveFTShipment.Location = new System.Drawing.Point(6, 35);
            this.btn_SaveFTShipment.Name = "btn_SaveFTShipment";
            this.btn_SaveFTShipment.Size = new System.Drawing.Size(114, 23);
            this.btn_SaveFTShipment.TabIndex = 0;
            this.btn_SaveFTShipment.Text = "Save Shipment";
            this.btn_SaveFTShipment.UseVisualStyleBackColor = true;
            this.btn_SaveFTShipment.Click += new System.EventHandler(this.btn_SaveFTShipment_Click);
            // 
            // btn_ShowFTShip
            // 
            this.btn_ShowFTShip.Location = new System.Drawing.Point(6, 6);
            this.btn_ShowFTShip.Name = "btn_ShowFTShip";
            this.btn_ShowFTShip.Size = new System.Drawing.Size(114, 23);
            this.btn_ShowFTShip.TabIndex = 0;
            this.btn_ShowFTShip.Text = "Show Shipment";
            this.btn_ShowFTShip.UseVisualStyleBackColor = true;
            this.btn_ShowFTShip.Click += new System.EventHandler(this.btn_ShowFTShip_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_SaveSignReceipt);
            this.tabPage2.Controls.Add(this.btn_showSignReceipt);
            this.tabPage2.Controls.Add(this.btn_CompleteAndSign);
            this.tabPage2.Controls.Add(this.btn_LoadShipment);
            this.tabPage2.Controls.Add(this.btn_SaveShipment);
            this.tabPage2.Controls.Add(this.btn_ShowCompleteSignShipment);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CompleteAndSign";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_SaveSignReceipt
            // 
            this.btn_SaveSignReceipt.Enabled = false;
            this.btn_SaveSignReceipt.Location = new System.Drawing.Point(300, 64);
            this.btn_SaveSignReceipt.Name = "btn_SaveSignReceipt";
            this.btn_SaveSignReceipt.Size = new System.Drawing.Size(112, 23);
            this.btn_SaveSignReceipt.TabIndex = 1;
            this.btn_SaveSignReceipt.Text = "Save Receipt";
            this.btn_SaveSignReceipt.UseVisualStyleBackColor = true;
            this.btn_SaveSignReceipt.Click += new System.EventHandler(this.btn_SaveSignReceipt_Click);
            // 
            // btn_showSignReceipt
            // 
            this.btn_showSignReceipt.Enabled = false;
            this.btn_showSignReceipt.Location = new System.Drawing.Point(300, 35);
            this.btn_showSignReceipt.Name = "btn_showSignReceipt";
            this.btn_showSignReceipt.Size = new System.Drawing.Size(112, 23);
            this.btn_showSignReceipt.TabIndex = 2;
            this.btn_showSignReceipt.Text = "Show Receipt";
            this.btn_showSignReceipt.UseVisualStyleBackColor = true;
            this.btn_showSignReceipt.Click += new System.EventHandler(this.btn_showSignReceipt_Click);
            // 
            // btn_CompleteAndSign
            // 
            this.btn_CompleteAndSign.Location = new System.Drawing.Point(300, 6);
            this.btn_CompleteAndSign.Name = "btn_CompleteAndSign";
            this.btn_CompleteAndSign.Size = new System.Drawing.Size(112, 23);
            this.btn_CompleteAndSign.TabIndex = 3;
            this.btn_CompleteAndSign.Text = "Invoke Method";
            this.btn_CompleteAndSign.UseVisualStyleBackColor = true;
            this.btn_CompleteAndSign.Click += new System.EventHandler(this.btn_CompleteAndSign_Click);
            // 
            // btn_LoadShipment
            // 
            this.btn_LoadShipment.Location = new System.Drawing.Point(6, 64);
            this.btn_LoadShipment.Name = "btn_LoadShipment";
            this.btn_LoadShipment.Size = new System.Drawing.Size(114, 23);
            this.btn_LoadShipment.TabIndex = 4;
            this.btn_LoadShipment.Text = "Load Shipment";
            this.btn_LoadShipment.UseVisualStyleBackColor = true;
            this.btn_LoadShipment.Click += new System.EventHandler(this.btn_LoadShipment_Click);
            // 
            // btn_SaveShipment
            // 
            this.btn_SaveShipment.Location = new System.Drawing.Point(6, 35);
            this.btn_SaveShipment.Name = "btn_SaveShipment";
            this.btn_SaveShipment.Size = new System.Drawing.Size(114, 23);
            this.btn_SaveShipment.TabIndex = 5;
            this.btn_SaveShipment.Text = "Save Shipment";
            this.btn_SaveShipment.UseVisualStyleBackColor = true;
            this.btn_SaveShipment.Click += new System.EventHandler(this.btn_SaveShipment_Click);
            // 
            // btn_ShowCompleteSignShipment
            // 
            this.btn_ShowCompleteSignShipment.Location = new System.Drawing.Point(6, 6);
            this.btn_ShowCompleteSignShipment.Name = "btn_ShowCompleteSignShipment";
            this.btn_ShowCompleteSignShipment.Size = new System.Drawing.Size(114, 23);
            this.btn_ShowCompleteSignShipment.TabIndex = 6;
            this.btn_ShowCompleteSignShipment.Text = "Show Shipment";
            this.btn_ShowCompleteSignShipment.UseVisualStyleBackColor = true;
            this.btn_ShowCompleteSignShipment.Click += new System.EventHandler(this.btn_ViewSignShipment);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_ShowSubmissionStatus);
            this.tabPage3.Controls.Add(this.btn_GetSubmissionStatus);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(417, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "GetSubmissionStatus";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_ShowSubmissionStatus
            // 
            this.btn_ShowSubmissionStatus.Location = new System.Drawing.Point(6, 35);
            this.btn_ShowSubmissionStatus.Name = "btn_ShowSubmissionStatus";
            this.btn_ShowSubmissionStatus.Size = new System.Drawing.Size(114, 23);
            this.btn_ShowSubmissionStatus.TabIndex = 6;
            this.btn_ShowSubmissionStatus.Text = "Show Result";
            this.btn_ShowSubmissionStatus.UseVisualStyleBackColor = true;
            this.btn_ShowSubmissionStatus.Click += new System.EventHandler(this.btn_ShowSubmissionStatus_Click);
            // 
            // btn_GetSubmissionStatus
            // 
            this.btn_GetSubmissionStatus.Location = new System.Drawing.Point(6, 6);
            this.btn_GetSubmissionStatus.Name = "btn_GetSubmissionStatus";
            this.btn_GetSubmissionStatus.Size = new System.Drawing.Size(114, 23);
            this.btn_GetSubmissionStatus.TabIndex = 6;
            this.btn_GetSubmissionStatus.Text = "Invoke Method";
            this.btn_GetSubmissionStatus.UseVisualStyleBackColor = true;
            this.btn_GetSubmissionStatus.Click += new System.EventHandler(this.btn_GetSubmissionStatus_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_Test);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(417, 343);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Test";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(6, 6);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(114, 23);
            this.btn_Test.TabIndex = 6;
            this.btn_Test.Text = "Test";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // IntermediaryInboundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Name = "IntermediaryInboundForm";
            this.Text = "IntermediaryInboundForm";
            this.servicePanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_SaveFTReceipt;
        private System.Windows.Forms.Button btn_ShowFTReceipt;
        private System.Windows.Forms.Button btn_SubmitFormTask;
        private System.Windows.Forms.Button btn_LoadFTShipment;
        private System.Windows.Forms.Button btn_SaveFTShipment;
        private System.Windows.Forms.Button btn_ShowFTShip;
        private System.Windows.Forms.Button btn_SaveSignReceipt;
        private System.Windows.Forms.Button btn_showSignReceipt;
        private System.Windows.Forms.Button btn_CompleteAndSign;
        private System.Windows.Forms.Button btn_LoadShipment;
        private System.Windows.Forms.Button btn_SaveShipment;
        private System.Windows.Forms.Button btn_ShowCompleteSignShipment;
        private System.Windows.Forms.Button btn_GetSubmissionStatus;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Button btn_ShowSubmissionStatus;
        private System.Windows.Forms.Button button1;
    }
}