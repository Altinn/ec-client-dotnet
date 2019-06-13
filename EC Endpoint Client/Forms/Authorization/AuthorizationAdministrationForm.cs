using System;
using System.ComponentModel;
using EC_Endpoint_Client.BaseForms;
using EC_Endpoint_Client.Classes.Shipments.Authorization;
using EC_Endpoint_Client.Functionality.EndPoints.Authorization;
using EC_Endpoint_Client.Service_References.Administration;

namespace EC_Endpoint_Client.Forms.Authorization
{
    public partial class AuthorizationAdministrationForm : AgencyBaseForm
    {
        public Guid TempKey { get; set; }
        public ExternalReporteeBE ExternalReportee { get; set; }
        public ExternalReporteeBEList ExternalReporteeList { get; set; }
        public ExternalReporteeBE[] ExternalReporteeArray => ExternalReporteeList.ToArray();
        public GetReporteesShipment GetReporteesShipment { get; set; }
        public GetReporteeByTempKeyShipment GetReporteeShipment { get; set; }
        private AuthorizationAdministrationEndPointFunctionality AaEpFunc { get; set; }
        public AuthorizationAdministrationForm()
        {
            InitializeComponent();
            GetReporteesShipment = new GetReporteesShipment();
            ExternalReporteeList = new ExternalReporteeBEList();
            GetReporteeShipment = new GetReporteeByTempKeyShipment();
            ExternalReportee = new ExternalReporteeBE();
            AaEpFunc = new AuthorizationAdministrationEndPointFunctionality();
            AaEpFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            SetUpObjectesForPropertyGrid();
            AssignActions();
        }

        private void SetUpObjectesForPropertyGrid()
        {
            TypeDescriptor.AddAttributes(typeof(ExternalReporteeBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(Guid), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        private void AssignActions()
        {
            AssignAction(testController, AaEpFunc.TestAuthorizationAdministration, BaseShipment, "Test Service");
            AssignAction(controllerGetReporteeByTempKey, AaEpFunc.GetReporteeByTempKeyEc, GetReporteeShipment, ExternalReportee, "GetReporteeByTempKey");
            AssignAction(controllerGetReportees, AaEpFunc.GetReporteesEc, GetReporteesShipment, ExternalReporteeList, "GetReportees Service");
        }
    }
}
