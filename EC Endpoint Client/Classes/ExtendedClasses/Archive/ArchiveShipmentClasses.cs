using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.Classes.Shipments;

namespace EC_Endpoint_Client.Classes.ExtendedClasses.Archive
{
    public class ArchiveBaseShipment : BaseShipment
    {
        public int ReporteeElementId { get; set; }
        public int? LanguageId { get; set; }
    }

    public class AttachmentBaseShipment : BaseShipment
    {
        public int AttachmentId { get; set; }
    }

    public class StreamedAttachmentResult
    {
        public string Result { get; set; }
    }
}
