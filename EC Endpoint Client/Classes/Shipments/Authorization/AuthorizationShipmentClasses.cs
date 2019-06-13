using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace EC_Endpoint_Client.Classes.Shipments.Authorization
{
    public class GetReporteesShipment : BaseShipment
    {
        public string Ssn { get; set; }
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
        [Browsable(false)]
        [XmlIgnore]
        public X509Certificate2 SpiCertificate { get; set; }
    }
}
