using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine;
using EC_Endpoint_Client.SubscriptionAgencyEC2;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine
{
    class SubscriptionAgencyEndPointFunctionEC2 : EndPointFunctionalityBase
    {
        private string _context = "SubscriptionAgencyExternalECClient";
        private SubscriptionAgencyExternalEC2Client GenerateProxy(BaseShipment shipment)
        {
            return
                base.GenerateProxy<SubscriptionAgencyExternalEC2Client, ISubscriptionAgencyExternalEC2>(
                    shipment.EndpointName, shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "Test";
            client.Test();
        }

        public ReceiptExternal SubmitSubscription(SubmitSubscriptionShipmentEC2 shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "SubmitSubscription";
            return client.SubmitSubscriptionEC(shipment.Username, shipment.Password, shipment.ExternalBatchId, shipment.SubscriptionDetails);
        }
    }
}
