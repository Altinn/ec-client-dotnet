using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EC_Endpoint_Client.Administration;
using EC_Endpoint_Client.BaseForms;

namespace EC_Endpoint_Client.Forms.Authorization
{
    public partial class AuthorizationAdministrationForm : AgencyBaseForm
    {
        public Guid TempKey { get; set; }
        public ExternalReporteeBE ExternalReportee { get; set; }
        public ExternalReporteeBEList ExternalReporteeList { get; set; }
        public ExternalReporteeBE[] ExternalReporteeArray { get { return ExternalReporteeList.ToArray(); } }
        public GetReporteesShipment GetReporteesShipment { get; set; }
        public GetReporteeByTempKeyShipment GetReporteeShipment { get; set; }
        private Functionality.AuthorizationAdministrationEndPointFunctionality aaEPFunc { get; set; }
        public AuthorizationAdministrationForm()
        {
            InitializeComponent();
            GetReporteesShipment = new GetReporteesShipment();
            ExternalReporteeList = new ExternalReporteeBEList();
            GetReporteeShipment = new GetReporteeByTempKeyShipment();
            ExternalReportee = new ExternalReporteeBE();
            aaEPFunc = new Functionality.AuthorizationAdministrationEndPointFunctionality();
            aaEPFunc.ReturnMessageXml += ReturnMessageXmlHandler;
        }

        private void SetUpObjectesForPropertyGrid()
        {
            TypeDescriptor.AddAttributes(typeof(ExternalReporteeBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(Guid), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        private void Test()
        {
            aaEPFunc.TestAuthorizationAdministration(SelectedEndpointName, SelectedCertificate);
        }

        private void GetReporteeByTempKey()
        {
            ExternalReportee = aaEPFunc.GetReporteeByTempKeyEC(SystemUsername, SystemPassword, GetReporteeShipment.TempKey, SelectedEndpointName, SelectedCertificate);
        }

        private void GetReportees()
        {
            GetReporteesShipment.Certificate = SelectedCertificate;
            GetReporteesShipment.EndpointName = SelectedEndpointName;
            GetReporteesShipment.Password = SystemPassword;
            GetReporteesShipment.Username = SystemUsername;
            ExternalReporteeList = aaEPFunc.GetReporteesEC(GetReporteesShipment);
        }

        private void btn_ShowShipment_Click(object sender, EventArgs e)
        {
            SetViewedItem(GetReporteesShipment, "Shipment to send to GetReportees");
        }

        private void btn_showReporteeArray_Click(object sender, EventArgs e)
        {
            SetViewedItem(ExternalReporteeArray, "List of ExternalReportees from GetReportees.");
        }

        private void btn_getReporteeList_Click(object sender, EventArgs e)
        {
            try
            {
                GetReportees();
                SetViewedItem(ExternalReporteeArray, "List of ExternalReportees from GetReportees.");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during GetReportees");
            }
        }

        private void btn_SaveReporteeList_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(ExternalReporteeList);
        }

        private void btn_showTempKey_Click(object sender, EventArgs e)
        {
            SetViewedItem(GetReporteeShipment, "Tempkey shipment to Get Reportee");
        }

        private void btn_GetReportee_Click(object sender, EventArgs e)
        {
            try
            {
                GetReporteeByTempKey();
                SetViewedItem(ExternalReportee, "ExternalReportee");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from GetReportee");
            }
        }

        private void btn_ShowReportee_Click(object sender, EventArgs e)
        {
            SetViewedItem(ExternalReportee, "ExternalReportee");
        }

        private void btn_SaveReportee_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(ExternalReportee);
        }


    }
}
