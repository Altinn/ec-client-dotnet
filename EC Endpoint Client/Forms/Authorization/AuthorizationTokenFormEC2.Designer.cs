namespace EC_Endpoint_Client.Forms.Authorization
{
    partial class AuthorizationTokenFormEC2
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
            this.testTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.controllerGetRightsByToken = new EC_Endpoint_Client.UserControls.ActionHolderControl();
            this.testController = new EC_Endpoint_Client.UserControls.ActionHolderControl();
            this.btn_SaveReporteeList = new System.Windows.Forms.Button();
            this.btn_showReporteeArray = new System.Windows.Forms.Button();
            this.btn_getReporteeList = new System.Windows.Forms.Button();
            this.btn_ShowShipment = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.servicePanel.SuspendLayout();
            this.testTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // servicePanel
            // 
            this.servicePanel.Controls.Add(this.testTabControl);
            // 
            // testTabControl
            // 
            this.testTabControl.Controls.Add(this.tabPage1);
            this.testTabControl.Controls.Add(this.tabPage2);
            this.testTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testTabControl.Location = new System.Drawing.Point(0, 0);
            this.testTabControl.Name = "testTabControl";
            this.testTabControl.SelectedIndex = 0;
            this.testTabControl.Size = new System.Drawing.Size(425, 369);
            this.testTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.controllerGetRightsByToken);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GetRightsByToken";
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
            // controllerGetRightsByToken
            // 
            this.controllerGetRightsByToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controllerGetRightsByToken.Location = new System.Drawing.Point(3, 3);
            this.controllerGetRightsByToken.Name = "controllerGetRightsByToken";
            this.controllerGetRightsByToken.Size = new System.Drawing.Size(411, 337);
            this.controllerGetRightsByToken.TabIndex = 0;
            // 
            // testController
            // 
            this.testController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testController.Location = new System.Drawing.Point(3, 3);
            this.testController.Name = "testController";
            this.testController.Size = new System.Drawing.Size(598, 197);
            this.testController.TabIndex = 0;
            // 
            // btn_SaveReporteeList
            // 
            this.btn_SaveReporteeList.Location = new System.Drawing.Point(0, 0);
            this.btn_SaveReporteeList.Name = "btn_SaveReporteeList";
            this.btn_SaveReporteeList.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveReporteeList.TabIndex = 0;
            // 
            // btn_showReporteeArray
            // 
            this.btn_showReporteeArray.Location = new System.Drawing.Point(0, 0);
            this.btn_showReporteeArray.Name = "btn_showReporteeArray";
            this.btn_showReporteeArray.Size = new System.Drawing.Size(75, 23);
            this.btn_showReporteeArray.TabIndex = 0;
            // 
            // btn_getReporteeList
            // 
            this.btn_getReporteeList.Location = new System.Drawing.Point(0, 0);
            this.btn_getReporteeList.Name = "btn_getReporteeList";
            this.btn_getReporteeList.Size = new System.Drawing.Size(75, 23);
            this.btn_getReporteeList.TabIndex = 0;
            // 
            // btn_ShowShipment
            // 
            this.btn_ShowShipment.Location = new System.Drawing.Point(0, 0);
            this.btn_ShowShipment.Name = "btn_ShowShipment";
            this.btn_ShowShipment.Size = new System.Drawing.Size(75, 23);
            this.btn_ShowShipment.TabIndex = 0;
            // 
            // AuthorizationTokenFormEC2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Name = "AuthorizationTokenFormEC2";
            this.Text = "AuthorizationAdministrationForm";
            this.servicePanel.ResumeLayout(false);
            this.testTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl testTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_SaveReporteeList;
        private System.Windows.Forms.Button btn_showReporteeArray;
        private System.Windows.Forms.Button btn_getReporteeList;
        private System.Windows.Forms.Button btn_ShowShipment;
        private UserControls.ActionHolderControl controllerGetRightsByToken;
        private UserControls.ActionHolderControl testController;
        private System.Windows.Forms.TabPage tabPage2;
    }
}