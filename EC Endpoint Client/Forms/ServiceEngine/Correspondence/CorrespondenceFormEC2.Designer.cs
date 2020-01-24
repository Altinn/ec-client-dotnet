namespace EC_Endpoint_Client.Forms.ServiceEngine.Correspondence
{
    partial class CorrespondenceFormEC2
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
            this.btn_ICSaveResult = new System.Windows.Forms.Button();
            this.btn_ICShowResult = new System.Windows.Forms.Button();
            this.btn_ICInvoke = new System.Windows.Forms.Button();
            this.btn_ICShowShipment = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_GCSaveResult = new System.Windows.Forms.Button();
            this.btn_GCShowResult = new System.Windows.Forms.Button();
            this.btn_GCInvoke = new System.Windows.Forms.Button();
            this.btn_GCShowShip = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_SCCInvoke = new System.Windows.Forms.Button();
            this.btn_SCCShowShip = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_TestInvoke = new System.Windows.Forms.Button();
            this.servicePanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(684, 8);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(684, 35);
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(745, 6);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(745, 32);
            // 
            // pg_objectViewer
            // 
            this.pg_objectViewer.Size = new System.Drawing.Size(404, 369);
            // 
            // servicePanel
            // 
            this.servicePanel.Controls.Add(this.tabControl1);
            this.servicePanel.Size = new System.Drawing.Size(443, 369);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(443, 369);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_ICSaveResult);
            this.tabPage1.Controls.Add(this.btn_ICShowResult);
            this.tabPage1.Controls.Add(this.btn_ICInvoke);
            this.tabPage1.Controls.Add(this.btn_ICShowShipment);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(435, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ArchiveCorrespondence";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_ICSaveResult
            // 
            this.btn_ICSaveResult.Location = new System.Drawing.Point(320, 64);
            this.btn_ICSaveResult.Name = "btn_ICSaveResult";
            this.btn_ICSaveResult.Size = new System.Drawing.Size(118, 23);
            this.btn_ICSaveResult.TabIndex = 7;
            this.btn_ICSaveResult.Text = "Save Receipt";
            this.btn_ICSaveResult.UseVisualStyleBackColor = true;
            this.btn_ICSaveResult.Click += new System.EventHandler(this.btn_ICSaveResult_Click);
            // 
            // btn_ICShowResult
            // 
            this.btn_ICShowResult.Location = new System.Drawing.Point(320, 35);
            this.btn_ICShowResult.Name = "btn_ICShowResult";
            this.btn_ICShowResult.Size = new System.Drawing.Size(118, 23);
            this.btn_ICShowResult.TabIndex = 9;
            this.btn_ICShowResult.Text = "Show Receipt";
            this.btn_ICShowResult.UseVisualStyleBackColor = true;
            this.btn_ICShowResult.Click += new System.EventHandler(this.btn_ICShowResult_Click);
            // 
            // btn_ICInvoke
            // 
            this.btn_ICInvoke.Location = new System.Drawing.Point(320, 6);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_GCSaveResult);
            this.tabPage3.Controls.Add(this.btn_GCShowResult);
            this.tabPage3.Controls.Add(this.btn_GCInvoke);
            this.tabPage3.Controls.Add(this.btn_GCShowShip);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(417, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "GetCorrespondence";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_GCSaveResult
            // 
            this.btn_GCSaveResult.Location = new System.Drawing.Point(315, 64);
            this.btn_GCSaveResult.Name = "btn_GCSaveResult";
            this.btn_GCSaveResult.Size = new System.Drawing.Size(123, 23);
            this.btn_GCSaveResult.TabIndex = 13;
            this.btn_GCSaveResult.Text = "Save Correspondence";
            this.btn_GCSaveResult.UseVisualStyleBackColor = true;
            this.btn_GCSaveResult.Click += new System.EventHandler(this.btn_GCSaveResult_Click);
            // 
            // btn_GCShowResult
            // 
            this.btn_GCShowResult.Location = new System.Drawing.Point(315, 35);
            this.btn_GCShowResult.Name = "btn_GCShowResult";
            this.btn_GCShowResult.Size = new System.Drawing.Size(123, 23);
            this.btn_GCShowResult.TabIndex = 15;
            this.btn_GCShowResult.Text = "Show Correspondence";
            this.btn_GCShowResult.UseVisualStyleBackColor = true;
            this.btn_GCShowResult.Click += new System.EventHandler(this.btn_GCShowResult_Click);
            // 
            // btn_GCInvoke
            // 
            this.btn_GCInvoke.Location = new System.Drawing.Point(315, 6);
            this.btn_GCInvoke.Name = "btn_GCInvoke";
            this.btn_GCInvoke.Size = new System.Drawing.Size(123, 23);
            this.btn_GCInvoke.TabIndex = 17;
            this.btn_GCInvoke.Text = "Invoke Service";
            this.btn_GCInvoke.UseVisualStyleBackColor = true;
            this.btn_GCInvoke.Click += new System.EventHandler(this.btn_GCInvoke_Click);
            // 
            // btn_GCShowShip
            // 
            this.btn_GCShowShip.Location = new System.Drawing.Point(6, 6);
            this.btn_GCShowShip.Name = "btn_GCShowShip";
            this.btn_GCShowShip.Size = new System.Drawing.Size(118, 23);
            this.btn_GCShowShip.TabIndex = 18;
            this.btn_GCShowShip.Text = "Show Shipment";
            this.btn_GCShowShip.UseVisualStyleBackColor = true;
            this.btn_GCShowShip.Click += new System.EventHandler(this.btn_GCShowShip_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_SCCInvoke);
            this.tabPage4.Controls.Add(this.btn_SCCShowShip);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(417, 343);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "SaveCorrespondenceConfirmation";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_SCCInvoke
            // 
            this.btn_SCCInvoke.Location = new System.Drawing.Point(320, 6);
            this.btn_SCCInvoke.Name = "btn_SCCInvoke";
            this.btn_SCCInvoke.Size = new System.Drawing.Size(118, 23);
            this.btn_SCCInvoke.TabIndex = 15;
            this.btn_SCCInvoke.Text = "Invoke Service";
            this.btn_SCCInvoke.UseVisualStyleBackColor = true;
            this.btn_SCCInvoke.Click += new System.EventHandler(this.btn_SCCInvoke_Click);
            // 
            // btn_SCCShowShip
            // 
            this.btn_SCCShowShip.Location = new System.Drawing.Point(6, 6);
            this.btn_SCCShowShip.Name = "btn_SCCShowShip";
            this.btn_SCCShowShip.Size = new System.Drawing.Size(118, 23);
            this.btn_SCCShowShip.TabIndex = 16;
            this.btn_SCCShowShip.Text = "Show Shipment";
            this.btn_SCCShowShip.UseVisualStyleBackColor = true;
            this.btn_SCCShowShip.Click += new System.EventHandler(this.btn_SCCShowShip_Click);
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
            // CorrespondenceFormEC2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 463);
            this.Name = "CorrespondenceFormEC2";
            this.Text = "CorrespondenceFormEC2";
            this.servicePanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_ICSaveResult;
        private System.Windows.Forms.Button btn_ICShowResult;
        private System.Windows.Forms.Button btn_ICInvoke;
        private System.Windows.Forms.Button btn_ICShowShipment;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_TestInvoke;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_GCSaveResult;
        private System.Windows.Forms.Button btn_GCShowResult;
        private System.Windows.Forms.Button btn_GCInvoke;
        private System.Windows.Forms.Button btn_GCShowShip;
        private System.Windows.Forms.Button btn_SCCInvoke;
        private System.Windows.Forms.Button btn_SCCShowShip;
    }
}