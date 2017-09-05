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
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine;
using EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine;
using EC_Endpoint_Client.NotificationAgency;

namespace EC_Endpoint_Client.Forms.ServiceEngine
{
    public partial class NotificationAgencyForm : AgencyBaseForm
    {
        private NotificationAgencyEndpointFunction naepFunc;
        public SendStandaloneNotificationShipment ShipmentSSN { get; set; }
        public NotificationAgencyForm()
        {
            InitializeComponent();
            naepFunc = new NotificationAgencyEndpointFunction();
            naepFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            ShipmentSSN = new SendStandaloneNotificationShipment();
            ShipmentSSN.NotificationList = new StandaloneNotificationBEList();
        }

        private void SetupObjForPropGrid()
        {
            TypeDescriptor.AddAttributes(typeof(StandaloneNotificationBEList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(StandaloneNotification), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ReceiverEndPointBEList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(TextTokenSubstitutionBEList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(TextToken), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ReceiverEndPoint), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        private void Test()
        {
            SetBasicShipmentSettings(ShipmentTest);
            try
            {
                naepFunc.Test(ShipmentTest);
                SetViewedItem("OK", "Test ran OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from Test");
            }
        }

        private void SendStandaloneNotification()
        {
            SetBasicShipmentSettings(ShipmentSSN);
            try
            {
                naepFunc.SendStandAloneNotification(ShipmentSSN);
                SetViewedItem("OK", "SendStandAloneNotification ran OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from SendStandAloneNotification");
            }
        }

        #region Clicks
        private void btn_SSNShowShip_Click(object sender, EventArgs e)
        {
            SetViewedItem(ShipmentSSN, "Shipment for SendStandAloneNotification");
        }

        private void btn_SSNSaveShip_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(ShipmentSSN);
            Functionality.IOFunctionality.GeneralizedSaveFile(ShipmentSSN);
        }

        private void btn_SSNLoadShip_Click(object sender, EventArgs e)
        {
            ShipmentSSN = (SendStandaloneNotificationShipment)Functionality.IOFunctionality.GeneralizedLoadFile(ShipmentSSN);
            SetViewedItem(ShipmentSSN, "Shipment for SendStandAloneNotification");
        }

        private void btn_SSNInvoke_Click(object sender, EventArgs e)
        {
            SendStandaloneNotification();
        }

        private void btn_TestInvoke_Click(object sender, EventArgs e)
        {
            Test();
        }
#endregion
    }
}
