using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine.Correspondence
{
    public class CorrespondenceShipmentBase : BaseShipment
    {
        public int ReporteeElementID { get; set; }
    }

    public class GetCorrespondenceShipment : CorrespondenceShipmentBase
    {
        public int LanguageID { get; set; }
    }
}
