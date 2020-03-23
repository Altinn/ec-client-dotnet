using System;
using System.ServiceModel;
using EC_Endpoint_Client.BaseForms;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine;
using EC_Endpoint_Client.ContextHandler;

namespace EC_Endpoint_Client.Forms.ServiceEngine.ContextHandler
{
    /// <summary>
    /// ContextHandlerAgencyForm used to test ContextHandlerAgency.
    /// </summary>
    public partial class ContextHandlerAgencyForm : AgencyBaseForm
    {
        /// <summary>
        /// Gets or sets the shipmentGC
        /// </summary>
        BaseReporteeElementIdShipment ShipmentGc { get; set; }

        /// <summary>
        /// Gets or sets the resultGC
        /// </summary>
        ReporteeElementContextExternalBE ResultGc { get; set; }

        /// <summary>
        /// Gets or sets the client
        /// </summary>
        ContextHandlerExternalEndPointFunction Client { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextHandlerAgencyForm"/> class.
        /// </summary>
        public ContextHandlerAgencyForm()
        {
            InitializeComponent();
            InitializeMyForm();
        }

        public void InitializeMyForm()
        {
            ShipmentGc = new BaseReporteeElementIdShipment();
            Client = new ContextHandlerExternalEndPointFunction();
            Client.ReturnMessageXml += ReturnMessageXmlHandler;
        }

        /// <summary>
        /// Shows the shipment.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ICShowShipment_Click(object sender, EventArgs e)
        {
            SetViewedItem(ShipmentGc, "GetReporteeElementContextShipment");
        }

        /// <summary>
        /// Shows the result.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ICShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(ResultGc, "Result from GetReporteeElementContext");
        }

        /// <summary>
        /// Invokes the GetReporteeElementContext service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ICInvoke_Click(object sender, EventArgs e)
        {
            SetBasicShipmentSettings(ShipmentGc);
            try
            {
                ResultGc = Client.GetReporteeElementcontextExternal(ShipmentGc);
                SetViewedItem(ResultGc, "Result from GetReporteeElementContext");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error during GetReporteeElementContext: ");            
                if (ex.InnerException != null)
                {
                    SetViewedItem(ex.InnerException, "Error during GetReporteeElementContext: ");
                }
            }
        }

        private bool IsAltinnFault(object obj)
        {
            try
            {
                var f = (FaultException<AltinnFault>)obj;
            }
            catch
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Saves the result.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ICSaveResult_Click(object sender, EventArgs e)
        {
            Functionality.IoFunctionality.GeneralizedSaveFile(ResultGc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BaseShipment shipment = new BaseShipment();
                SetBasicShipmentSettings(shipment);
                Client.Test(shipment);
                SetViewedItem("OK", "Test result: ");
            }
            catch(Exception ex)
            {
                SetViewedItem(ex, "Error during Test: ");
            }
        }
    }
}
