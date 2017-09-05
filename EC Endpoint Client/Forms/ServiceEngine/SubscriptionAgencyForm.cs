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
using EC_Endpoint_Client.SubscriptionAgency;

namespace EC_Endpoint_Client.Forms.ServiceEngine
{
    public partial class SubscriptionAgencyForm : AgencyBaseForm
    {
        private SubscriptionAgencyEndPointFunction saepFunc;
        public SubmitSubscriptionShipment ShipmentSS { get; set; }
        private ReceiptExternal ResultSS { get; set; }
        public SubscriptionAgencyForm()
        {
            InitializeComponent();
            saepFunc = new SubscriptionAgencyEndPointFunction();
            saepFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            ShipmentSS = new SubmitSubscriptionShipment();
            ShipmentSS.SubscriptionDetails = new SubscriptionDetails();
            ShipmentSS.SubscriptionDetails.Subscriptionlist = new SubscriptionList();
            ResultSS = new ReceiptExternal();
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
                saepFunc.Test(ShipmentTest);
                SetViewedItem("OK", "Test ran OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from Test");
            }
        }

        private void SubmitSubscription()
        {
            SetBasicShipmentSettings(ShipmentSS);
            try
            {
                ResultSS = saepFunc.SubmitSubscription(ShipmentSS);
                SetViewedItem(ResultSS, "Result from SubmitSubscription");
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
            SetViewedItem(ShipmentSS, "Shipment for SubmitSubscription");
        }

        private void btn_SSSaveShip_Click(object sender, EventArgs e)
        {
            ClearBasicShipmentsettings(ShipmentSS);
            Functionality.IOFunctionality.GeneralizedSaveFile(ShipmentSS);
        }

        private void btn_SSLoadShip_Click(object sender, EventArgs e)
        {
            ShipmentSS = (SubmitSubscriptionShipment)Functionality.IOFunctionality.GeneralizedLoadFile(ShipmentSS);
            SetViewedItem(ShipmentSS, "Shipment for SubmitSubscription");
        }

        private void btn_SSInvoke_Click(object sender, EventArgs e)
        {
            SubmitSubscription();
        }

        private void btn_SSShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(ResultSS, "Result from SubmitSubscription");
        }

        private void btn_SSSaveResult_Click(object sender, EventArgs e)
        {
            Functionality.IOFunctionality.GeneralizedSaveFile(ResultSS);
        }

        private void btn_TestInvoke_Click(object sender, EventArgs e)
        {
            Test();
        }
#endregion
    }
}
