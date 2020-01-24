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
            this.btn_IntermediaryInbound = new System.Windows.Forms.Button();
            this.btn_IntermediaryInboundStreamed = new System.Windows.Forms.Button();
            this.btn_ReceiptAgency = new System.Windows.Forms.Button();
            this.btn_Receipt = new System.Windows.Forms.Button();
            this.btn_BatchLoggingAgency = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_IntermediaryInbound
            // 
            this.btn_IntermediaryInbound.Location = new System.Drawing.Point(12, 41);
            this.btn_IntermediaryInbound.Name = "btn_IntermediaryInbound";
            this.btn_IntermediaryInbound.Size = new System.Drawing.Size(162, 23);
            this.btn_IntermediaryInbound.TabIndex = 0;
            this.btn_IntermediaryInbound.Text = "IntermediaryInbound";
            this.btn_IntermediaryInbound.UseVisualStyleBackColor = true;
            this.btn_IntermediaryInbound.Click += new System.EventHandler(this.btn_IntermediaryInbound_Click);
            // 
            // btn_IntermediaryInboundStreamed
            // 
            this.btn_IntermediaryInboundStreamed.Location = new System.Drawing.Point(12, 70);
            this.btn_IntermediaryInboundStreamed.Name = "btn_IntermediaryInboundStreamed";
            this.btn_IntermediaryInboundStreamed.Size = new System.Drawing.Size(162, 23);
            this.btn_IntermediaryInboundStreamed.TabIndex = 0;
            this.btn_IntermediaryInboundStreamed.Text = "IntermediaryInboundStreamed";
            this.btn_IntermediaryInboundStreamed.UseVisualStyleBackColor = true;
            this.btn_IntermediaryInboundStreamed.Click += new System.EventHandler(this.btn_IntermediaryInboundStreamed_Click);
            // 
            // btn_ReceiptAgency
            // 
            this.btn_ReceiptAgency.Location = new System.Drawing.Point(12, 99);
            this.btn_ReceiptAgency.Name = "btn_ReceiptAgency";
            this.btn_ReceiptAgency.Size = new System.Drawing.Size(162, 23);
            this.btn_ReceiptAgency.TabIndex = 0;
            this.btn_ReceiptAgency.Text = "ReceiptAgency";
            this.btn_ReceiptAgency.UseVisualStyleBackColor = true;
            this.btn_ReceiptAgency.Click += new System.EventHandler(this.btn_ReceiptAgency_Click);
            // 
            // btn_Receipt
            // 
            this.btn_Receipt.Location = new System.Drawing.Point(12, 128);
            this.btn_Receipt.Name = "btn_Receipt";
            this.btn_Receipt.Size = new System.Drawing.Size(162, 23);
            this.btn_Receipt.TabIndex = 0;
            this.btn_Receipt.Text = "Receipt";
            this.btn_Receipt.UseVisualStyleBackColor = true;
            this.btn_Receipt.Click += new System.EventHandler(this.btn_Receipt_Click);
            // 
            // btn_BatchLoggingAgency
            // 
            this.btn_BatchLoggingAgency.Location = new System.Drawing.Point(12, 12);
            this.btn_BatchLoggingAgency.Name = "btn_BatchLoggingAgency";
            this.btn_BatchLoggingAgency.Size = new System.Drawing.Size(162, 23);
            this.btn_BatchLoggingAgency.TabIndex = 1;
            this.btn_BatchLoggingAgency.Text = "BatchLoggingAgency";
            this.btn_BatchLoggingAgency.UseVisualStyleBackColor = true;
            this.btn_BatchLoggingAgency.Click += new System.EventHandler(this.btn_BatchLoggingAgency_Click);
            // 
            // IntermediarySelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 167);
            this.Controls.Add(this.btn_BatchLoggingAgency);
            this.Controls.Add(this.btn_Receipt);
            this.Controls.Add(this.btn_ReceiptAgency);
            this.Controls.Add(this.btn_IntermediaryInboundStreamed);
            this.Controls.Add(this.btn_IntermediaryInbound);
            this.Name = "IntermediarySelectorForm";
            this.Text = "IntermediarySelectorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_IntermediaryInbound;
        private System.Windows.Forms.Button btn_IntermediaryInboundStreamed;
        private System.Windows.Forms.Button btn_ReceiptAgency;
        private System.Windows.Forms.Button btn_Receipt;
        private System.Windows.Forms.Button btn_BatchLoggingAgency;
    }
}