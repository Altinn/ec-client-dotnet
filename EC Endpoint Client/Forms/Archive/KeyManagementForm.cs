using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.KeyManagement;

namespace EC_Endpoint_Client.Forms
{
    public partial class KeyManagementForm : ClientBaseForm
    {
        public CertificateBEList CertificateList { get; set; }
        public KeyManagementShipmentClass Shipment { get; set; }
        private CertificateBE[] CertificateArray
        {
            get { return CertificateList.ToArray(); }
            set
            {
                CertificateList = (CertificateBEList)value.ToList<CertificateBE>();
            }
        }

        private Functionality.KeyManagementEndPointFunctionality keyManFunc { get; set; }

        public KeyManagementForm()
        {
            InitializeComponent();
            CertificateList = new CertificateBEList();
            SetUpObjectsForPropertyGrid();
            keyManFunc = new Functionality.KeyManagementEndPointFunctionality();
            keyManFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            Shipment = new KeyManagementShipmentClass();
            ShowShipment();
        }

        public virtual void SetUpObjectsForPropertyGrid()
        {
            TypeDescriptor.AddAttributes(typeof(CertificateBE), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(CertificateBEList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        private void ShowShipment()
        {
            SetViewedItem(Shipment, "Shipment Item");
        }

        public void Test()
        {
            try
            {
                keyManFunc.TestKeyManagement(SelectedEndpointName, SelectedCertificate);
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
                
                CertificateList = keyManFunc.GetKeyManagementCertificatesBEList(Shipment);
                SetViewedItem(CertificateArray, "CertificateBEList");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from GetCertificateBEList");
            }
        }

        private void btn_getCertificateBEList_Click(object sender, EventArgs e)
        {
            GetCertificates();
        }

        private void btn_ShowCertificateBEList_Click(object sender, EventArgs e)
        {
            SetViewedItem(CertificateArray, "CertificateBEList");
        }

        private void btn_SaveCertificateBEList_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(CertificateList);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test();
        }

        private void btn_showShipment_Click(object sender, EventArgs e)
        {
            ShowShipment();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            ShowShipment();
        }
    }
}
