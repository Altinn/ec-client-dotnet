using EC_Endpoint_Client.SubscriptionAgencyEC2;

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine
{
    public class SubmitSubscriptionShipmentEC2 : BaseShipment
    {
        public string ExternalBatchId { get; set; }
        public SubscriptionDetails SubscriptionDetails { get; set; }
    }
}
