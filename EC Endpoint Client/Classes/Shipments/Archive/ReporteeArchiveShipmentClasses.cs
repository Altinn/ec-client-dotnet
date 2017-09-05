using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Endpoint_Client.Classes
{
    public class ReporteeArchiveShipment : ReporteeArchiveShipmentBase
    {
        public int? LanguageID { get; set; }
    }

    public class ReporteeArchiveAttachmentShipment : BaseShipment
    {
        public int AttachimentID { get; set; }
    }

    public class ReporteeArchiveLookupShipment : ReporteeArchiveShipmentBase
    {
        public int LanguageID { get; set; }
    }

    public class ReporteeArchiveShipmentBase : BaseShipment
    {
        public int ReporteeElementID { get; set; }
    }
}
