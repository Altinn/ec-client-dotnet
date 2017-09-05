using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine.Case
{
    public class ArchiveCaseShipment : BaseShipment
    {
        public int CaseID { get; set; }
        public bool ForceArchive { get; set; }
    }

    public class CaseListShipment : BaseShipment
    {
        public int CaseID { get; set; }
        public string ExternalServiceCode { get; set; }
        public int ExternalServiceEditionCode { get; set; }
        public int LanguageID { get; set; }
        public string ReporteeNumber { get; set; }
    }

    public class InstantiateCollaborationShipment : BaseShipment
    {
        public string ExternalServiceCode { get; set; }
        public int ExternalServiceEditionCode { get; set; }
        public string ReporteeNumber { get; set; }
        public string ExternalSystemReference { get; set; }
        public DateTime VisibleDateTime { get; set; }
        public DateTime DueDate { get; set; }
    }

}
