using EC_Endpoint_Client.BaseForms;
using System;
using System.ComponentModel;
using EC_Endpoint_Client.Functionality;
using EC_Endpoint_Client.Functionality.EndPoints.Intermediary;
using System.ServiceModel;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.Intermediary.AgencyClasses;
using EC_Endpoint_Client.BatchLoggingAgency;

namespace EC_Endpoint_Client.Forms.Intermediary
{
    public partial class BatchLoggingForm : AgencyBaseForm
    {
        private BatchLoggingAgencyShipment Shipment { get; set; }
		public BaseShipment TestShipment { get; set; }
        DataItem DataItemResult { get; set; }
        BatchLoggingStatusOverview Result { get; set; }
        BatchLoggingDetailedStatus ResultDetail { get; set; }
        BatchLoggingAgencyEndPointFunctionality Func { get; set; }

        public BatchLoggingForm()
        {
            Func = new BatchLoggingAgencyEndPointFunctionality();
            Func.ReturnMessageXml += ReturnMessageXmlHandler;
            Shipment = new BatchLoggingAgencyShipment();
			TestShipment = new BaseShipment();
            Result = new BatchLoggingStatusOverview();
            ResultDetail = new BatchLoggingDetailedStatus();
            DataItemResult = new DataItem();
            InitializeComponent();
            SetupObjectsForPropertyGrid();
            AssignActions();
        }

        private void AssignActions()
        {
            AssignAction(controllerGetStatusOverviews, Func.GetStatusOverview, Shipment, Result, "GetStatusOverview");
            AssignAction(controllerGetDetailedStatus, Func.GetDetailedOverview, Shipment, ResultDetail, "GetDetailedStatus");
            AssignAction(controllerGetDataItem, Func.GetDataItem, Shipment, DataItemResult, "GetDataItem");
        }

        private void SetupObjectsForPropertyGrid()
        {
            // BatchLoggingDataItemIdShipment
            TypeDescriptor.AddAttributes(typeof(BatchLoggingDataItemIdShipment), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(BatchLoggingRequestExternal), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(BatchLoggingAgencyShipment), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(BatchLoggingDateTimeRequestExternal), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        private void Test()
        {
            SetBasicShipmentSettings(TestShipment);
            Func.Test(TestShipment);
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            try
            {
                Test();
                SetViewedItem("OK", "Test ran OK");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Error from Test");
            }
        }
    }
}
