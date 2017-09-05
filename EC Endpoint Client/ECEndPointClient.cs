using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#region authorization administration
using EC_Endpoint_Client.Administration;
#endregion
#region intermediaryexternal
using EC_Endpoint_Client.IntermediaryInboundStreamed;
using EC_Endpoint_Client.Receipt;
using EC_Endpoint_Client.ReceiptAgency;
using EC_Endpoint_Client.IntermediaryInbound;
using System.Configuration;
using System.ServiceModel.Configuration;
using EC_Endpoint_Client.Forms;
using System.Security.Cryptography.X509Certificates;
using EC_Endpoint_Client.Classes;
#endregion
namespace EC_Endpoint_Client
{
    public partial class ECEndPointClient : CertificateFunctionality
    {
        public EndPointState State { get; set; }
        public ECEndPointClient()
        {
            InitializeComponent();
            GetDefaultCertificate();
        }

        

        public override void GetDefaultCertificate()
        {
            base.GetDefaultCertificate();
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

        public override void ShowCertificateForm()
        {
            base.ShowCertificateForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowCertificateForm();
        }

        /*
         * These buttons open the EndPoint selector form for each "Area" of altinn services. (Archive, Authorization, Intermediary, ServiceEngine).
         * Register doesn't have any EC endpoints, and is therefore not included.
         * All proxy behavior is contained in the Functionality/EndPoints code files.
         * 
         */
        #region endpoint selector form activation
        private void button2_Click_1(object sender, EventArgs e)
        {
            Forms.ArchiveEndPointSelectorForm aepsForm = new Forms.ArchiveEndPointSelectorForm(Thumbprint, SelectedCertificate);
            this.Hide();
            aepsForm.SelectedCertificate = SelectedCertificate;
            aepsForm.Thumbprint = Thumbprint;
            aepsForm.State = this.State;
            aepsForm.FormClosing += SelectorFormClosing;
            aepsForm.ShowDialog();
            this.Show();
        }

        private void btn_AuthorizationAdministration_Click(object sender, EventArgs e)
        {
            Forms.Authorization.AuthorizationSelectorForm asF = new Forms.Authorization.AuthorizationSelectorForm();
            asF.SelectedCertificate = SelectedCertificate;
            asF.Thumbprint = Thumbprint;
            asF.State = State;
            asF.FormClosing += SelectorFormClosing;
            this.Hide();
            asF.ShowDialog();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Forms.Intermediary.IntermediarySelectorForm isf = new Forms.Intermediary.IntermediarySelectorForm();
            isf.SelectedCertificate = SelectedCertificate;
            isf.Thumbprint = Thumbprint;
            isf.State = State;
            isf.FormClosing += SelectorFormClosing;
            this.Hide();
            isf.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Forms.ServiceEngine.ServiceEngineSelectorForm ssf = new Forms.ServiceEngine.ServiceEngineSelectorForm();
            ssf.SelectedCertificate = SelectedCertificate;
            ssf.Thumbprint = Thumbprint;
            ssf.State = State;
            ssf.FormClosing += SelectorFormClosing;
            this.Hide();
            ssf.ShowDialog();
            this.Show();
        }

        private void SelectorFormClosing(object sender, FormClosingEventArgs e)
        {
            this.State = ((SelectorBaseForm)sender).State;
            this.SelectedCertificate = ((SelectorBaseForm)sender).SelectedCertificate;
            this.Thumbprint = SelectedCertificate.Thumbprint;
        }

        private void btn_Api_Click(object sender, EventArgs e)
        {
            Forms.ApiForm apiForm = new Forms.ApiForm();
            apiForm.SelectedCertificate = SelectedCertificate;
            apiForm.Thumbprint = Thumbprint;
            apiForm.FormClosing += SelectorFormClosing;
            apiForm.State = State;
            this.Hide();
            apiForm.ShowDialog();
            this.Show();
        }

        #endregion

    }
}
