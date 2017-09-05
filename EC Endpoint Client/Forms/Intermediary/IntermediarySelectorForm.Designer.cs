namespace EC_Endpoint_Client.Forms.Intermediary
{
    partial class IntermediarySelectorForm
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
            this.btn_intermediary = new System.Windows.Forms.Button();
            this.btn_intermediarystreamed = new System.Windows.Forms.Button();
            this.btn_receiptAgency = new System.Windows.Forms.Button();
            this.btn_receipt = new System.Windows.Forms.Button();
            this.btn_batchlogging = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_intermediary
            // 
            this.btn_intermediary.Location = new System.Drawing.Point(12, 41);
            this.btn_intermediary.Name = "btn_intermediary";
            this.btn_intermediary.Size = new System.Drawing.Size(162, 23);
            this.btn_intermediary.TabIndex = 0;
            this.btn_intermediary.Text = "IntermediaryInbound";
            this.btn_intermediary.UseVisualStyleBackColor = true;
            this.btn_intermediary.Click += new System.EventHandler(this.btn_intermediary_Click);
            // 
            // btn_intermediarystreamed
            // 
            this.btn_intermediarystreamed.Location = new System.Drawing.Point(12, 70);
            this.btn_intermediarystreamed.Name = "btn_intermediarystreamed";
            this.btn_intermediarystreamed.Size = new System.Drawing.Size(162, 23);
            this.btn_intermediarystreamed.TabIndex = 0;
            this.btn_intermediarystreamed.Text = "IntermediaryInboundStreamed";
            this.btn_intermediarystreamed.UseVisualStyleBackColor = true;
            this.btn_intermediarystreamed.Click += new System.EventHandler(this.btn_intermediarystreamed_Click);
            // 
            // btn_receiptAgency
            // 
            this.btn_receiptAgency.Location = new System.Drawing.Point(12, 99);
            this.btn_receiptAgency.Name = "btn_receiptAgency";
            this.btn_receiptAgency.Size = new System.Drawing.Size(162, 23);
            this.btn_receiptAgency.TabIndex = 0;
            this.btn_receiptAgency.Text = "ReceiptAgency";
            this.btn_receiptAgency.UseVisualStyleBackColor = true;
            this.btn_receiptAgency.Click += new System.EventHandler(this.btn_receiptAgency_Click);
            // 
            // btn_receipt
            // 
            this.btn_receipt.Location = new System.Drawing.Point(12, 128);
            this.btn_receipt.Name = "btn_receipt";
            this.btn_receipt.Size = new System.Drawing.Size(162, 23);
            this.btn_receipt.TabIndex = 0;
            this.btn_receipt.Text = "Receipt";
            this.btn_receipt.UseVisualStyleBackColor = true;
            this.btn_receipt.Click += new System.EventHandler(this.btn_receipt_Click);
            // 
            // btn_batchlogging
            // 
            this.btn_batchlogging.Location = new System.Drawing.Point(12, 12);
            this.btn_batchlogging.Name = "btn_batchlogging";
            this.btn_batchlogging.Size = new System.Drawing.Size(162, 23);
            this.btn_batchlogging.TabIndex = 1;
            this.btn_batchlogging.Text = "BatchLoggingAgency";
            this.btn_batchlogging.UseVisualStyleBackColor = true;
            this.btn_batchlogging.Click += new System.EventHandler(this.btn_batchlogging_Click);
            // 
            // IntermediarySelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 167);
            this.Controls.Add(this.btn_batchlogging);
            this.Controls.Add(this.btn_receipt);
            this.Controls.Add(this.btn_receiptAgency);
            this.Controls.Add(this.btn_intermediarystreamed);
            this.Controls.Add(this.btn_intermediary);
            this.Name = "IntermediarySelectorForm";
            this.Text = "IntermediarySelectorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_intermediary;
        private System.Windows.Forms.Button btn_intermediarystreamed;
        private System.Windows.Forms.Button btn_receiptAgency;
        private System.Windows.Forms.Button btn_receipt;
        private System.Windows.Forms.Button btn_batchlogging;
    }
}