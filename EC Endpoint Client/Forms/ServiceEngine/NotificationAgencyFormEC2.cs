using System;
using System.ComponentModel;
using EC_Endpoint_Client.BaseForms;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine;
using EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine;
using EC_Endpoint_Client.NotificationAgencyEC2;

namespace EC_Endpoint_Client.Forms.ServiceEngine
{
    public partial class NotificationAgencyFormEC2 : AgencyBaseForm
    {
        private NotificationAgencyEndpointFunctionEC2 _naepFunc;
        public SendStandaloneNotificationShipmentEC2 ShipmentSsn { get; set; }
        public NotificationAgencyFormEC2()
        {
            InitializeComponent();
            _naepFunc = new NotificationAgencyEndpointFunctionEC2();
            _naepFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            ShipmentSsn = new SendStandaloneNotificationShipmentEC2();
            ShipmentSsn.NotificationList = new StandaloneNotificationBEList();
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
                _naepFunc.Test(ShipmentTest);
                SetViewedItem("OK", "Test ran OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from Test");
            }
        }

        private void SendStandaloneNotification()
        {
            SetBasicShipmentSettings(ShipmentSsn);
            try
            {
                _naepFunc.SendStandAloneNotification(ShipmentSsn);
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
            SetViewedItem(ShipmentSsn, "Shipment for SendStandAloneNotification");
        }

        private void btn_SSNSaveShip_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(ShipmentSsn);
            Functionality.IoFunctionality.GeneralizedSaveFile(ShipmentSsn);
        }

        private void btn_SSNLoadShip_Click(object sender, EventArgs e)
        {
            ShipmentSsn = Functionality.IoFunctionality.GeneralizedLoadFile(ShipmentSsn);
            SetViewedItem(ShipmentSsn, "Shipment for SendStandAloneNotification");
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
