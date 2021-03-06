﻿namespace EC_Endpoint_Client.Forms.Authorization
{
    partial class AuthorizationAdministrationFormEC2
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.controllerGetReporteeByTempKey = new EC_Endpoint_Client.UserControls.ActionHolderControl();
            this.controllerGetReportees = new EC_Endpoint_Client.UserControls.ActionHolderControl();
            this.testController = new EC_Endpoint_Client.UserControls.ActionHolderControl();
            this.servicePanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(425, 369);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.controllerGetReporteeByTempKey);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GetReporteeByTempKey";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.controllerGetReportees);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GetReportees";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.testController);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(417, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Test";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // controllerGetReporteeByTempKey
            // 
            this.controllerGetReporteeByTempKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controllerGetReporteeByTempKey.Location = new System.Drawing.Point(3, 3);
            this.controllerGetReporteeByTempKey.Name = "controllerGetReporteeByTempKey";
            this.controllerGetReporteeByTempKey.Size = new System.Drawing.Size(411, 337);
            this.controllerGetReporteeByTempKey.TabIndex = 0;
            // 
            // controllerGetReportees
            // 
            this.controllerGetReportees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controllerGetReportees.Location = new System.Drawing.Point(3, 3);
            this.controllerGetReportees.Name = "controllerGetReportees";
            this.controllerGetReportees.Size = new System.Drawing.Size(411, 337);
            this.controllerGetReportees.TabIndex = 0;
            // 
            // testController
            // 
            this.testController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testController.Location = new System.Drawing.Point(3, 3);
            this.testController.Name = "testController";
            this.testController.Size = new System.Drawing.Size(411, 337);
            this.testController.TabIndex = 0;
            // 
            // AuthorizationAdministrationFormEC2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Name = "AuthorizationAdministrationFormEC2";
            this.Text = "AuthorizationAdministrationFormEC2";
            this.servicePanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private UserControls.ActionHolderControl controllerGetReporteeByTempKey;
        private UserControls.ActionHolderControl controllerGetReportees;
        private UserControls.ActionHolderControl testController;
    }
}