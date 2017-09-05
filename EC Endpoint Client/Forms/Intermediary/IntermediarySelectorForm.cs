using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC_Endpoint_Client.Forms.Intermediary
{
    public partial class IntermediarySelectorForm : SelectorBaseForm
    {
        public IntermediarySelectorForm()
        {
            InitializeComponent();
        }

        private void btn_intermediary_Click(object sender, EventArgs e)
        {
            IntermediaryInboundForm iiF = new IntermediaryInboundForm();
            SetClientValues(iiF, "IntermediaryInbound.IIntermediaryInboundExternalEC");
            ShowMethod1(iiF);
        }

        private void btn_intermediarystreamed_Click(object sender, EventArgs e)
        {
            IntermediaryInboundStreamedForm iisF = new IntermediaryInboundStreamedForm();
            iisF.SelectedCertificate = SelectedCertificate;
            iisF.EndPointConfigurationNameList = GetEndPoints("IntermediaryInboundStreamed.IIntermediaryInboundExternalECStreamed");
            iisF.SelectedEndpointName = SelectedEndPointName;
            SetClientValues(iisF, "IntermediaryInboundStreamed.IIntermediaryInboundExternalECStreamed");
            ShowMethod1(iisF);
        }

        private void btn_receiptAgency_Click(object sender, EventArgs e)
        {
            ReceiptAgencyForm raF = new ReceiptAgencyForm();
            raF.SelectedCertificate = SelectedCertificate;
            raF.EndPointConfigurationNameList = GetEndPoints("ReceiptAgency.IReceiptAgencyExternalEC");
            raF.SelectedEndpointName = SelectedEndPointName;
            SetClientValues(raF, "ReceiptAgency.IReceiptAgencyExternalEC");
            ShowMethod1(raF);
        }

        private void btn_receipt_Click(object sender, EventArgs e)
        {
            ReceiptForm raF = new ReceiptForm();
            raF.SelectedCertificate = SelectedCertificate;
            raF.EndPointConfigurationNameList = GetEndPoints("Receipt.IReceiptExternalEC");
            raF.SelectedEndpointName = SelectedEndPointName;
            SetClientValues(raF, "Receipt.IReceiptExternalEC");
            ShowMethod1(raF);
        }

        private void btn_batchlogging_Click(object sender, EventArgs e)
        {
            BatchLoggingForm blf = new BatchLoggingForm();
            blf.SelectedCertificate = SelectedCertificate;
            blf.EndPointConfigurationNameList = GetEndPoints("BatchLoggingAgency.IBatchLoggingAgencyExternalEC");
            blf.SelectedEndpointName = SelectedEndPointName;
            SetClientValues(blf, "BatchLoggingAgency.IBatchLoggingAgencyExternalEC");
            ShowMethod1(blf);
        }
    }
}
