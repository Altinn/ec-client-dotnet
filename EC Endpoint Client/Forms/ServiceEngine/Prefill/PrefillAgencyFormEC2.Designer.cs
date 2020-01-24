namespace EC_Endpoint_Client.Forms.ServiceEngine.Prefill
{
    partial class PrefillAgencyFormEC2
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
            this.btn_SPFSaveResult = new System.Windows.Forms.Button();
            this.btn_SPFLoadShip = new System.Windows.Forms.Button();
            this.btn_SPFShowResult = new System.Windows.Forms.Button();
            this.btn_SPFSaveShip = new System.Windows.Forms.Button();
            this.btn_SPFInvoke = new System.Windows.Forms.Button();
            this.btn_SPFShowShip = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_SAIPFSaveResult = new System.Windows.Forms.Button();
            this.btn_SAIPFLoadShip = new System.Windows.Forms.Button();
            this.btn_SAIPFShowResult = new System.Windows.Forms.Button();
            this.btn_SAIPFSaveShip = new System.Windows.Forms.Button();
            this.btn_SAIPFInvoke = new System.Windows.Forms.Button();
            this.btn_SAIPFShowShip = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_TestInvoke = new System.Windows.Forms.Button();
            this.servicePanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(425, 369);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_SPFSaveResult);
            this.tabPage1.Controls.Add(this.btn_SPFLoadShip);
            this.tabPage1.Controls.Add(this.btn_SPFShowResult);
            this.tabPage1.Controls.Add(this.btn_SPFSaveShip);
            this.tabPage1.Controls.Add(this.btn_SPFInvoke);
            this.tabPage1.Controls.Add(this.btn_SPFShowShip);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SubmitPrefilledFormTask";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_SPFSaveResult
            // 
            this.btn_SPFSaveResult.Location = new System.Drawing.Point(294, 64);
            this.btn_SPFSaveResult.Name = "btn_SPFSaveResult";
            this.btn_SPFSaveResult.Size = new System.Drawing.Size(118, 23);
            this.btn_SPFSaveResult.TabIndex = 7;
            this.btn_SPFSaveResult.Text = "Save Receipt";
            this.btn_SPFSaveResult.UseVisualStyleBackColor = true;
            this.btn_SPFSaveResult.Click += new System.EventHandler(this.btn_SPFSaveResult_Click);
            // 
            // btn_SPFLoadShip
            // 
            this.btn_SPFLoadShip.Location = new System.Drawing.Point(6, 64);
            this.btn_SPFLoadShip.Name = "btn_SPFLoadShip";
            this.btn_SPFLoadShip.Size = new System.Drawing.Size(118, 23);
            this.btn_SPFLoadShip.TabIndex = 8;
            this.btn_SPFLoadShip.Text = "Load Shipment";
            this.btn_SPFLoadShip.UseVisualStyleBackColor = true;
            this.btn_SPFLoadShip.Click += new System.EventHandler(this.btn_SPFLoadShip_Click);
            // 
            // btn_SPFShowResult
            // 
            this.btn_SPFShowResult.Location = new System.Drawing.Point(294, 35);
            this.btn_SPFShowResult.Name = "btn_SPFShowResult";
            this.btn_SPFShowResult.Size = new System.Drawing.Size(118, 23);
            this.btn_SPFShowResult.TabIndex = 9;
            this.btn_SPFShowResult.Text = "Show Receipt";
            this.btn_SPFShowResult.UseVisualStyleBackColor = true;
            this.btn_SPFShowResult.Click += new System.EventHandler(this.btn_SPFShowResult_Click);
            // 
            // btn_SPFSaveShip
            // 
            this.btn_SPFSaveShip.Location = new System.Drawing.Point(6, 35);
            this.btn_SPFSaveShip.Name = "btn_SPFSaveShip";
            this.btn_SPFSaveShip.Size = new System.Drawing.Size(118, 23);
            this.btn_SPFSaveShip.TabIndex = 10;
            this.btn_SPFSaveShip.Text = "Save Shipment";
            this.btn_SPFSaveShip.UseVisualStyleBackColor = true;
            this.btn_SPFSaveShip.Click += new System.EventHandler(this.btn_SPFSaveShip_Click);
            // 
            // btn_SPFInvoke
            // 
            this.btn_SPFInvoke.Location = new System.Drawing.Point(294, 6);
            this.btn_SPFInvoke.Name = "btn_SPFInvoke";
            this.btn_SPFInvoke.Size = new System.Drawing.Size(118, 23);
            this.btn_SPFInvoke.TabIndex = 11;
            this.btn_SPFInvoke.Text = "Invoke Service";
            this.btn_SPFInvoke.UseVisualStyleBackColor = true;
            this.btn_SPFInvoke.Click += new System.EventHandler(this.btn_SPFInvoke_Click);
            // 
            // btn_SPFShowShip
            // 
            this.btn_SPFShowShip.Location = new System.Drawing.Point(6, 6);
            this.btn_SPFShowShip.Name = "btn_SPFShowShip";
            this.btn_SPFShowShip.Size = new System.Drawing.Size(118, 23);
            this.btn_SPFShowShip.TabIndex = 12;
            this.btn_SPFShowShip.Text = "Show Shipment";
            this.btn_SPFShowShip.UseVisualStyleBackColor = true;
            this.btn_SPFShowShip.Click += new System.EventHandler(this.btn_SPFShowShip_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_SAIPFSaveResult);
            this.tabPage3.Controls.Add(this.btn_SAIPFLoadShip);
            this.tabPage3.Controls.Add(this.btn_SAIPFShowResult);
            this.tabPage3.Controls.Add(this.btn_SAIPFSaveShip);
            this.tabPage3.Controls.Add(this.btn_SAIPFInvoke);
            this.tabPage3.Controls.Add(this.btn_SAIPFShowShip);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(417, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SubmitAndInstantiatePrefilledFormTask";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_SAIPFSaveResult
            // 
            this.btn_SAIPFSaveResult.Location = new System.Drawing.Point(294, 64);
            this.btn_SAIPFSaveResult.Name = "btn_SAIPFSaveResult";
            this.btn_SAIPFSaveResult.Size = new System.Drawing.Size(118, 23);
            this.btn_SAIPFSaveResult.TabIndex = 13;
            this.btn_SAIPFSaveResult.Text = "Save Receipt";
            this.btn_SAIPFSaveResult.UseVisualStyleBackColor = true;
            this.btn_SAIPFSaveResult.Click += new System.EventHandler(this.btn_SAIPFSaveResult_Click);
            // 
            // btn_SAIPFLoadShip
            // 
            this.btn_SAIPFLoadShip.Location = new System.Drawing.Point(6, 64);
            this.btn_SAIPFLoadShip.Name = "btn_SAIPFLoadShip";
            this.btn_SAIPFLoadShip.Size = new System.Drawing.Size(118, 23);
            this.btn_SAIPFLoadShip.TabIndex = 14;
            this.btn_SAIPFLoadShip.Text = "Load Shipment";
            this.btn_SAIPFLoadShip.UseVisualStyleBackColor = true;
            this.btn_SAIPFLoadShip.Click += new System.EventHandler(this.btn_SAIPFLoadShip_Click);
            // 
            // btn_SAIPFShowResult
            // 
            this.btn_SAIPFShowResult.Location = new System.Drawing.Point(294, 35);
            this.btn_SAIPFShowResult.Name = "btn_SAIPFShowResult";
            this.btn_SAIPFShowResult.Size = new System.Drawing.Size(118, 23);
            this.btn_SAIPFShowResult.TabIndex = 15;
            this.btn_SAIPFShowResult.Text = "Show Receipt";
            this.btn_SAIPFShowResult.UseVisualStyleBackColor = true;
            this.btn_SAIPFShowResult.Click += new System.EventHandler(this.btn_SAIPFShowResult_Click);
            // 
            // btn_SAIPFSaveShip
            // 
            this.btn_SAIPFSaveShip.Location = new System.Drawing.Point(6, 35);
            this.btn_SAIPFSaveShip.Name = "btn_SAIPFSaveShip";
            this.btn_SAIPFSaveShip.Size = new System.Drawing.Size(118, 23);
            this.btn_SAIPFSaveShip.TabIndex = 16;
            this.btn_SAIPFSaveShip.Text = "Save Shipment";
            this.btn_SAIPFSaveShip.UseVisualStyleBackColor = true;
            this.btn_SAIPFSaveShip.Click += new System.EventHandler(this.btn_SAIPFSaveShip_Click);
            // 
            // btn_SAIPFInvoke
            // 
            this.btn_SAIPFInvoke.Location = new System.Drawing.Point(294, 6);
            this.btn_SAIPFInvoke.Name = "btn_SAIPFInvoke";
            this.btn_SAIPFInvoke.Size = new System.Drawing.Size(118, 23);
            this.btn_SAIPFInvoke.TabIndex = 17;
            this.btn_SAIPFInvoke.Text = "Invoke Service";
            this.btn_SAIPFInvoke.UseVisualStyleBackColor = true;
            this.btn_SAIPFInvoke.Click += new System.EventHandler(this.btn_SAIPFInvoke_Click);
            // 
            // btn_SAIPFShowShip
            // 
            this.btn_SAIPFShowShip.Location = new System.Drawing.Point(6, 6);
            this.btn_SAIPFShowShip.Name = "btn_SAIPFShowShip";
            this.btn_SAIPFShowShip.Size = new System.Drawing.Size(118, 23);
            this.btn_SAIPFShowShip.TabIndex = 18;
            this.btn_SAIPFShowShip.Text = "Show Shipment";
            this.btn_SAIPFShowShip.UseVisualStyleBackColor = true;
            this.btn_SAIPFShowShip.Click += new System.EventHandler(this.btn_SAIPFShowShip_Click);
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
            // PrefillAgencyFormEC2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Name = "PrefillAgencyFormEC2";
            this.Text = "PrefillAgencyFormEC2";
            this.servicePanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_SPFSaveResult;
        private System.Windows.Forms.Button btn_SPFLoadShip;
        private System.Windows.Forms.Button btn_SPFShowResult;
        private System.Windows.Forms.Button btn_SPFSaveShip;
        private System.Windows.Forms.Button btn_SPFInvoke;
        private System.Windows.Forms.Button btn_SPFShowShip;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_TestInvoke;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_SAIPFSaveResult;
        private System.Windows.Forms.Button btn_SAIPFLoadShip;
        private System.Windows.Forms.Button btn_SAIPFShowResult;
        private System.Windows.Forms.Button btn_SAIPFSaveShip;
        private System.Windows.Forms.Button btn_SAIPFInvoke;
        private System.Windows.Forms.Button btn_SAIPFShowShip;
    }
}