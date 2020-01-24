using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.LookUp;
using EC_Endpoint_Client.LookUpEC2;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine.LookUp
{
    class LookUpEndPointFunctionEC2 : EndPointFunctionalityBase
    {
        private LookUpExternalEC2Client GenerateProxy(BaseShipment shipment)
        {
            return base.GenerateProxy<LookUpExternalEC2Client, ILookUpExternalEC2>(shipment.EndpointName,
                shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "LookUpTest";
            client.Test();
        }

        public string LookUp(LookUpShipmentEC2 shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "LookUp";
            return client.ExecuteLookUp(shipment.Username, shipment.Password, shipment.LookUpRequest);
        }
    }
}
