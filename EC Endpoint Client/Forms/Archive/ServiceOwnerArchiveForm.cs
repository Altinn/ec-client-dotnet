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
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.SOArchive;

namespace EC_Endpoint_Client.Forms
{
    public partial class ServiceOwnerArchiveForm : AgencyBaseForm
    {
        private SOAShipment SOAShipment { get; set; }
        private Functionality.ServiceOwnerArchiveEndpointFunctionality soaFunc { get; set; }
        public ArchivedFormTaskV2 ArchivedFormTask { get; set; }
        public ServiceOwnerArchiveForm()
        {
            InitializeComponent();
            ShowShipment();
            SOAShipment = new Classes.SOAShipment();
            soaFunc = new Functionality.ServiceOwnerArchiveEndpointFunctionality();
            soaFunc.ReturnMessageXml += ReturnMessageXmlHandler;
        }

        private void ShowShipment()
        {
            SetViewedItem(SOAShipment, "Shipment for GetFormTask");
        }

        private void SetupObjectsForPropertyGrid()
        {
            TypeDescriptor.AddAttributes(typeof(ArchivedFormTaskV2), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        private void Test()
        {
            soaFunc.TestSOArchive(SelectedEndpointName, SelectedCertificate);
        }

        private void GetArchivedFormTask()
        {
            ArchivedFormTask = soaFunc.GetSOArchiveArchivedFormTaskV2(SystemUsername, SystemPassword, SOAShipment.ReporteeElementID, SOAShipment.LanguageID, SelectedEndpointName, SelectedCertificate);
        }

        private void btn_getArchivedFormTask_Click(object sender, EventArgs e)
        {
            try
            {
                GetArchivedFormTask();
                SetViewedItem(ArchivedFormTask, "Archived FormTask");
            }
            catch(Exception ex)
            {
                SetViewedItem(ex, "Error during GetArchivedFormTask");
            }
        }

        private void btn_ShowArchivedFormTask_Click(object sender, EventArgs e)
        {
            SetViewedItem(ArchivedFormTask, "Archived FormTask");
        }

        private void btn_SaveArchivedFormTask_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(ArchivedFormTask);
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            try
            {
                Test();
                SetViewedItem("OK", "Test was OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during Test");
            }
        }

        private void btn_ShowSOAShipment_Click(object sender, EventArgs e)
        {
            ShowShipment();
        }
    }
}
