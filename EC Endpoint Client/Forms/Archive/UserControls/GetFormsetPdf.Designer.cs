namespace EC_Endpoint_Client.Forms.Archive.UserControls
{
    partial class GetFormsetPdf
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
            this.btnInvoke = new System.Windows.Forms.Button();
            this.lblArchiveReference = new System.Windows.Forms.Label();
            this.txbArchiveReference = new System.Windows.Forms.TextBox();
            this.lblLanguageId = new System.Windows.Forms.Label();
            this.cobLanguageId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnInvoke
            // 
            this.btnInvoke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvoke.Location = new System.Drawing.Point(238, 4);
            this.btnInvoke.Name = "btnInvoke";
            this.btnInvoke.Size = new System.Drawing.Size(144, 23);
            this.btnInvoke.TabIndex = 3;
            this.btnInvoke.Text = "Invoke Service";
            this.btnInvoke.UseVisualStyleBackColor = true;
            this.btnInvoke.Click += new System.EventHandler(this.btnInvoke_Click);
            // 
            // lblArchiveReference
            // 
            this.lblArchiveReference.AutoSize = true;
            this.lblArchiveReference.Location = new System.Drawing.Point(4, 9);
            this.lblArchiveReference.Name = "lblArchiveReference";
            this.lblArchiveReference.Size = new System.Drawing.Size(94, 13);
            this.lblArchiveReference.TabIndex = 3;
            this.lblArchiveReference.Text = "Archive reference:";
            // 
            // txbArchiveReference
            // 
            this.txbArchiveReference.Location = new System.Drawing.Point(104, 6);
            this.txbArchiveReference.Name = "txbArchiveReference";
            this.txbArchiveReference.Size = new System.Drawing.Size(102, 20);
            this.txbArchiveReference.TabIndex = 1;
            // 
            // lblLanguageId
            // 
            this.lblLanguageId.AutoSize = true;
            this.lblLanguageId.Location = new System.Drawing.Point(4, 38);
            this.lblLanguageId.Name = "lblLanguageId";
            this.lblLanguageId.Size = new System.Drawing.Size(69, 13);
            this.lblLanguageId.TabIndex = 5;
            this.lblLanguageId.Text = "Language id:";
            // 
            // cobLanguageId
            // 
            this.cobLanguageId.FormattingEnabled = true;
            this.cobLanguageId.Items.AddRange(new object[] {
            "1044",
            "1033",
            "1083",
            "2068"});
            this.cobLanguageId.Location = new System.Drawing.Point(104, 35);
            this.cobLanguageId.Name = "cobLanguageId";
            this.cobLanguageId.Size = new System.Drawing.Size(102, 21);
            this.cobLanguageId.TabIndex = 2;
            this.cobLanguageId.Text = "1044";
            // 
            // GetFormsetPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cobLanguageId);
            this.Controls.Add(this.lblLanguageId);
            this.Controls.Add(this.txbArchiveReference);
            this.Controls.Add(this.lblArchiveReference);
            this.Controls.Add(this.btnInvoke);
            this.Name = "GetFormsetPdf";
            this.Size = new System.Drawing.Size(385, 63);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInvoke;
        private System.Windows.Forms.Label lblArchiveReference;
        private System.Windows.Forms.TextBox txbArchiveReference;
        private System.Windows.Forms.Label lblLanguageId;
        private System.Windows.Forms.ComboBox cobLanguageId;

    }
}
