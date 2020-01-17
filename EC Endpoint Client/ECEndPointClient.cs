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
            btn_IntermediaryECEndpoint.Enabled = SelectedCertificate != null;
            btn_ArchiveECEndpoint.Enabled = SelectedCertificate != null;
            btn_ServiceEngineECEndPoint.Enabled = SelectedCertificate != null;
            btn_AuthorizationECEndPoint.Enabled = SelectedCertificate != null;

            btn_IntermediaryEC2Endpoint.Enabled = SelectedCertificate != null;
            btn_ArchiveEC2Endpoint.Enabled = SelectedCertificate != null;
            btn_ServiceEngineEC2EndPoint.Enabled = SelectedCertificate != null;
            btn_AuthorizationEC2EndPoint.Enabled = SelectedCertificate != null;
        }

        private void btn_SelectCertificate_Click(object sender, EventArgs e)
        {
            ShowCertificateForm();
        }

        #region endpoint selector form activation
        private void btn_ArchiveECEndpoint_Click(object sender, EventArgs e)
        {
            ArchiveEndPointSelectorForm aepsForm = new ArchiveEndPointSelectorForm(Thumbprint, SelectedCertificate, false);
            Hide();
            aepsForm.SelectedCertificate = SelectedCertificate;
            aepsForm.Thumbprint = Thumbprint;
            aepsForm.State = State;
            aepsForm.FormClosing += SelectorFormClosing;
            aepsForm.ShowDialog();
            Show();
        }

        private void btn_AuthorizationECEndPoint_Click(object sender, EventArgs e)
        {
            Forms.Authorization.AuthorizationSelectorForm asF = new Forms.Authorization.AuthorizationSelectorForm(Thumbprint, SelectedCertificate, false);
            asF.State = State;
            asF.FormClosing += SelectorFormClosing;
            Hide();
            asF.ShowDialog();
            Show();
        }

        private void btn_IntermediaryECEndpoint_Click(object sender, EventArgs e)
        {
            Forms.Intermediary.IntermediarySelectorForm isf = new Forms.Intermediary.IntermediarySelectorForm(Thumbprint, SelectedCertificate, false);
            isf.State = State;
            isf.FormClosing += SelectorFormClosing;
            Hide();
            isf.ShowDialog();
            Show();
        }

        private void btn_ServiceEngineECEndPoint_Click(object sender, EventArgs e)
        {
            Forms.ServiceEngine.ServiceEngineSelectorForm ssf = new Forms.ServiceEngine.ServiceEngineSelectorForm(Thumbprint, SelectedCertificate, false);
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

        private void btn_ArchiveEC2Endpoint_Click(object sender, EventArgs e)
        {
            ArchiveEndPointSelectorForm aepsForm = new ArchiveEndPointSelectorForm(Thumbprint, SelectedCertificate, true);
            Hide();
            aepsForm.SelectedCertificate = SelectedCertificate;
            aepsForm.Thumbprint = Thumbprint;
            aepsForm.State = State;
            aepsForm.FormClosing += SelectorFormClosing;
            aepsForm.ShowDialog();
            Show();
        }

        private void btn_AuthorizationEC2EndPoint_Click(object sender, EventArgs e)
        {
            Forms.Authorization.AuthorizationSelectorForm asF = new Forms.Authorization.AuthorizationSelectorForm(Thumbprint, SelectedCertificate, true);
            asF.State = State;
            asF.FormClosing += SelectorFormClosing;
            Hide();
            asF.ShowDialog();
            Show();
        }

        private void btn_ServiceEngineEC2EndPoint_Click(object sender, EventArgs e)
        {
            Forms.ServiceEngine.ServiceEngineSelectorForm ssf = new Forms.ServiceEngine.ServiceEngineSelectorForm(Thumbprint, SelectedCertificate, true);
            ssf.State = State;
            ssf.FormClosing += SelectorFormClosing;
            Hide();
            ssf.ShowDialog();
            Show();
        }

        private void btn_IntermediaryEC2Endpoint_Click(object sender, EventArgs e)
        {
            Forms.Intermediary.IntermediarySelectorForm isf = new Forms.Intermediary.IntermediarySelectorForm(Thumbprint, SelectedCertificate, true);
            isf.State = State;
            isf.FormClosing += SelectorFormClosing;
            Hide();
            isf.ShowDialog();
            Show();
        }
    }
}
