using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.ServiceModel.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using EC_Endpoint_Client.ArchiveCommonAgency;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Xml;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.BaseForms;

namespace EC_Endpoint_Client.Forms
{
    public partial class ArchiveCommonAgencyForm : AgencyBaseForm
    {
        private Functionality.ArchiveCommonAgencyEndPointFunctionality archiveFunc; 
        private ExternalSOASearchBE soaSearchBE;
        private ServiceOwnerArchiveReporteeElementBEV2List soaREBEV2List;
        private ServiceOwnerArchiveReporteeElementBEV2[] soaREBEV2ListArray
        {
            get
            {
                return soaREBEV2List.ToArray();
            }
            set
            {
                soaREBEV2List = new ServiceOwnerArchiveReporteeElementBEV2List();
                foreach (ServiceOwnerArchiveReporteeElementBEV2 element in value)
                {
                    soaREBEV2List.Add(element);
                }
                
            }
        }
        public ArchiveCommonAgencyForm()
        {
            InitializeComponent();
            SetUpObjectsForUse();
        }

        public virtual void SetUpObjectsForUse()
        {
            soaSearchBE = new ExternalSOASearchBE();
            soaREBEV2List = new ServiceOwnerArchiveReporteeElementBEV2List();
            SetViewedItem(soaSearchBE, "ExternalSOASearchBE");
            archiveFunc = new Functionality.ArchiveCommonAgencyEndPointFunctionality();
            archiveFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            SetUpObjectsForPropertyGrid();
        }

        public virtual void SetUpObjectsForPropertyGrid()
        {
            TypeDescriptor.AddAttributes(typeof(ExternalSOASearchBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ServiceOwnerArchiveReporteeElementBEV2List), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ServiceOwnerArchiveReporteeElementBEV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        void Test()
        {
            try
            {
                archiveFunc.TestArchiveCommonAgency(SelectedEndpointName, SelectedCertificate);
            }
            catch(Exception ex)
            {
                SetViewedItem(ex, "Test Error");
            }
        }

        private void GetArchiveCommonAgencyReporteeElementsEC()
        {
            try
            {
                soaREBEV2List = archiveFunc.GetArchiveCommonAgencyReporteeElementsEC(SystemUsername, SystemPassword, soaSearchBE, LanguageID, SelectedEndpointName, SelectedCertificate);
                SetViewedItem(soaREBEV2ListArray, "SOA ReporteeElement BE V2 List"); 
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from GetArchiveCommonAgencyReporteeElementsEC");
            }
        }

        private void btn_GetServiceOwnerArchiveReporteeElementsEC_Click(object sender, EventArgs e)
        {
            GetArchiveCommonAgencyReporteeElementsEC();
        }

        private void btn_showShipment_Click(object sender, EventArgs e)
        {
            SetViewedItem(soaSearchBE, "SOA Search BE");
        }

        private void btn_showReturnedList_Click(object sender, EventArgs e)
        {
            SetViewedItem( soaREBEV2ListArray ,"SOA ReporteeElement BE V2 List");
        }

        public override void GenerateMenu()
        {
            base.GenerateMenu();
        }

        private void btn_SaveShip_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(soaSearchBE);
        }

        private void btn_loadShip_Click(object sender, EventArgs e)
        {
            soaSearchBE = (ExternalSOASearchBE)Functionality.IOFunctionality.GeneralizedLoadFile(soaSearchBE);
        }

        private void btn_SaveResult_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(soaREBEV2List);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(ReplySoap.XmlDocument);
            Functionality.IOFunctionality.GeneralizedSaveFile(RequestSoap.XmlDocument);
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            Test();
        }
    }
}
