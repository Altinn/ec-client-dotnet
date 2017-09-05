using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC_Endpoint_Client.Forms
{
    public partial class ReporteeArchiveStreamedForm : ClientBaseForm
    {
        System.IO.Stream AttachmentStream { get; set; }
        private Functionality.ReporteeArchiveEndPointFunctionality repArchFunc { get; set; }
        private int _attachmentId;
        public int AttachmentId
        {
            get
            {
                return _attachmentId;
            }
            set
            {
                if (_attachmentId != value)
                {
                    _attachmentId = value;
                    tb_attachmentId.Text = value.ToString();
                }
            }
        }
        public ReporteeArchiveStreamedForm()
        {
            InitializeComponent();
            SetupDatabindings();
            repArchFunc = new Functionality.ReporteeArchiveEndPointFunctionality();
            repArchFunc.ReturnMessageXml += ReturnMessageXmlHandler;
        }

        private void SetupDatabindings()
        {
            tb_attachmentId.DataBindings.Add("Text", this, "AttachmentId");
        }

        public void GetStreamedAttachment()
        {
            AttachmentStream = repArchFunc.GetReporteeArchiveAttachmentDataECStreamed(SystemUsername, SystemPassword, AttachmentId, SelectedEndpointName, SelectedCertificate);
        }

        public void Test()
        {
            repArchFunc.TestReporteeArchiveExternalStreamed(SelectedEndpointName, SelectedCertificate);
        }

        private void btn_GetAttachmentData_Click(object sender, EventArgs e)
        {
            try
            {
                GetStreamedAttachment();
                Functionality.IOFunctionality.WriteStreamToFile(AttachmentStream);
                AttachmentStream.Close();
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during GetAttachmentData");
            }
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            try
            {
                Test();
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during Test");
            }
        }
    }
}
