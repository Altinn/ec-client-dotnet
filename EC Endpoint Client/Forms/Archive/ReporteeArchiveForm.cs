using System;
using System.ComponentModel;
using EC_Endpoint_Client.Classes.ExtendedClasses.Archive;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.Archive;
using EC_Endpoint_Client.Functionality.EndPoints.Archive;
using EC_Endpoint_Client.ReporteeArchive;

namespace EC_Endpoint_Client.Forms.Archive
{
    public partial class ReporteeArchiveForm : BaseForms.ClientBaseForm
    {
        #region variables
        public ArchivedFormTaskV2 ArchivedFormTask { get; set; }
        public AttachmentBEV2 Attachment { get; set; }
        public ArchivedLookupExternal ArchivedLookup { get; set; }
        public ArchivedCorrespondence ArchivedCorrespondence { get; set; }
        private ReporteeArchiveEndPointFunctionality RepArchFunc { get; set; }
        public ReporteeArchiveShipment GetFtShipment { get; set; }
        public ReporteeArchiveLookupShipment GetLuShipment { get; set; }
        private AttachmentBaseShipment AttachmentShipment { get; set; }
        private ArchiveBaseShipment ArchiveBaseShipment { get; set; }
        private ReporteeArchiveCorrespondenceShipment ReporteeArchiveCorrespondenceShipment { get; set; }
        private BaseShipment BaseShipment { get; set; }
        #endregion
        public ReporteeArchiveForm()
        {
            InitializeComponent();
            SetupObjectsForPropertyGrid();
            ArchivedFormTask = new ArchivedFormTaskV2();
            Attachment = new AttachmentBEV2();
            ArchivedLookup = new ArchivedLookupExternal();
            RepArchFunc = new ReporteeArchiveEndPointFunctionality();
            RepArchFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            GetFtShipment = new ReporteeArchiveShipment();
            GetLuShipment = new ReporteeArchiveLookupShipment();
            AttachmentShipment = new AttachmentBaseShipment();
            ArchiveBaseShipment = new ArchiveBaseShipment();
            BaseShipment = new BaseShipment();
            ReporteeArchiveCorrespondenceShipment = new ReporteeArchiveCorrespondenceShipment();
            ArchivedCorrespondence = new ArchivedCorrespondence();
            AssignActions();
        }

        private void AssignActions()
        {
            AssignAction(getArchFTctrl, RepArchFunc.GetReporteeArchiveArchivedFormTaskV2, ArchiveBaseShipment, ArchivedFormTask, "GetArchivedFormTask");
            AssignAction(getArchivedLookupController, RepArchFunc.GetReporteeArchiveLookUp, ArchiveBaseShipment, ArchivedLookup, "GetArchiveLookup");
            AssignAction(getAttachmentDataController, RepArchFunc.GetReporteeArchiveAttachment, AttachmentShipment, Attachment, "GetAttachment");
            AssignAction(getArchivedCorrespondenceController, RepArchFunc.GetReporteeArchiveCorrespondence, ReporteeArchiveCorrespondenceShipment, ArchivedCorrespondence, "GetArchivedCorrespondence");
            AssignAction(testController, RepArchFunc.TestReporteeArchive, BaseShipment, "Test");
        }

        public void SetupObjectsForPropertyGrid()
        {
            TypeDescriptor.AddAttributes(typeof(ArchivedFormTaskV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ArchivedFormBEList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ArchivedFormBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ArchivedAttachmentBEV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ArchivedAttachmentBEV2List), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ArchivedFormTaskSigningStepBEV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ArchivedFormTaskSigningStepBEV2List), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ArchivedLookupExternal), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ArchivedAttachmentBEV2List), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ArchivedAttachmentBEV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ArchivedCorrespondence), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }
    }
}
