using System;
using System.ComponentModel;
using EC_Endpoint_Client.BaseForms;
using EC_Endpoint_Client.Classes.ExtendedClasses.Archive;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.Archive;
using EC_Endpoint_Client.Functionality.EndPoints.Archive;
using EC_Endpoint_Client.SOArchiveEC2;

namespace EC_Endpoint_Client.Forms.Archive
{
    public partial class ServiceOwnerArchiveFormEC2 : AgencyBaseForm
    {
        private SoaShipment SoaShipment { get; set; }
        private ServiceOwnerArchiveEndpointFunctionalityEC2 SoaFunc { get; set; }
        public ArchivedFormTaskV2 ArchivedFormTask { get; set; }
        private BaseShipment BaseShipment { get; set; }
        private ArchiveBaseShipment ArchiveShipment { get; set; }
        public ServiceOwnerArchiveFormEC2()
        {
            InitializeComponent();
            SoaShipment = new SoaShipment();
            SetupObjectsForPropertyGrid();
            SoaFunc = new ServiceOwnerArchiveEndpointFunctionalityEC2();
            SoaFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            AssignActions();
        }

        private void SetupObjectsForPropertyGrid()
        {
            TypeDescriptor.AddAttributes(typeof(ArchivedFormTaskV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        private void AssignActions()
        {
            AssignAction(getArchivedFormTaskController, SoaFunc.GetSoArchiveArchivedFormTaskV2, ArchiveShipment, ArchivedFormTask, "GetArchivedFormTask");
            AssignAction(testController, SoaFunc.TestSoArchive, BaseShipment, "Test Service");
        }
    }
}
