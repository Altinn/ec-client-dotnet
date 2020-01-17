using System;
using EC_Endpoint_Client.ReporteeElementListEC2;

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine
{
    public class DeleteReporteeElementShipmentEC2 : BaseShipment
    {
        public string ReporteeElementCode { get; set; }
    }

    public class GetFormSetShipmentBaseEC2 : BaseShipment
    {
        public int ReporteeElementId { get; set; }
        public int LanguageId { get; set; }
    }

    public class ReporteeElemenetListShipmentBaseEC2 : BaseShipment
    {
        public string Reportee { get; set; }
        public string ArchiveReference { get; set; }
        public int LanguageId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }

    public class GetReporteeElementListShipmentEC2 : BaseShipment
    {
        public int LanguageId { get; set; }
        public ExternalSearchBEV2 ExternalSearch { get; set; }
    }
}
