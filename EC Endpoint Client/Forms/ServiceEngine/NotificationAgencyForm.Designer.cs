namespace EC_Endpoint_Client.Forms.ServiceEngine
{
    partial class NotificationAgencyForm
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
            this.btn_SSNLoadShip = new System.Windows.Forms.Button();
            this.btn_SSNSaveShip = new System.Windows.Forms.Button();
            this.btn_SSNInvoke = new System.Windows.Forms.Button();
            this.btn_SSNShowShip = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_TestInvoke = new System.Windows.Forms.Button();
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
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_SSNLoadShip);
            this.tabPage1.Controls.Add(this.btn_SSNSaveShip);
            this.tabPage1.Controls.Add(this.btn_SSNInvoke);
            this.tabPage1.Controls.Add(this.btn_SSNShowShip);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SendStandaloneNotification";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_SSNLoadShip
            // 
            this.btn_SSNLoadShip.Location = new System.Drawing.Point(6, 64);
            this.btn_SSNLoadShip.Name = "btn_SSNLoadShip";
            this.btn_SSNLoadShip.Size = new System.Drawing.Size(118, 23);
            this.btn_SSNLoadShip.TabIndex = 8;
            this.btn_SSNLoadShip.Text = "Load Shipment";
            this.btn_SSNLoadShip.UseVisualStyleBackColor = true;
            this.btn_SSNLoadShip.Click += new System.EventHandler(this.btn_SSNLoadShip_Click);
            // 
            // btn_SSNSaveShip
            // 
            this.btn_SSNSaveShip.Location = new System.Drawing.Point(6, 35);
            this.btn_SSNSaveShip.Name = "btn_SSNSaveShip";
            this.btn_SSNSaveShip.Size = new System.Drawing.Size(118, 23);
            this.btn_SSNSaveShip.TabIndex = 10;
            this.btn_SSNSaveShip.Text = "Save Shipment";
            this.btn_SSNSaveShip.UseVisualStyleBackColor = true;
            this.btn_SSNSaveShip.Click += new System.EventHandler(this.btn_SSNSaveShip_Click);
            // 
            // btn_SSNInvoke
            // 
            this.btn_SSNInvoke.Location = new System.Drawing.Point(294, 6);
            this.btn_SSNInvoke.Name = "btn_SSNInvoke";
            this.btn_SSNInvoke.Size = new System.Drawing.Size(118, 23);
            this.btn_SSNInvoke.TabIndex = 11;
            this.btn_SSNInvoke.Text = "Invoke Service";
            this.btn_SSNInvoke.UseVisualStyleBackColor = true;
            this.btn_SSNInvoke.Click += new System.EventHandler(this.btn_SSNInvoke_Click);
            // 
            // btn_SSNShowShip
            // 
            this.btn_SSNShowShip.Location = new System.Drawing.Point(6, 6);
            this.btn_SSNShowShip.Name = "btn_SSNShowShip";
            this.btn_SSNShowShip.Size = new System.Drawing.Size(118, 23);
            this.btn_SSNShowShip.TabIndex = 12;
            this.btn_SSNShowShip.Text = "Show Shipment";
            this.btn_SSNShowShip.UseVisualStyleBackColor = true;
            this.btn_SSNShowShip.Click += new System.EventHandler(this.btn_SSNShowShip_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_TestInvoke);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Test";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_TestInvoke
            // 
            this.btn_TestInvoke.Location = new System.Drawing.Point(6, 6);
            this.btn_TestInvoke.Name = "btn_TestInvoke";
            this.btn_TestInvoke.Size = new System.Drawing.Size(106, 23);
            this.btn_TestInvoke.TabIndex = 0;
            this.btn_TestInvoke.Text = "Test";
            this.btn_TestInvoke.UseVisualStyleBackColor = true;
            this.btn_TestInvoke.Click += new System.EventHandler(this.btn_TestInvoke_Click);
            // 
            // NotificationAgencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Name = "NotificationAgencyForm";
            this.Text = "NotificationAgencyForm";
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
        private System.Windows.Forms.Button btn_SSNLoadShip;
        private System.Windows.Forms.Button btn_SSNSaveShip;
        private System.Windows.Forms.Button btn_SSNInvoke;
        private System.Windows.Forms.Button btn_SSNShowShip;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_TestInvoke;
    }
}