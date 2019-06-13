namespace EC_Endpoint_Client.Forms.Api
{
    partial class ApiForm
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
            this.txtAppKey = new System.Windows.Forms.TextBox();
            this.lblAppKey = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblResponse = new System.Windows.Forms.Label();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCertificate = new System.Windows.Forms.Button();
            this.ddlMethod = new System.Windows.Forms.ComboBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.lblBody = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTargetMethod = new System.Windows.Forms.TextBox();
            this.lblTargetUrl = new System.Windows.Forms.Label();
            this.ddlEnvironment = new System.Windows.Forms.ComboBox();
            this.lblEnvironment = new System.Windows.Forms.Label();
            this.txtCertificate = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblLoginInfo = new System.Windows.Forms.Label();
            this.lsResponseHeaders = new System.Windows.Forms.ListView();
            this.btnRun = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cbxServiceOwner = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtAppKey
            // 
            this.txtAppKey.Location = new System.Drawing.Point(110, 53);
            this.txtAppKey.Name = "txtAppKey";
            this.txtAppKey.Size = new System.Drawing.Size(242, 20);
            this.txtAppKey.TabIndex = 2;
            // 
            // lblAppKey
            // 
            this.lblAppKey.AutoSize = true;
            this.lblAppKey.Location = new System.Drawing.Point(9, 52);
            this.lblAppKey.Name = "lblAppKey";
            this.lblAppKey.Size = new System.Drawing.Size(44, 13);
            this.lblAppKey.TabIndex = 3;
            this.lblAppKey.Text = "AppKey";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(110, 106);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(242, 20);
            this.txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(110, 132);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(242, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(9, 109);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(9, 135);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(13, 270);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(72, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Login";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(355, 292);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(81, 13);
            this.lblResponse.TabIndex = 9;
            this.lblResponse.Text = "Response body";
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(358, 308);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(576, 245);
            this.txtResponse.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Selected certificate:";
            // 
            // btnCertificate
            // 
            this.btnCertificate.Location = new System.Drawing.Point(236, 237);
            this.btnCertificate.Name = "btnCertificate";
            this.btnCertificate.Size = new System.Drawing.Size(116, 23);
            this.btnCertificate.TabIndex = 13;
            this.btnCertificate.Text = "Select certificate";
            this.btnCertificate.UseVisualStyleBackColor = true;
            this.btnCertificate.Click += new System.EventHandler(this.btnCertificate_Click);
            // 
            // ddlMethod
            // 
            this.ddlMethod.FormattingEnabled = true;
            this.ddlMethod.Location = new System.Drawing.Point(110, 79);
            this.ddlMethod.Name = "ddlMethod";
            this.ddlMethod.Size = new System.Drawing.Size(242, 21);
            this.ddlMethod.TabIndex = 19;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(9, 81);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(75, 13);
            this.lblMethod.TabIndex = 20;
            this.lblMethod.Text = "HTTP Method";
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(358, 26);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBody.Size = new System.Drawing.Size(576, 245);
            this.txtBody.TabIndex = 21;
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(355, 9);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(73, 13);
            this.lblBody.TabIndex = 22;
            this.lblBody.Text = "Request body";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Response headers";
            // 
            // txtTargetMethod
            // 
            this.txtTargetMethod.Location = new System.Drawing.Point(110, 158);
            this.txtTargetMethod.Name = "txtTargetMethod";
            this.txtTargetMethod.Size = new System.Drawing.Size(242, 20);
            this.txtTargetMethod.TabIndex = 25;
            // 
            // lblTargetUrl
            // 
            this.lblTargetUrl.AutoSize = true;
            this.lblTargetUrl.Location = new System.Drawing.Point(9, 161);
            this.lblTargetUrl.Name = "lblTargetUrl";
            this.lblTargetUrl.Size = new System.Drawing.Size(76, 13);
            this.lblTargetUrl.TabIndex = 26;
            this.lblTargetUrl.Text = "Target method";
            // 
            // ddlEnvironment
            // 
            this.ddlEnvironment.FormattingEnabled = true;
            this.ddlEnvironment.Location = new System.Drawing.Point(110, 26);
            this.ddlEnvironment.Name = "ddlEnvironment";
            this.ddlEnvironment.Size = new System.Drawing.Size(242, 21);
            this.ddlEnvironment.TabIndex = 27;
            // 
            // lblEnvironment
            // 
            this.lblEnvironment.AutoSize = true;
            this.lblEnvironment.Location = new System.Drawing.Point(9, 26);
            this.lblEnvironment.Name = "lblEnvironment";
            this.lblEnvironment.Size = new System.Drawing.Size(66, 13);
            this.lblEnvironment.TabIndex = 28;
            this.lblEnvironment.Text = "Environment";
            // 
            // txtCertificate
            // 
            this.txtCertificate.Location = new System.Drawing.Point(12, 239);
            this.txtCertificate.Name = "txtCertificate";
            this.txtCertificate.Size = new System.Drawing.Size(218, 20);
            this.txtCertificate.TabIndex = 29;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(120, 275);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(67, 13);
            this.lblLogin.TabIndex = 30;
            this.lblLogin.Text = "Login status:";
            // 
            // lblLoginInfo
            // 
            this.lblLoginInfo.AutoSize = true;
            this.lblLoginInfo.Location = new System.Drawing.Point(193, 275);
            this.lblLoginInfo.Name = "lblLoginInfo";
            this.lblLoginInfo.Size = new System.Drawing.Size(70, 13);
            this.lblLoginInfo.TabIndex = 31;
            this.lblLoginInfo.Text = "Not logged in";
            // 
            // lsResponseHeaders
            // 
            this.lsResponseHeaders.Location = new System.Drawing.Point(42, 327);
            this.lsResponseHeaders.Name = "lsResponseHeaders";
            this.lsResponseHeaders.Size = new System.Drawing.Size(280, 204);
            this.lsResponseHeaders.TabIndex = 32;
            this.lsResponseHeaders.UseCompatibleStateImageBehavior = false;
            this.lsResponseHeaders.View = System.Windows.Forms.View.List;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(277, 184);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 33;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // cbxServiceOwner
            // 
            this.cbxServiceOwner.AutoSize = true;
            this.cbxServiceOwner.Location = new System.Drawing.Point(13, 190);
            this.cbxServiceOwner.Name = "cbxServiceOwner";
            this.cbxServiceOwner.Size = new System.Drawing.Size(84, 17);
            this.cbxServiceOwner.TabIndex = 35;
            this.cbxServiceOwner.Text = "Tjenesteeier";
            this.cbxServiceOwner.UseVisualStyleBackColor = true;
            // 
            // ApiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 565);
            this.Controls.Add(this.cbxServiceOwner);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lsResponseHeaders);
            this.Controls.Add(this.lblLoginInfo);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtCertificate);
            this.Controls.Add(this.lblEnvironment);
            this.Controls.Add(this.ddlEnvironment);
            this.Controls.Add(this.lblTargetUrl);
            this.Controls.Add(this.txtTargetMethod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.ddlMethod);
            this.Controls.Add(this.btnCertificate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblAppKey);
            this.Controls.Add(this.txtAppKey);
            this.Name = "ApiForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAppKey;
        private System.Windows.Forms.Label lblAppKey;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCertificate;
        private System.Windows.Forms.ComboBox ddlMethod;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTargetMethod;
        private System.Windows.Forms.Label lblTargetUrl;
        private System.Windows.Forms.ComboBox ddlEnvironment;
        private System.Windows.Forms.Label lblEnvironment;
        private System.Windows.Forms.TextBox txtCertificate;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblLoginInfo;
        private System.Windows.Forms.ListView lsResponseHeaders;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox cbxServiceOwner;
    }
}

