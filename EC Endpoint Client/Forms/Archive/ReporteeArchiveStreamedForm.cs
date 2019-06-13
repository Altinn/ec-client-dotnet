using System;
using System.IO;
using EC_Endpoint_Client.Classes.ExtendedClasses.Archive;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Functionality.EndPoints.Archive;

namespace EC_Endpoint_Client.Forms.Archive
{
    public partial class ReporteeArchiveStreamedForm : BaseForms.ClientBaseForm
    {
        private ReporteeArchiveEndPointFunctionality RepArchFunc { get; set; }
        private AttachmentBaseShipment AttachmentShipment { get; set; }
        private StreamedAttachmentResult AttachmentResult { get; set; }
        public ReporteeArchiveStreamedForm()
        {
            InitializeComponent();
            RepArchFunc = new ReporteeArchiveEndPointFunctionality();
            RepArchFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            AssignAction(testController, RepArchFunc.TestReporteeArchiveExternalStreamed, BaseShipment, "Test Endpoint");
            AssignAction(getAttachmentDataStreamed, RepArchFunc.GetReporteeArchiveAttachmentDataEcStreamed, AttachmentShipment, AttachmentResult, "StreamedAttachment");
        }
    }

}
