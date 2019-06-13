using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace EC_Endpoint_Client.Forms
{
    internal class CertInfo
    {
        public string Thumbprint;
        public string Description;
        public DateTime ValidTo;
    }

    public partial class CertificateSelectorForm : Form
    {
        private X509Store _store;
        private List<CertInfo> _certs;
        private X509Certificate2 _selectedCertificate;
        public X509Certificate2 SelectedCertificate 
        { 
            get { return _selectedCertificate; }
        }

        public CertificateSelectorForm()
        {
            InitializeComponent();
            ShowCertificates();
            pg_certViewer.ReadOnly = true;
        }

        public CertificateSelectorForm(X509Certificate2 cert)
        {
            InitializeComponent();
            ShowCertificates();
            _selectedCertificate = cert;
            SetSelectionByCertificate(cert);
            pg_certViewer.SelectedObject = SelectedCertificate;
            pg_certViewer.ReadOnly = true;
        }

        private void ShowCertificates()
        {
            _store = new X509Store("My", StoreLocation.CurrentUser);
            _store.Open(OpenFlags.ReadOnly);
            _certs = new List<CertInfo>();
            foreach (X509Certificate2 cert in _store.Certificates)
            {
                _certs.Add(new CertInfo
                {
                    Description = !string.IsNullOrWhiteSpace(cert.FriendlyName) ? cert.FriendlyName : cert.IssuerName.Name,
                    Thumbprint = cert.Thumbprint,
                    ValidTo = cert.NotAfter

                });
            }
            dgv_certificates.DataSource =  (from d in _certs
                                           orderby d.Description
                                            select new { d.Description, d.Thumbprint, d.ValidTo }).ToList();
            dgv_certificates.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_certificates.MultiSelect = false;
            dgv_certificates.Columns["Description"].Name = "Description";
            dgv_certificates.Columns["Thumbprint"].Name = "Thumbprint";
            dgv_certificates.Columns["ValidTo"].Name = "ValidTo";

            foreach (DataGridViewRow row in dgv_certificates.Rows)
            {
                if ((DateTime)row.Cells["ValidTo"].Value > DateTime.Now)
                {
                    row.DefaultCellStyle.BackColor = Color.DarkRed;
                }
            }
        }

        private void dgv_certificates_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_certificates.SelectedRows.Count > 0)
            {
                string thumbPrint = dgv_certificates.SelectedRows[0].Cells["Thumbprint"].Value.ToString();
                SetCertificateByThumbprint(thumbPrint);
                pg_certViewer.SelectedObject = SelectedCertificate;
            }
        }

        private void SetSelectionByCertificate(X509Certificate2 cert)
        {
            if (cert != null)
            {
                foreach (DataGridViewRow row in dgv_certificates.Rows)
                {
                    row.Selected = false;
                    if (row.Cells["Thumbprint"].Value.ToString() == cert.Thumbprint)
                    {
                        row.Cells["Thumbprint"].Selected = true;
                    }
                }
            }
        }

        private void SetCertificateByThumbprint(string thumbprint)
        {
            _selectedCertificate = _store.Certificates.Find(X509FindType.FindByThumbprint, thumbprint, false)[0];
        }
    }
}
