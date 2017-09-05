namespace EC_Endpoint_Client.Forms
{
    partial class ReporteeArchiveForm
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
            this.btn_SaveArchivedFormTask = new System.Windows.Forms.Button();
            this.btn_ViewArchivedFormTask = new System.Windows.Forms.Button();
            this.btn_ShowFTShipment = new System.Windows.Forms.Button();
            this.btn_GetArchivedFormTask = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_SaveArchivedLookUp = new System.Windows.Forms.Button();
            this.btn_ViewArchivedLookUp = new System.Windows.Forms.Button();
            this.btn_ShowLUShipment = new System.Windows.Forms.Button();
            this.btn_GetArchivedLookUP = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_SaveAttachmentData = new System.Windows.Forms.Button();
            this.btn_ViewAttachmentData = new System.Windows.Forms.Button();
            this.btn_getAttachmentData = new System.Windows.Forms.Button();
            this.tb_AttachmentID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_Test = new System.Windows.Forms.Button();
            this.servicePanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(425, 369);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_SaveArchivedFormTask);
            this.tabPage1.Controls.Add(this.btn_ViewArchivedFormTask);
            this.tabPage1.Controls.Add(this.btn_ShowFTShipment);
            this.tabPage1.Controls.Add(this.btn_GetArchivedFormTask);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GetArchivedFormTask";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_SaveArchivedFormTask
            // 
            this.btn_SaveArchivedFormTask.Location = new System.Drawing.Point(280, 64);
            this.btn_SaveArchivedFormTask.Name = "btn_SaveArchivedFormTask";
            this.btn_SaveArchivedFormTask.Size = new System.Drawing.Size(134, 23);
            this.btn_SaveArchivedFormTask.TabIndex = 14;
            this.btn_SaveArchivedFormTask.Text = "Save Result";
            this.btn_SaveArchivedFormTask.UseVisualStyleBackColor = true;
            this.btn_SaveArchivedFormTask.Click += new System.EventHandler(this.btn_SaveArchivedFormTask_Click);
            // 
            // btn_ViewArchivedFormTask
            // 
            this.btn_ViewArchivedFormTask.Location = new System.Drawing.Point(280, 35);
            this.btn_ViewArchivedFormTask.Name = "btn_ViewArchivedFormTask";
            this.btn_ViewArchivedFormTask.Size = new System.Drawing.Size(134, 23);
            this.btn_ViewArchivedFormTask.TabIndex = 13;
            this.btn_ViewArchivedFormTask.Text = "Show Result";
            this.btn_ViewArchivedFormTask.UseVisualStyleBackColor = true;
            this.btn_ViewArchivedFormTask.Click += new System.EventHandler(this.btn_ViewArchivedFormTask_Click);
            // 
            // btn_ShowFTShipment
            // 
            this.btn_ShowFTShipment.Location = new System.Drawing.Point(6, 6);
            this.btn_ShowFTShipment.Name = "btn_ShowFTShipment";
            this.btn_ShowFTShipment.Size = new System.Drawing.Size(134, 23);
            this.btn_ShowFTShipment.TabIndex = 12;
            this.btn_ShowFTShipment.Text = "Show Shipment";
            this.btn_ShowFTShipment.UseVisualStyleBackColor = true;
            this.btn_ShowFTShipment.Click += new System.EventHandler(this.btn_ShowFTShipment_Click);
            // 
            // btn_GetArchivedFormTask
            // 
            this.btn_GetArchivedFormTask.Location = new System.Drawing.Point(280, 6);
            this.btn_GetArchivedFormTask.Name = "btn_GetArchivedFormTask";
            this.btn_GetArchivedFormTask.Size = new System.Drawing.Size(134, 23);
            this.btn_GetArchivedFormTask.TabIndex = 12;
            this.btn_GetArchivedFormTask.Text = "Invoke Service";
            this.btn_GetArchivedFormTask.UseVisualStyleBackColor = true;
            this.btn_GetArchivedFormTask.Click += new System.EventHandler(this.btn_GetArchivedFormTask_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_SaveArchivedLookUp);
            this.tabPage2.Controls.Add(this.btn_ViewArchivedLookUp);
            this.tabPage2.Controls.Add(this.btn_ShowLUShipment);
            this.tabPage2.Controls.Add(this.btn_GetArchivedLookUP);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GetArchivedLookup";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btn_SaveArchivedLookUp
            // 
            this.btn_SaveArchivedLookUp.Location = new System.Drawing.Point(280, 64);
            this.btn_SaveArchivedLookUp.Name = "btn_SaveArchivedLookUp";
            this.btn_SaveArchivedLookUp.Size = new System.Drawing.Size(134, 23);
            this.btn_SaveArchivedLookUp.TabIndex = 14;
            this.btn_SaveArchivedLookUp.Text = "Save Result";
            this.btn_SaveArchivedLookUp.UseVisualStyleBackColor = true;
            this.btn_SaveArchivedLookUp.Click += new System.EventHandler(this.btn_SaveArchivedLookUp_Click);
            // 
            // btn_ViewArchivedLookUp
            // 
            this.btn_ViewArchivedLookUp.Location = new System.Drawing.Point(280, 35);
            this.btn_ViewArchivedLookUp.Name = "btn_ViewArchivedLookUp";
            this.btn_ViewArchivedLookUp.Size = new System.Drawing.Size(134, 23);
            this.btn_ViewArchivedLookUp.TabIndex = 13;
            this.btn_ViewArchivedLookUp.Text = "Show Result";
            this.btn_ViewArchivedLookUp.UseVisualStyleBackColor = true;
            this.btn_ViewArchivedLookUp.Click += new System.EventHandler(this.btn_ViewArchivedLookUp_Click);
            // 
            // btn_ShowLUShipment
            // 
            this.btn_ShowLUShipment.Location = new System.Drawing.Point(6, 6);
            this.btn_ShowLUShipment.Name = "btn_ShowLUShipment";
            this.btn_ShowLUShipment.Size = new System.Drawing.Size(134, 23);
            this.btn_ShowLUShipment.TabIndex = 12;
            this.btn_ShowLUShipment.Text = "Show Shipment";
            this.btn_ShowLUShipment.UseVisualStyleBackColor = true;
            this.btn_ShowLUShipment.Click += new System.EventHandler(this.btn_ShowLUShipment_Click);
            // 
            // btn_GetArchivedLookUP
            // 
            this.btn_GetArchivedLookUP.Location = new System.Drawing.Point(280, 6);
            this.btn_GetArchivedLookUP.Name = "btn_GetArchivedLookUP";
            this.btn_GetArchivedLookUP.Size = new System.Drawing.Size(134, 23);
            this.btn_GetArchivedLookUP.TabIndex = 12;
            this.btn_GetArchivedLookUP.Text = "Invoke Service";
            this.btn_GetArchivedLookUP.UseVisualStyleBackColor = true;
            this.btn_GetArchivedLookUP.Click += new System.EventHandler(this.btn_GetArchivedLookUP_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_SaveAttachmentData);
            this.tabPage3.Controls.Add(this.btn_ViewAttachmentData);
            this.tabPage3.Controls.Add(this.btn_getAttachmentData);
            this.tabPage3.Controls.Add(this.tb_AttachmentID);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(417, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "GetAttachmentData";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_SaveAttachmentData
            // 
            this.btn_SaveAttachmentData.Location = new System.Drawing.Point(280, 62);
            this.btn_SaveAttachmentData.Name = "btn_SaveAttachmentData";
            this.btn_SaveAttachmentData.Size = new System.Drawing.Size(134, 23);
            this.btn_SaveAttachmentData.TabIndex = 13;
            this.btn_SaveAttachmentData.Text = "Save Result";
            this.btn_SaveAttachmentData.UseVisualStyleBackColor = true;
            this.btn_SaveAttachmentData.Click += new System.EventHandler(this.btn_SaveAttachmentData_Click);
            // 
            // btn_ViewAttachmentData
            // 
            this.btn_ViewAttachmentData.Location = new System.Drawing.Point(280, 33);
            this.btn_ViewAttachmentData.Name = "btn_ViewAttachmentData";
            this.btn_ViewAttachmentData.Size = new System.Drawing.Size(134, 23);
            this.btn_ViewAttachmentData.TabIndex = 12;
            this.btn_ViewAttachmentData.Text = "Show Result";
            this.btn_ViewAttachmentData.UseVisualStyleBackColor = true;
            this.btn_ViewAttachmentData.Click += new System.EventHandler(this.btn_ViewAttachmentData_Click);
            // 
            // btn_getAttachmentData
            // 
            this.btn_getAttachmentData.Location = new System.Drawing.Point(280, 4);
            this.btn_getAttachmentData.Name = "btn_getAttachmentData";
            this.btn_getAttachmentData.Size = new System.Drawing.Size(134, 23);
            this.btn_getAttachmentData.TabIndex = 11;
            this.btn_getAttachmentData.Text = "Invoke Service";
            this.btn_getAttachmentData.UseVisualStyleBackColor = true;
            this.btn_getAttachmentData.Click += new System.EventHandler(this.btn_getAttachmentData_Click);
            // 
            // tb_AttachmentID
            // 
            this.tb_AttachmentID.Location = new System.Drawing.Point(84, 6);
            this.tb_AttachmentID.Name = "tb_AttachmentID";
            this.tb_AttachmentID.Size = new System.Drawing.Size(100, 20);
            this.tb_AttachmentID.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "AttachmentID";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_Test);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(417, 343);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Test";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(6, 6);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(134, 23);
            this.btn_Test.TabIndex = 12;
            this.btn_Test.Text = "Test";
            this.btn_Test.UseVisualStyleBackColor = true;
            // 
            // ReporteeArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Name = "ReporteeArchiveForm";
            this.Text = "ReporteeArchiveForm";
            this.servicePanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_SaveArchivedFormTask;
        private System.Windows.Forms.Button btn_ViewArchivedFormTask;
        private System.Windows.Forms.Button btn_GetArchivedFormTask;
        private System.Windows.Forms.Button btn_SaveArchivedLookUp;
        private System.Windows.Forms.Button btn_ViewArchivedLookUp;
        private System.Windows.Forms.Button btn_GetArchivedLookUP;
        private System.Windows.Forms.Button btn_SaveAttachmentData;
        private System.Windows.Forms.Button btn_ViewAttachmentData;
        private System.Windows.Forms.Button btn_getAttachmentData;
        private System.Windows.Forms.TextBox tb_AttachmentID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Button btn_ShowFTShipment;
        private System.Windows.Forms.Button btn_ShowLUShipment;
    }
}