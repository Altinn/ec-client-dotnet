namespace EC_Endpoint_Client.BaseForms
{
    partial class AgencyBaseForm
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(615, 9);
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.Text = "AgencyUsername";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(615, 35);
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.Text = "AgencyPassword";
            // 
            // AgencyBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Name = "AgencyBaseForm";
            this.Text = "AgencyBaseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}