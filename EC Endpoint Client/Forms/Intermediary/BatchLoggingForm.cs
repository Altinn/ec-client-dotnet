using EC_Endpoint_Client.BaseForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EC_Endpoint_Client.BatchLoggingAgency;
using EC_Endpoint_Client.Classes.Shipments.Intermediary;
using EC_Endpoint_Client.Functionality;
using EC_Endpoint_Client.Functionality.EndPoints.Intermediary;
using System.ServiceModel;

namespace EC_Endpoint_Client.Forms.Intermediary
{
    public partial class BatchLoggingForm : AgencyBaseForm
    {
        BatchLoggingAgencyShipment shipment { get; set; }
        DataItem dataItemResult { get; set; }
        long dataItemId { get; set; }
        BatchLoggingStatusOverview result { get; set; }
        BatchLoggingDetailedStatus resultDetail { get; set; }
        BatchLoggingAgencyEndPointFunctionality func { get; set; }

        public BatchLoggingForm()
        {
            func = new BatchLoggingAgencyEndPointFunctionality();
            func.ReturnMessageXml += ReturnMessageXmlHandler;
            shipment = new BatchLoggingAgencyShipment();
            result = new BatchLoggingStatusOverview();
            resultDetail = new BatchLoggingDetailedStatus();
            dataItemResult = new DataItem();
            InitializeComponent();
            SelectedServiceList.SelectedIndex = 0;
            SetupObjectsForPropertyGrid();
        }

        private void CheckShipment()
        {
            if (shipment.BatchLoggingRequest.TimeRange.DateFrom == DateTime.MinValue && shipment.BatchLoggingRequest.TimeRange.DateTo == DateTime.MinValue)
            {
                shipment.BatchLoggingRequest.TimeRange = null;
            }
        }

        private void SetupObjectsForPropertyGrid()
        {
            TypeDescriptor.AddAttributes(typeof(BatchLoggingDateTimeRequestExternal), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        private void btn_ShowRequest_Click(object sender, EventArgs e)
        {
            SetViewedItem(shipment.BatchLoggingRequest, "Request for Status or Detailed overview");
        }

        private void btn_SaveRequest_Click(object sender, EventArgs e)
        {
            IOFunctionality.GeneralizedSaveFile(shipment.BatchLoggingRequest);
        }

        private void btn_LoadRequest_Click(object sender, EventArgs e)
        {
            shipment.BatchLoggingRequest = IOFunctionality.GeneralizedLoadFile<BatchLoggingRequestExternal>();
        }

        private void btn_SubmitRequest_Click(object sender, EventArgs e)
        {
            SetBasicShipmentSettings(shipment);
            CheckShipment();
            try
            {
                if (SelectedServiceList.SelectedItem.ToString() == "GetStatusOverview")
                {
                    result = func.GetStatusOverview(shipment);
                    SetViewedItem(result, "Result from BatchLog Overview");
                }
                else
                {
                    resultDetail = func.GetDetailedOverview(shipment);
                    SetViewedItem(resultDetail, "Result from BatchLog Detail");
                }
            }
            catch (FaultException<AltinnFault> af)
            {
                SetViewedItem(af, "Caught altinnFault");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Caught exception");
            }

            if (shipment.BatchLoggingRequest.TimeRange == null)
            {
                shipment.BatchLoggingRequest.TimeRange = new BatchLoggingDateTimeRequestExternal();
            }

        }

        private void btn_ShowResult_Click(object sender, EventArgs e)
        {
            SetViewedItem(result, "Result from BatchLog Overview");
        }

        private void btn_SaveResult_Click(object sender, EventArgs e)
        {
            IOFunctionality.GeneralizedSaveFile(result);
        }

        private void showDataItemIdbtn_Click(object sender, EventArgs e)
        {
            SetViewedItem(shipment.DataItemIdRequest, "Shipment for GetDataItem");
        }

        private void GetDataItemBtn_Click(object sender, EventArgs e)
        {
            SetBasicShipmentSettings(shipment);
            try
            {
                dataItemResult = func.GetDataItem(shipment);
                SetViewedItem(dataItemResult, "Result from GetDataItem");
            }
            catch (FaultException<AltinnFault> af)
            {
                SetViewedItem(af, "Caught altinnFault");
            }
            catch (Exception ex)
            {
                SetViewedItem(ex, "Caught exception");
            }
        }

        private void showDataItembtn_Click(object sender, EventArgs e)
        {
            SetViewedItem(dataItemResult, "Result from GetDataItem");
        }

        private void saveDataItembtn_Click(object sender, EventArgs e)
        {
            IOFunctionality.GeneralizedSaveFile(dataItemResult);
        }
    }
}
