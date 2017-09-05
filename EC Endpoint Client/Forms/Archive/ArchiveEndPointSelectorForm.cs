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
    public partial class ArchiveEndPointSelectorForm : SelectorBaseForm
    {

        public ArchiveEndPointSelectorForm()
        {
            InitializeComponent();
        }

        public ArchiveEndPointSelectorForm(string thumb, X509Certificate2 cert)
        {
            Thumbprint = thumb;
            SelectedCertificate = cert;
            InitializeComponent();
        }

        private void btn_ArchiveCommonAgency_Click(object sender, EventArgs e)
        {
            EC_Endpoint_Client.Forms.ArchiveCommonAgencyForm acaForm = new Forms.ArchiveCommonAgencyForm();
            SetClientValues(acaForm, "ArchiveCommonAgency.IArchiveCommonAgencyExternalEC");
            acaForm.SelectedCertificate = this.SelectedCertificate;
            acaForm.Thumbprint = this.Thumbprint;
            acaForm.EndPointConfigurationNameList = GetEndPoints("ArchiveCommonAgency.IArchiveCommonAgencyExternalEC");
            ShowMethod1(acaForm);
        }

        private void btn_DownloadQueue_Click(object sender, EventArgs e)
        {
            EC_Endpoint_Client.Forms.DownloadQueueForm dqForm = new DownloadQueueForm();
            dqForm.Thumbprint = this.Thumbprint;
            dqForm.SelectedCertificate = this.SelectedCertificate;
            dqForm.EndPointConfigurationNameList = GetEndPoints("DownloadQueue.IDownloadQueueExternalEC");
            SetClientValues(dqForm, "DownloadQueue.IDownloadQueueExternalEC");
            ShowMethod1(dqForm);
        }

        private void btn_KeyManangement_Click(object sender, EventArgs e)
        {
            EC_Endpoint_Client.Forms.KeyManagementForm keyForm = new KeyManagementForm();
            keyForm.Thumbprint = this.Thumbprint;
            keyForm.SelectedCertificate = this.SelectedCertificate;
            keyForm.EndPointConfigurationNameList = GetEndPoints("KeyManagement.IKeyManagementExternalEC");
            SetClientValues(keyForm, "KeyManagement.IKeyManagementExternalEC");
            ShowMethod1(keyForm);
        }

        private void btn_ReporteeArchive_Click(object sender, EventArgs e)
        {
            EC_Endpoint_Client.Forms.ReporteeArchiveForm repForm = new ReporteeArchiveForm();
            repForm.Thumbprint = this.Thumbprint;
            repForm.SelectedCertificate = this.SelectedCertificate;
            repForm.EndPointConfigurationNameList = GetEndPoints("ReporteeArchive.IReporteeArchiveExternalEC");
            SetClientValues(repForm, "ReporteeArchive.IReporteeArchiveExternalEC");
            ShowMethod1(repForm);
        }

        private void btn_ReporteeArchiveStreamed_Click(object sender, EventArgs e)
        {
            ReporteeArchiveStreamedForm repStreamForm = new ReporteeArchiveStreamedForm();
            repStreamForm.Thumbprint = this.Thumbprint;
            repStreamForm.SelectedCertificate = this.SelectedCertificate;
            repStreamForm.EndPointConfigurationNameList = GetEndPoints("ReporteeArchiveStreamed.IReporteeArchiveExternalStreamedEC");
            SetClientValues(repStreamForm, "ReporteeArchiveStreamed.IReporteeArchiveExternalStreamedEC");
            ShowMethod1(repStreamForm);
        }

        private void btn_ServiceOwnerArchive_Click(object sender, EventArgs e)
        {
            ServiceOwnerArchiveForm soaForm = new ServiceOwnerArchiveForm();
            soaForm.Thumbprint = this.Thumbprint;
            soaForm.SelectedCertificate = this.SelectedCertificate;
            soaForm.EndPointConfigurationNameList = GetEndPoints("SOArchive.IServiceOwnerArchiveExternalEC");
            SetClientValues(soaForm, "SOArchive.IServiceOwnerArchiveExternalEC");
            ShowMethod1(soaForm);
        }

        private void btn_ServiceOwnerArchiveStreamed_Click(object sender, EventArgs e)
        {
            ServiceOwnerArchiveStreamedForm soaStreamForm = new ServiceOwnerArchiveStreamedForm();
            soaStreamForm.Thumbprint = this.Thumbprint;
            soaStreamForm.SelectedCertificate = this.SelectedCertificate;
            soaStreamForm.EndPointConfigurationNameList = GetEndPoints("SOArchiveStreamed.IServiceOwnerArchiveExternalStreamedEC");
            SetClientValues(soaStreamForm, "SOArchiveStreamed.IServiceOwnerArchiveExternalStreamedEC");
            ShowMethod1(soaStreamForm);
        }
    }
}
