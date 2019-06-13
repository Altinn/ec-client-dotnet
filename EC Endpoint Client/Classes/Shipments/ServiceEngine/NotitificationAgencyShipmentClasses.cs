using EC_Endpoint_Client.Service_References.NotificationAgency;

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine
{
    public class SendStandaloneNotificationShipment : BaseShipment
    {
        public StandaloneNotificationBEList NotificationList { get; set; }
    }
}
