using EC_Endpoint_Client.LookUpEC2;

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine.LookUp

{
    public class LookUpShipmentEC2 : BaseShipment
    {
        public LookUpRequest LookUpRequest { get; set; }

        public LookUpShipmentEC2()
        {
            LookUpRequest = new LookUpRequest
            {
                Reportee = string.Empty,
                ServiceCode = string.Empty,
                ServiceEditionCode = 0,
                QueryData = string.Empty
            };
        }
    }

}
