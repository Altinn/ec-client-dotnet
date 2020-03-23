using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine;
using EC_Endpoint_Client.SubscriptionAgency;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine
{
    class SubscriptionAgencyEndPointFunction : EndPointFunctionalityBase
    {
        private string _context = "SubscriptionAgencyExternalECClient";
        private SubscriptionAgencyExternalECClient GenerateProxy(BaseShipment shipment)
        {
            return
                base.GenerateProxy<SubscriptionAgencyExternalECClient, ISubscriptionAgencyExternalEC>(
                    shipment.EndpointName, shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "Test";
            client.Test();
        }

        public ReceiptExternal SubmitSubscription(SubmitSubscriptionShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "SubmitSubscription";
            return client.SubmitSubscriptionEC(shipment.Username, shipment.Password, shipment.ExternalBatchId, shipment.SubscriptionDetails);
        }
    }
}
