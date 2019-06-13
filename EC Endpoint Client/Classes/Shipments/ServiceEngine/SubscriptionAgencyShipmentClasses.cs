using EC_Endpoint_Client.Service_References.SubscriptionAgency;

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine
{
    public class SubmitSubscriptionShipment : BaseShipment
    {
        public string ExternalBatchId { get; set; }
        public SubscriptionDetails SubscriptionDetails { get; set; }
    }
}
