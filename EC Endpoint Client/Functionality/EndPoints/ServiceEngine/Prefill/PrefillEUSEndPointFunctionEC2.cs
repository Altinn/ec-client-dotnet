using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.PrefillEUS;
using EC_Endpoint_Client.PrefillEUSEC2;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine.Prefill
{
    class PrefillEusEndPointFunctionEC2 : EndPointFunctionalityBase
    {
        private string _context = "PrefillEUS";
        private PreFillEUSExternalEC2Client GenerateProxy(BaseShipment shipment)
        {
            return base.GenerateProxy<PreFillEUSExternalEC2Client, IPreFillEUSExternalEC2>(shipment.EndpointName,
                shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "Test";
            client.Test();
        }

        public PrefillDataBE GetPrefillData(GetPrefillDataShipmentBaseEC2 shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "GetPrefillData";
            return client.GetPrefillDataEC(shipment.Username, shipment.Password, shipment.ReporteeNumber, shipment.ExternalServiceCode, shipment.ExternalServiceEditionCode);
        }

        public PrefillDataBEv2 GetPrefillDataV2(GetPrefillDataV2ShipmentEC2 shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "GetPrefillDataV2";
            return client.GetPrefillDataECV2(shipment.Username, shipment.Password, shipment.ReporteeNumber, shipment.ExternalServiceCode, shipment.ExternalServiceEditionCode, shipment.PrefillBeList, false);
        }
    }
}
