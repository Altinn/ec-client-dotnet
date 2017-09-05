namespace EC_Endpoint_Client.Forms
{
    partial class ArchiveCommonAgencyForm
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
            this.btn_showShipment = new System.Windows.Forms.Button();
            this.btn_showReturnedList = new System.Windows.Forms.Button();
            this.btn_GetServiceOwnerArchiveReporteeElementsEC = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_SaveResult = new System.Windows.Forms.Button();
            this.btn_loadShip = new System.Windows.Forms.Button();
            this.btn_SaveShip = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Test = new System.Windows.Forms.Button();
            this.servicePanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(613, 9);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(613, 35);
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(710, 6);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(710, 32);
            // 
            // pg_objectViewer
            // 
            this.pg_objectViewer.Size = new System.Drawing.Size(388, 371);
            // 
            // servicePanel
            // 
            this.servicePanel.Controls.Add(this.tabControl1);
            this.servicePanel.Size = new System.Drawing.Size(425, 371);
            // 
            // btn_showShipment
            // 
            this.btn_showShipment.Location = new System.Drawing.Point(6, 6);
            this.btn_showShipment.Name = "btn_showShipment";
            this.btn_showShipment.Size = new System.Drawing.Size(97, 23);
            this.btn_showShipment.TabIndex = 1;
            this.btn_showShipment.Text = "Show Shipment";
            this.btn_showShipment.UseVisualStyleBackColor = true;
            this.btn_showShipment.Click += new System.EventHandler(this.btn_showShipment_Click);
            // 
            // btn_showReturnedList
            // 
            this.btn_showReturnedList.Location = new System.Drawing.Point(291, 35);
            this.btn_showReturnedList.Name = "btn_showReturnedList";
            this.btn_showReturnedList.Size = new System.Drawing.Size(111, 23);
            this.btn_showReturnedList.TabIndex = 1;
            this.btn_showReturnedList.Text = "Show Result";
            this.btn_showReturnedList.UseVisualStyleBackColor = true;
            this.btn_showReturnedList.Click += new System.EventHandler(this.btn_showReturnedList_Click);
            // 
            // btn_GetServiceOwnerArchiveReporteeElementsEC
            // 
            this.btn_GetServiceOwnerArchiveReporteeElementsEC.Location = new System.Drawing.Point(291, 6);
            this.btn_GetServiceOwnerArchiveReporteeElementsEC.Name = "btn_GetServiceOwnerArchiveReporteeElementsEC";
            this.btn_GetServiceOwnerArchiveReporteeElementsEC.Size = new System.Drawing.Size(111, 23);
            this.btn_GetServiceOwnerArchiveReporteeElementsEC.TabIndex = 0;
            this.btn_GetServiceOwnerArchiveReporteeElementsEC.Text = "Invoke Service";
            this.btn_GetServiceOwnerArchiveReporteeElementsEC.UseVisualStyleBackColor = true;
            this.btn_GetServiceOwnerArchiveReporteeElementsEC.Click += new System.EventHandler(this.btn_GetServiceOwnerArchiveReporteeElementsEC_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_GetServiceOwnerArchiveReporteeElementsEC);
            this.tabPage2.Controls.Add(this.btn_SaveResult);
            this.tabPage2.Controls.Add(this.btn_showReturnedList);
            this.tabPage2.Controls.Add(this.btn_loadShip);
            this.tabPage2.Controls.Add(this.btn_SaveShip);
            this.tabPage2.Controls.Add(this.btn_showShipment);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 345);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "GetServiceOwnerArchiveReporteeElements";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_SaveResult
            // 
            this.btn_SaveResult.Location = new System.Drawing.Point(291, 64);
            this.btn_SaveResult.Name = "btn_SaveResult";
            this.btn_SaveResult.Size = new System.Drawing.Size(111, 23);
            this.btn_SaveResult.TabIndex = 1;
            this.btn_SaveResult.Text = "Save Result";
            this.btn_SaveResult.UseVisualStyleBackColor = true;
            this.btn_SaveResult.Click += new System.EventHandler(this.btn_SaveResult_Click);
            // 
            // btn_loadShip
            // 
            this.btn_loadShip.Location = new System.Drawing.Point(6, 64);
            this.btn_loadShip.Name = "btn_loadShip";
            this.btn_loadShip.Size = new System.Drawing.Size(97, 23);
            this.btn_loadShip.TabIndex = 1;
            this.btn_loadShip.Text = "Load Shipment";
            this.btn_loadShip.UseVisualStyleBackColor = true;
            this.btn_loadShip.Click += new System.EventHandler(this.btn_loadShip_Click);
            // 
            // btn_SaveShip
            // 
            this.btn_SaveShip.Location = new System.Drawing.Point(6, 35);
            this.btn_SaveShip.Name = "btn_SaveShip";
            this.btn_SaveShip.Size = new System.Drawing.Size(97, 23);
            this.btn_SaveShip.TabIndex = 1;
            this.btn_SaveShip.Text = "Save Shipment";
            this.btn_SaveShip.UseVisualStyleBackColor = true;
            this.btn_SaveShip.Click += new System.EventHandler(this.btn_SaveShip_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(425, 371);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Test);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 343);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Test";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(7, 7);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(106, 23);
            this.btn_Test.TabIndex = 0;
            this.btn_Test.Text = "Test";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // ArchiveCommonAgencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 465);
            this.Name = "ArchiveCommonAgencyForm";
            this.Text = "ArchiveCommonAgency";
            this.servicePanel.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GetServiceOwnerArchiveReporteeElementsEC;
        private System.Windows.Forms.Button btn_showShipment;
        private System.Windows.Forms.Button btn_showReturnedList;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_SaveResult;
        private System.Windows.Forms.Button btn_loadShip;
        private System.Windows.Forms.Button btn_SaveShip;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Test;
    }
}