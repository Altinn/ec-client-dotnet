namespace EC_Endpoint_Client.Forms.Authorization
{
    partial class AuthorizationSelectorForm
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
            this.btn_AuthorizationAdministration = new System.Windows.Forms.Button();
            this.btn_AuthorizationToken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AuthorizationAdministration
            // 
            this.btn_AuthorizationAdministration.Location = new System.Drawing.Point(13, 13);
            this.btn_AuthorizationAdministration.Name = "btn_AuthorizationAdministration";
            this.btn_AuthorizationAdministration.Size = new System.Drawing.Size(141, 23);
            this.btn_AuthorizationAdministration.TabIndex = 0;
            this.btn_AuthorizationAdministration.Text = "AuthorizationAdministration";
            this.btn_AuthorizationAdministration.UseVisualStyleBackColor = true;
            this.btn_AuthorizationAdministration.Click += new System.EventHandler(this.btn_AuthorizationAdministration_Click);
            // 
            // btn_AuthorizationToken
            // 
            this.btn_AuthorizationToken.Location = new System.Drawing.Point(13, 42);
            this.btn_AuthorizationToken.Name = "btn_AuthorizationToken";
            this.btn_AuthorizationToken.Size = new System.Drawing.Size(141, 23);
            this.btn_AuthorizationToken.TabIndex = 1;
            this.btn_AuthorizationToken.Text = "AuthorizationToken";
            this.btn_AuthorizationToken.UseVisualStyleBackColor = true;
            this.btn_AuthorizationToken.Click += new System.EventHandler(this.btn_AuthorizationToken_Click);
            // 
            // AuthorizationSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 72);
            this.Controls.Add(this.btn_AuthorizationToken);
            this.Controls.Add(this.btn_AuthorizationAdministration);
            this.Name = "AuthorizationSelectorForm";
            this.Text = "AuthorizationSelectorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AuthorizationAdministration;
        private System.Windows.Forms.Button btn_AuthorizationToken;
    }
}