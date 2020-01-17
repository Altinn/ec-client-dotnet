namespace EC_Endpoint_Client.Forms.ServiceEngine.Correspondence
{
    sealed partial class CorrespondenceAgencyFormEC2
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
            this.InsertCorrespondence = new System.Windows.Forms.TabPage();
            this.btn_ICSaveResult = new System.Windows.Forms.Button();
            this.btn_ICLoadShipment = new System.Windows.Forms.Button();
            this.btn_ICShowResult = new System.Windows.Forms.Button();
            this.btn_ICSaveShipment = new System.Windows.Forms.Button();
            this.btn_ICInvoke = new System.Windows.Forms.Button();
            this.btn_ICShowShipment = new System.Windows.Forms.Button();
            this.TestTab = new System.Windows.Forms.TabPage();
            this.btn_TestInvoke = new System.Windows.Forms.Button();
            this.GetCorrespondenceDetails = new System.Windows.Forms.TabPage();
            this.btn_GCD_SaR = new System.Windows.Forms.Button();
            this.btn_GCD_LS = new System.Windows.Forms.Button();
            this.btn_GCD_ShR = new System.Windows.Forms.Button();
            this.btn_GCD_SaS = new System.Windows.Forms.Button();
            this.btn_GCD_Invoke = new System.Windows.Forms.Button();
            this.btn_GCD_ShS = new System.Windows.Forms.Button();
            this.GetCorrespondenceHistory = new System.Windows.Forms.TabPage();
            this.btn_GCH_SaR = new System.Windows.Forms.Button();
            this.btn_GCH_LS = new System.Windows.Forms.Button();
            this.btn_GCH_ShR = new System.Windows.Forms.Button();
            this.btn_GCH_SaS = new System.Windows.Forms.Button();
            this.btn_GCH_Invoke = new System.Windows.Forms.Button();
            this.btn_GCH_ShS = new System.Windows.Forms.Button();
            this.servicePanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.InsertCorrespondence.SuspendLayout();
            this.TestTab.SuspendLayout();
            this.GetCorrespondenceDetails.SuspendLayout();
            this.GetCorrespondenceHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // servicePanel
            // 
            this.servicePanel.Controls.Add(this.tabControl1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.InsertCorrespondence);
            this.tabControl1.Controls.Add(this.GetCorrespondenceDetails);
            this.tabControl1.Controls.Add(this.GetCorrespondenceHistory);
            this.tabControl1.Controls.Add(this.TestTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(425, 369);
            this.tabControl1.TabIndex = 0;
            // 
            // InsertCorrespondence
            // 
            this.InsertCorrespondence.Controls.Add(this.btn_ICSaveResult);
            this.InsertCorrespondence.Controls.Add(this.btn_ICLoadShipment);
            this.InsertCorrespondence.Controls.Add(this.btn_ICShowResult);
            this.InsertCorrespondence.Controls.Add(this.btn_ICSaveShipment);
            this.InsertCorrespondence.Controls.Add(this.btn_ICInvoke);
            this.InsertCorrespondence.Controls.Add(this.btn_ICShowShipment);
            this.InsertCorrespondence.Location = new System.Drawing.Point(4, 22);
            this.InsertCorrespondence.Name = "InsertCorrespondence";
            this.InsertCorrespondence.Padding = new System.Windows.Forms.Padding(3);
            this.InsertCorrespondence.Size = new System.Drawing.Size(417, 343);
            this.InsertCorrespondence.TabIndex = 0;
            this.InsertCorrespondence.Text = "InsertCorrespondence";
            this.InsertCorrespondence.UseVisualStyleBackColor = true;
            // 
            // btn_ICSaveResult
            // 
            this.btn_ICSaveResult.Location = new System.Drawing.Point(294, 64);
            this.btn_ICSaveResult.Name = "btn_ICSaveResult";
            this.btn_ICSaveResult.Size = new System.Drawing.Size(118, 23);
            this.btn_ICSaveResult.TabIndex = 7;
            this.btn_ICSaveResult.Text = "Save Receipt";
            this.btn_ICSaveResult.UseVisualStyleBackColor = true;
            this.btn_ICSaveResult.Click += new System.EventHandler(this.btn_ICSaveResult_Click);
            // 
            // btn_ICLoadShipment
            // 
            this.btn_ICLoadShipment.Location = new System.Drawing.Point(6, 64);
            this.btn_ICLoadShipment.Name = "btn_ICLoadShipment";
            this.btn_ICLoadShipment.Size = new System.Drawing.Size(118, 23);
            this.btn_ICLoadShipment.TabIndex = 8;
            this.btn_ICLoadShipment.Text = "Load Shipment";
            this.btn_ICLoadShipment.UseVisualStyleBackColor = true;
            this.btn_ICLoadShipment.Click += new System.EventHandler(this.btn_ICLoadShipment_Click);
            // 
            // btn_ICShowResult
            // 
            this.btn_ICShowResult.Location = new System.Drawing.Point(294, 35);
            this.btn_ICShowResult.Name = "btn_ICShowResult";
            this.btn_ICShowResult.Size = new System.Drawing.Size(118, 23);
            this.btn_ICShowResult.TabIndex = 9;
            this.btn_ICShowResult.Text = "Show Receipt";
            this.btn_ICShowResult.UseVisualStyleBackColor = true;
            this.btn_ICShowResult.Click += new System.EventHandler(this.btn_ICShowResult_Click);
            // 
            // btn_ICSaveShipment
            // 
            this.btn_ICSaveShipment.Location = new System.Drawing.Point(6, 35);
            this.btn_ICSaveShipment.Name = "btn_ICSaveShipment";
            this.btn_ICSaveShipment.Size = new System.Drawing.Size(118, 23);
            this.btn_ICSaveShipment.TabIndex = 10;
            this.btn_ICSaveShipment.Text = "Save Shipment";
            this.btn_ICSaveShipment.UseVisualStyleBackColor = true;
            this.btn_ICSaveShipment.Click += new System.EventHandler(this.btn_ICSaveShipment_Click);
            // 
            // btn_ICInvoke
            // 
            this.btn_ICInvoke.Location = new System.Drawing.Point(294, 6);
            this.btn_ICInvoke.Name = "btn_ICInvoke";
            this.btn_ICInvoke.Size = new System.Drawing.Size(118, 23);
            this.btn_ICInvoke.TabIndex = 11;
            this.btn_ICInvoke.Text = "Invoke Service";
            this.btn_ICInvoke.UseVisualStyleBackColor = true;
            this.btn_ICInvoke.Click += new System.EventHandler(this.btn_ICInvoke_Click);
            // 
            // btn_ICShowShipment
            // 
            this.btn_ICShowShipment.Location = new System.Drawing.Point(6, 6);
            this.btn_ICShowShipment.Name = "btn_ICShowShipment";
            this.btn_ICShowShipment.Size = new System.Drawing.Size(118, 23);
            this.btn_ICShowShipment.TabIndex = 12;
            this.btn_ICShowShipment.Text = "Show Shipment";
            this.btn_ICShowShipment.UseVisualStyleBackColor = true;
            this.btn_ICShowShipment.Click += new System.EventHandler(this.btn_ICShowShipment_Click);
            // 
            // TestTab
            // 
            this.TestTab.Controls.Add(this.btn_TestInvoke);
            this.TestTab.Location = new System.Drawing.Point(4, 22);
            this.TestTab.Name = "TestTab";
            this.TestTab.Padding = new System.Windows.Forms.Padding(3);
            this.TestTab.Size = new System.Drawing.Size(417, 343);
            this.TestTab.TabIndex = 1;
            this.TestTab.Text = "Test";
            this.TestTab.UseVisualStyleBackColor = true;
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
            // GetCorrespondenceDetails
            // 
            this.GetCorrespondenceDetails.Controls.Add(this.btn_GCD_SaR);
            this.GetCorrespondenceDetails.Controls.Add(this.btn_GCD_LS);
            this.GetCorrespondenceDetails.Controls.Add(this.btn_GCD_ShR);
            this.GetCorrespondenceDetails.Controls.Add(this.btn_GCD_SaS);
            this.GetCorrespondenceDetails.Controls.Add(this.btn_GCD_Invoke);
            this.GetCorrespondenceDetails.Controls.Add(this.btn_GCD_ShS);
            this.GetCorrespondenceDetails.Location = new System.Drawing.Point(4, 22);
            this.GetCorrespondenceDetails.Name = "GetCorrespondenceDetails";
            this.GetCorrespondenceDetails.Padding = new System.Windows.Forms.Padding(3);
            this.GetCorrespondenceDetails.Size = new System.Drawing.Size(417, 343);
            this.GetCorrespondenceDetails.TabIndex = 2;
            this.GetCorrespondenceDetails.Text = "GetCorrespondenceDetails";
            this.GetCorrespondenceDetails.UseVisualStyleBackColor = true;
            // 
            // btn_GCD_SaR
            // 
            this.btn_GCD_SaR.Location = new System.Drawing.Point(294, 64);
            this.btn_GCD_SaR.Name = "btn_GCD_SaR";
            this.btn_GCD_SaR.Size = new System.Drawing.Size(118, 23);
            this.btn_GCD_SaR.TabIndex = 13;
            this.btn_GCD_SaR.Text = "Save Receipt";
            this.btn_GCD_SaR.UseVisualStyleBackColor = true;
            this.btn_GCD_SaR.Click += new System.EventHandler(this.btn_GCD_SaR_Click);
            // 
            // btn_GCD_LS
            // 
            this.btn_GCD_LS.Location = new System.Drawing.Point(6, 64);
            this.btn_GCD_LS.Name = "btn_GCD_LS";
            this.btn_GCD_LS.Size = new System.Drawing.Size(118, 23);
            this.btn_GCD_LS.TabIndex = 14;
            this.btn_GCD_LS.Text = "Load Shipment";
            this.btn_GCD_LS.UseVisualStyleBackColor = true;
            this.btn_GCD_LS.Click += new System.EventHandler(this.btn_GCD_LS_Click);
            // 
            // btn_GCD_ShR
            // 
            this.btn_GCD_ShR.Location = new System.Drawing.Point(294, 35);
            this.btn_GCD_ShR.Name = "btn_GCD_ShR";
            this.btn_GCD_ShR.Size = new System.Drawing.Size(118, 23);
            this.btn_GCD_ShR.TabIndex = 15;
            this.btn_GCD_ShR.Text = "Show Receipt";
            this.btn_GCD_ShR.UseVisualStyleBackColor = true;
            this.btn_GCD_ShR.Click += new System.EventHandler(this.btn_GCD_ShR_Click);
            // 
            // btn_GCD_SaS
            // 
            this.btn_GCD_SaS.Location = new System.Drawing.Point(6, 35);
            this.btn_GCD_SaS.Name = "btn_GCD_SaS";
            this.btn_GCD_SaS.Size = new System.Drawing.Size(118, 23);
            this.btn_GCD_SaS.TabIndex = 16;
            this.btn_GCD_SaS.Text = "Save Shipment";
            this.btn_GCD_SaS.UseVisualStyleBackColor = true;
            this.btn_GCD_SaS.Click += new System.EventHandler(this.btn_GCD_SaS_Click);
            // 
            // btn_GCD_Invoke
            // 
            this.btn_GCD_Invoke.Location = new System.Drawing.Point(294, 6);
            this.btn_GCD_Invoke.Name = "btn_GCD_Invoke";
            this.btn_GCD_Invoke.Size = new System.Drawing.Size(118, 23);
            this.btn_GCD_Invoke.TabIndex = 17;
            this.btn_GCD_Invoke.Text = "Invoke Service";
            this.btn_GCD_Invoke.UseVisualStyleBackColor = true;
            this.btn_GCD_Invoke.Click += new System.EventHandler(this.btn_GCD_Invoke_Click);
            // 
            // btn_GCD_ShS
            // 
            this.btn_GCD_ShS.Location = new System.Drawing.Point(6, 6);
            this.btn_GCD_ShS.Name = "btn_GCD_ShS";
            this.btn_GCD_ShS.Size = new System.Drawing.Size(118, 23);
            this.btn_GCD_ShS.TabIndex = 18;
            this.btn_GCD_ShS.Text = "Show Shipment";
            this.btn_GCD_ShS.UseVisualStyleBackColor = true;
            this.btn_GCD_ShS.Click += new System.EventHandler(this.btn_GCD_ShS_Click);
            // 
            // GetCorrespondenceHistory
            // 
            this.GetCorrespondenceHistory.Controls.Add(this.btn_GCH_SaR);
            this.GetCorrespondenceHistory.Controls.Add(this.btn_GCH_LS);
            this.GetCorrespondenceHistory.Controls.Add(this.btn_GCH_ShR);
            this.GetCorrespondenceHistory.Controls.Add(this.btn_GCH_SaS);
            this.GetCorrespondenceHistory.Controls.Add(this.btn_GCH_Invoke);
            this.GetCorrespondenceHistory.Controls.Add(this.btn_GCH_ShS);
            this.GetCorrespondenceHistory.Location = new System.Drawing.Point(4, 22);
            this.GetCorrespondenceHistory.Name = "GetCorrespondenceHistory";
            this.GetCorrespondenceHistory.Padding = new System.Windows.Forms.Padding(3);
            this.GetCorrespondenceHistory.Size = new System.Drawing.Size(417, 343);
            this.GetCorrespondenceHistory.TabIndex = 3;
            this.GetCorrespondenceHistory.Text = "GetCorrespondenceHistory";
            this.GetCorrespondenceHistory.UseVisualStyleBackColor = true;
            // 
            // btn_GCH_SaR
            // 
            this.btn_GCH_SaR.Location = new System.Drawing.Point(294, 64);
            this.btn_GCH_SaR.Name = "btn_GCH_SaR";
            this.btn_GCH_SaR.Size = new System.Drawing.Size(118, 23);
            this.btn_GCH_SaR.TabIndex = 13;
            this.btn_GCH_SaR.Text = "Save Receipt";
            this.btn_GCH_SaR.UseVisualStyleBackColor = true;
            this.btn_GCH_SaR.Click += new System.EventHandler(this.btn_GCH_SaR_Click);
            // 
            // btn_GCH_LS
            // 
            this.btn_GCH_LS.Location = new System.Drawing.Point(6, 64);
            this.btn_GCH_LS.Name = "btn_GCH_LS";
            this.btn_GCH_LS.Size = new System.Drawing.Size(118, 23);
            this.btn_GCH_LS.TabIndex = 14;
            this.btn_GCH_LS.Text = "Load Shipment";
            this.btn_GCH_LS.UseVisualStyleBackColor = true;
            this.btn_GCH_LS.Click += new System.EventHandler(this.btn_GCH_LS_Click);
            // 
            // btn_GCH_ShR
            // 
            this.btn_GCH_ShR.Location = new System.Drawing.Point(294, 35);
            this.btn_GCH_ShR.Name = "btn_GCH_ShR";
            this.btn_GCH_ShR.Size = new System.Drawing.Size(118, 23);
            this.btn_GCH_ShR.TabIndex = 15;
            this.btn_GCH_ShR.Text = "Show Receipt";
            this.btn_GCH_ShR.UseVisualStyleBackColor = true;
            this.btn_GCH_ShR.Click += new System.EventHandler(this.btn_GCH_ShR_Click);
            // 
            // btn_GCH_SaS
            // 
            this.btn_GCH_SaS.Location = new System.Drawing.Point(6, 35);
            this.btn_GCH_SaS.Name = "btn_GCH_SaS";
            this.btn_GCH_SaS.Size = new System.Drawing.Size(118, 23);
            this.btn_GCH_SaS.TabIndex = 16;
            this.btn_GCH_SaS.Text = "Save Shipment";
            this.btn_GCH_SaS.UseVisualStyleBackColor = true;
            this.btn_GCH_SaS.Click += new System.EventHandler(this.btn_GCH_SaS_Click);
            // 
            // btn_GCH_Invoke
            // 
            this.btn_GCH_Invoke.Location = new System.Drawing.Point(294, 6);
            this.btn_GCH_Invoke.Name = "btn_GCH_Invoke";
            this.btn_GCH_Invoke.Size = new System.Drawing.Size(118, 23);
            this.btn_GCH_Invoke.TabIndex = 17;
            this.btn_GCH_Invoke.Text = "Invoke Service";
            this.btn_GCH_Invoke.UseVisualStyleBackColor = true;
            this.btn_GCH_Invoke.Click += new System.EventHandler(this.btn_GCH_Invoke_Click);
            // 
            // btn_GCH_ShS
            // 
            this.btn_GCH_ShS.Location = new System.Drawing.Point(6, 6);
            this.btn_GCH_ShS.Name = "btn_GCH_ShS";
            this.btn_GCH_ShS.Size = new System.Drawing.Size(118, 23);
            this.btn_GCH_ShS.TabIndex = 18;
            this.btn_GCH_ShS.Text = "Show Shipment";
            this.btn_GCH_ShS.UseVisualStyleBackColor = true;
            this.btn_GCH_ShS.Click += new System.EventHandler(this.btn_GCH_ShS_Click);
            // 
            // CorrespondenceAgencyFormEC2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Name = "CorrespondenceAgencyFormEC2";
            this.Text = "CorrespondenceAgencyFormEC2";
            this.servicePanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.InsertCorrespondence.ResumeLayout(false);
            this.TestTab.ResumeLayout(false);
            this.GetCorrespondenceDetails.ResumeLayout(false);
            this.GetCorrespondenceHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage InsertCorrespondence;
        private System.Windows.Forms.TabPage TestTab;
        private System.Windows.Forms.Button btn_TestInvoke;
        private System.Windows.Forms.Button btn_ICSaveResult;
        private System.Windows.Forms.Button btn_ICLoadShipment;
        private System.Windows.Forms.Button btn_ICShowResult;
        private System.Windows.Forms.Button btn_ICSaveShipment;
        private System.Windows.Forms.Button btn_ICInvoke;
        private System.Windows.Forms.Button btn_ICShowShipment;
        private System.Windows.Forms.TabPage GetCorrespondenceDetails;
        private System.Windows.Forms.Button btn_GCD_SaR;
        private System.Windows.Forms.Button btn_GCD_LS;
        private System.Windows.Forms.Button btn_GCD_ShR;
        private System.Windows.Forms.Button btn_GCD_SaS;
        private System.Windows.Forms.Button btn_GCD_Invoke;
        private System.Windows.Forms.Button btn_GCD_ShS;
        private System.Windows.Forms.TabPage GetCorrespondenceHistory;
        private System.Windows.Forms.Button btn_GCH_SaR;
        private System.Windows.Forms.Button btn_GCH_LS;
        private System.Windows.Forms.Button btn_GCH_ShR;
        private System.Windows.Forms.Button btn_GCH_SaS;
        private System.Windows.Forms.Button btn_GCH_Invoke;
        private System.Windows.Forms.Button btn_GCH_ShS;
    }
}