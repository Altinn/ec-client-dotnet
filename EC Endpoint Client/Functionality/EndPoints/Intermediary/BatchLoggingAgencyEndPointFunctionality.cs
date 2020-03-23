using System;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.Intermediary.AgencyClasses;
using EC_Endpoint_Client.BatchLoggingAgency;

namespace EC_Endpoint_Client.Functionality.EndPoints.Intermediary
{
    public class BatchLoggingAgencyEndPointFunctionality : EndPointFunctionalityBase
    {
        private BatchLoggingAgencyExternalECClient GenerateBatchLoggingAgencyProxy(BaseShipment shipment)
        {
            return GenerateProxy<BatchLoggingAgencyExternalECClient, IBatchLoggingAgencyExternalEC>(shipment.EndpointName, shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            OperationContext = "BatchLoggingAgencyTest";
            using (var client = GenerateBatchLoggingAgencyProxy(shipment))
            {
                client.Test();
            }
        }

        public BatchLoggingStatusOverview GetStatusOverview(BatchLoggingAgencyShipment shipment)
        {
            OperationContext = "BatchLoggingAgencyGetStatusOverview";
            CheckShipment(shipment);
            using (var client = GenerateBatchLoggingAgencyProxy(shipment))
            {
                return client.GetStatusOverview(shipment.Username, shipment.Password, shipment.BatchLoggingRequest);
            }
        }

        public BatchLoggingDetailedStatus GetDetailedOverview(BatchLoggingAgencyShipment shipment)
        {
            OperationContext = "BatchLoggingAgencyGetStatusOverview";
            CheckShipment(shipment);
            using (var client = GenerateBatchLoggingAgencyProxy(shipment))
            {
                return client.GetDetailedStatus(shipment.Username, shipment.Password, shipment.BatchLoggingRequest);
            }
        }

        public DataItem GetDataItem(BatchLoggingAgencyShipment shipment)
        {
            OperationContext = "BatchLoggingAgencyGetStatusOverview";
            CheckShipment(shipment);
            using (var client = GenerateBatchLoggingAgencyProxy(shipment))
            {
                return client.GetDataItem(shipment.Username, shipment.Password, shipment.DataItemIdRequest.DataItemId);
            }
        }

        private void CheckShipment(BatchLoggingAgencyShipment shipment)
        {
            if (shipment.BatchLoggingRequest.TimeRange.DateFrom == DateTime.MinValue && shipment.BatchLoggingRequest.TimeRange.DateTo == DateTime.MinValue)
            {
                shipment.BatchLoggingRequest.TimeRange = null;
            }
        }
    }
}
