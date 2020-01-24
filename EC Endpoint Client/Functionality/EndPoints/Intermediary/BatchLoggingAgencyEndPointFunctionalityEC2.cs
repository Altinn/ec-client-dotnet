using System;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.Intermediary.AgencyClasses;
using EC_Endpoint_Client.BatchLoggingAgencyEC2;

namespace EC_Endpoint_Client.Functionality.EndPoints.Intermediary
{
    public class BatchLoggingAgencyEndPointFunctionalityEC2 : EndPointFunctionalityBase
    {
        private BatchLoggingAgencyExternalEC2Client GenerateBatchLoggingAgencyProxy(BaseShipment shipment)
        {
            return GenerateProxy<BatchLoggingAgencyExternalEC2Client, IBatchLoggingAgencyExternalEC2>(shipment.EndpointName, shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            OperationContext = "BatchLoggingAgencyTest";
            using (var client = GenerateBatchLoggingAgencyProxy(shipment))
            {
                client.Test();
            }
        }

        public BatchLoggingStatusOverview GetStatusOverview(BatchLoggingAgencyShipmentEC2 shipment)
        {
            OperationContext = "BatchLoggingAgencyGetStatusOverview";
            CheckShipment(shipment);
            using (var client = GenerateBatchLoggingAgencyProxy(shipment))
            {
                return client.GetStatusOverview(shipment.Username, shipment.Password, shipment.BatchLoggingRequest);
            }
        }

        public BatchLoggingDetailedStatus GetDetailedOverview(BatchLoggingAgencyShipmentEC2 shipment)
        {
            OperationContext = "BatchLoggingAgencyGetStatusOverview";
            CheckShipment(shipment);
            using (var client = GenerateBatchLoggingAgencyProxy(shipment))
            {
                return client.GetDetailedStatus(shipment.Username, shipment.Password, shipment.BatchLoggingRequest);
            }
        }

        public DataItem GetDataItem(BatchLoggingAgencyShipmentEC2 shipment)
        {
            OperationContext = "BatchLoggingAgencyGetStatusOverview";
            CheckShipment(shipment);
            using (var client = GenerateBatchLoggingAgencyProxy(shipment))
            {
                return client.GetDataItem(shipment.Username, shipment.Password, shipment.DataItemIdRequest.DataItemId);
            }
        }

        private void CheckShipment(BatchLoggingAgencyShipmentEC2 shipment)
        {
            if (shipment.BatchLoggingRequest.TimeRange.DateFrom == DateTime.MinValue && shipment.BatchLoggingRequest.TimeRange.DateTo == DateTime.MinValue)
            {
                shipment.BatchLoggingRequest.TimeRange = null;
            }
        }
    }
}
