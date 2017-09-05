using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.Classes;

namespace EC_Endpoint_Client
{
    public class GetReporteesShipment : BaseShipment
    {
        public string SSN { get; set; }
        public bool RetrieveInactiveReportee { get; set; }
        public bool RetrieveSubEntity { get; set; }
        public int? MaximumReporteeCount { get; set; }
    }

    public class GetReporteeByTempKeyShipment : BaseShipment
    {
        public Guid TempKey { get; set; }
    }

    public class GetTokenByAuthorizationCodeShipment : BaseShipment
    {
        public bool SelfContainedToken { get; set; }
        public Guid AuthorizationCode { get; set; }
    }
}
