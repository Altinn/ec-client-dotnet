namespace EC_Endpoint_Client.Classes.Shipments.Archive
{
    public class ReporteeArchiveShipment : ReporteeArchiveShipmentBase
    {
        public int? LanguageId { get; set; }
    }

    public class ReporteeArchiveAttachmentShipment : BaseShipment
    {
        public int AttachimentId { get; set; }
    }

    public class ReporteeArchiveLookupShipment : ReporteeArchiveShipmentBase
    {
        public int LanguageId { get; set; }
    }

    public class ReporteeArchiveShipmentBase : BaseShipment
    {
        public int ReporteeElementId { get; set; }
    }

    public class ReporteeArchiveCorrespondenceShipment : BaseShipment
    {
        public int ArchiveId { get; set; }
    }
}
