using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.SubscriptionAgency;

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine
{
    public class SubmitSubscriptionShipment : BaseShipment
    {
        public string ExternalBatchID { get; set; }
        public SubscriptionDetails SubscriptionDetails { get; set; }
    }
}
