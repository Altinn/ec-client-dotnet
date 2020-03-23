using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.CorrespondenceAgency;
using EC_Endpoint_Client.CorrespondenceAgencyNoSystem;
using ReceiptExternal = EC_Endpoint_Client.CorrespondenceAgencyNoSystem.ReceiptExternal;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine.Correspondence
{
    public class CorrespondenceAgencyNoSystemEndPointFunction : EndPointFunctionalityBase
    {
        private string _context = "CorrespondenceAgencyNoSystem";

        private CorrespondenceAgencyExternalAECClient GenerateProxy(BaseShipment shipment)
        {
            return
                base.GenerateProxy<CorrespondenceAgencyExternalAECClient, ICorrespondenceAgencyExternalAEC>(
                    shipment.EndpointName, shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "Test";
            client.Test();
        }

        public ReceiptExternal InsertCorrespondence(InsertCorrespondenceShipmentAec shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "InsertCorrespondence";
            return client.InsertCorrespondenceAECV2(shipment.ExternalShipmentReference, shipment.InsertCorrespondence);
        }

        public CorrespondenceStatusResultV3 GetCorrespondenceDetailsV3(GetCorrespondenceStatus filter)
        {
            var client = GenerateProxy(filter);
            OperationContext = _context + "GetCorrespondenceDetails";
            return client.GetCorrespondenceStatusDetailsAECV3(filter.CorrespondenceStatusFilter);
        }


        public CorrespondenceStatusResultV3 GetCorrespondenceDetailsV3(GetCorrespondenceStatusDetailsAecShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "GetCorrespondenceDetailsStatus";
            return client.GetCorrespondenceStatusDetailsAECV3(shipment.Request);
        }

        public CorrespondenceStatusHistoryAecResult GetCorrespondenceStatusHistory(GetCorrespondenceStatusHistoryAecShipment shipment)
        {
            using (var client = GenerateProxy(shipment))
            {
                SdpStatusInformation info = new SdpStatusInformation();

                CorrespondenceStatusHistoryRequestExternalBE req = new CorrespondenceStatusHistoryRequestExternalBE();
                req.CorrespondenceSendersReferences = shipment.Request;
                OperationContext = _context + "GetcorrespondenceStatusHistory";
                var result = client.GetCorrespondenceStatusHistoryAEC(req.CorrespondenceSendersReferences, out info);
                return new CorrespondenceStatusHistoryAecResult(result, info);
            }
        }

    }
}
