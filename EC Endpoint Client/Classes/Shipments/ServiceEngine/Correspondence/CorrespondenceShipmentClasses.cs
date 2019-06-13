namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine.Correspondence
{
    public class CorrespondenceShipmentBase : BaseShipment
    {
        public int ReporteeElementId { get; set; }
    }

    public class GetCorrespondenceShipment : CorrespondenceShipmentBase
    {
        public int LanguageId { get; set; }
    }
}
