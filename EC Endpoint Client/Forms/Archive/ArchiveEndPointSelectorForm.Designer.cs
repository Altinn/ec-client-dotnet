namespace EC_Endpoint_Client.Forms.Archive
{
    partial class ArchiveEndPointSelectorForm
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
            this.btn_ServiceOwnerArchiveStreamed = new System.Windows.Forms.Button();
            this.btn_ServiceOwnerArchive = new System.Windows.Forms.Button();
            this.btn_ReporteeArchiveStreamed = new System.Windows.Forms.Button();
            this.btn_ReporteeArchive = new System.Windows.Forms.Button();
            this.btn_KeyManangement = new System.Windows.Forms.Button();
            this.btn_DownloadQueue = new System.Windows.Forms.Button();
            this.btn_ArchiveCommonAgency = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ServiceOwnerArchiveStreamed
            // 
            this.btn_ServiceOwnerArchiveStreamed.Location = new System.Drawing.Point(6, 186);
            this.btn_ServiceOwnerArchiveStreamed.Name = "btn_ServiceOwnerArchiveStreamed";
            this.btn_ServiceOwnerArchiveStreamed.Size = new System.Drawing.Size(225, 23);
            this.btn_ServiceOwnerArchiveStreamed.TabIndex = 1;
            this.btn_ServiceOwnerArchiveStreamed.Text = "ServiceOwnerArchiveExternalStreamedEC";
            this.btn_ServiceOwnerArchiveStreamed.UseVisualStyleBackColor = true;
            this.btn_ServiceOwnerArchiveStreamed.Click += new System.EventHandler(this.btn_ServiceOwnerArchiveStreamed_Click);
            // 
            // btn_ServiceOwnerArchive
            // 
            this.btn_ServiceOwnerArchive.Location = new System.Drawing.Point(6, 157);
            this.btn_ServiceOwnerArchive.Name = "btn_ServiceOwnerArchive";
            this.btn_ServiceOwnerArchive.Size = new System.Drawing.Size(225, 23);
            this.btn_ServiceOwnerArchive.TabIndex = 2;
            this.btn_ServiceOwnerArchive.Text = "ServiceOwnerArchiveExternalEC";
            this.btn_ServiceOwnerArchive.UseVisualStyleBackColor = true;
            this.btn_ServiceOwnerArchive.Click += new System.EventHandler(this.btn_ServiceOwnerArchive_Click);
            // 
            // btn_ReporteeArchiveStreamed
            // 
            this.btn_ReporteeArchiveStreamed.Location = new System.Drawing.Point(5, 128);
            this.btn_ReporteeArchiveStreamed.Name = "btn_ReporteeArchiveStreamed";
            this.btn_ReporteeArchiveStreamed.Size = new System.Drawing.Size(225, 23);
            this.btn_ReporteeArchiveStreamed.TabIndex = 3;
            this.btn_ReporteeArchiveStreamed.Text = "ReporteeArchiveExternalStreamedEC";
            this.btn_ReporteeArchiveStreamed.UseVisualStyleBackColor = true;
            this.btn_ReporteeArchiveStreamed.Click += new System.EventHandler(this.btn_ReporteeArchiveStreamed_Click);
            // 
            // btn_ReporteeArchive
            // 
            this.btn_ReporteeArchive.Location = new System.Drawing.Point(6, 99);
            this.btn_ReporteeArchive.Name = "btn_ReporteeArchive";
            this.btn_ReporteeArchive.Size = new System.Drawing.Size(225, 23);
            this.btn_ReporteeArchive.TabIndex = 4;
            this.btn_ReporteeArchive.Text = "ReporteeArchiveExternalEC";
            this.btn_ReporteeArchive.UseVisualStyleBackColor = true;
            this.btn_ReporteeArchive.Click += new System.EventHandler(this.btn_ReporteeArchive_Click);
            // 
            // btn_KeyManangement
            // 
            this.btn_KeyManangement.Location = new System.Drawing.Point(5, 70);
            this.btn_KeyManangement.Name = "btn_KeyManangement";
            this.btn_KeyManangement.Size = new System.Drawing.Size(225, 23);
            this.btn_KeyManangement.TabIndex = 5;
            this.btn_KeyManangement.Text = "KeyManagementExternalEC";
            this.btn_KeyManangement.UseVisualStyleBackColor = true;
            this.btn_KeyManangement.Click += new System.EventHandler(this.btn_KeyManangement_Click);
            // 
            // btn_DownloadQueue
            // 
            this.btn_DownloadQueue.Location = new System.Drawing.Point(5, 41);
            this.btn_DownloadQueue.Name = "btn_DownloadQueue";
            this.btn_DownloadQueue.Size = new System.Drawing.Size(225, 23);
            this.btn_DownloadQueue.TabIndex = 6;
            this.btn_DownloadQueue.Text = "DownloadQueueExternalEC";
            this.btn_DownloadQueue.UseVisualStyleBackColor = true;
            this.btn_DownloadQueue.Click += new System.EventHandler(this.btn_DownloadQueue_Click);
            // 
            // btn_ArchiveCommonAgency
            // 
            this.btn_ArchiveCommonAgency.Location = new System.Drawing.Point(6, 12);
            this.btn_ArchiveCommonAgency.Name = "btn_ArchiveCommonAgency";
            this.btn_ArchiveCommonAgency.Size = new System.Drawing.Size(225, 23);
            this.btn_ArchiveCommonAgency.TabIndex = 7;
            this.btn_ArchiveCommonAgency.Text = "ArchiveCommonAgencyExternalEC";
            this.btn_ArchiveCommonAgency.UseVisualStyleBackColor = true;
            this.btn_ArchiveCommonAgency.Click += new System.EventHandler(this.btn_ArchiveCommonAgency_Click);
            // 
            // ArchiveEndPointSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 214);
            this.Controls.Add(this.btn_ServiceOwnerArchiveStreamed);
            this.Controls.Add(this.btn_ServiceOwnerArchive);
            this.Controls.Add(this.btn_ReporteeArchiveStreamed);
            this.Controls.Add(this.btn_ReporteeArchive);
            this.Controls.Add(this.btn_KeyManangement);
            this.Controls.Add(this.btn_DownloadQueue);
            this.Controls.Add(this.btn_ArchiveCommonAgency);
            this.Name = "ArchiveEndPointSelectorForm";
            this.Text = "ArchiveEndPointSelector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ServiceOwnerArchiveStreamed;
        private System.Windows.Forms.Button btn_ServiceOwnerArchive;
        private System.Windows.Forms.Button btn_ReporteeArchiveStreamed;
        private System.Windows.Forms.Button btn_ReporteeArchive;
        private System.Windows.Forms.Button btn_KeyManangement;
        private System.Windows.Forms.Button btn_DownloadQueue;
        private System.Windows.Forms.Button btn_ArchiveCommonAgency;

    }
}