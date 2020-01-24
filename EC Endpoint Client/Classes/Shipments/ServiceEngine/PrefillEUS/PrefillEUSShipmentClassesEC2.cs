using EC_Endpoint_Client.PrefillEUSEC2;

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine.PrefillEUS
{
    public class GetPrefillDataShipmentBaseEC2 : BaseShipment
    {
        public string ReporteeNumber { get; set; }
        public string ExternalServiceCode { get; set; }
        public int ExternalServiceEditionCode { get; set; }
    }

    public class GetPrefillDataV2ShipmentEC2 : GetPrefillDataShipmentBase
    {
        public PreFillRequestBEList PrefillBeList { get; set; }
    }

    public class GetPrefillDataV2ShipmentExtEC2 : GetPrefillDataShipmentBase
    {
        public string[] PrefillBeList { get; set; }
    }
}
