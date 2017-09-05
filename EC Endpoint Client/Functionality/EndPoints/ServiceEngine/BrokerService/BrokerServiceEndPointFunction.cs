using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.BrokerService;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.BrokerService;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine
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
