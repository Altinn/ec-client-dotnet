namespace EC_Endpoint_Client.Forms.ServiceEngine
{
    partial class SubscriptionAgencyForm
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
            this.btn_SSSaveResult = new System.Windows.Forms.Button();
            this.btn_SSLoadShip = new System.Windows.Forms.Button();
            this.btn_SSShowResult = new System.Windows.Forms.Button();
            this.btn_SSSaveShip = new System.Windows.Forms.Button();
            this.btn_SSInvoke = new System.Windows.Forms.Button();
            this.btn_SSShowShip = new System.Windows.Forms.Button();
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
            this.tabPage1.Controls.Add(this.btn_SSSaveResult);
            this.tabPage1.Controls.Add(this.btn_SSLoadShip);
            this.tabPage1.Controls.Add(this.btn_SSShowResult);
            this.tabPage1.Controls.Add(this.btn_SSSaveShip);
            this.tabPage1.Controls.Add(this.btn_SSInvoke);
            this.tabPage1.Controls.Add(this.btn_SSShowShip);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SubmitSubscription";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_SSSaveResult
            // 
            this.btn_SSSaveResult.Location = new System.Drawing.Point(294, 64);
            this.btn_SSSaveResult.Name = "btn_SSSaveResult";
            this.btn_SSSaveResult.Size = new System.Drawing.Size(118, 23);
            this.btn_SSSaveResult.TabIndex = 7;
            this.btn_SSSaveResult.Text = "Save Result";
            this.btn_SSSaveResult.UseVisualStyleBackColor = true;
            this.btn_SSSaveResult.Click += new System.EventHandler(this.btn_SSSaveResult_Click);
            // 
            // btn_SSLoadShip
            // 
            this.btn_SSLoadShip.Location = new System.Drawing.Point(6, 64);
            this.btn_SSLoadShip.Name = "btn_SSLoadShip";
            this.btn_SSLoadShip.Size = new System.Drawing.Size(118, 23);
            this.btn_SSLoadShip.TabIndex = 8;
            this.btn_SSLoadShip.Text = "Load Shipment";
            this.btn_SSLoadShip.UseVisualStyleBackColor = true;
            this.btn_SSLoadShip.Click += new System.EventHandler(this.btn_SSLoadShip_Click);
            // 
            // btn_SSShowResult
            // 
            this.btn_SSShowResult.Location = new System.Drawing.Point(294, 35);
            this.btn_SSShowResult.Name = "btn_SSShowResult";
            this.btn_SSShowResult.Size = new System.Drawing.Size(118, 23);
            this.btn_SSShowResult.TabIndex = 9;
            this.btn_SSShowResult.Text = "Show Result";
            this.btn_SSShowResult.UseVisualStyleBackColor = true;
            this.btn_SSShowResult.Click += new System.EventHandler(this.btn_SSShowResult_Click);
            // 
            // btn_SSSaveShip
            // 
            this.btn_SSSaveShip.Location = new System.Drawing.Point(6, 35);
            this.btn_SSSaveShip.Name = "btn_SSSaveShip";
            this.btn_SSSaveShip.Size = new System.Drawing.Size(118, 23);
            this.btn_SSSaveShip.TabIndex = 10;
            this.btn_SSSaveShip.Text = "Save Shipment";
            this.btn_SSSaveShip.UseVisualStyleBackColor = true;
            this.btn_SSSaveShip.Click += new System.EventHandler(this.btn_SSSaveShip_Click);
            // 
            // btn_SSInvoke
            // 
            this.btn_SSInvoke.Location = new System.Drawing.Point(294, 6);
            this.btn_SSInvoke.Name = "btn_SSInvoke";
            this.btn_SSInvoke.Size = new System.Drawing.Size(118, 23);
            this.btn_SSInvoke.TabIndex = 11;
            this.btn_SSInvoke.Text = "Invoke Service";
            this.btn_SSInvoke.UseVisualStyleBackColor = true;
            this.btn_SSInvoke.Click += new System.EventHandler(this.btn_SSInvoke_Click);
            // 
            // btn_SSShowShip
            // 
            this.btn_SSShowShip.Location = new System.Drawing.Point(6, 6);
            this.btn_SSShowShip.Name = "btn_SSShowShip";
            this.btn_SSShowShip.Size = new System.Drawing.Size(118, 23);
            this.btn_SSShowShip.TabIndex = 12;
            this.btn_SSShowShip.Text = "Show Shipment";
            this.btn_SSShowShip.UseVisualStyleBackColor = true;
            this.btn_SSShowShip.Click += new System.EventHandler(this.btn_SSShowShip_Click);
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
            // SubscriptionAgencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Name = "SubscriptionAgencyForm";
            this.Text = "SubscriptionAgencyForm";
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
        private System.Windows.Forms.Button btn_SSSaveResult;
        private System.Windows.Forms.Button btn_SSLoadShip;
        private System.Windows.Forms.Button btn_SSShowResult;
        private System.Windows.Forms.Button btn_SSSaveShip;
        private System.Windows.Forms.Button btn_SSInvoke;
        private System.Windows.Forms.Button btn_SSShowShip;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_TestInvoke;
    }
}