namespace EC_Endpoint_Client.Forms
{
    partial class ServiceOwnerArchiveForm
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
            this.btn_SaveArchivedFormTask = new System.Windows.Forms.Button();
            this.btn_ShowArchivedFormTask = new System.Windows.Forms.Button();
            this.btn_ShowSOAShipment = new System.Windows.Forms.Button();
            this.btn_getArchivedFormTask = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_test = new System.Windows.Forms.Button();
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
            this.tabPage1.Controls.Add(this.btn_SaveArchivedFormTask);
            this.tabPage1.Controls.Add(this.btn_ShowArchivedFormTask);
            this.tabPage1.Controls.Add(this.btn_ShowSOAShipment);
            this.tabPage1.Controls.Add(this.btn_getArchivedFormTask);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GetArchivedFormTask";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_SaveArchivedFormTask
            // 
            this.btn_SaveArchivedFormTask.Location = new System.Drawing.Point(280, 64);
            this.btn_SaveArchivedFormTask.Name = "btn_SaveArchivedFormTask";
            this.btn_SaveArchivedFormTask.Size = new System.Drawing.Size(134, 23);
            this.btn_SaveArchivedFormTask.TabIndex = 3;
            this.btn_SaveArchivedFormTask.Text = "Save Result";
            this.btn_SaveArchivedFormTask.UseVisualStyleBackColor = true;
            this.btn_SaveArchivedFormTask.Click += new System.EventHandler(this.btn_SaveArchivedFormTask_Click);
            // 
            // btn_ShowArchivedFormTask
            // 
            this.btn_ShowArchivedFormTask.Location = new System.Drawing.Point(280, 35);
            this.btn_ShowArchivedFormTask.Name = "btn_ShowArchivedFormTask";
            this.btn_ShowArchivedFormTask.Size = new System.Drawing.Size(134, 23);
            this.btn_ShowArchivedFormTask.TabIndex = 3;
            this.btn_ShowArchivedFormTask.Text = "Show Result";
            this.btn_ShowArchivedFormTask.UseVisualStyleBackColor = true;
            this.btn_ShowArchivedFormTask.Click += new System.EventHandler(this.btn_ShowArchivedFormTask_Click);
            // 
            // btn_ShowSOAShipment
            // 
            this.btn_ShowSOAShipment.Location = new System.Drawing.Point(6, 6);
            this.btn_ShowSOAShipment.Name = "btn_ShowSOAShipment";
            this.btn_ShowSOAShipment.Size = new System.Drawing.Size(134, 23);
            this.btn_ShowSOAShipment.TabIndex = 3;
            this.btn_ShowSOAShipment.Text = "Show Shipment";
            this.btn_ShowSOAShipment.UseVisualStyleBackColor = true;
            this.btn_ShowSOAShipment.Click += new System.EventHandler(this.btn_ShowSOAShipment_Click);
            // 
            // btn_getArchivedFormTask
            // 
            this.btn_getArchivedFormTask.Location = new System.Drawing.Point(280, 6);
            this.btn_getArchivedFormTask.Name = "btn_getArchivedFormTask";
            this.btn_getArchivedFormTask.Size = new System.Drawing.Size(134, 23);
            this.btn_getArchivedFormTask.TabIndex = 3;
            this.btn_getArchivedFormTask.Text = "Invoke Service";
            this.btn_getArchivedFormTask.UseVisualStyleBackColor = true;
            this.btn_getArchivedFormTask.Click += new System.EventHandler(this.btn_getArchivedFormTask_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_test);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Test";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(7, 7);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(75, 23);
            this.btn_test.TabIndex = 0;
            this.btn_test.Text = "Test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // ServiceOwnerArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 463);
            this.Name = "ServiceOwnerArchiveForm";
            this.Text = "ServiceOwnerArchiveForm";
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
        private System.Windows.Forms.Button btn_SaveArchivedFormTask;
        private System.Windows.Forms.Button btn_ShowArchivedFormTask;
        private System.Windows.Forms.Button btn_getArchivedFormTask;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Button btn_ShowSOAShipment;
    }
}