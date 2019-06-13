using System;
using System.Security.Cryptography.X509Certificates;

namespace EC_Endpoint_Client.Forms.Archive
{
    public partial class ArchiveEndPointSelectorForm : BaseForms.SelectorBaseForm
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
            Archive.ArchiveCommonAgencyForm acaForm = new Archive.ArchiveCommonAgencyForm();
            SetClientValues(acaForm, "ArchiveCommonAgency.IArchiveCommonAgencyExternalEC");
            acaForm.SelectedCertificate = SelectedCertificate;
            acaForm.Thumbprint = Thumbprint;
            acaForm.EndPointConfigurationNameList = GetEndPoints("ArchiveCommonAgency.IArchiveCommonAgencyExternalEC");
            ShowMethod1(acaForm);
        }

        private void btn_DownloadQueue_Click(object sender, EventArgs e)
        {
            DownloadQueueForm dqForm = new DownloadQueueForm();
            dqForm.Thumbprint = Thumbprint;
            dqForm.SelectedCertificate = SelectedCertificate;
            dqForm.EndPointConfigurationNameList = GetEndPoints("DownloadQueue.IDownloadQueueExternalEC");
            SetClientValues(dqForm, "DownloadQueue.IDownloadQueueExternalEC");
            ShowMethod1(dqForm);
        }

        private void btn_KeyManangement_Click(object sender, EventArgs e)
        {
            KeyManagementForm keyForm = new KeyManagementForm();
            keyForm.Thumbprint = Thumbprint;
            keyForm.SelectedCertificate = SelectedCertificate;
            keyForm.EndPointConfigurationNameList = GetEndPoints("KeyManagement.IKeyManagementExternalEC");
            SetClientValues(keyForm, "KeyManagement.IKeyManagementExternalEC");
            ShowMethod1(keyForm);
        }

        private void btn_ReporteeArchive_Click(object sender, EventArgs e)
        {
            ReporteeArchiveForm repForm = new ReporteeArchiveForm();
            repForm.Thumbprint = Thumbprint;
            repForm.SelectedCertificate = SelectedCertificate;
            repForm.EndPointConfigurationNameList = GetEndPoints("ReporteeArchive.IReporteeArchiveExternalEC");
            SetClientValues(repForm, "ReporteeArchive.IReporteeArchiveExternalEC");
            ShowMethod1(repForm);
        }

        private void btn_ReporteeArchiveStreamed_Click(object sender, EventArgs e)
        {
            ReporteeArchiveStreamedForm repStreamForm = new ReporteeArchiveStreamedForm();
            repStreamForm.Thumbprint = Thumbprint;
            repStreamForm.SelectedCertificate = SelectedCertificate;
            repStreamForm.EndPointConfigurationNameList = GetEndPoints("ReporteeArchiveStreamed.IReporteeArchiveExternalStreamedEC");
            SetClientValues(repStreamForm, "ReporteeArchiveStreamed.IReporteeArchiveExternalStreamedEC");
            ShowMethod1(repStreamForm);
        }

        private void btn_ServiceOwnerArchive_Click(object sender, EventArgs e)
        {
            ServiceOwnerArchiveForm soaForm = new ServiceOwnerArchiveForm();
            soaForm.Thumbprint = Thumbprint;
            soaForm.SelectedCertificate = SelectedCertificate;
            soaForm.EndPointConfigurationNameList = GetEndPoints("SOArchive.IServiceOwnerArchiveExternalEC");
            SetClientValues(soaForm, "SOArchive.IServiceOwnerArchiveExternalEC");
            ShowMethod1(soaForm);
        }

        private void btn_ServiceOwnerArchiveStreamed_Click(object sender, EventArgs e)
        {
            ServiceOwnerArchiveStreamedForm soaStreamForm = new ServiceOwnerArchiveStreamedForm();
            soaStreamForm.Thumbprint = Thumbprint;
            soaStreamForm.SelectedCertificate = SelectedCertificate;
            soaStreamForm.EndPointConfigurationNameList = GetEndPoints("SOArchiveStreamed.IServiceOwnerArchiveExternalStreamedEC");
            SetClientValues(soaStreamForm, "SOArchiveStreamed.IServiceOwnerArchiveExternalStreamedEC");
            ShowMethod1(soaStreamForm);
        }
    }
}
