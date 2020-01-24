using EC_Endpoint_Client.BatchLoggingAgencyEC2;

namespace EC_Endpoint_Client.Classes.Shipments.Intermediary.AgencyClasses
{
    public class BatchLoggingAgencyShipmentEC2 : BaseShipment
    {
        public BatchLoggingAgencyShipmentEC2()
            : base()
        {
            BatchLoggingRequest = new BatchLoggingRequestExternal();
            BatchLoggingRequest.TimeRange = new BatchLoggingDateTimeRequestExternal();
            DataItemIdRequest = new BatchLoggingDataItemIdShipment();
        }

        public BatchLoggingRequestExternal BatchLoggingRequest { get; set; }
        public BatchLoggingDataItemIdShipment DataItemIdRequest { get; set; }
    }

    public class BatchLoggingDataItemIdShipmentEC2
    {
        public long DataItemId { get; set; }
    }
}
