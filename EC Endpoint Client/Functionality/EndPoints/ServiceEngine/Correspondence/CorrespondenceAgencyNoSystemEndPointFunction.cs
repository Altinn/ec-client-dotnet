using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.CorrespondenceAgency;
using EC_Endpoint_Client.CorrespondenceAgencyNoSystem;
using ReceiptExternal = EC_Endpoint_Client.CorrespondenceAgencyNoSystem.ReceiptExternal;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine
{
    public class CorrespondenceAgencyNoSystemEndPointFunction : EndPointFunctionalityBase
    {
        private string Context = "CorrespondenceAgencyNoSystem";

        private CorrespondenceAgencyExternalAECClient GenerateProxy(BaseShipment shipment)
        {
            return
                base.GenerateProxy<CorrespondenceAgencyExternalAECClient, ICorrespondenceAgencyExternalAEC>(
                    shipment.EndpointName, shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "Test";
            client.Test();
        }

        public ReceiptExternal InsertCorrespondence(InsertCorrespondenceShipmentAEC shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "InsertCorrespondence";
            return client.InsertCorrespondenceAECV2(shipment.ExternalShipmentReference, shipment.InsertCorrespondence);
        }

        public CorrespondenceStatusResultV3 GetCorrespondenceDetailsV3(GetCorrespondenceStatus filter)
        {
            var client = GenerateProxy(filter);
            OperationContext = Context + "GetCorrespondenceDetails";
            return client.GetCorrespondenceStatusDetailsAECV3(filter.CorrespondenceStatusFilter);
        }


        public CorrespondenceStatusResultV3 GetCorrespondenceDetailsV3(GetCorrespondenceStatusDetailsAECShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "GetCorrespondenceDetailsStatus";
            return client.GetCorrespondenceStatusDetailsAECV3(shipment.request);
        }

        public CorrespondenceStatusHistoryAECResult GetCorrespondenceStatusHistory(GetCorrespondenceStatusHistoryAECShipment shipment)
        {
            using (var client = GenerateProxy(shipment))
            {
                CorrespondenceStatusHistoryRequestExternalBE req = new CorrespondenceStatusHistoryRequestExternalBE();
                req.CorrespondenceSendersReferences = shipment.request;
                OperationContext = Context + "GetcorrespondenceStatusHistory";
                return new CorrespondenceStatusHistoryAECResult(client.GetCorrespondenceStatusHistoryAEC(req));
            }
        }

    }
}
