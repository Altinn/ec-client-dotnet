namespace EC_Endpoint_Client.Forms.Intermediary
{
    partial class BatchLoggingForm
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
            this.getDetailedOverViewTab = new System.Windows.Forms.TabControl();
            this.getStatusOverviewTab = new System.Windows.Forms.TabPage();
            this.SelectedServiceList = new System.Windows.Forms.ListBox();
            this.btn_SaveResult = new System.Windows.Forms.Button();
            this.btn_ShowResult = new System.Windows.Forms.Button();
            this.btn_SubmitRequest = new System.Windows.Forms.Button();
            this.btn_LoadRequest = new System.Windows.Forms.Button();
            this.btn_SaveRequest = new System.Windows.Forms.Button();
            this.btn_ShowRequest = new System.Windows.Forms.Button();
            this.getDataItemPage = new System.Windows.Forms.TabPage();
            this.saveDataItembtn = new System.Windows.Forms.Button();
            this.showDataItembtn = new System.Windows.Forms.Button();
            this.GetDataItemBtn = new System.Windows.Forms.Button();
            this.showDataItemIdbtn = new System.Windows.Forms.Button();
            this.servicePanel.SuspendLayout();
            this.getDetailedOverViewTab.SuspendLayout();
            this.getStatusOverviewTab.SuspendLayout();
            this.getDataItemPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // servicePanel
            // 
            this.servicePanel.Controls.Add(this.getDetailedOverViewTab);
            // 
            // getDetailedOverViewTab
            // 
            this.getDetailedOverViewTab.Controls.Add(this.getStatusOverviewTab);
            this.getDetailedOverViewTab.Controls.Add(this.getDataItemPage);
            this.getDetailedOverViewTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getDetailedOverViewTab.Location = new System.Drawing.Point(0, 0);
            this.getDetailedOverViewTab.Name = "getDetailedOverViewTab";
            this.getDetailedOverViewTab.SelectedIndex = 0;
            this.getDetailedOverViewTab.Size = new System.Drawing.Size(425, 369);
            this.getDetailedOverViewTab.TabIndex = 0;
            // 
            // getStatusOverviewTab
            // 
            this.getStatusOverviewTab.Controls.Add(this.SelectedServiceList);
            this.getStatusOverviewTab.Controls.Add(this.btn_SaveResult);
            this.getStatusOverviewTab.Controls.Add(this.btn_ShowResult);
            this.getStatusOverviewTab.Controls.Add(this.btn_SubmitRequest);
            this.getStatusOverviewTab.Controls.Add(this.btn_LoadRequest);
            this.getStatusOverviewTab.Controls.Add(this.btn_SaveRequest);
            this.getStatusOverviewTab.Controls.Add(this.btn_ShowRequest);
            this.getStatusOverviewTab.Location = new System.Drawing.Point(4, 22);
            this.getStatusOverviewTab.Name = "getStatusOverviewTab";
            this.getStatusOverviewTab.Padding = new System.Windows.Forms.Padding(3);
            this.getStatusOverviewTab.Size = new System.Drawing.Size(417, 343);
            this.getStatusOverviewTab.TabIndex = 0;
            this.getStatusOverviewTab.Text = "GetLogOverviews";
            this.getStatusOverviewTab.UseVisualStyleBackColor = true;
            // 
            // SelectedServiceList
            // 
            this.SelectedServiceList.FormattingEnabled = true;
            this.SelectedServiceList.Items.AddRange(new object[] {
            "GetStatusOverview",
            "GetDetailedStatus"});
            this.SelectedServiceList.Location = new System.Drawing.Point(5, 6);
            this.SelectedServiceList.Name = "SelectedServiceList";
            this.SelectedServiceList.Size = new System.Drawing.Size(406, 30);
            this.SelectedServiceList.TabIndex = 8;
            // 
            // btn_SaveResult
            // 
            this.btn_SaveResult.Location = new System.Drawing.Point(300, 100);
            this.btn_SaveResult.Name = "btn_SaveResult";
            this.btn_SaveResult.Size = new System.Drawing.Size(112, 23);
            this.btn_SaveResult.TabIndex = 1;
            this.btn_SaveResult.Text = "Save Result";
            this.btn_SaveResult.UseVisualStyleBackColor = true;
            this.btn_SaveResult.Click += new System.EventHandler(this.btn_SaveResult_Click);
            // 
            // btn_ShowResult
            // 
            this.btn_ShowResult.Location = new System.Drawing.Point(300, 71);
            this.btn_ShowResult.Name = "btn_ShowResult";
            this.btn_ShowResult.Size = new System.Drawing.Size(112, 23);
            this.btn_ShowResult.TabIndex = 2;
            this.btn_ShowResult.Text = "Show Result";
            this.btn_ShowResult.UseVisualStyleBackColor = true;
            this.btn_ShowResult.Click += new System.EventHandler(this.btn_ShowResult_Click);
            // 
            // btn_SubmitRequest
            // 
            this.btn_SubmitRequest.Location = new System.Drawing.Point(300, 42);
            this.btn_SubmitRequest.Name = "btn_SubmitRequest";
            this.btn_SubmitRequest.Size = new System.Drawing.Size(112, 23);
            this.btn_SubmitRequest.TabIndex = 3;
            this.btn_SubmitRequest.Text = "Invoke Method";
            this.btn_SubmitRequest.UseVisualStyleBackColor = true;
            this.btn_SubmitRequest.Click += new System.EventHandler(this.btn_SubmitRequest_Click);
            // 
            // btn_LoadRequest
            // 
            this.btn_LoadRequest.Location = new System.Drawing.Point(6, 100);
            this.btn_LoadRequest.Name = "btn_LoadRequest";
            this.btn_LoadRequest.Size = new System.Drawing.Size(114, 23);
            this.btn_LoadRequest.TabIndex = 4;
            this.btn_LoadRequest.Text = "Load Shipment";
            this.btn_LoadRequest.UseVisualStyleBackColor = true;
            this.btn_LoadRequest.Click += new System.EventHandler(this.btn_LoadRequest_Click);
            // 
            // btn_SaveRequest
            // 
            this.btn_SaveRequest.Location = new System.Drawing.Point(6, 71);
            this.btn_SaveRequest.Name = "btn_SaveRequest";
            this.btn_SaveRequest.Size = new System.Drawing.Size(114, 23);
            this.btn_SaveRequest.TabIndex = 5;
            this.btn_SaveRequest.Text = "Save Shipment";
            this.btn_SaveRequest.UseVisualStyleBackColor = true;
            this.btn_SaveRequest.Click += new System.EventHandler(this.btn_SaveRequest_Click);
            // 
            // btn_ShowRequest
            // 
            this.btn_ShowRequest.Location = new System.Drawing.Point(6, 42);
            this.btn_ShowRequest.Name = "btn_ShowRequest";
            this.btn_ShowRequest.Size = new System.Drawing.Size(114, 23);
            this.btn_ShowRequest.TabIndex = 6;
            this.btn_ShowRequest.Text = "Show Shipment";
            this.btn_ShowRequest.UseVisualStyleBackColor = true;
            this.btn_ShowRequest.Click += new System.EventHandler(this.btn_ShowRequest_Click);
            // 
            // getDataItemPage
            // 
            this.getDataItemPage.Controls.Add(this.saveDataItembtn);
            this.getDataItemPage.Controls.Add(this.showDataItembtn);
            this.getDataItemPage.Controls.Add(this.GetDataItemBtn);
            this.getDataItemPage.Controls.Add(this.showDataItemIdbtn);
            this.getDataItemPage.Location = new System.Drawing.Point(4, 22);
            this.getDataItemPage.Name = "getDataItemPage";
            this.getDataItemPage.Padding = new System.Windows.Forms.Padding(3);
            this.getDataItemPage.Size = new System.Drawing.Size(417, 343);
            this.getDataItemPage.TabIndex = 2;
            this.getDataItemPage.Text = "GetDataItem";
            this.getDataItemPage.UseVisualStyleBackColor = true;
            // 
            // saveDataItembtn
            // 
            this.saveDataItembtn.Location = new System.Drawing.Point(300, 64);
            this.saveDataItembtn.Name = "saveDataItembtn";
            this.saveDataItembtn.Size = new System.Drawing.Size(112, 23);
            this.saveDataItembtn.TabIndex = 7;
            this.saveDataItembtn.Text = "Save Result";
            this.saveDataItembtn.UseVisualStyleBackColor = true;
            this.saveDataItembtn.Click += new System.EventHandler(this.saveDataItembtn_Click);
            // 
            // showDataItembtn
            // 
            this.showDataItembtn.Location = new System.Drawing.Point(300, 35);
            this.showDataItembtn.Name = "showDataItembtn";
            this.showDataItembtn.Size = new System.Drawing.Size(112, 23);
            this.showDataItembtn.TabIndex = 8;
            this.showDataItembtn.Text = "Show Result";
            this.showDataItembtn.UseVisualStyleBackColor = true;
            this.showDataItembtn.Click += new System.EventHandler(this.showDataItembtn_Click);
            // 
            // GetDataItemBtn
            // 
            this.GetDataItemBtn.Location = new System.Drawing.Point(300, 6);
            this.GetDataItemBtn.Name = "GetDataItemBtn";
            this.GetDataItemBtn.Size = new System.Drawing.Size(112, 23);
            this.GetDataItemBtn.TabIndex = 9;
            this.GetDataItemBtn.Text = "Invoke Method";
            this.GetDataItemBtn.UseVisualStyleBackColor = true;
            this.GetDataItemBtn.Click += new System.EventHandler(this.GetDataItemBtn_Click);
            // 
            // showDataItemIdbtn
            // 
            this.showDataItemIdbtn.Location = new System.Drawing.Point(6, 6);
            this.showDataItemIdbtn.Name = "showDataItemIdbtn";
            this.showDataItemIdbtn.Size = new System.Drawing.Size(114, 23);
            this.showDataItemIdbtn.TabIndex = 10;
            this.showDataItemIdbtn.Text = "Show Shipment";
            this.showDataItemIdbtn.UseVisualStyleBackColor = true;
            this.showDataItemIdbtn.Click += new System.EventHandler(this.showDataItemIdbtn_Click);
            // 
            // BatchLoggingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Name = "BatchLoggingForm";
            this.Text = "BatchLoggingForm";
            this.servicePanel.ResumeLayout(false);
            this.getDetailedOverViewTab.ResumeLayout(false);
            this.getStatusOverviewTab.ResumeLayout(false);
            this.getDataItemPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl getDetailedOverViewTab;
        private System.Windows.Forms.TabPage getStatusOverviewTab;
        private System.Windows.Forms.TabPage getDataItemPage;
        private System.Windows.Forms.Button btn_SaveResult;
        private System.Windows.Forms.Button btn_ShowResult;
        private System.Windows.Forms.Button btn_SubmitRequest;
        private System.Windows.Forms.Button btn_LoadRequest;
        private System.Windows.Forms.Button btn_SaveRequest;
        private System.Windows.Forms.Button btn_ShowRequest;
        private System.Windows.Forms.Button saveDataItembtn;
        private System.Windows.Forms.Button showDataItembtn;
        private System.Windows.Forms.Button GetDataItemBtn;
        private System.Windows.Forms.Button showDataItemIdbtn;
        private System.Windows.Forms.ListBox SelectedServiceList;
    }
}