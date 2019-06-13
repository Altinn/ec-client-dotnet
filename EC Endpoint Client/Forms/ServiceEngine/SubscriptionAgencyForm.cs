using System;
using System.ComponentModel;
using EC_Endpoint_Client.BaseForms;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine;
using EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine;
using EC_Endpoint_Client.Service_References.SubscriptionAgency;

namespace EC_Endpoint_Client.Forms.ServiceEngine
{
    public partial class SubscriptionAgencyForm : AgencyBaseForm
    {
        private SubscriptionAgencyEndPointFunction _saepFunc;
        public SubmitSubscriptionShipment ShipmentSs { get; set; }
        private ReceiptExternal ResultSs { get; set; }
        public SubscriptionAgencyForm()
        {
            InitializeComponent();
            _saepFunc = new SubscriptionAgencyEndPointFunction();
            _saepFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            ShipmentSs = new SubmitSubscriptionShipment();
            ShipmentSs.SubscriptionDetails = new SubscriptionDetails();
            ShipmentSs.SubscriptionDetails.Subscriptionlist = new SubscriptionList();
            ResultSs = new ReceiptExternal();
            SetupObjForPropGrid();
        }

        private void SetupObjForPropGrid()
        {
            TypeDescriptor.AddAttributes(typeof(SubscriptionDetails), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(SubscriptionList), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(Subscription), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ReceiptExternal), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }
        #region Invokes
        private void Test()
        {
            SetBasicShipmentSettings(ShipmentTest);
            try
            {
                _saepFunc.Test(ShipmentTest);
                SetViewedItem("OK", "Test ran OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from Test");
            }
        }

        private void SubmitSubscription()
        {
            SetBasicShipmentSettings(ShipmentSs);
            try
            {
                ResultSs = _saepFunc.SubmitSubscription(ShipmentSs);
                SetViewedItem(ResultSs, "Result from SubmitSubscription");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from SubmitSubscription");
            }
        }
        #endregion
        #region clicks
        private void btn_SSShowShip_Click(object sender, EventArgs e)
        {
            SetViewedItem(ShipmentSs, "Shipment for SubmitSubscription");
        }

        private void btn_SSSaveShip_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(ShipmentSs);
            Functionality.IoFunctionality.GeneralizedSaveFile(ShipmentSs);
        }

        private void btn_SSLoadShip_Click(object sender, EventArgs e)
        {
            ShipmentSs = (SubmitSubscriptionShipment)Functionality.IoFunctionality.GeneralizedLoadFile(ShipmentSs);
            SetViewedItem(ShipmentSs, "Shipment for SubmitSubscription");
        }

        private void btn_SSInvoke_Click(object sender, EventArgs e)
        {
            SubmitSubscription();
        }

        private void btn_SSShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(ResultSs, "Result from SubmitSubscription");
        }

        private void btn_SSSaveResult_Click(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(ResultSs);
        }

        private void btn_TestInvoke_Click(object sender, EventArgs e)
        {
            Test();
        }
#endregion
    }
}
