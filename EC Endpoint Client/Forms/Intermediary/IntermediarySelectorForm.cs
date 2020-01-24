using System;
using System.Security.Cryptography.X509Certificates;

namespace EC_Endpoint_Client.Forms.Intermediary
{
    public partial class IntermediarySelectorForm : BaseForms.SelectorBaseForm
    {
        public IntermediarySelectorForm(string thumb, X509Certificate2 cert, bool useEC2Interface) : base(thumb, cert, useEC2Interface)
        {
            InitializeComponent();
        }

        private void btn_IntermediaryInbound_Click(object sender, EventArgs e)
        {
            if (UseEC2Interface)
            {
                IntermediaryInboundFormEC2 iiF = new IntermediaryInboundFormEC2();
                iiF.Text = "IntermediaryInboundForm (EC2)";
                SetClientValues(iiF, "IntermediaryInboundEC2.IIntermediaryInboundExternalEC2");
                ShowMethod1(iiF);
            }
            else
            {
                IntermediaryInboundForm iiF = new IntermediaryInboundForm();
                iiF.Text = "IntermediaryInboundForm (EC)";
                SetClientValues(iiF, "IntermediaryInbound.IIntermediaryInboundExternalEC");
                ShowMethod1(iiF);
            }
        }

        private void btn_IntermediaryInboundStreamed_Click(object sender, EventArgs e)
        {
            if (UseEC2Interface)
            {
                IntermediaryInboundStreamedFormEC2 iisF = new IntermediaryInboundStreamedFormEC2();
                iisF.Text = "IntermediaryInboundStreamedForm (EC2)";
                iisF.SelectedCertificate = SelectedCertificate;
                iisF.EndPointConfigurationNameList = GetEndPoints();
                iisF.SelectedEndpointName = SelectedEndPointName;
                SetClientValues(iisF, "IntermediaryInboundEC2Streamed.IIntermediaryInboundExternalEC2Streamed");
                ShowMethod1(iisF);
            }
            else
            {
                IntermediaryInboundStreamedForm iisF = new IntermediaryInboundStreamedForm();
                iisF.Text = "BatchLoggingForm (EC)";
                iisF.SelectedCertificate = SelectedCertificate;
                iisF.EndPointConfigurationNameList = GetEndPoints();
                iisF.SelectedEndpointName = SelectedEndPointName;
                SetClientValues(iisF, "IntermediaryInboundStreamed.IIntermediaryInboundExternalECStreamed");
                ShowMethod1(iisF);
            }
        }

        private void btn_ReceiptAgency_Click(object sender, EventArgs e)
        {
            if (UseEC2Interface)
            {
                ReceiptAgencyFormEC2 raF = new ReceiptAgencyFormEC2();
                raF.Text = "ReceiptAgencyForm (EC2)";
                raF.SelectedCertificate = SelectedCertificate;
                raF.EndPointConfigurationNameList = GetEndPoints();
                raF.SelectedEndpointName = SelectedEndPointName;
                SetClientValues(raF, "ReceiptAgencyEC2.IReceiptAgencyExternalEC2");
                ShowMethod1(raF);
            }
            else
            {
                ReceiptAgencyForm raF = new ReceiptAgencyForm();
                raF.Text = "ReceiptAgencyForm (EC)";
                raF.SelectedCertificate = SelectedCertificate;
                raF.EndPointConfigurationNameList = GetEndPoints();
                raF.SelectedEndpointName = SelectedEndPointName;
                SetClientValues(raF, "ReceiptAgency.IReceiptAgencyExternalEC");
                ShowMethod1(raF);
            }
        }

        private void btn_Receipt_Click(object sender, EventArgs e)
        {
            if (UseEC2Interface)
            {
                ReceiptFormEC2 raF = new ReceiptFormEC2();
                raF.Text = "ReceiptForm (EC2)";
                raF.SelectedCertificate = SelectedCertificate;
                raF.EndPointConfigurationNameList = GetEndPoints();
                raF.SelectedEndpointName = SelectedEndPointName;
                SetClientValues(raF, "ReceiptEC2.IReceiptExternalEC2");
                ShowMethod1(raF);
            }
            else
            {
                ReceiptForm raF = new ReceiptForm();
                raF.Text = "ReceiptForm (EC)";
                raF.SelectedCertificate = SelectedCertificate;
                raF.EndPointConfigurationNameList = GetEndPoints();
                raF.SelectedEndpointName = SelectedEndPointName;
                SetClientValues(raF, "Receipt.IReceiptExternalEC");
                ShowMethod1(raF);
            }
        }

        private void btn_BatchLoggingAgency_Click(object sender, EventArgs e)
        {
            if(UseEC2Interface)
            {
                BatchLoggingFormEC2 blf = new BatchLoggingFormEC2();
                blf.Text = "BatchLoggingForm (EC2)";
                blf.SelectedCertificate = SelectedCertificate;
                blf.EndPointConfigurationNameList = GetEndPoints();
                blf.SelectedEndpointName = SelectedEndPointName;
                SetClientValues(blf, "BatchLoggingAgencyEC2.IBatchLoggingAgencyExternalEC2");
                ShowMethod1(blf);
            }
            else
            {
                BatchLoggingForm blf = new BatchLoggingForm();
                blf.Text = "BatchLoggingForm (EC)";
                blf.SelectedCertificate = SelectedCertificate;
                blf.EndPointConfigurationNameList = GetEndPoints();
                blf.SelectedEndpointName = SelectedEndPointName;
                SetClientValues(blf, "BatchLoggingAgency.IBatchLoggingAgencyExternalEC");
                ShowMethod1(blf);
            }
            
        }
    }
}
