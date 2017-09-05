namespace EC_Endpoint_Client.Forms.Authorization
{
    partial class AuthorizationAdministrationForm
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
            this.btn_SaveReportee = new System.Windows.Forms.Button();
            this.btn_ShowReportee = new System.Windows.Forms.Button();
            this.btn_GetReportee = new System.Windows.Forms.Button();
            this.btn_showTempKey = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_SaveReporteeList = new System.Windows.Forms.Button();
            this.btn_showReporteeArray = new System.Windows.Forms.Button();
            this.btn_getReporteeList = new System.Windows.Forms.Button();
            this.btn_ShowShipment = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
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
            this.tabPage1.Controls.Add(this.btn_SaveReportee);
            this.tabPage1.Controls.Add(this.btn_ShowReportee);
            this.tabPage1.Controls.Add(this.btn_GetReportee);
            this.tabPage1.Controls.Add(this.btn_showTempKey);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GetReporteeByTempKey";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_SaveReportee
            // 
            this.btn_SaveReportee.Location = new System.Drawing.Point(288, 64);
            this.btn_SaveReportee.Name = "btn_SaveReportee";
            this.btn_SaveReportee.Size = new System.Drawing.Size(124, 23);
            this.btn_SaveReportee.TabIndex = 0;
            this.btn_SaveReportee.Text = "SaveReportee";
            this.btn_SaveReportee.UseVisualStyleBackColor = true;
            this.btn_SaveReportee.Click += new System.EventHandler(this.btn_SaveReportee_Click);
            // 
            // btn_ShowReportee
            // 
            this.btn_ShowReportee.Location = new System.Drawing.Point(288, 35);
            this.btn_ShowReportee.Name = "btn_ShowReportee";
            this.btn_ShowReportee.Size = new System.Drawing.Size(124, 23);
            this.btn_ShowReportee.TabIndex = 0;
            this.btn_ShowReportee.Text = "ShowReportee";
            this.btn_ShowReportee.UseVisualStyleBackColor = true;
            this.btn_ShowReportee.Click += new System.EventHandler(this.btn_ShowReportee_Click);
            // 
            // btn_GetReportee
            // 
            this.btn_GetReportee.Location = new System.Drawing.Point(288, 6);
            this.btn_GetReportee.Name = "btn_GetReportee";
            this.btn_GetReportee.Size = new System.Drawing.Size(124, 23);
            this.btn_GetReportee.TabIndex = 0;
            this.btn_GetReportee.Text = "Invoke Service";
            this.btn_GetReportee.UseVisualStyleBackColor = true;
            this.btn_GetReportee.Click += new System.EventHandler(this.btn_GetReportee_Click);
            // 
            // btn_showTempKey
            // 
            this.btn_showTempKey.Location = new System.Drawing.Point(6, 6);
            this.btn_showTempKey.Name = "btn_showTempKey";
            this.btn_showTempKey.Size = new System.Drawing.Size(124, 23);
            this.btn_showTempKey.TabIndex = 0;
            this.btn_showTempKey.Text = "Show Shipment";
            this.btn_showTempKey.UseVisualStyleBackColor = true;
            this.btn_showTempKey.Click += new System.EventHandler(this.btn_showTempKey_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_SaveReporteeList);
            this.tabPage2.Controls.Add(this.btn_showReporteeArray);
            this.tabPage2.Controls.Add(this.btn_getReporteeList);
            this.tabPage2.Controls.Add(this.btn_ShowShipment);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GetReportees";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_SaveReporteeList
            // 
            this.btn_SaveReporteeList.Location = new System.Drawing.Point(293, 64);
            this.btn_SaveReporteeList.Name = "btn_SaveReporteeList";
            this.btn_SaveReporteeList.Size = new System.Drawing.Size(119, 23);
            this.btn_SaveReporteeList.TabIndex = 0;
            this.btn_SaveReporteeList.Text = "SaveReportees";
            this.btn_SaveReporteeList.UseVisualStyleBackColor = true;
            this.btn_SaveReporteeList.Click += new System.EventHandler(this.btn_SaveReporteeList_Click);
            // 
            // btn_showReporteeArray
            // 
            this.btn_showReporteeArray.Location = new System.Drawing.Point(293, 35);
            this.btn_showReporteeArray.Name = "btn_showReporteeArray";
            this.btn_showReporteeArray.Size = new System.Drawing.Size(119, 23);
            this.btn_showReporteeArray.TabIndex = 0;
            this.btn_showReporteeArray.Text = "ShowReportees";
            this.btn_showReporteeArray.UseVisualStyleBackColor = true;
            this.btn_showReporteeArray.Click += new System.EventHandler(this.btn_showReporteeArray_Click);
            // 
            // btn_getReporteeList
            // 
            this.btn_getReporteeList.Location = new System.Drawing.Point(293, 6);
            this.btn_getReporteeList.Name = "btn_getReporteeList";
            this.btn_getReporteeList.Size = new System.Drawing.Size(119, 23);
            this.btn_getReporteeList.TabIndex = 0;
            this.btn_getReporteeList.Text = "Invoke Service";
            this.btn_getReporteeList.UseVisualStyleBackColor = true;
            this.btn_getReporteeList.Click += new System.EventHandler(this.btn_getReporteeList_Click);
            // 
            // btn_ShowShipment
            // 
            this.btn_ShowShipment.Location = new System.Drawing.Point(6, 6);
            this.btn_ShowShipment.Name = "btn_ShowShipment";
            this.btn_ShowShipment.Size = new System.Drawing.Size(119, 23);
            this.btn_ShowShipment.TabIndex = 0;
            this.btn_ShowShipment.Text = "Show Shipment";
            this.btn_ShowShipment.UseVisualStyleBackColor = true;
            this.btn_ShowShipment.Click += new System.EventHandler(this.btn_ShowShipment_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(417, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Test";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // AuthorizationAdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Name = "AuthorizationAdministrationForm";
            this.Text = "AuthorizationAdministrationForm";
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
        private System.Windows.Forms.Button btn_SaveReportee;
        private System.Windows.Forms.Button btn_ShowReportee;
        private System.Windows.Forms.Button btn_GetReportee;
        private System.Windows.Forms.Button btn_showTempKey;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_SaveReporteeList;
        private System.Windows.Forms.Button btn_showReporteeArray;
        private System.Windows.Forms.Button btn_getReporteeList;
        private System.Windows.Forms.Button btn_ShowShipment;
    }
}