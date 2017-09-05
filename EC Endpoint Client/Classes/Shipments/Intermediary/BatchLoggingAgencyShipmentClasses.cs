using EC_Endpoint_Client.BatchLoggingAgency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Endpoint_Client.Classes.Shipments.Intermediary
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
