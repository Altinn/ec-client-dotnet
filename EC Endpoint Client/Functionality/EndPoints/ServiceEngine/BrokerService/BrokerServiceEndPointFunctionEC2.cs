using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.BrokerService;
using EC_Endpoint_Client.BrokerServiceEC2;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine.BrokerService
{
    class BrokerServiceEndPointFunctionEC2 : EndPointFunctionalityBase
    {
        private BrokerServiceExternalEC2Client GenerateProxy(BaseShipment shipment)
        {
            return base.GenerateProxy<BrokerServiceExternalEC2Client, IBrokerServiceExternalEC2>(shipment.EndpointName, shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "BrokerServiceTest";
            client.Test();
        }

        public string InitiateBrokerService(InitiateBrokerServiceShipmentEC2 shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "InitiateBrokerService";
            return client.InitiateBrokerServiceEC(shipment.Username, shipment.Password, shipment.BrokerServiceInitiation);
        }

        public BrokerServiceAvailableFile[] GetAvailableFiles(GetAvailableFilesShipmentEC2 shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "BrokerServiceTest";
            return client.GetAvailableFilesEC(shipment.Username, shipment.Password, shipment.BrokerServiceSearch).ToArray();
        }
    }
}
