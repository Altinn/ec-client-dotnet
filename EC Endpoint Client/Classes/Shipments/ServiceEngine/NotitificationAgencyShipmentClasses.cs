using EC_Endpoint_Client.NotificationAgency;

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine
{
    public class SendStandaloneNotificationShipment : BaseShipment
    {
        public StandaloneNotificationBEList NotificationList { get; set; }
    }
}
