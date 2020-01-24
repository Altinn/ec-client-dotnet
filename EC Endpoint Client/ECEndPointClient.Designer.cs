namespace EC_Endpoint_Client
{
    partial class EcEndPointClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcEndPointClient));
            this.btn_ArchiveECEndpoint = new System.Windows.Forms.Button();
            this.btn_SelectCertificate = new System.Windows.Forms.Button();
            this.btn_AuthorizationECEndPoint = new System.Windows.Forms.Button();
            this.btn_IntermediaryECEndpoint = new System.Windows.Forms.Button();
            this.btn_ServiceEngineECEndPoint = new System.Windows.Forms.Button();
            this.btn_Api = new System.Windows.Forms.Button();
            this.grp_ServerSessionHolder = new System.Windows.Forms.GroupBox();
            this.grp_ClientSessionHolder = new System.Windows.Forms.GroupBox();
            this.btn_AuthorizationEC2EndPoint = new System.Windows.Forms.Button();
            this.btn_ArchiveEC2Endpoint = new System.Windows.Forms.Button();
            this.btn_ServiceEngineEC2EndPoint = new System.Windows.Forms.Button();
            this.btn_IntermediaryEC2Endpoint = new System.Windows.Forms.Button();
            this.grp_ServerSessionHolder.SuspendLayout();
            this.grp_ClientSessionHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ArchiveECEndpoint
            // 
            this.btn_ArchiveECEndpoint.Location = new System.Drawing.Point(6, 23);
            this.btn_ArchiveECEndpoint.Name = "btn_ArchiveECEndpoint";
            this.btn_ArchiveECEndpoint.Size = new System.Drawing.Size(221, 23);
            this.btn_ArchiveECEndpoint.TabIndex = 9;
            this.btn_ArchiveECEndpoint.Text = "Archive Endpoint Select";
            this.btn_ArchiveECEndpoint.UseVisualStyleBackColor = true;
            this.btn_ArchiveECEndpoint.Click += new System.EventHandler(this.btn_ArchiveECEndpoint_Click);
            // 
            // btn_SelectCertificate
            // 
            this.btn_SelectCertificate.Location = new System.Drawing.Point(17, 255);
            this.btn_SelectCertificate.Name = "btn_SelectCertificate";
            this.btn_SelectCertificate.Size = new System.Drawing.Size(221, 23);
            this.btn_SelectCertificate.TabIndex = 10;
            this.btn_SelectCertificate.Text = "CertificateSelection";
            this.btn_SelectCertificate.UseVisualStyleBackColor = true;
            this.btn_SelectCertificate.Click += new System.EventHandler(this.btn_SelectCertificate_Click);
            // 
            // btn_AuthorizationECEndPoint
            // 
            this.btn_AuthorizationECEndPoint.Location = new System.Drawing.Point(6, 52);
            this.btn_AuthorizationECEndPoint.Name = "btn_AuthorizationECEndPoint";
            this.btn_AuthorizationECEndPoint.Size = new System.Drawing.Size(221, 23);
            this.btn_AuthorizationECEndPoint.TabIndex = 9;
            this.btn_AuthorizationECEndPoint.Text = "Authorization Endpoint Select";
            this.btn_AuthorizationECEndPoint.UseVisualStyleBackColor = true;
            this.btn_AuthorizationECEndPoint.Click += new System.EventHandler(this.btn_AuthorizationECEndPoint_Click);
            // 
            // btn_IntermediaryECEndpoint
            // 
            this.btn_IntermediaryECEndpoint.Location = new System.Drawing.Point(7, 82);
            this.btn_IntermediaryECEndpoint.Name = "btn_IntermediaryECEndpoint";
            this.btn_IntermediaryECEndpoint.Size = new System.Drawing.Size(220, 23);
            this.btn_IntermediaryECEndpoint.TabIndex = 11;
            this.btn_IntermediaryECEndpoint.Text = "Intermediary Endpoint Select";
            this.btn_IntermediaryECEndpoint.UseVisualStyleBackColor = true;
            this.btn_IntermediaryECEndpoint.Click += new System.EventHandler(this.btn_IntermediaryECEndpoint_Click);
            // 
            // btn_ServiceEngineECEndPoint
            // 
            this.btn_ServiceEngineECEndPoint.Location = new System.Drawing.Point(6, 111);
            this.btn_ServiceEngineECEndPoint.Name = "btn_ServiceEngineECEndPoint";
            this.btn_ServiceEngineECEndPoint.Size = new System.Drawing.Size(220, 23);
            this.btn_ServiceEngineECEndPoint.TabIndex = 11;
            this.btn_ServiceEngineECEndPoint.Text = "ServiceEngine Endpoint Select";
            this.btn_ServiceEngineECEndPoint.UseVisualStyleBackColor = true;
            this.btn_ServiceEngineECEndPoint.Click += new System.EventHandler(this.btn_ServiceEngineECEndPoint_Click);
            // 
            // btn_Api
            // 
            this.btn_Api.Location = new System.Drawing.Point(19, 191);
            this.btn_Api.Name = "btn_Api";
            this.btn_Api.Size = new System.Drawing.Size(220, 23);
            this.btn_Api.TabIndex = 12;
            this.btn_Api.Text = "Altinn Api Select";
            this.btn_Api.UseVisualStyleBackColor = true;
            this.btn_Api.Click += new System.EventHandler(this.btn_Api_Click);
            // 
            // grp_ServerSessionHolder
            // 
            this.grp_ServerSessionHolder.Controls.Add(this.btn_AuthorizationECEndPoint);
            this.grp_ServerSessionHolder.Controls.Add(this.btn_ArchiveECEndpoint);
            this.grp_ServerSessionHolder.Controls.Add(this.btn_ServiceEngineECEndPoint);
            this.grp_ServerSessionHolder.Controls.Add(this.btn_IntermediaryECEndpoint);
            this.grp_ServerSessionHolder.Location = new System.Drawing.Point(12, 12);
            this.grp_ServerSessionHolder.Name = "grp_ServerSessionHolder";
            this.grp_ServerSessionHolder.Size = new System.Drawing.Size(240, 144);
            this.grp_ServerSessionHolder.TabIndex = 13;
            this.grp_ServerSessionHolder.TabStop = false;
            this.grp_ServerSessionHolder.Text = "Server session holder";
            // 
            // grp_ClientSessionHolder
            // 
            this.grp_ClientSessionHolder.Controls.Add(this.btn_AuthorizationEC2EndPoint);
            this.grp_ClientSessionHolder.Controls.Add(this.btn_ArchiveEC2Endpoint);
            this.grp_ClientSessionHolder.Controls.Add(this.btn_ServiceEngineEC2EndPoint);
            this.grp_ClientSessionHolder.Controls.Add(this.btn_IntermediaryEC2Endpoint);
            this.grp_ClientSessionHolder.Location = new System.Drawing.Point(271, 12);
            this.grp_ClientSessionHolder.Name = "grp_ClientSessionHolder";
            this.grp_ClientSessionHolder.Size = new System.Drawing.Size(240, 144);
            this.grp_ClientSessionHolder.TabIndex = 14;
            this.grp_ClientSessionHolder.TabStop = false;
            this.grp_ClientSessionHolder.Text = "Client session holder";
            // 
            // btn_AuthorizationEC2EndPoint
            // 
            this.btn_AuthorizationEC2EndPoint.Location = new System.Drawing.Point(6, 52);
            this.btn_AuthorizationEC2EndPoint.Name = "btn_AuthorizationEC2EndPoint";
            this.btn_AuthorizationEC2EndPoint.Size = new System.Drawing.Size(221, 23);
            this.btn_AuthorizationEC2EndPoint.TabIndex = 9;
            this.btn_AuthorizationEC2EndPoint.Text = "Authorization Endpoint Select";
            this.btn_AuthorizationEC2EndPoint.UseVisualStyleBackColor = true;
            this.btn_AuthorizationEC2EndPoint.Click += new System.EventHandler(this.btn_AuthorizationEC2EndPoint_Click);
            // 
            // btn_ArchiveEC2Endpoint
            // 
            this.btn_ArchiveEC2Endpoint.Location = new System.Drawing.Point(6, 23);
            this.btn_ArchiveEC2Endpoint.Name = "btn_ArchiveEC2Endpoint";
            this.btn_ArchiveEC2Endpoint.Size = new System.Drawing.Size(221, 23);
            this.btn_ArchiveEC2Endpoint.TabIndex = 9;
            this.btn_ArchiveEC2Endpoint.Text = "Archive Endpoint Select";
            this.btn_ArchiveEC2Endpoint.UseVisualStyleBackColor = true;
            this.btn_ArchiveEC2Endpoint.Click += new System.EventHandler(this.btn_ArchiveEC2Endpoint_Click);
            // 
            // btn_ServiceEngineEC2EndPoint
            // 
            this.btn_ServiceEngineEC2EndPoint.Location = new System.Drawing.Point(6, 111);
            this.btn_ServiceEngineEC2EndPoint.Name = "btn_ServiceEngineEC2EndPoint";
            this.btn_ServiceEngineEC2EndPoint.Size = new System.Drawing.Size(220, 23);
            this.btn_ServiceEngineEC2EndPoint.TabIndex = 11;
            this.btn_ServiceEngineEC2EndPoint.Text = "ServiceEngine Endpoint Select";
            this.btn_ServiceEngineEC2EndPoint.UseVisualStyleBackColor = true;
            this.btn_ServiceEngineEC2EndPoint.Click += new System.EventHandler(this.btn_ServiceEngineEC2EndPoint_Click);
            // 
            // btn_IntermediaryEC2Endpoint
            // 
            this.btn_IntermediaryEC2Endpoint.Location = new System.Drawing.Point(7, 82);
            this.btn_IntermediaryEC2Endpoint.Name = "btn_IntermediaryEC2Endpoint";
            this.btn_IntermediaryEC2Endpoint.Size = new System.Drawing.Size(220, 23);
            this.btn_IntermediaryEC2Endpoint.TabIndex = 11;
            this.btn_IntermediaryEC2Endpoint.Text = "Intermediary Endpoint Select";
            this.btn_IntermediaryEC2Endpoint.UseVisualStyleBackColor = true;
            this.btn_IntermediaryEC2Endpoint.Click += new System.EventHandler(this.btn_IntermediaryEC2Endpoint_Click);
            // 
            // EcEndPointClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 475);
            this.Controls.Add(this.grp_ClientSessionHolder);
            this.Controls.Add(this.grp_ServerSessionHolder);
            this.Controls.Add(this.btn_Api);
            this.Controls.Add(this.btn_SelectCertificate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EcEndPointClient";
            this.Text = "EC Endpoint Client";
            this.grp_ServerSessionHolder.ResumeLayout(false);
            this.grp_ClientSessionHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ArchiveECEndpoint;
        private System.Windows.Forms.Button btn_SelectCertificate;
        private System.Windows.Forms.Button btn_AuthorizationECEndPoint;
        private System.Windows.Forms.Button btn_ServiceEngineECEndPoint;
        private System.Windows.Forms.Button btn_Api;
        private System.Windows.Forms.GroupBox grp_ServerSessionHolder;
        private System.Windows.Forms.GroupBox grp_ClientSessionHolder;
        private System.Windows.Forms.Button btn_AuthorizationEC2EndPoint;
        private System.Windows.Forms.Button btn_ArchiveEC2Endpoint;
        private System.Windows.Forms.Button btn_ServiceEngineEC2EndPoint;
        private System.Windows.Forms.Button btn_IntermediaryEC2Endpoint;
        public System.Windows.Forms.Button btn_IntermediaryECEndpoint;
    }
}

