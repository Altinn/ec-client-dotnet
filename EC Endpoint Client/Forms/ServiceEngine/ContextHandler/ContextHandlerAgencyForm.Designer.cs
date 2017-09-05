namespace EC_Endpoint_Client.Forms.ServiceEngine
{
    partial class ContextHandlerAgencyForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_ICSaveResult = new System.Windows.Forms.Button();
            this.btn_ICShowResult = new System.Windows.Forms.Button();
            this.btn_ICInvoke = new System.Windows.Forms.Button();
            this.btn_ICShowShipment = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.servicePanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // servicePanel
            // 
            this.servicePanel.Controls.Add(this.tabControl1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(425, 369);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_ICSaveResult);
            this.tabPage1.Controls.Add(this.btn_ICShowResult);
            this.tabPage1.Controls.Add(this.btn_ICInvoke);
            this.tabPage1.Controls.Add(this.btn_ICShowShipment);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GetReporteeElementcontext";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_ICSaveResult
            // 
            this.btn_ICSaveResult.Location = new System.Drawing.Point(294, 64);
            this.btn_ICSaveResult.Name = "btn_ICSaveResult";
            this.btn_ICSaveResult.Size = new System.Drawing.Size(118, 23);
            this.btn_ICSaveResult.TabIndex = 13;
            this.btn_ICSaveResult.Text = "Save Result";
            this.btn_ICSaveResult.UseVisualStyleBackColor = true;
            this.btn_ICSaveResult.Click += new System.EventHandler(this.btn_ICSaveResult_Click);
            // 
            // btn_ICShowResult
            // 
            this.btn_ICShowResult.Location = new System.Drawing.Point(294, 35);
            this.btn_ICShowResult.Name = "btn_ICShowResult";
            this.btn_ICShowResult.Size = new System.Drawing.Size(118, 23);
            this.btn_ICShowResult.TabIndex = 15;
            this.btn_ICShowResult.Text = "Show Result";
            this.btn_ICShowResult.UseVisualStyleBackColor = true;
            this.btn_ICShowResult.Click += new System.EventHandler(this.btn_ICShowResult_Click);
            // 
            // btn_ICInvoke
            // 
            this.btn_ICInvoke.Location = new System.Drawing.Point(294, 6);
            this.btn_ICInvoke.Name = "btn_ICInvoke";
            this.btn_ICInvoke.Size = new System.Drawing.Size(118, 23);
            this.btn_ICInvoke.TabIndex = 17;
            this.btn_ICInvoke.Text = "Invoke Service";
            this.btn_ICInvoke.UseVisualStyleBackColor = true;
            this.btn_ICInvoke.Click += new System.EventHandler(this.btn_ICInvoke_Click);
            // 
            // btn_ICShowShipment
            // 
            this.btn_ICShowShipment.Location = new System.Drawing.Point(6, 6);
            this.btn_ICShowShipment.Name = "btn_ICShowShipment";
            this.btn_ICShowShipment.Size = new System.Drawing.Size(118, 23);
            this.btn_ICShowShipment.TabIndex = 18;
            this.btn_ICShowShipment.Text = "Show Shipment";
            this.btn_ICShowShipment.UseVisualStyleBackColor = true;
            this.btn_ICShowShipment.Click += new System.EventHandler(this.btn_ICShowShipment_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Test";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ContextHandlerAgencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Name = "ContextHandlerAgencyForm";
            this.Text = "ContextHandlerAgencyForm";
            this.servicePanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ICSaveResult;
        private System.Windows.Forms.Button btn_ICShowResult;
        private System.Windows.Forms.Button btn_ICInvoke;
        private System.Windows.Forms.Button btn_ICShowShipment;
    }
}