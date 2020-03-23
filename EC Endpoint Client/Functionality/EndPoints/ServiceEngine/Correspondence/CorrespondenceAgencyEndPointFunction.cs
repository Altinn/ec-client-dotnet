using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.CorrespondenceAgency;
using EC_Endpoint_Client.CorrespondenceAgency;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine.Correspondence
{
    public class CorrespondenceAgencyEndPointFunction : EndPointFunctionalityBase
    {
        private string _context = "CorrespondenceAgency";
        private CorrespondenceAgencyExternalECClient GenerateProxy(BaseShipment shipment)
        {
            return
                base.GenerateProxy<CorrespondenceAgencyExternalECClient, ICorrespondenceAgencyExternalEC>(
                    shipment.EndpointName, shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "Test";
            client.Test();
        }

        public ReceiptExternal InsertCorrespondence(InsertCorrespondenceShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "InsertCorrespondence";
            return client.InsertCorrespondenceEC(shipment.Username, shipment.Password, shipment.SystemUserCode, shipment.ExternalShipmentReference, shipment.InsertCorrespondence);
        }

        public CorrespondenceStatusResultV3 GetCorrespondenceDetailsV3(GetCorrespondenceStatusDetailsShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "GetCorrespondenceDetailsStatus";
            return client.GetCorrespondenceStatusDetailsECV3(shipment.Username, shipment.Password, shipment.Request);
        }

        public CorrespondenceStatusHistoryResultEx GetCorrespondenceStatusHistory(GetCorrespondenceStatusHistoryShipment shipment)
        {
            SdpStatusInformation info = new SdpStatusInformation();
            using (var client = GenerateProxy(shipment))
            {
                OperationContext = _context + "GetcorrespondenceStatusHistory";
                var result = client.GetCorrespondenceStatusHistoryEC(shipment.Password, shipment.Username, shipment.Request, out info);
                CorrespondenceStatusHistoryResultEx resultEx = new CorrespondenceStatusHistoryResultEx(result, info);
                return resultEx;
            }
        }
    }
}
