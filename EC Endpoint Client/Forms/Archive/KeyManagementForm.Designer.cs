namespace EC_Endpoint_Client.Forms
{
    partial class KeyManagementForm
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
            this.btn_SaveCertificateBEList = new System.Windows.Forms.Button();
            this.btn_ShowCertificateBEList = new System.Windows.Forms.Button();
            this.btn_showShipment = new System.Windows.Forms.Button();
            this.btn_getCertificateBEList = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
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
            this.tabPage1.Controls.Add(this.btn_SaveCertificateBEList);
            this.tabPage1.Controls.Add(this.btn_ShowCertificateBEList);
            this.tabPage1.Controls.Add(this.btn_showShipment);
            this.tabPage1.Controls.Add(this.btn_getCertificateBEList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GetCertificateBEList";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_SaveCertificateBEList
            // 
            this.btn_SaveCertificateBEList.Location = new System.Drawing.Point(277, 64);
            this.btn_SaveCertificateBEList.Name = "btn_SaveCertificateBEList";
            this.btn_SaveCertificateBEList.Size = new System.Drawing.Size(135, 23);
            this.btn_SaveCertificateBEList.TabIndex = 0;
            this.btn_SaveCertificateBEList.Text = "SaveCertificateBEList";
            this.btn_SaveCertificateBEList.UseVisualStyleBackColor = true;
            this.btn_SaveCertificateBEList.Click += new System.EventHandler(this.btn_SaveCertificateBEList_Click);
            // 
            // btn_ShowCertificateBEList
            // 
            this.btn_ShowCertificateBEList.Location = new System.Drawing.Point(277, 35);
            this.btn_ShowCertificateBEList.Name = "btn_ShowCertificateBEList";
            this.btn_ShowCertificateBEList.Size = new System.Drawing.Size(135, 23);
            this.btn_ShowCertificateBEList.TabIndex = 0;
            this.btn_ShowCertificateBEList.Text = "ShowCertificateBEList";
            this.btn_ShowCertificateBEList.UseVisualStyleBackColor = true;
            this.btn_ShowCertificateBEList.Click += new System.EventHandler(this.btn_ShowCertificateBEList_Click);
            // 
            // btn_showShipment
            // 
            this.btn_showShipment.Location = new System.Drawing.Point(6, 6);
            this.btn_showShipment.Name = "btn_showShipment";
            this.btn_showShipment.Size = new System.Drawing.Size(135, 23);
            this.btn_showShipment.TabIndex = 0;
            this.btn_showShipment.Text = "Show Shipment";
            this.btn_showShipment.UseVisualStyleBackColor = true;
            this.btn_showShipment.Click += new System.EventHandler(this.btn_showShipment_Click);
            // 
            // btn_getCertificateBEList
            // 
            this.btn_getCertificateBEList.Location = new System.Drawing.Point(277, 6);
            this.btn_getCertificateBEList.Name = "btn_getCertificateBEList";
            this.btn_getCertificateBEList.Size = new System.Drawing.Size(135, 23);
            this.btn_getCertificateBEList.TabIndex = 0;
            this.btn_getCertificateBEList.Text = "Invoke Service";
            this.btn_getCertificateBEList.UseVisualStyleBackColor = true;
            this.btn_getCertificateBEList.Click += new System.EventHandler(this.btn_getCertificateBEList_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Test";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KeyManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Name = "KeyManagementForm";
            this.Text = "KeyManagementForm";
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
        private System.Windows.Forms.Button btn_getCertificateBEList;
        private System.Windows.Forms.Button btn_SaveCertificateBEList;
        private System.Windows.Forms.Button btn_ShowCertificateBEList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_showShipment;
    }
}