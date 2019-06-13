using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Endpoint_Client.Classes.Shipments.Archive
{
    public class GetDownloadQueueShipment : BaseShipment
    {
        public string ServiceCode { get; set; }
    }

    public class DownloadQueueBaseShipment : BaseShipment
    {
        public string ArchiveReference { get; set; }
    }

    public class DownloadQueueExtendedShipment : DownloadQueueBaseShipment
    {
        public int? LanguageId { get; set; }
    }

    public class BaseResult
    {
        public string Result { get; set; }
    }
}
