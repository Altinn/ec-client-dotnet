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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_AuthorizationAdministration = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_Api = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Archive Endpoint Select";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "CertificateSelection";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_AuthorizationAdministration
            // 
            this.btn_AuthorizationAdministration.Location = new System.Drawing.Point(12, 41);
            this.btn_AuthorizationAdministration.Name = "btn_AuthorizationAdministration";
            this.btn_AuthorizationAdministration.Size = new System.Drawing.Size(221, 23);
            this.btn_AuthorizationAdministration.TabIndex = 9;
            this.btn_AuthorizationAdministration.Text = "Authorization Endpoint Select";
            this.btn_AuthorizationAdministration.UseVisualStyleBackColor = true;
            this.btn_AuthorizationAdministration.Click += new System.EventHandler(this.btn_AuthorizationAdministration_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Intermediary Endpoint Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "ServiceEngine Endpoint Select";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Api
            // 
            this.btn_Api.Location = new System.Drawing.Point(12, 129);
            this.btn_Api.Name = "btn_Api";
            this.btn_Api.Size = new System.Drawing.Size(220, 23);
            this.btn_Api.TabIndex = 12;
            this.btn_Api.Text = "Altinn Api Select";
            this.btn_Api.UseVisualStyleBackColor = true;
            this.btn_Api.Click += new System.EventHandler(this.btn_Api_Click);
            // 
            // ECEndPointClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 475);
            this.Controls.Add(this.btn_Api);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_AuthorizationAdministration);
            this.Controls.Add(this.button2);
            this.Name = "EcEndPointClient";
            this.Text = "EC Endpoint Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_AuthorizationAdministration;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_Api;
    }
}

