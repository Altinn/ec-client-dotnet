using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EC_Endpoint_Client.BaseForms;

namespace EC_Endpoint_Client.Forms
{
    public partial class ServiceOwnerArchiveStreamedForm : AgencyBaseForm
    {
        private int _attachmentId;
        public int AttachmentId { get { return _attachmentId; }
            set
            {
                if (_attachmentId != value)
                {
                    _attachmentId = value;
                    tb_attachmentId.Text = value.ToString();
                }
            }
        }
        public System.IO.Stream AttachmentStream { get; set; }
        private Functionality.ServiceOwnerArchiveEndpointFunctionality soaFunc { get; set; }
        public ServiceOwnerArchiveStreamedForm()
        {
            InitializeComponent();
            SetupDataBinding();
            soaFunc = new Functionality.ServiceOwnerArchiveEndpointFunctionality();
            soaFunc.ReturnMessageXml += ReturnMessageXmlHandler;
        }

        private void SetupDataBinding()
        {
            tb_attachmentId.DataBindings.Add("Text", this, "AttachmentId");
        }

        private void Test()
        {
            soaFunc.TestSOArchiveStreamed(SelectedEndpointName, SelectedCertificate);
        }

        private void GetAttachmentData()
        {
            AttachmentStream = soaFunc.GetSOArchiveAttachmentDataStreamed(SystemUsername, SystemPassword, AttachmentId, SelectedEndpointName, SelectedCertificate);
            Functionality.IOFunctionality.WriteStreamToFile(AttachmentStream);
            AttachmentStream.Close();
        }

        private void btn_getAttachment_Click(object sender, EventArgs e)
        {
            try
            {
                GetAttachmentData();
                SetViewedItem("OK", "Result from GetAttachmentData");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during GetAttachment");
            }
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            try
            {
                Test();
                SetViewedItem("OK", "Result from Test");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during Test");
            }
        }


    }
}
