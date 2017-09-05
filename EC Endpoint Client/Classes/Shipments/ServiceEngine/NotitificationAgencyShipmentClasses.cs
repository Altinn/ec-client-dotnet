using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.NotificationAgency;

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine
{
    public class SendStandaloneNotificationShipment : BaseShipment
    {
        public StandaloneNotificationBEList NotificationList { get; set; }
    }
}
