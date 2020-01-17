using EC_Endpoint_Client.NotificationAgencyEC2;

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine
{
    public class SendStandaloneNotificationShipmentEC2 : BaseShipment
    {
        public StandaloneNotificationBEList NotificationList { get; set; }
    }
}
