namespace EC_Endpoint_Client.UserControls
{
    partial class ActionHolderControl
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.request = new System.Windows.Forms.FlowLayoutPanel();
            this.invoke = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_ShowShipment = new System.Windows.Forms.Button();
            this.btn_SaveShipment = new System.Windows.Forms.Button();
            this.btn_LoadShipment = new System.Windows.Forms.Button();
            this.btn_invoke = new System.Windows.Forms.Button();
            this.btn_showResult = new System.Windows.Forms.Button();
            this.btn_saveResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.request.SuspendLayout();
            this.invoke.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.request);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.invoke);
            this.splitContainer1.Size = new System.Drawing.Size(598, 197);
            this.splitContainer1.SplitterDistance = 274;
            this.splitContainer1.TabIndex = 0;
            // 
            // request
            // 
            this.request.Controls.Add(this.btn_ShowShipment);
            this.request.Controls.Add(this.btn_SaveShipment);
            this.request.Controls.Add(this.btn_LoadShipment);
            this.request.Dock = System.Windows.Forms.DockStyle.Fill;
            this.request.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.request.Location = new System.Drawing.Point(0, 0);
            this.request.Name = "request";
            this.request.Size = new System.Drawing.Size(274, 197);
            this.request.TabIndex = 0;
            // 
            // invoke
            // 
            this.invoke.Controls.Add(this.btn_invoke);
            this.invoke.Controls.Add(this.btn_showResult);
            this.invoke.Controls.Add(this.btn_saveResult);
            this.invoke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoke.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.invoke.Location = new System.Drawing.Point(0, 0);
            this.invoke.Name = "invoke";
            this.invoke.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.invoke.Size = new System.Drawing.Size(320, 197);
            this.invoke.TabIndex = 0;
            // 
            // btn_ShowShipment
            // 
            this.btn_ShowShipment.Location = new System.Drawing.Point(3, 3);
            this.btn_ShowShipment.Name = "btn_ShowShipment";
            this.btn_ShowShipment.Size = new System.Drawing.Size(91, 23);
            this.btn_ShowShipment.TabIndex = 1;
            this.btn_ShowShipment.Text = "Show Shipment";
            this.btn_ShowShipment.UseVisualStyleBackColor = true;
            this.btn_ShowShipment.Click += new System.EventHandler(this.btn_ShowShipment_Click);
            // 
            // btn_SaveShipment
            // 
            this.btn_SaveShipment.Location = new System.Drawing.Point(3, 32);
            this.btn_SaveShipment.Name = "btn_SaveShipment";
            this.btn_SaveShipment.Size = new System.Drawing.Size(91, 23);
            this.btn_SaveShipment.TabIndex = 2;
            this.btn_SaveShipment.Text = "Save Shipment";
            this.btn_SaveShipment.UseVisualStyleBackColor = true;
            this.btn_SaveShipment.Click += new System.EventHandler(this.btn_SaveShipment_Click);
            // 
            // btn_LoadShipment
            // 
            this.btn_LoadShipment.Location = new System.Drawing.Point(3, 61);
            this.btn_LoadShipment.Name = "btn_LoadShipment";
            this.btn_LoadShipment.Size = new System.Drawing.Size(91, 23);
            this.btn_LoadShipment.TabIndex = 3;
            this.btn_LoadShipment.Text = "Load Shipment";
            this.btn_LoadShipment.UseVisualStyleBackColor = true;
            this.btn_LoadShipment.Click += new System.EventHandler(this.btn_LoadShipment_Click);
            // 
            // btn_invoke
            // 
            this.btn_invoke.Location = new System.Drawing.Point(218, 3);
            this.btn_invoke.Name = "btn_invoke";
            this.btn_invoke.Size = new System.Drawing.Size(99, 23);
            this.btn_invoke.TabIndex = 0;
            this.btn_invoke.Text = "Invoke Service";
            this.btn_invoke.UseVisualStyleBackColor = true;
            this.btn_invoke.Click += new System.EventHandler(this.btn_invoke_Click);
            // 
            // btn_showResult
            // 
            this.btn_showResult.Location = new System.Drawing.Point(218, 32);
            this.btn_showResult.Name = "btn_showResult";
            this.btn_showResult.Size = new System.Drawing.Size(99, 23);
            this.btn_showResult.TabIndex = 1;
            this.btn_showResult.Text = "Show Result";
            this.btn_showResult.UseVisualStyleBackColor = true;
            this.btn_showResult.Click += new System.EventHandler(this.btn_showResult_Click);
            // 
            // btn_saveResult
            // 
            this.btn_saveResult.Location = new System.Drawing.Point(218, 61);
            this.btn_saveResult.Name = "btn_saveResult";
            this.btn_saveResult.Size = new System.Drawing.Size(99, 23);
            this.btn_saveResult.TabIndex = 2;
            this.btn_saveResult.Text = "Save Result";
            this.btn_saveResult.UseVisualStyleBackColor = true;
            this.btn_saveResult.Click += new System.EventHandler(this.btn_saveResult_Click);
            // 
            // ActionHolderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ActionHolderControl";
            this.Size = new System.Drawing.Size(598, 197);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.request.ResumeLayout(false);
            this.invoke.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel request;
        private System.Windows.Forms.Button btn_ShowShipment;
        private System.Windows.Forms.Button btn_SaveShipment;
        private System.Windows.Forms.Button btn_LoadShipment;
        private System.Windows.Forms.FlowLayoutPanel invoke;
        private System.Windows.Forms.Button btn_invoke;
        private System.Windows.Forms.Button btn_showResult;
        private System.Windows.Forms.Button btn_saveResult;
    }
}
