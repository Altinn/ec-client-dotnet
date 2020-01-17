using System;
using System.ComponentModel;
using EC_Endpoint_Client.Classes.Shipments.Archive;
using EC_Endpoint_Client.Functionality.EndPoints.Archive;
using EC_Endpoint_Client.KeyManagementEC2;

namespace EC_Endpoint_Client.Forms.Archive
{
    public partial class KeyManagementFormEC2 : BaseForms.ClientBaseForm
    {
        public CertificateBEList CertificateList { get; set; }
        public KeyManagementShipmentClass Shipment { get; set; }
        private CertificateBE[] CertificateArray => CertificateList.ToArray();

        private KeyManagementEndPointFunctionalityEC2 KeyManFunc { get; set; }

        public KeyManagementFormEC2()
        {
            InitializeComponent();
            CertificateList = new CertificateBEList();
            SetUpObjectsForPropertyGrid();
            KeyManFunc = new KeyManagementEndPointFunctionalityEC2();
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
