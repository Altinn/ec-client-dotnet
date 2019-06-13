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
            this.getDataItemPage = new System.Windows.Forms.TabPage();
            this.getDetailedStatusTab = new System.Windows.Forms.TabPage();
            this.controllerGetDetailedStatus = new EC_Endpoint_Client.UserControls.ActionHolderControl();
            this.controllerGetStatusOverviews = new EC_Endpoint_Client.UserControls.ActionHolderControl();
            this.controllerGetDataItem = new EC_Endpoint_Client.UserControls.ActionHolderControl();
            this.servicePanel.SuspendLayout();
            this.getDetailedOverViewTab.SuspendLayout();
            this.getStatusOverviewTab.SuspendLayout();
            this.getDataItemPage.SuspendLayout();
            this.getDetailedStatusTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // servicePanel
            // 
            this.servicePanel.Controls.Add(this.getDetailedOverViewTab);
            // 
            // getDetailedOverViewTab
            // 
            this.getDetailedOverViewTab.Controls.Add(this.getStatusOverviewTab);
            this.getDetailedOverViewTab.Controls.Add(this.getDetailedStatusTab);
            this.getDetailedOverViewTab.Controls.Add(this.getDataItemPage);
            this.getDetailedOverViewTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getDetailedOverViewTab.Location = new System.Drawing.Point(0, 0);
            this.getDetailedOverViewTab.Name = "getDetailedOverViewTab";
            this.getDetailedOverViewTab.SelectedIndex = 0;
            this.getDetailedOverViewTab.Size = new System.Drawing.Size(425, 369);
            this.getDetailedOverViewTab.TabIndex = 2;
            // 
            // getStatusOverviewTab
            // 
            this.getStatusOverviewTab.Controls.Add(this.controllerGetStatusOverviews);
            this.getStatusOverviewTab.Location = new System.Drawing.Point(4, 22);
            this.getStatusOverviewTab.Name = "getStatusOverviewTab";
            this.getStatusOverviewTab.Padding = new System.Windows.Forms.Padding(3);
            this.getStatusOverviewTab.Size = new System.Drawing.Size(417, 343);
            this.getStatusOverviewTab.TabIndex = 0;
            this.getStatusOverviewTab.Text = "GetStatusOverviews";
            this.getStatusOverviewTab.UseVisualStyleBackColor = true;
            // 
            // getDataItemPage
            // 
            this.getDataItemPage.Controls.Add(this.controllerGetDataItem);
            this.getDataItemPage.Location = new System.Drawing.Point(4, 22);
            this.getDataItemPage.Name = "getDataItemPage";
            this.getDataItemPage.Padding = new System.Windows.Forms.Padding(3);
            this.getDataItemPage.Size = new System.Drawing.Size(417, 343);
            this.getDataItemPage.TabIndex = 2;
            this.getDataItemPage.Text = "GetDataItem";
            this.getDataItemPage.UseVisualStyleBackColor = true;
            // 
            // getDetailedStatusTab
            // 
            this.getDetailedStatusTab.Controls.Add(this.controllerGetDetailedStatus);
            this.getDetailedStatusTab.Location = new System.Drawing.Point(4, 22);
            this.getDetailedStatusTab.Name = "getDetailedStatusTab";
            this.getDetailedStatusTab.Padding = new System.Windows.Forms.Padding(3);
            this.getDetailedStatusTab.Size = new System.Drawing.Size(417, 343);
            this.getDetailedStatusTab.TabIndex = 3;
            this.getDetailedStatusTab.Text = "GetDetailedStatus";
            this.getDetailedStatusTab.UseVisualStyleBackColor = true;
            // 
            // controllerGetDetailedStatus
            // 
            this.controllerGetDetailedStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controllerGetDetailedStatus.Location = new System.Drawing.Point(3, 3);
            this.controllerGetDetailedStatus.Name = "controllerGetDetailedStatus";
            this.controllerGetDetailedStatus.Size = new System.Drawing.Size(411, 337);
            this.controllerGetDetailedStatus.TabIndex = 0;
            // 
            // controllerGetStatusOverviews
            // 
            this.controllerGetStatusOverviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controllerGetStatusOverviews.Location = new System.Drawing.Point(3, 3);
            this.controllerGetStatusOverviews.Name = "controllerGetStatusOverviews";
            this.controllerGetStatusOverviews.Size = new System.Drawing.Size(411, 337);
            this.controllerGetStatusOverviews.TabIndex = 0;
            // 
            // controllerGetDataItem
            // 
            this.controllerGetDataItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controllerGetDataItem.Location = new System.Drawing.Point(3, 3);
            this.controllerGetDataItem.Name = "controllerGetDataItem";
            this.controllerGetDataItem.Size = new System.Drawing.Size(411, 337);
            this.controllerGetDataItem.TabIndex = 0;
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
            this.getDetailedStatusTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl getDetailedOverViewTab;
        private System.Windows.Forms.TabPage getStatusOverviewTab;
        private System.Windows.Forms.TabPage getDataItemPage;
        private System.Windows.Forms.TabPage getDetailedStatusTab;
        private UserControls.ActionHolderControl controllerGetDetailedStatus;
        private UserControls.ActionHolderControl controllerGetStatusOverviews;
        private UserControls.ActionHolderControl controllerGetDataItem;
    }
}