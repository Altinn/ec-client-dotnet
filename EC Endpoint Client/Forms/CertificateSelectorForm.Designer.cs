namespace EC_Endpoint_Client.Forms
{
    partial class CertificateSelectorForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_certificates = new System.Windows.Forms.DataGridView();
            this.pg_certViewer = new EC_Endpoint_Client.UserControls.ReadOnlyPropertyGrid();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_certificates)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_certificates, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pg_certViewer, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.28767F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.71233F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 505);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgv_certificates
            // 
            this.dgv_certificates.AllowUserToAddRows = false;
            this.dgv_certificates.AllowUserToDeleteRows = false;
            this.dgv_certificates.AllowUserToOrderColumns = true;
            this.dgv_certificates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_certificates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_certificates.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_certificates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_certificates.Location = new System.Drawing.Point(3, 3);
            this.dgv_certificates.Name = "dgv_certificates";
            this.dgv_certificates.ReadOnly = true;
            this.dgv_certificates.Size = new System.Drawing.Size(808, 237);
            this.dgv_certificates.TabIndex = 0;
            this.dgv_certificates.SelectionChanged += new System.EventHandler(this.dgv_certificates_SelectionChanged);
            // 
            // pg_certViewer
            // 
            this.pg_certViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pg_certViewer.Location = new System.Drawing.Point(3, 246);
            this.pg_certViewer.Name = "pg_certViewer";
            this.pg_certViewer.ReadOnly = false;
            this.pg_certViewer.Size = new System.Drawing.Size(808, 256);
            this.pg_certViewer.TabIndex = 1;
            // 
            // CertificateSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 505);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CertificateSelectorForm";
            this.Text = "CertificateSelectorForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_certificates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_certificates;
        private UserControls.ReadOnlyPropertyGrid pg_certViewer;
    }
}