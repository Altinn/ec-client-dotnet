using System;
using System.ComponentModel;
using EC_Endpoint_Client.Classes.Shipments.Archive;
using EC_Endpoint_Client.Functionality.EndPoints.Archive;
using EC_Endpoint_Client.Service_References.KeyManagement;

namespace EC_Endpoint_Client.Forms.Archive
{
    public partial class KeyManagementForm : BaseForms.ClientBaseForm
    {
        public CertificateBEList CertificateList { get; set; }
        public KeyManagementShipmentClass Shipment { get; set; }
        private CertificateBE[] CertificateArray => CertificateList.ToArray();

        private KeyManagementEndPointFunctionality KeyManFunc { get; set; }

        public KeyManagementForm()
        {
            InitializeComponent();
            CertificateList = new CertificateBEList();
            SetUpObjectsForPropertyGrid();
            KeyManFunc = new KeyManagementEndPointFunctionality();
            KeyManFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            Shipment = new KeyManagementShipmentClass();
            AssignActions();
        }

        public void SetUpObjectsForPropertyGrid()
        {
            TypeDescriptor.AddAttributes(typeof(CertificateBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(CertificateBEList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        private void AssignActions()
        {
            AssignAction(GetCertificateList, KeyManFunc.GetKeyManagementCertificatesBeList, Shipment, CertificateList, "GetCertificateList");
        }

        public void Test()
        {
            try
            {
                KeyManFunc.TestKeyManagement(SelectedEndpointName, SelectedCertificate);
                SetViewedItem("OK", "Test was OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from Test");
            }
        }

        public void GetCertificates()
        {

            try
            {
                Shipment.Certificate = SelectedCertificate;
                Shipment.EndpointName = SelectedEndpointName;
                Shipment.Username = SystemUsername;
                Shipment.Password = SystemPassword;
                
                CertificateList = KeyManFunc.GetKeyManagementCertificatesBeList(Shipment);
                SetViewedItem(CertificateArray, "CertificateBEList");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from GetCertificateBEList");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test();
        }
    }
}
