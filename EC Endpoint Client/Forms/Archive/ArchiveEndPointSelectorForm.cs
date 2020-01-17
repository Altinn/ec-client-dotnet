using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using EC_Endpoint_Client.Functionality.EndPoints;
using EC_Endpoint_Client.Functionality.EndPoints.Archive;

namespace EC_Endpoint_Client.Forms.Archive
{
    public partial class ArchiveEndPointSelectorForm : BaseForms.SelectorBaseForm
    {
        public ArchiveEndPointSelectorForm(string thumb, X509Certificate2 cert, bool useEC2Interface) : base(thumb, cert, useEC2Interface)
        {
            InitializeComponent();
        }

        private void btn_ArchiveCommonAgency_Click(object sender, EventArgs e)
        {
            if (UseEC2Interface)
            {
                Archive.ArchiveCommonAgencyFormEC2 acaForm = new ArchiveCommonAgencyFormEC2();
                acaForm.Text = "ArchiveCommonAgency (EC2)";
                SetClientValues(acaForm, "ArchiveCommonAgencyEC2.IArchiveCommonAgencyExternalEC2");
                acaForm.SelectedCertificate = SelectedCertificate;
                acaForm.Thumbprint = Thumbprint;
                acaForm.EndPointConfigurationNameList = GetEndPoints();
                ShowMethod1(acaForm);
            }
            else
            {
                Archive.ArchiveCommonAgencyForm acaForm = new ArchiveCommonAgencyForm();
                acaForm.Text = "ArchiveCommonAgency (EC)";
                SetClientValues(acaForm, "ArchiveCommonAgency.IArchiveCommonAgencyExternalEC");
                acaForm.SelectedCertificate = SelectedCertificate;
                acaForm.Thumbprint = Thumbprint;
                acaForm.EndPointConfigurationNameList = GetEndPoints();
                ShowMethod1(acaForm);
            }
        }

        private void btn_DownloadQueue_Click(object sender, EventArgs e)
        {
            if (UseEC2Interface)
            {
                DownloadQueueFormEC2 dqForm = new DownloadQueueFormEC2();
                dqForm.Text = "DownloadQueueForm (EC2)";
                dqForm.Thumbprint = Thumbprint;
                dqForm.SelectedCertificate = SelectedCertificate;
                dqForm.EndPointConfigurationNameList = GetEndPoints();
                SetClientValues(dqForm, "DownloadQueueEC2.IDownloadQueueExternalEC2");
                ShowMethod1(dqForm);
            }
            else
            {
                DownloadQueueForm dqForm = new DownloadQueueForm();
                dqForm.Text = "DownloadQueueForm (EC)";
                dqForm.Thumbprint = Thumbprint;
                dqForm.SelectedCertificate = SelectedCertificate;
                dqForm.EndPointConfigurationNameList = GetEndPoints();
                SetClientValues(dqForm, "DownloadQueue.IDownloadQueueExternalEC");
                ShowMethod1(dqForm);
            }
        }

        private void btn_KeyManangement_Click(object sender, EventArgs e)
        {
            if (UseEC2Interface)
            {
                KeyManagementFormEC2 keyForm = new KeyManagementFormEC2();
                keyForm.Text = "KeyManagementForm (EC2)";
                keyForm.Thumbprint = Thumbprint;
                keyForm.SelectedCertificate = SelectedCertificate;
                keyForm.EndPointConfigurationNameList = GetEndPoints();
                SetClientValues(keyForm, "KeyManagementEC2.IKeyManagementExternalEC2");
                ShowMethod1(keyForm);
            }
            else
            {
                KeyManagementForm keyForm = new KeyManagementForm();
                keyForm.Text = "KeyManagementForm (EC)";
                keyForm.Thumbprint = Thumbprint;
                keyForm.SelectedCertificate = SelectedCertificate;
                keyForm.EndPointConfigurationNameList = GetEndPoints();
                SetClientValues(keyForm, "KeyManagement.IKeyManagementExternalEC");
                ShowMethod1(keyForm);
            }
        }

        private void btn_ReporteeArchive_Click(object sender, EventArgs e)
        {
            if (UseEC2Interface)
            {
                ReporteeArchiveFormEC2 repForm = new ReporteeArchiveFormEC2();
                repForm.Text = "ReporteeArchiveForm (EC2)";
                repForm.Thumbprint = Thumbprint;
                repForm.SelectedCertificate = SelectedCertificate;
                repForm.EndPointConfigurationNameList = GetEndPoints();
                SetClientValues(repForm, "ReporteeArchiveEC2.IReporteeArchiveExternalEC2");
                ShowMethod1(repForm);
            }
            else
            {
                ReporteeArchiveForm repForm = new ReporteeArchiveForm();
                repForm.Text = "ReporteeArchiveForm (EC)";
                repForm.Thumbprint = Thumbprint;
                repForm.SelectedCertificate = SelectedCertificate;
                repForm.EndPointConfigurationNameList = GetEndPoints();
                SetClientValues(repForm, "ReporteeArchive.IReporteeArchiveExternalEC");
                ShowMethod1(repForm);
            }
            
        }

        private void btn_ReporteeArchiveStreamed_Click(object sender, EventArgs e)
        {
            if (UseEC2Interface)
            {
                ReporteeArchiveStreamedFormEC2 repStreamForm = new ReporteeArchiveStreamedFormEC2();
                repStreamForm.Text = "ReporteeArchiveStreamedForm (EC2)";
                repStreamForm.Thumbprint = Thumbprint;
                repStreamForm.SelectedCertificate = SelectedCertificate;
                repStreamForm.EndPointConfigurationNameList = GetEndPoints();
                SetClientValues(repStreamForm, "ReporteeArchiveStreamedEC2.IReporteeArchiveExternalStreamedEC2");
                ShowMethod1(repStreamForm);
            }
            else
            {
                ReporteeArchiveStreamedForm repStreamForm = new ReporteeArchiveStreamedForm();
                repStreamForm.Text = "ReporteeArchiveStreamedForm (EC)";
                repStreamForm.Thumbprint = Thumbprint;
                repStreamForm.SelectedCertificate = SelectedCertificate;
                repStreamForm.EndPointConfigurationNameList = GetEndPoints();
                SetClientValues(repStreamForm, "ReporteeArchiveStreamed.IReporteeArchiveExternalStreamedEC");
                ShowMethod1(repStreamForm);
            }
        }

        private void btn_ServiceOwnerArchive_Click(object sender, EventArgs e)
        {
            if (UseEC2Interface)
            {
                ServiceOwnerArchiveFormEC2 soaForm = new ServiceOwnerArchiveFormEC2();
                soaForm.Text = "ServiceOwnerArchiveForm (EC2)";
                soaForm.Thumbprint = Thumbprint;
                soaForm.SelectedCertificate = SelectedCertificate;
                soaForm.EndPointConfigurationNameList = GetEndPoints();
                SetClientValues(soaForm, "SOArchiveEC2.IServiceOwnerArchiveExternalEC2");
                ShowMethod1(soaForm);
            }
            else
            {
                ServiceOwnerArchiveForm soaForm = new ServiceOwnerArchiveForm();
                soaForm.Text = "ServiceOwnerArchiveForm (EC)";
                soaForm.Thumbprint = Thumbprint;
                soaForm.SelectedCertificate = SelectedCertificate;
                soaForm.EndPointConfigurationNameList = GetEndPoints();
                SetClientValues(soaForm, "SOArchive.IServiceOwnerArchiveExternalEC");
                ShowMethod1(soaForm);
            }
            
        }

        private void btn_ServiceOwnerArchiveStreamed_Click(object sender, EventArgs e)
        {
            if (UseEC2Interface)
            {
                ServiceOwnerArchiveStreamedFormEC2 soaStreamForm = new ServiceOwnerArchiveStreamedFormEC2();
                soaStreamForm.Text = "ServiceOwnerArchiveStreamedForm (EC2)";
                soaStreamForm.Thumbprint = Thumbprint;
                soaStreamForm.SelectedCertificate = SelectedCertificate;
                soaStreamForm.EndPointConfigurationNameList = GetEndPoints();
                SetClientValues(soaStreamForm, "SOArchiveStreamed.IServiceOwnerArchiveExternalStreamedEC2");
                ShowMethod1(soaStreamForm);
            }
            else
            {
                ServiceOwnerArchiveStreamedForm soaStreamForm = new ServiceOwnerArchiveStreamedForm();
                soaStreamForm.Text = "ServiceOwnerArchiveStreamedForm (EC)";
                soaStreamForm.Thumbprint = Thumbprint;
                soaStreamForm.SelectedCertificate = SelectedCertificate;
                soaStreamForm.EndPointConfigurationNameList = GetEndPoints();
                SetClientValues(soaStreamForm, "SOArchiveStreamed.IServiceOwnerArchiveExternalStreamedEC");
                ShowMethod1(soaStreamForm);
            }
        }
    }
}
