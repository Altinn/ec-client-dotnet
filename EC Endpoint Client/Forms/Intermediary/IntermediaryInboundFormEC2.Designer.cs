namespace EC_Endpoint_Client.Forms.Intermediary
{
    partial class IntermediaryInboundFormEC2
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
            this.controllerCompleteAndSign = new EC_Endpoint_Client.UserControls.ActionHolderControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.controllerGetSubmissionStatus = new EC_Endpoint_Client.UserControls.ActionHolderControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.testController = new EC_Endpoint_Client.UserControls.ActionHolderControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.actionHolder_UpdateFormData = new EC_Endpoint_Client.UserControls.ActionHolderControl();
            this.servicePanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
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
            this.tabPage2.Controls.Add(this.controllerCompleteAndSign);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CompleteAndSign";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // controllerCompleteAndSign
            // 
            this.controllerCompleteAndSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controllerCompleteAndSign.Location = new System.Drawing.Point(3, 3);
            this.controllerCompleteAndSign.Name = "controllerCompleteAndSign";
            this.controllerCompleteAndSign.Size = new System.Drawing.Size(411, 337);
            this.controllerCompleteAndSign.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.controllerGetSubmissionStatus);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(417, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "GetSubmissionStatus";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // controllerGetSubmissionStatus
            // 
            this.controllerGetSubmissionStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controllerGetSubmissionStatus.Location = new System.Drawing.Point(3, 3);
            this.controllerGetSubmissionStatus.Name = "controllerGetSubmissionStatus";
            this.controllerGetSubmissionStatus.Size = new System.Drawing.Size(411, 337);
            this.controllerGetSubmissionStatus.TabIndex = 0;
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
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.actionHolder_UpdateFormData);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(417, 343);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "UpdateFormData";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // actionHolder_UpdateFormData
            // 
            this.actionHolder_UpdateFormData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionHolder_UpdateFormData.Location = new System.Drawing.Point(3, 3);
            this.actionHolder_UpdateFormData.Name = "actionHolder_UpdateFormData";
            this.actionHolder_UpdateFormData.Size = new System.Drawing.Size(411, 337);
            this.actionHolder_UpdateFormData.TabIndex = 0;
            // 
            // IntermediaryInboundFormEC2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Name = "IntermediaryInboundFormEC2";
            this.Text = "IntermediaryInboundFormEC2";
            this.servicePanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private UserControls.ActionHolderControl controllerCompleteAndSign;
        private UserControls.ActionHolderControl controllerGetSubmissionStatus;
        private UserControls.ActionHolderControl testController;
        private System.Windows.Forms.TabPage tabPage5;
        private UserControls.ActionHolderControl actionHolder_UpdateFormData;
    }
}