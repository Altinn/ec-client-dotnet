using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Endpoint_Client.Classes
{
    class SOAShipment : BaseShipment
    {
        public int ReporteeElementID { get; set; }
        public int? LanguageID { get; set; }
    }
}
