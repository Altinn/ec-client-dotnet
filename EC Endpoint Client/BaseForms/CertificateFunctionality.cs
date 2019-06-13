using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel.Configuration;
using System.Windows.Forms;
using EC_Endpoint_Client.Forms;

namespace EC_Endpoint_Client.BaseForms
{
    public partial class CertificateFunctionality : Form
    {
        public X509Certificate2 SelectedCertificate { get; set; }
        public string Thumbprint { get; set; }
        public CertificateFunctionality()
        {
            InitializeComponent();
        }

        public virtual X509Certificate2 GetCertificateByThumbPrint(string thumbPrint)
        {
            X509Store store = new X509Store(StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);
            foreach (X509Certificate2 cert in store.Certificates)
            {
                if (cert.Thumbprint?.ToUpper() == thumbPrint.ToUpper())
                {
                    return cert;
                }
            }
            return null;
        }

        public virtual void GetDefaultCertificate()
        {
            var behaviors = (BehaviorsSection)ConfigurationManager.GetSection("system.serviceModel/behaviors");
            EndpointBehaviorElement endpointBehavior = behaviors.EndpointBehaviors["CustomBehavior"];
            ClientCredentialsElement cce = (ClientCredentialsElement)endpointBehavior[0];
            Thumbprint = cce.ClientCertificate.FindValue;
            SelectedCertificate = GetCertificateByThumbPrint(Thumbprint);
            HandleCertificateSet();
        }

        public virtual void HandleCertificateSet()
        {
        }

        public virtual void ShowCertificateForm()
        {
            var csf = new CertificateSelectorForm(SelectedCertificate);
            csf.FormClosing += csf_FormClosing;
            csf.ShowDialog();
        }

        private void csf_FormClosing(object sender, FormClosingEventArgs e)
        {
            SelectedCertificate = ((CertificateSelectorForm)sender).SelectedCertificate;
            if (SelectedCertificate != null)
            {
                Thumbprint = SelectedCertificate.Thumbprint;
            }

            HandleCertificateSet();
        }
    }
}
