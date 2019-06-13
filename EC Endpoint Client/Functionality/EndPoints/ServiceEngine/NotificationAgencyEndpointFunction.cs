using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine;
using EC_Endpoint_Client.Service_References.NotificationAgency;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine
{
    class NotificationAgencyEndpointFunction : EndPointFunctionalityBase
    {
        private string _context = "NotificationAgency";
        /// <summary>
        /// It's worth noting that in this file, as well as  most of the later files, I've generated shipment classes, so that the GenerateProxy functions are more 
        /// easily replicated between each endpoint. (Still has to return different clients, though.)
        /// By putting user and certificate info in the baseshipment class, I can easily grab this info easily from every Shipment for every endpoint, 
        /// whicm makes coding a new GenerateProxy function a lot easier. (Control+c Control+v easy.)
        /// </summary>
        /// <param name="shipment"></param>
        /// <returns></returns>
        private NotificationAgencyExternalECClient GenerateProxy(BaseShipment shipment)
        {
            return
                base.GenerateProxy<NotificationAgencyExternalECClient, INotificationAgencyExternalEC>(
                    shipment.EndpointName, shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "Test";
            client.Test();
        }

        public void SendStandAloneNotification(SendStandaloneNotificationShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "SendStandAloneNotification";
            client.SendStandaloneNotificationEC(shipment.Username, shipment.Password, shipment.NotificationList);
        }
    }
}
