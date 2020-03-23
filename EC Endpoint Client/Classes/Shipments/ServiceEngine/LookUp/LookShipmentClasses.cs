using EC_Endpoint_Client.LookUp;

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine.LookUp

{
    public class LookUpShipment : BaseShipment
    {
        public LookUpRequest LookUpRequest { get; set; }

        public LookUpShipment()
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
