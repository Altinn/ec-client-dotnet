using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.PrefillEUS;
using EC_Endpoint_Client.PrefillEUS;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine.Prefill
{
    class PrefillEUSEndPointFunction : EndPointFunctionalityBase
    {
        private string Context = "PrefillEUS";
        private PreFillEUSExternalECClient GenerateProxy(BaseShipment shipment)
        {
            return base.GenerateProxy<PreFillEUSExternalECClient, IPreFillEUSExternalEC>(shipment.EndpointName,
                shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "Test";
            client.Test();
        }

        public PrefillDataBE GetPrefillData(GetPrefillDataShipmentBase shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "GetPrefillData";
            return client.GetPrefillDataEC(shipment.Username, shipment.Password, shipment.ReporteeNumber, shipment.ExternalServiceCode, shipment.ExternalServiceEditionCode);
        }

        public PrefillDataBEv2 GetPrefillDataV2(GetPrefillDataV2Shipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "GetPrefillDataV2";
            return client.GetPrefillDataECV2(shipment.Username, shipment.Password, shipment.ReporteeNumber, shipment.ExternalServiceCode, shipment.ExternalServiceEditionCode, shipment.PrefillBEList);
        }
    }
}
