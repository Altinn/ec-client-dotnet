using System;
using EC_Endpoint_Client.BaseForms;
using EC_Endpoint_Client.Classes.ExtendedClasses.Archive;
using EC_Endpoint_Client.Functionality.EndPoints.Archive;

namespace EC_Endpoint_Client.Forms.Archive
{
    public partial class ServiceOwnerArchiveStreamedForm : AgencyBaseForm
    {
        private ServiceOwnerArchiveEndpointFunctionality SoaFunc { get; set; }
        private AttachmentBaseShipment AttachmentShipment { get; set; }
        private StreamedAttachmentResult Result { get; set; }
        public ServiceOwnerArchiveStreamedForm()
        {
            InitializeComponent();
            SoaFunc = new ServiceOwnerArchiveEndpointFunctionality();
            SoaFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            AssignAction(getAttachmentDataStreamedController, SoaFunc.GetSoArchiveAttachmentDataStreamed, AttachmentShipment, Result, "Get AttachmentData Streamed");
            AssignAction(testController, SoaFunc.TestSoArchiveStreamed, BaseShipment, "Test Service");
        }
    }
}
