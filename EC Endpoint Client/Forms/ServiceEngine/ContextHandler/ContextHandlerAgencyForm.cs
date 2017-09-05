namespace EC_Endpoint_Client.Forms.ServiceEngine
{
    using EC_Endpoint_Client.BaseForms;
    using EC_Endpoint_Client.Classes;
    using EC_Endpoint_Client.ContextHandler;
    using EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine;
    using System;
    using System.ServiceModel;

    /// <summary>
    /// ContextHandlerAgencyForm used to test ContextHandlerAgency.
    /// </summary>
    public partial class ContextHandlerAgencyForm : AgencyBaseForm
    {
        /// <summary>
        /// Gets or sets the shipmentGC
        /// </summary>
        BaseReporteeElementIdShipment shipmentGC { get; set; }

        /// <summary>
        /// Gets or sets the resultGC
        /// </summary>
        ReporteeElementContextExternalBE resultGC { get; set; }

        /// <summary>
        /// Gets or sets the client
        /// </summary>
        ContextHandlerExternalEndPointFunction client { get; set; }

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
            shipmentGC = new BaseReporteeElementIdShipment();
            client = new ContextHandlerExternalEndPointFunction();
            client.ReturnMessageXml += ReturnMessageXmlHandler;
        }

        /// <summary>
        /// Shows the shipment.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ICShowShipment_Click(object sender, System.EventArgs e)
        {
            SetViewedItem(shipmentGC, "GetReporteeElementContextShipment");
        }

        /// <summary>
        /// Shows the result.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ICShowResult_Click(object sender, System.EventArgs e)
        {
            SetViewedItem(resultGC, "Result from GetReporteeElementContext");
        }

        /// <summary>
        /// Invokes the GetReporteeElementContext service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ICInvoke_Click(object sender, System.EventArgs e)
        {
            SetBasicShipmentSettings(shipmentGC);
            try
            {
                resultGC = client.GetReporteeElementcontextExternal(shipmentGC);
                SetViewedItem(resultGC, "Result from GetReporteeElementContext");
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
            Functionality.IOFunctionality.GeneralizedSaveFile(resultGC);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BaseShipment shipment = new BaseShipment();
                SetBasicShipmentSettings(shipment);
                client.Test(shipment);
                SetViewedItem("OK", "Test result: ");
            }
            catch(Exception ex)
            {
                SetViewedItem(ex, "Error during Test: ");
            }
        }
    }
}
