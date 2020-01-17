namespace EC_Endpoint_Client.Forms.Intermediary
{
    partial class IntermediaryInboundStreamedFormEC2
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
            this.btn_saveResult = new System.Windows.Forms.Button();
            this.btn_ShowResult = new System.Windows.Forms.Button();
            this.btn_SubmitAttachmentData = new System.Windows.Forms.Button();
            this.btn_loadShipment = new System.Windows.Forms.Button();
            this.btn_saveShipment = new System.Windows.Forms.Button();
            this.btn_loadAttachment = new System.Windows.Forms.Button();
            this.btn_showShipment = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_test = new System.Windows.Forms.Button();
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
            this.tabPage1.Controls.Add(this.btn_saveResult);
            this.tabPage1.Controls.Add(this.btn_ShowResult);
            this.tabPage1.Controls.Add(this.btn_SubmitAttachmentData);
            this.tabPage1.Controls.Add(this.btn_loadShipment);
            this.tabPage1.Controls.Add(this.btn_saveShipment);
            this.tabPage1.Controls.Add(this.btn_loadAttachment);
            this.tabPage1.Controls.Add(this.btn_showShipment);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SubmitAttachmentData";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_saveResult
            // 
            this.btn_saveResult.Location = new System.Drawing.Point(282, 64);
            this.btn_saveResult.Name = "btn_saveResult";
            this.btn_saveResult.Size = new System.Drawing.Size(130, 23);
            this.btn_saveResult.TabIndex = 0;
            this.btn_saveResult.Text = "Save Result";
            this.btn_saveResult.UseVisualStyleBackColor = true;
            this.btn_saveResult.Click += new System.EventHandler(this.btn_saveResult_Click);
            // 
            // btn_ShowResult
            // 
            this.btn_ShowResult.Location = new System.Drawing.Point(282, 35);
            this.btn_ShowResult.Name = "btn_ShowResult";
            this.btn_ShowResult.Size = new System.Drawing.Size(130, 23);
            this.btn_ShowResult.TabIndex = 0;
            this.btn_ShowResult.Text = "Show Result";
            this.btn_ShowResult.UseVisualStyleBackColor = true;
            this.btn_ShowResult.Click += new System.EventHandler(this.btn_ShowResult_Click);
            // 
            // btn_SubmitAttachmentData
            // 
            this.btn_SubmitAttachmentData.Location = new System.Drawing.Point(282, 6);
            this.btn_SubmitAttachmentData.Name = "btn_SubmitAttachmentData";
            this.btn_SubmitAttachmentData.Size = new System.Drawing.Size(130, 23);
            this.btn_SubmitAttachmentData.TabIndex = 0;
            this.btn_SubmitAttachmentData.Text = "Invoke Service";
            this.btn_SubmitAttachmentData.UseVisualStyleBackColor = true;
            this.btn_SubmitAttachmentData.Click += new System.EventHandler(this.btn_SubmitAttachmentData_Click);
            // 
            // btn_loadShipment
            // 
            this.btn_loadShipment.Location = new System.Drawing.Point(6, 93);
            this.btn_loadShipment.Name = "btn_loadShipment";
            this.btn_loadShipment.Size = new System.Drawing.Size(130, 23);
            this.btn_loadShipment.TabIndex = 0;
            this.btn_loadShipment.Text = "LoadShipment";
            this.btn_loadShipment.UseVisualStyleBackColor = true;
            this.btn_loadShipment.Click += new System.EventHandler(this.btn_loadShipment_Click);
            // 
            // btn_saveShipment
            // 
            this.btn_saveShipment.Location = new System.Drawing.Point(6, 64);
            this.btn_saveShipment.Name = "btn_saveShipment";
            this.btn_saveShipment.Size = new System.Drawing.Size(130, 23);
            this.btn_saveShipment.TabIndex = 0;
            this.btn_saveShipment.Text = "Save Shipment";
            this.btn_saveShipment.UseVisualStyleBackColor = true;
            this.btn_saveShipment.Click += new System.EventHandler(this.btn_saveShipment_Click);
            // 
            // btn_loadAttachment
            // 
            this.btn_loadAttachment.Location = new System.Drawing.Point(6, 35);
            this.btn_loadAttachment.Name = "btn_loadAttachment";
            this.btn_loadAttachment.Size = new System.Drawing.Size(130, 23);
            this.btn_loadAttachment.TabIndex = 0;
            this.btn_loadAttachment.Text = "Load AttachmentData";
            this.btn_loadAttachment.UseVisualStyleBackColor = true;
            this.btn_loadAttachment.Click += new System.EventHandler(this.btn_loadAttachment_Click);
            // 
            // btn_showShipment
            // 
            this.btn_showShipment.Location = new System.Drawing.Point(6, 6);
            this.btn_showShipment.Name = "btn_showShipment";
            this.btn_showShipment.Size = new System.Drawing.Size(130, 23);
            this.btn_showShipment.TabIndex = 0;
            this.btn_showShipment.Text = "Show Shipment";
            this.btn_showShipment.UseVisualStyleBackColor = true;
            this.btn_showShipment.Click += new System.EventHandler(this.btn_showShipment_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_test);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Test";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(6, 6);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(130, 23);
            this.btn_test.TabIndex = 1;
            this.btn_test.Text = "Test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // IntermediaryInboundStreamedFormEC2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Name = "IntermediaryInboundStreamedFormEC2";
            this.Text = "IntermediaryInboundStreamedFormEC2";
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
        private System.Windows.Forms.Button btn_saveResult;
        private System.Windows.Forms.Button btn_ShowResult;
        private System.Windows.Forms.Button btn_SubmitAttachmentData;
        private System.Windows.Forms.Button btn_loadShipment;
        private System.Windows.Forms.Button btn_saveShipment;
        private System.Windows.Forms.Button btn_loadAttachment;
        private System.Windows.Forms.Button btn_showShipment;
        private System.Windows.Forms.Button btn_test;
    }
}