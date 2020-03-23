using EC_Endpoint_Client.BatchLoggingAgency;

namespace EC_Endpoint_Client.Classes.Shipments.Intermediary.AgencyClasses
{
    public class BatchLoggingAgencyShipment : BaseShipment
    {
        public BatchLoggingAgencyShipment()
            : base()
        {
            BatchLoggingRequest = new BatchLoggingRequestExternal();
            BatchLoggingRequest.TimeRange = new BatchLoggingDateTimeRequestExternal();
            DataItemIdRequest = new BatchLoggingDataItemIdShipment();
        }

        public BatchLoggingRequestExternal BatchLoggingRequest { get; set; }
        public BatchLoggingDataItemIdShipment DataItemIdRequest { get; set; }
    }

    public class BatchLoggingDataItemIdShipment
    {
        public long DataItemId { get; set; }
    }
}
