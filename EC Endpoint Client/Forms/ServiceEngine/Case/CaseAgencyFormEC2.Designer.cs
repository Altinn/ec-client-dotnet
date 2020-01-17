namespace EC_Endpoint_Client.Forms.ServiceEngine.Case
{
    partial class CaseAgencyFormEC2
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
            this.btn_GetCaseListSaveResult = new System.Windows.Forms.Button();
            this.btn_GetCaseListLoadShipment = new System.Windows.Forms.Button();
            this.btn_GetCaseListShowResult = new System.Windows.Forms.Button();
            this.btn_GetCaseListSaveShipment = new System.Windows.Forms.Button();
            this.btn_GetCaseListInvoke = new System.Windows.Forms.Button();
            this.btn_GetCaseListShowShipment = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_ICLoadShipment = new System.Windows.Forms.Button();
            this.btn_ICSaveShipment = new System.Windows.Forms.Button();
            this.btn_ICInvoke = new System.Windows.Forms.Button();
            this.btn_ICShowShipment = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_NotifyEventSaveResult = new System.Windows.Forms.Button();
            this.btn_NotifyEventLoadShipment = new System.Windows.Forms.Button();
            this.btn_NotifyEventShowResult = new System.Windows.Forms.Button();
            this.btn_NotifyEventSaveShipment = new System.Windows.Forms.Button();
            this.btn_NotifyEventInvoke = new System.Windows.Forms.Button();
            this.btn_NotifyEventShowShipment = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_SetNoticeLoadShipment = new System.Windows.Forms.Button();
            this.btn_SetNoticeSaveShipment = new System.Windows.Forms.Button();
            this.btn_SetNoticeInvoke = new System.Windows.Forms.Button();
            this.btn_SetNoticeShowShpiment = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn_TestInvoke = new System.Windows.Forms.Button();
            this.servicePanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(425, 369);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_GetCaseListSaveResult);
            this.tabPage1.Controls.Add(this.btn_GetCaseListLoadShipment);
            this.tabPage1.Controls.Add(this.btn_GetCaseListShowResult);
            this.tabPage1.Controls.Add(this.btn_GetCaseListSaveShipment);
            this.tabPage1.Controls.Add(this.btn_GetCaseListInvoke);
            this.tabPage1.Controls.Add(this.btn_GetCaseListShowShipment);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GetCaseList";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_GetCaseListSaveResult
            // 
            this.btn_GetCaseListSaveResult.Location = new System.Drawing.Point(294, 64);
            this.btn_GetCaseListSaveResult.Name = "btn_GetCaseListSaveResult";
            this.btn_GetCaseListSaveResult.Size = new System.Drawing.Size(118, 23);
            this.btn_GetCaseListSaveResult.TabIndex = 1;
            this.btn_GetCaseListSaveResult.Text = "Save Result";
            this.btn_GetCaseListSaveResult.UseVisualStyleBackColor = true;
            this.btn_GetCaseListSaveResult.Click += new System.EventHandler(this.btn_GetCaseListSaveResult_Click);
            // 
            // btn_GetCaseListLoadShipment
            // 
            this.btn_GetCaseListLoadShipment.Location = new System.Drawing.Point(6, 64);
            this.btn_GetCaseListLoadShipment.Name = "btn_GetCaseListLoadShipment";
            this.btn_GetCaseListLoadShipment.Size = new System.Drawing.Size(118, 23);
            this.btn_GetCaseListLoadShipment.TabIndex = 2;
            this.btn_GetCaseListLoadShipment.Text = "Load Shipment";
            this.btn_GetCaseListLoadShipment.UseVisualStyleBackColor = true;
            this.btn_GetCaseListLoadShipment.Click += new System.EventHandler(this.btn_GetCaseListLoadShipment_Click);
            // 
            // btn_GetCaseListShowResult
            // 
            this.btn_GetCaseListShowResult.Location = new System.Drawing.Point(294, 35);
            this.btn_GetCaseListShowResult.Name = "btn_GetCaseListShowResult";
            this.btn_GetCaseListShowResult.Size = new System.Drawing.Size(118, 23);
            this.btn_GetCaseListShowResult.TabIndex = 3;
            this.btn_GetCaseListShowResult.Text = "Show Result";
            this.btn_GetCaseListShowResult.UseVisualStyleBackColor = true;
            this.btn_GetCaseListShowResult.Click += new System.EventHandler(this.btn_GetCaseListShowResult_Click);
            // 
            // btn_GetCaseListSaveShipment
            // 
            this.btn_GetCaseListSaveShipment.Location = new System.Drawing.Point(6, 35);
            this.btn_GetCaseListSaveShipment.Name = "btn_GetCaseListSaveShipment";
            this.btn_GetCaseListSaveShipment.Size = new System.Drawing.Size(118, 23);
            this.btn_GetCaseListSaveShipment.TabIndex = 4;
            this.btn_GetCaseListSaveShipment.Text = "Save Shipment";
            this.btn_GetCaseListSaveShipment.UseVisualStyleBackColor = true;
            this.btn_GetCaseListSaveShipment.Click += new System.EventHandler(this.btn_GetCaseListSaveShipment_Click);
            // 
            // btn_GetCaseListInvoke
            // 
            this.btn_GetCaseListInvoke.Location = new System.Drawing.Point(294, 6);
            this.btn_GetCaseListInvoke.Name = "btn_GetCaseListInvoke";
            this.btn_GetCaseListInvoke.Size = new System.Drawing.Size(118, 23);
            this.btn_GetCaseListInvoke.TabIndex = 5;
            this.btn_GetCaseListInvoke.Text = "Invoke Service";
            this.btn_GetCaseListInvoke.UseVisualStyleBackColor = true;
            this.btn_GetCaseListInvoke.Click += new System.EventHandler(this.btn_GetCaseListInvoke_Click);
            // 
            // btn_GetCaseListShowShipment
            // 
            this.btn_GetCaseListShowShipment.Location = new System.Drawing.Point(6, 6);
            this.btn_GetCaseListShowShipment.Name = "btn_GetCaseListShowShipment";
            this.btn_GetCaseListShowShipment.Size = new System.Drawing.Size(118, 23);
            this.btn_GetCaseListShowShipment.TabIndex = 6;
            this.btn_GetCaseListShowShipment.Text = "Show Shipment";
            this.btn_GetCaseListShowShipment.UseVisualStyleBackColor = true;
            this.btn_GetCaseListShowShipment.Click += new System.EventHandler(this.btn_GetCaseListShowShipment_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_ICLoadShipment);
            this.tabPage2.Controls.Add(this.btn_ICSaveShipment);
            this.tabPage2.Controls.Add(this.btn_ICInvoke);
            this.tabPage2.Controls.Add(this.btn_ICShowShipment);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "InstantiateCollaboration";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_NotifyEventSaveResult);
            this.tabPage3.Controls.Add(this.btn_NotifyEventLoadShipment);
            this.tabPage3.Controls.Add(this.btn_NotifyEventShowResult);
            this.tabPage3.Controls.Add(this.btn_NotifyEventSaveShipment);
            this.tabPage3.Controls.Add(this.btn_NotifyEventInvoke);
            this.tabPage3.Controls.Add(this.btn_NotifyEventShowShipment);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(417, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "NotifyEvent";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_NotifyEventSaveResult
            // 
            this.btn_NotifyEventSaveResult.Location = new System.Drawing.Point(294, 64);
            this.btn_NotifyEventSaveResult.Name = "btn_NotifyEventSaveResult";
            this.btn_NotifyEventSaveResult.Size = new System.Drawing.Size(118, 23);
            this.btn_NotifyEventSaveResult.TabIndex = 7;
            this.btn_NotifyEventSaveResult.Text = "Save Result";
            this.btn_NotifyEventSaveResult.UseVisualStyleBackColor = true;
            this.btn_NotifyEventSaveResult.Click += new System.EventHandler(this.btn_NotifyEventSaveResult_Click);
            // 
            // btn_NotifyEventLoadShipment
            // 
            this.btn_NotifyEventLoadShipment.Location = new System.Drawing.Point(6, 64);
            this.btn_NotifyEventLoadShipment.Name = "btn_NotifyEventLoadShipment";
            this.btn_NotifyEventLoadShipment.Size = new System.Drawing.Size(118, 23);
            this.btn_NotifyEventLoadShipment.TabIndex = 8;
            this.btn_NotifyEventLoadShipment.Text = "Load Shipment";
            this.btn_NotifyEventLoadShipment.UseVisualStyleBackColor = true;
            this.btn_NotifyEventLoadShipment.Click += new System.EventHandler(this.btn_NotifyEventLoadShipment_Click);
            // 
            // btn_NotifyEventShowResult
            // 
            this.btn_NotifyEventShowResult.Location = new System.Drawing.Point(294, 35);
            this.btn_NotifyEventShowResult.Name = "btn_NotifyEventShowResult";
            this.btn_NotifyEventShowResult.Size = new System.Drawing.Size(118, 23);
            this.btn_NotifyEventShowResult.TabIndex = 9;
            this.btn_NotifyEventShowResult.Text = "Show Result";
            this.btn_NotifyEventShowResult.UseVisualStyleBackColor = true;
            this.btn_NotifyEventShowResult.Click += new System.EventHandler(this.btn_NotifyEventShowResult_Click);
            // 
            // btn_NotifyEventSaveShipment
            // 
            this.btn_NotifyEventSaveShipment.Location = new System.Drawing.Point(6, 35);
            this.btn_NotifyEventSaveShipment.Name = "btn_NotifyEventSaveShipment";
            this.btn_NotifyEventSaveShipment.Size = new System.Drawing.Size(118, 23);
            this.btn_NotifyEventSaveShipment.TabIndex = 10;
            this.btn_NotifyEventSaveShipment.Text = "Save Shipment";
            this.btn_NotifyEventSaveShipment.UseVisualStyleBackColor = true;
            this.btn_NotifyEventSaveShipment.Click += new System.EventHandler(this.btn_NotifyEventSaveShipment_Click);
            // 
            // btn_NotifyEventInvoke
            // 
            this.btn_NotifyEventInvoke.Location = new System.Drawing.Point(294, 6);
            this.btn_NotifyEventInvoke.Name = "btn_NotifyEventInvoke";
            this.btn_NotifyEventInvoke.Size = new System.Drawing.Size(118, 23);
            this.btn_NotifyEventInvoke.TabIndex = 11;
            this.btn_NotifyEventInvoke.Text = "Invoke Service";
            this.btn_NotifyEventInvoke.UseVisualStyleBackColor = true;
            this.btn_NotifyEventInvoke.Click += new System.EventHandler(this.btn_NotifyEventInvoke_Click);
            // 
            // btn_NotifyEventShowShipment
            // 
            this.btn_NotifyEventShowShipment.Location = new System.Drawing.Point(6, 6);
            this.btn_NotifyEventShowShipment.Name = "btn_NotifyEventShowShipment";
            this.btn_NotifyEventShowShipment.Size = new System.Drawing.Size(118, 23);
            this.btn_NotifyEventShowShipment.TabIndex = 12;
            this.btn_NotifyEventShowShipment.Text = "Show Shipment";
            this.btn_NotifyEventShowShipment.UseVisualStyleBackColor = true;
            this.btn_NotifyEventShowShipment.Click += new System.EventHandler(this.btn_NotifyEventShowShipment_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_SetNoticeLoadShipment);
            this.tabPage4.Controls.Add(this.btn_SetNoticeSaveShipment);
            this.tabPage4.Controls.Add(this.btn_SetNoticeInvoke);
            this.tabPage4.Controls.Add(this.btn_SetNoticeShowShpiment);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(417, 343);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "SetNotice";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_SetNoticeLoadShipment
            // 
            this.btn_SetNoticeLoadShipment.Location = new System.Drawing.Point(6, 64);
            this.btn_SetNoticeLoadShipment.Name = "btn_SetNoticeLoadShipment";
            this.btn_SetNoticeLoadShipment.Size = new System.Drawing.Size(118, 23);
            this.btn_SetNoticeLoadShipment.TabIndex = 8;
            this.btn_SetNoticeLoadShipment.Text = "Load Shipment";
            this.btn_SetNoticeLoadShipment.UseVisualStyleBackColor = true;
            this.btn_SetNoticeLoadShipment.Click += new System.EventHandler(this.btn_SetNoticeLoadShipment_Click);
            // 
            // btn_SetNoticeSaveShipment
            // 
            this.btn_SetNoticeSaveShipment.Location = new System.Drawing.Point(6, 35);
            this.btn_SetNoticeSaveShipment.Name = "btn_SetNoticeSaveShipment";
            this.btn_SetNoticeSaveShipment.Size = new System.Drawing.Size(118, 23);
            this.btn_SetNoticeSaveShipment.TabIndex = 10;
            this.btn_SetNoticeSaveShipment.Text = "Save Shipment";
            this.btn_SetNoticeSaveShipment.UseVisualStyleBackColor = true;
            this.btn_SetNoticeSaveShipment.Click += new System.EventHandler(this.btn_SetNoticeSaveShipment_Click);
            // 
            // btn_SetNoticeInvoke
            // 
            this.btn_SetNoticeInvoke.Location = new System.Drawing.Point(294, 6);
            this.btn_SetNoticeInvoke.Name = "btn_SetNoticeInvoke";
            this.btn_SetNoticeInvoke.Size = new System.Drawing.Size(118, 23);
            this.btn_SetNoticeInvoke.TabIndex = 11;
            this.btn_SetNoticeInvoke.Text = "Invoke Service";
            this.btn_SetNoticeInvoke.UseVisualStyleBackColor = true;
            this.btn_SetNoticeInvoke.Click += new System.EventHandler(this.btn_SetNoticeInvoke_Click);
            // 
            // btn_SetNoticeShowShpiment
            // 
            this.btn_SetNoticeShowShpiment.Location = new System.Drawing.Point(6, 6);
            this.btn_SetNoticeShowShpiment.Name = "btn_SetNoticeShowShpiment";
            this.btn_SetNoticeShowShpiment.Size = new System.Drawing.Size(118, 23);
            this.btn_SetNoticeShowShpiment.TabIndex = 12;
            this.btn_SetNoticeShowShpiment.Text = "Show Shipment";
            this.btn_SetNoticeShowShpiment.UseVisualStyleBackColor = true;
            this.btn_SetNoticeShowShpiment.Click += new System.EventHandler(this.btn_SetNoticeShowShpiment_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btn_TestInvoke);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(417, 343);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Test";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn_TestInvoke
            // 
            this.btn_TestInvoke.Location = new System.Drawing.Point(6, 6);
            this.btn_TestInvoke.Name = "btn_TestInvoke";
            this.btn_TestInvoke.Size = new System.Drawing.Size(118, 23);
            this.btn_TestInvoke.TabIndex = 13;
            this.btn_TestInvoke.Text = "Test";
            this.btn_TestInvoke.UseVisualStyleBackColor = true;
            this.btn_TestInvoke.Click += new System.EventHandler(this.btn_TestInvoke_Click);
            // 
            // CaseAgencyFormEC2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Name = "CaseAgencyFormEC2";
            this.Text = "CaseAgencyFormEC2";
            this.servicePanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btn_GetCaseListLoadShipment;
        private System.Windows.Forms.Button btn_GetCaseListSaveShipment;
        private System.Windows.Forms.Button btn_GetCaseListInvoke;
        private System.Windows.Forms.Button btn_GetCaseListShowShipment;
        private System.Windows.Forms.Button btn_ICLoadShipment;
        private System.Windows.Forms.Button btn_ICSaveShipment;
        private System.Windows.Forms.Button btn_ICInvoke;
        private System.Windows.Forms.Button btn_ICShowShipment;
        private System.Windows.Forms.Button btn_NotifyEventSaveResult;
        private System.Windows.Forms.Button btn_NotifyEventLoadShipment;
        private System.Windows.Forms.Button btn_NotifyEventShowResult;
        private System.Windows.Forms.Button btn_NotifyEventSaveShipment;
        private System.Windows.Forms.Button btn_NotifyEventInvoke;
        private System.Windows.Forms.Button btn_NotifyEventShowShipment;
        private System.Windows.Forms.Button btn_SetNoticeLoadShipment;
        private System.Windows.Forms.Button btn_SetNoticeSaveShipment;
        private System.Windows.Forms.Button btn_SetNoticeInvoke;
        private System.Windows.Forms.Button btn_SetNoticeShowShpiment;
        private System.Windows.Forms.Button btn_TestInvoke;
        private System.Windows.Forms.Button btn_GetCaseListSaveResult;
        private System.Windows.Forms.Button btn_GetCaseListShowResult;
    }
}