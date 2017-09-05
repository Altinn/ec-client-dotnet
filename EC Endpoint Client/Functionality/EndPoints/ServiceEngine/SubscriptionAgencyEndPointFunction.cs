using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine;
using EC_Endpoint_Client.SubscriptionAgency;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine
{
    class SubscriptionAgencyEndPointFunction : EndPointFunctionalityBase
    {
        private string Context = "SubscriptionAgencyExternalECClient";
        private SubscriptionAgencyExternalECClient GenerateProxy(BaseShipment shipment)
        {
            return
                base.GenerateProxy<SubscriptionAgencyExternalECClient, ISubscriptionAgencyExternalEC>(
                    shipment.EndpointName, shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "Test";
            client.Test();
        }

        public ReceiptExternal SubmitSubscription(SubmitSubscriptionShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "SubmitSubscription";
            return client.SubmitSubscriptionEC(shipment.Username, shipment.Password, shipment.ExternalBatchID, shipment.SubscriptionDetails);
        }
    }
}
