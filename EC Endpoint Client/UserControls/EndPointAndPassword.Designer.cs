namespace EC_Endpoint_Client.UserControls
{
    partial class EndPointAndPassword
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_SelectedCertificate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_viewedObject = new System.Windows.Forms.Label();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.cb_endPointConfigurationName = new System.Windows.Forms.ComboBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_SelectedCertificate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_viewedObject);
            this.panel1.Controls.Add(this.tb_userName);
            this.panel1.Controls.Add(this.cb_endPointConfigurationName);
            this.panel1.Controls.Add(this.tb_password);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 61);
            this.panel1.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // lbl_SelectedCertificate
            // 
            this.lbl_SelectedCertificate.AutoSize = true;
            this.lbl_SelectedCertificate.Location = new System.Drawing.Point(211, 9);
            this.lbl_SelectedCertificate.Name = "lbl_SelectedCertificate";
            this.lbl_SelectedCertificate.Size = new System.Drawing.Size(60, 13);
            this.lbl_SelectedCertificate.TabIndex = 52;
            this.lbl_SelectedCertificate.Text = "Certificate: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "EndPoints";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(651, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // lbl_viewedObject
            // 
            this.lbl_viewedObject.AutoSize = true;
            this.lbl_viewedObject.Location = new System.Drawing.Point(70, 39);
            this.lbl_viewedObject.Name = "lbl_viewedObject";
            this.lbl_viewedObject.Size = new System.Drawing.Size(88, 13);
            this.lbl_viewedObject.TabIndex = 6;
            this.lbl_viewedObject.Text = "lbl_viewedObject";
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(712, 6);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(100, 20);
            this.tb_userName.TabIndex = 50;
            // 
            // cb_endPointConfigurationName
            // 
            this.cb_endPointConfigurationName.FormattingEnabled = true;
            this.cb_endPointConfigurationName.Location = new System.Drawing.Point(73, 6);
            this.cb_endPointConfigurationName.Name = "cb_endPointConfigurationName";
            this.cb_endPointConfigurationName.Size = new System.Drawing.Size(132, 21);
            this.cb_endPointConfigurationName.TabIndex = 49;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(712, 32);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(100, 20);
            this.tb_password.TabIndex = 51;
            // 
            // EndPointAndPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "EndPointAndPassword";
            this.Size = new System.Drawing.Size(817, 61);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_SelectedCertificate;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl_viewedObject;
        public System.Windows.Forms.TextBox tb_userName;
        public System.Windows.Forms.ComboBox cb_endPointConfigurationName;
        public System.Windows.Forms.TextBox tb_password;
    }
}
