using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC_Endpoint_Client.Forms
{
    public partial class CertificateSelectorForm : Form
    {
        private X509Store _store;
        private List<string> _thumbPrints;
        private Dictionary<string, string> _certInfo;
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
            _thumbPrints = new List<string>();
            _certInfo = new Dictionary<string, string>();
            foreach (X509Certificate2 cert in _store.Certificates)
            {
                _thumbPrints.Add(cert.Thumbprint);
                _certInfo.Add(cert.Thumbprint, cert.FriendlyName != "" ? cert.FriendlyName : cert.IssuerName.Name);
            }
            dgv_certificates.DataSource = (from d in _certInfo
                                           orderby d.Value
                                           select new { d.Value, d.Key }).ToList();
            dgv_certificates.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_certificates.MultiSelect = false;
            dgv_certificates.Columns["Value"].Name = "Description";
            dgv_certificates.Columns["Key"].Name = "Thumbprint";
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
            foreach (X509Certificate2 cert in _store.Certificates)
            {
                if (cert.Thumbprint == thumbprint)
                {
                    _selectedCertificate = cert;
                    break;
                }
            }
        }
    }
}
