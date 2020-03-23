using System;
using System.ComponentModel;
using System.ServiceModel.Security;
using EC_Endpoint_Client.BaseForms;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Functionality.EndPoints.Archive;
using EC_Endpoint_Client.ArchiveCommonAgency;
using EC_Endpoint_Client.UserControls;

namespace EC_Endpoint_Client.Forms.Archive
{
    public partial class ArchiveCommonAgencyForm : AgencyBaseForm
    {
        private ArchiveCommonAgencyEndPointFunctionality _archiveFunc;
        private ArchiveCommonAgencyShipment _acaShipment;
        private ServiceOwnerArchiveReporteeElementBEV2List _soaRebev2List;
        private ServiceOwnerArchiveReporteeElementBEV2[] SoaRebev2ListArray => _soaRebev2List.ToArray();

        public ArchiveCommonAgencyForm()
        {
            InitializeComponent();
            // ReSharper disable once VirtualMemberCallInConstructor
            SetUpObjectsForUse();
        }

        public virtual void SetUpObjectsForUse()
        {
            _acaShipment = new ArchiveCommonAgencyShipment()
            {
                SoaSearch = new ExternalSOASearchBE()
            };
            _soaRebev2List = new ServiceOwnerArchiveReporteeElementBEV2List();
            SetViewedItem(_acaShipment.SoaSearch, "ExternalSOASearchBE");
            _archiveFunc = new ArchiveCommonAgencyEndPointFunctionality();
            _archiveFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            SetUpObjectsForPropertyGrid();
            SetUpServices();
        }

        public virtual void SetUpObjectsForPropertyGrid()
        {
            TypeDescriptor.AddAttributes(typeof(ExternalSOASearchBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ServiceOwnerArchiveReporteeElementBEV2List), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ServiceOwnerArchiveReporteeElementBEV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        private void SetUpServices()
        {
            getServiceOwnerArchiveReporteeElements.AssignActions(
            () => { InvokeService(_archiveFunc.GetArchiveCommonAgencyReporteeElementsEc, _acaShipment, ref _soaRebev2List,
                    "GetArchiveReporteeElements");},
            () => { SetViewedItem(_acaShipment, "SOA Search BE"); }, 
            () => { InvokeSaveShipment(_acaShipment);}, 
            () => { _acaShipment = InvokeLoad<ArchiveCommonAgencyShipment>(); },
            () => { SetViewedItem(SoaRebev2ListArray, "Result"); },
            () => { InvokeSave(_soaRebev2List);} 
            );
            testController.AssignActions(() => { InvokeService(_archiveFunc.TestArchiveCommonAgency, new BaseShipment(), "Test"); });
        }
    }

    public class ArchiveCommonAgencyShipment : BaseShipment
    {
        public ExternalSOASearchBE SoaSearch { get; set; }
        public int LanguageId { get; set; }
    }
}
