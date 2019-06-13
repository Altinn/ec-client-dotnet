using System;

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine.Case
{
    public class ArchiveCaseShipment : BaseShipment
    {
        public int CaseId { get; set; }
        public bool ForceArchive { get; set; }
    }

    public class CaseListShipment : BaseShipment
    {
        public int CaseId { get; set; }
        public string ExternalServiceCode { get; set; }
        public int ExternalServiceEditionCode { get; set; }
        public int LanguageId { get; set; }
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
