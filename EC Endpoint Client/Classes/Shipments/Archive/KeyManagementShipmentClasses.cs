using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Endpoint_Client.Classes
{
    public class KeyManagementShipmentClass : BaseShipment
    {
        public string ExternalServiceCode { get; set; }
        public int ExternalServiceEditionCode { get; set; }
    }
}
