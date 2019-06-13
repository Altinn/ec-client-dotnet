using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.BrokerService;
using EC_Endpoint_Client.Service_References.BrokerService;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine.BrokerService
{
    class BrokerServiceEndPointFunction : EndPointFunctionalityBase
    {
        private BrokerServiceExternalECClient GenerateProxy(BaseShipment shipment)
        {
            return base.GenerateProxy<BrokerServiceExternalECClient, IBrokerServiceExternalEC>(shipment.EndpointName, shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "BrokerServiceTest";
            client.Test();
        }

        public string InitiateBrokerService(InitiateBrokerServiceShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "InitiateBrokerService";
            return client.InitiateBrokerServiceEC(shipment.Username, shipment.Password, shipment.BrokerServiceInitiation);
        }

        public BrokerServiceAvailableFile[] GetAvailableFiles(GetAvailableFilesShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "BrokerServiceTest";
            return client.GetAvailableFilesEC(shipment.Username, shipment.Password, shipment.BrokerServiceSearch).ToArray();
        }
    }
}
