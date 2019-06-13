using System;
using EC_Endpoint_Client.ReporteeElementList;

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine
{
    public class DeleteReporteeElementShipment : BaseShipment
    {
        public string ReporteeElementCode { get; set; }
    }

    public class GetFormSetShipmentBase : BaseShipment
    {
        public int ReporteeElementId { get; set; }
        public int LanguageId { get; set; }
    }

    public class ReporteeElemenetListShipmentBase : BaseShipment
    {
        public string Reportee { get; set; }
        public string ArchiveReference { get; set; }
        public int LanguageId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }

    public class GetReporteeElementListShipment : BaseShipment
    {
        public int LanguageId { get; set; }
        public ExternalSearchBEV2 ExternalSearch { get; set; }
    }
}
