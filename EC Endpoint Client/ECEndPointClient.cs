using System;
using System.Windows.Forms;
using ApiForm = EC_Endpoint_Client.Forms.Api.ApiForm;
using ArchiveEndPointSelectorForm = EC_Endpoint_Client.Forms.Archive.ArchiveEndPointSelectorForm;
using SelectorBaseForm = EC_Endpoint_Client.BaseForms.SelectorBaseForm;

#region authorization administration

#endregion
#region intermediaryexternal

using System.Security.Cryptography.X509Certificates;
using EC_Endpoint_Client.Classes;
#endregion
namespace EC_Endpoint_Client
{
    public partial class EcEndPointClient : BaseForms.CertificateFunctionality
    {
        public EndPointState State { get; set; }
        public EcEndPointClient()
        {
            InitializeComponent();
            GetDefaultCertificateHelper();
        }

        public void GetDefaultCertificateHelper()
        {
            GetDefaultCertificate();
        }

        public override X509Certificate2 GetCertificateByThumbPrint(string thumbprint)
        {
            return base.GetCertificateByThumbPrint(thumbprint);
        }

        public override void HandleCertificateSet()
        {
            button1.Enabled = SelectedCertificate != null;
            button2.Enabled = SelectedCertificate != null;
            button4.Enabled = SelectedCertificate != null;
            btn_AuthorizationAdministration.Enabled = SelectedCertificate != null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowCertificateForm();
        }

        #region endpoint selector form activation
        private void button2_Click_1(object sender, EventArgs e)
        {
            ArchiveEndPointSelectorForm aepsForm = new ArchiveEndPointSelectorForm(Thumbprint, SelectedCertificate);
            Hide();
            aepsForm.SelectedCertificate = SelectedCertificate;
            aepsForm.Thumbprint = Thumbprint;
            aepsForm.State = State;
            aepsForm.FormClosing += SelectorFormClosing;
            aepsForm.ShowDialog();
            Show();
        }

        private void btn_AuthorizationAdministration_Click(object sender, EventArgs e)
        {
            Forms.Authorization.AuthorizationSelectorForm asF = new Forms.Authorization.AuthorizationSelectorForm();
            asF.SelectedCertificate = SelectedCertificate;
            asF.Thumbprint = Thumbprint;
            asF.State = State;
            asF.FormClosing += SelectorFormClosing;
            Hide();
            asF.ShowDialog();
            Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Forms.Intermediary.IntermediarySelectorForm isf = new Forms.Intermediary.IntermediarySelectorForm();
            isf.SelectedCertificate = SelectedCertificate;
            isf.Thumbprint = Thumbprint;
            isf.State = State;
            isf.FormClosing += SelectorFormClosing;
            Hide();
            isf.ShowDialog();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Forms.ServiceEngine.ServiceEngineSelectorForm ssf = new Forms.ServiceEngine.ServiceEngineSelectorForm();
            ssf.SelectedCertificate = SelectedCertificate;
            ssf.Thumbprint = Thumbprint;
            ssf.State = State;
            ssf.FormClosing += SelectorFormClosing;
            Hide();
            ssf.ShowDialog();
            Show();
        }

        private void SelectorFormClosing(object sender, FormClosingEventArgs e)
        {
            State = ((SelectorBaseForm)sender).State;
            SelectedCertificate = ((SelectorBaseForm)sender).SelectedCertificate;
            Thumbprint = SelectedCertificate.Thumbprint;
        }

        private void btn_Api_Click(object sender, EventArgs e)
        {
            ApiForm apiForm = new ApiForm();
            apiForm.SelectedCertificate = SelectedCertificate;
            apiForm.Thumbprint = Thumbprint;
            apiForm.FormClosing += SelectorFormClosing;
            apiForm.State = State;
            Hide();
            apiForm.ShowDialog();
            Show();
        }

        #endregion

    }
}
