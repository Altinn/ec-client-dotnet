namespace EC_Endpoint_Client.Forms.ServiceEngine.LookUp
{
    partial class LookUpFormEC2
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
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn_TestInvoke = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_LookUpSaveResult = new System.Windows.Forms.Button();
            this.btn_LookUpLoadShipment = new System.Windows.Forms.Button();
            this.btn_LookUpShowResult = new System.Windows.Forms.Button();
            this.btn_LookUpSaveShipment = new System.Windows.Forms.Button();
            this.btn_LookUpInvokeService = new System.Windows.Forms.Button();
            this.btn_LookUpShowShipment = new System.Windows.Forms.Button();
            this.servicePanel.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // servicePanel
            // 
            this.servicePanel.Controls.Add(this.tabControl1);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btn_TestInvoke);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(417, 343);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Test";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn_TestInvoke
            // 
            this.btn_TestInvoke.Location = new System.Drawing.Point(6, 6);
            this.btn_TestInvoke.Name = "btn_TestInvoke";
            this.btn_TestInvoke.Size = new System.Drawing.Size(118, 23);
            this.btn_TestInvoke.TabIndex = 13;
            this.btn_TestInvoke.Text = "Test";
            this.btn_TestInvoke.UseVisualStyleBackColor = true;
            this.btn_TestInvoke.Click += new System.EventHandler(this.btn_TestInvoke_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(425, 369);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_LookUpSaveResult);
            this.tabPage2.Controls.Add(this.btn_LookUpLoadShipment);
            this.tabPage2.Controls.Add(this.btn_LookUpShowResult);
            this.tabPage2.Controls.Add(this.btn_LookUpSaveShipment);
            this.tabPage2.Controls.Add(this.btn_LookUpInvokeService);
            this.tabPage2.Controls.Add(this.btn_LookUpShowShipment);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 343);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "LookUp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_LookUpSaveResult
            // 
            this.btn_LookUpSaveResult.Location = new System.Drawing.Point(294, 64);
            this.btn_LookUpSaveResult.Name = "btn_LookUpSaveResult";
            this.btn_LookUpSaveResult.Size = new System.Drawing.Size(118, 23);
            this.btn_LookUpSaveResult.TabIndex = 14;
            this.btn_LookUpSaveResult.Text = "Save Result";
            this.btn_LookUpSaveResult.UseVisualStyleBackColor = true;
            this.btn_LookUpSaveResult.Click += new System.EventHandler(this.btn_LookUpSaveResult_Click);
            // 
            // btn_LookUpLoadShipment
            // 
            this.btn_LookUpLoadShipment.Location = new System.Drawing.Point(6, 64);
            this.btn_LookUpLoadShipment.Name = "btn_LookUpLoadShipment";
            this.btn_LookUpLoadShipment.Size = new System.Drawing.Size(118, 23);
            this.btn_LookUpLoadShipment.TabIndex = 9;
            this.btn_LookUpLoadShipment.Text = "Load Shipment";
            this.btn_LookUpLoadShipment.UseVisualStyleBackColor = true;
            this.btn_LookUpLoadShipment.Click += new System.EventHandler(this.btn_LookUpLoadShipment_Click);
            // 
            // btn_LookUpShowResult
            // 
            this.btn_LookUpShowResult.Location = new System.Drawing.Point(294, 35);
            this.btn_LookUpShowResult.Name = "btn_LookUpShowResult";
            this.btn_LookUpShowResult.Size = new System.Drawing.Size(118, 23);
            this.btn_LookUpShowResult.TabIndex = 10;
            this.btn_LookUpShowResult.Text = "Show Result";
            this.btn_LookUpShowResult.UseVisualStyleBackColor = true;
            this.btn_LookUpShowResult.Click += new System.EventHandler(this.btn_LookUpShowResult_Click);
            // 
            // btn_LookUpSaveShipment
            // 
            this.btn_LookUpSaveShipment.Location = new System.Drawing.Point(6, 35);
            this.btn_LookUpSaveShipment.Name = "btn_LookUpSaveShipment";
            this.btn_LookUpSaveShipment.Size = new System.Drawing.Size(118, 23);
            this.btn_LookUpSaveShipment.TabIndex = 11;
            this.btn_LookUpSaveShipment.Text = "Save Shipment";
            this.btn_LookUpSaveShipment.UseVisualStyleBackColor = true;
            this.btn_LookUpSaveShipment.Click += new System.EventHandler(this.btn_LookUpSaveShipment_Click);
            // 
            // btn_LookUpInvokeService
            // 
            this.btn_LookUpInvokeService.Location = new System.Drawing.Point(294, 6);
            this.btn_LookUpInvokeService.Name = "btn_LookUpInvokeService";
            this.btn_LookUpInvokeService.Size = new System.Drawing.Size(118, 23);
            this.btn_LookUpInvokeService.TabIndex = 12;
            this.btn_LookUpInvokeService.Text = "Invoke Service";
            this.btn_LookUpInvokeService.UseVisualStyleBackColor = true;
            this.btn_LookUpInvokeService.Click += new System.EventHandler(this.btn_LookUpInvokeService_Click);
            // 
            // btn_LookUpShowShipment
            // 
            this.btn_LookUpShowShipment.Location = new System.Drawing.Point(6, 6);
            this.btn_LookUpShowShipment.Name = "btn_LookUpShowShipment";
            this.btn_LookUpShowShipment.Size = new System.Drawing.Size(118, 23);
            this.btn_LookUpShowShipment.TabIndex = 13;
            this.btn_LookUpShowShipment.Text = "Show Shipment";
            this.btn_LookUpShowShipment.UseVisualStyleBackColor = true;
            this.btn_LookUpShowShipment.Click += new System.EventHandler(this.btn_LookUpShowShipment_Click);
            // 
            // LookUpFormEC2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Name = "LookUpFormEC2";
            this.Text = "LookUpFormEC2";
            this.servicePanel.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btn_TestInvoke;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_LookUpSaveResult;
        private System.Windows.Forms.Button btn_LookUpLoadShipment;
        private System.Windows.Forms.Button btn_LookUpShowResult;
        private System.Windows.Forms.Button btn_LookUpSaveShipment;
        private System.Windows.Forms.Button btn_LookUpInvokeService;
        private System.Windows.Forms.Button btn_LookUpShowShipment;


    }
}