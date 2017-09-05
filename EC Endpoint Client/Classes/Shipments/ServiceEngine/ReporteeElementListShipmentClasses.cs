using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.ReporteeElementList;

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine
{
    public class DeleteReporteeElementShipment : BaseShipment
    {
        public string ReporteeElementCode { get; set; }
    }

    public class GetFormSetShipmentBase : BaseShipment
    {
        public int ReporteeElementID { get; set; }
        public int LanguageID { get; set; }
    }

    public class ReporteeElemenetListShipmentBase : BaseShipment
    {
        public string Reportee { get; set; }
        public string ArchiveReference { get; set; }
        public int LanguageID { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }

    public class GetReporteeElementListShipment : BaseShipment
    {
        public int LanguageID { get; set; }
        public ExternalSearchBEV2 ExternalSearch { get; set; }
    }
}
