namespace EC_Endpoint_Client.Forms.ServiceEngine.Prefill
{
    partial class PrefillForm
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
            this.btn_GPDSaveResult = new System.Windows.Forms.Button();
            this.btn_GPDLoadShip = new System.Windows.Forms.Button();
            this.btn_GPDShowResult = new System.Windows.Forms.Button();
            this.btn_GPDSaveShip = new System.Windows.Forms.Button();
            this.btn_GPDInvoke = new System.Windows.Forms.Button();
            this.btn_GPDShowShip = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_GPDV2SaveResult = new System.Windows.Forms.Button();
            this.btn_GPDV2LoadShip = new System.Windows.Forms.Button();
            this.btn_GPDV2ShowResult = new System.Windows.Forms.Button();
            this.btn_GPDV2SaveShip = new System.Windows.Forms.Button();
            this.btn_GPDV2Invoke = new System.Windows.Forms.Button();
            this.btn_GPDV2ShowShip = new System.Windows.Forms.Button();
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
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_GPDSaveResult);
            this.tabPage1.Controls.Add(this.btn_GPDLoadShip);
            this.tabPage1.Controls.Add(this.btn_GPDShowResult);
            this.tabPage1.Controls.Add(this.btn_GPDSaveShip);
            this.tabPage1.Controls.Add(this.btn_GPDInvoke);
            this.tabPage1.Controls.Add(this.btn_GPDShowShip);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GetPrefillData";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_GPDSaveResult
            // 
            this.btn_GPDSaveResult.Location = new System.Drawing.Point(294, 64);
            this.btn_GPDSaveResult.Name = "btn_GPDSaveResult";
            this.btn_GPDSaveResult.Size = new System.Drawing.Size(118, 23);
            this.btn_GPDSaveResult.TabIndex = 7;
            this.btn_GPDSaveResult.Text = "Save Result";
            this.btn_GPDSaveResult.UseVisualStyleBackColor = true;
            this.btn_GPDSaveResult.Click += new System.EventHandler(this.btn_GPDSaveResult_Click);
            // 
            // btn_GPDLoadShip
            // 
            this.btn_GPDLoadShip.Location = new System.Drawing.Point(6, 64);
            this.btn_GPDLoadShip.Name = "btn_GPDLoadShip";
            this.btn_GPDLoadShip.Size = new System.Drawing.Size(118, 23);
            this.btn_GPDLoadShip.TabIndex = 8;
            this.btn_GPDLoadShip.Text = "Load Shipment";
            this.btn_GPDLoadShip.UseVisualStyleBackColor = true;
            this.btn_GPDLoadShip.Click += new System.EventHandler(this.btn_GPDLoadShip_Click);
            // 
            // btn_GPDShowResult
            // 
            this.btn_GPDShowResult.Location = new System.Drawing.Point(294, 35);
            this.btn_GPDShowResult.Name = "btn_GPDShowResult";
            this.btn_GPDShowResult.Size = new System.Drawing.Size(118, 23);
            this.btn_GPDShowResult.TabIndex = 9;
            this.btn_GPDShowResult.Text = "Show Result";
            this.btn_GPDShowResult.UseVisualStyleBackColor = true;
            this.btn_GPDShowResult.Click += new System.EventHandler(this.btn_GPDShowResult_Click);
            // 
            // btn_GPDSaveShip
            // 
            this.btn_GPDSaveShip.Location = new System.Drawing.Point(6, 35);
            this.btn_GPDSaveShip.Name = "btn_GPDSaveShip";
            this.btn_GPDSaveShip.Size = new System.Drawing.Size(118, 23);
            this.btn_GPDSaveShip.TabIndex = 10;
            this.btn_GPDSaveShip.Text = "Save Shipment";
            this.btn_GPDSaveShip.UseVisualStyleBackColor = true;
            this.btn_GPDSaveShip.Click += new System.EventHandler(this.btn_GPDSaveShip_Click);
            // 
            // btn_GPDInvoke
            // 
            this.btn_GPDInvoke.Location = new System.Drawing.Point(294, 6);
            this.btn_GPDInvoke.Name = "btn_GPDInvoke";
            this.btn_GPDInvoke.Size = new System.Drawing.Size(118, 23);
            this.btn_GPDInvoke.TabIndex = 11;
            this.btn_GPDInvoke.Text = "Invoke Service";
            this.btn_GPDInvoke.UseVisualStyleBackColor = true;
            this.btn_GPDInvoke.Click += new System.EventHandler(this.btn_GPDInvoke_Click);
            // 
            // btn_GPDShowShip
            // 
            this.btn_GPDShowShip.Location = new System.Drawing.Point(6, 6);
            this.btn_GPDShowShip.Name = "btn_GPDShowShip";
            this.btn_GPDShowShip.Size = new System.Drawing.Size(118, 23);
            this.btn_GPDShowShip.TabIndex = 12;
            this.btn_GPDShowShip.Text = "Show Shipment";
            this.btn_GPDShowShip.UseVisualStyleBackColor = true;
            this.btn_GPDShowShip.Click += new System.EventHandler(this.btn_GPDShowShip_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_GPDV2SaveResult);
            this.tabPage3.Controls.Add(this.btn_GPDV2LoadShip);
            this.tabPage3.Controls.Add(this.btn_GPDV2ShowResult);
            this.tabPage3.Controls.Add(this.btn_GPDV2SaveShip);
            this.tabPage3.Controls.Add(this.btn_GPDV2Invoke);
            this.tabPage3.Controls.Add(this.btn_GPDV2ShowShip);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(417, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "GetPrefillDataV2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_GPDV2SaveResult
            // 
            this.btn_GPDV2SaveResult.Location = new System.Drawing.Point(294, 64);
            this.btn_GPDV2SaveResult.Name = "btn_GPDV2SaveResult";
            this.btn_GPDV2SaveResult.Size = new System.Drawing.Size(118, 23);
            this.btn_GPDV2SaveResult.TabIndex = 13;
            this.btn_GPDV2SaveResult.Text = "Save Result";
            this.btn_GPDV2SaveResult.UseVisualStyleBackColor = true;
            this.btn_GPDV2SaveResult.Click += new System.EventHandler(this.btn_GPDV2SaveResult_Click);
            // 
            // btn_GPDV2LoadShip
            // 
            this.btn_GPDV2LoadShip.Location = new System.Drawing.Point(6, 64);
            this.btn_GPDV2LoadShip.Name = "btn_GPDV2LoadShip";
            this.btn_GPDV2LoadShip.Size = new System.Drawing.Size(118, 23);
            this.btn_GPDV2LoadShip.TabIndex = 14;
            this.btn_GPDV2LoadShip.Text = "Load Shipment";
            this.btn_GPDV2LoadShip.UseVisualStyleBackColor = true;
            this.btn_GPDV2LoadShip.Click += new System.EventHandler(this.btn_GPDV2LoadShip_Click);
            // 
            // btn_GPDV2ShowResult
            // 
            this.btn_GPDV2ShowResult.Location = new System.Drawing.Point(294, 35);
            this.btn_GPDV2ShowResult.Name = "btn_GPDV2ShowResult";
            this.btn_GPDV2ShowResult.Size = new System.Drawing.Size(118, 23);
            this.btn_GPDV2ShowResult.TabIndex = 15;
            this.btn_GPDV2ShowResult.Text = "Show Result";
            this.btn_GPDV2ShowResult.UseVisualStyleBackColor = true;
            this.btn_GPDV2ShowResult.Click += new System.EventHandler(this.btn_GPDV2ShowResult_Click);
            // 
            // btn_GPDV2SaveShip
            // 
            this.btn_GPDV2SaveShip.Location = new System.Drawing.Point(6, 35);
            this.btn_GPDV2SaveShip.Name = "btn_GPDV2SaveShip";
            this.btn_GPDV2SaveShip.Size = new System.Drawing.Size(118, 23);
            this.btn_GPDV2SaveShip.TabIndex = 16;
            this.btn_GPDV2SaveShip.Text = "Save Shipment";
            this.btn_GPDV2SaveShip.UseVisualStyleBackColor = true;
            this.btn_GPDV2SaveShip.Click += new System.EventHandler(this.btn_GPDV2SaveShip_Click);
            // 
            // btn_GPDV2Invoke
            // 
            this.btn_GPDV2Invoke.Location = new System.Drawing.Point(294, 6);
            this.btn_GPDV2Invoke.Name = "btn_GPDV2Invoke";
            this.btn_GPDV2Invoke.Size = new System.Drawing.Size(118, 23);
            this.btn_GPDV2Invoke.TabIndex = 17;
            this.btn_GPDV2Invoke.Text = "Invoke Service";
            this.btn_GPDV2Invoke.UseVisualStyleBackColor = true;
            this.btn_GPDV2Invoke.Click += new System.EventHandler(this.btn_GPDV2Invoke_Click);
            // 
            // btn_GPDV2ShowShip
            // 
            this.btn_GPDV2ShowShip.Location = new System.Drawing.Point(6, 6);
            this.btn_GPDV2ShowShip.Name = "btn_GPDV2ShowShip";
            this.btn_GPDV2ShowShip.Size = new System.Drawing.Size(118, 23);
            this.btn_GPDV2ShowShip.TabIndex = 18;
            this.btn_GPDV2ShowShip.Text = "Show Shipment";
            this.btn_GPDV2ShowShip.UseVisualStyleBackColor = true;
            this.btn_GPDV2ShowShip.Click += new System.EventHandler(this.btn_GPDV2ShowShip_Click);
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
            // PrefillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Name = "PrefillForm";
            this.Text = "PrefillForm";
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
        private System.Windows.Forms.Button btn_GPDSaveResult;
        private System.Windows.Forms.Button btn_GPDLoadShip;
        private System.Windows.Forms.Button btn_GPDShowResult;
        private System.Windows.Forms.Button btn_GPDSaveShip;
        private System.Windows.Forms.Button btn_GPDInvoke;
        private System.Windows.Forms.Button btn_GPDShowShip;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_GPDV2SaveResult;
        private System.Windows.Forms.Button btn_GPDV2LoadShip;
        private System.Windows.Forms.Button btn_GPDV2ShowResult;
        private System.Windows.Forms.Button btn_GPDV2SaveShip;
        private System.Windows.Forms.Button btn_GPDV2Invoke;
        private System.Windows.Forms.Button btn_GPDV2ShowShip;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_TestInvoke;
    }
}