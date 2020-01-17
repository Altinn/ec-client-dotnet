using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.CorrespondenceAgency;
using EC_Endpoint_Client.CorrespondenceAgencyEC2;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine.Correspondence
{
    public class CorrespondenceAgencyEndPointFunctionEC2 : EndPointFunctionalityBase
    {
        private string _context = "CorrespondenceAgency";
        private CorrespondenceAgencyExternalEC2Client GenerateProxy(BaseShipment shipment)
        {
            return
                base.GenerateProxy<CorrespondenceAgencyExternalEC2Client, ICorrespondenceAgencyExternalEC2>(
                    shipment.EndpointName, shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "Test";
            client.Test();
        }

        public ReceiptExternal InsertCorrespondence(InsertCorrespondenceShipmentEC2 shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "InsertCorrespondence";
            return client.InsertCorrespondenceEC(shipment.Username, shipment.Password, shipment.SystemUserCode, shipment.ExternalShipmentReference, shipment.InsertCorrespondence);
        }

        public CorrespondenceStatusResultV3 GetCorrespondenceDetailsV3(GetCorrespondenceStatusDetailsShipmentEC2 shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "GetCorrespondenceDetailsStatus";
            return client.GetCorrespondenceStatusDetailsECV3(shipment.Username, shipment.Password, shipment.Request);
        }

        public CorrespondenceStatusHistoryResultExEC2 GetCorrespondenceStatusHistory(GetCorrespondenceStatusHistoryShipmentEC2 shipment)
        {
            using (var client = GenerateProxy(shipment))
            {
                OperationContext = _context + "GetcorrespondenceStatusHistory";
                //TODO: Fix the out parameter is just burried
                SdpStatusInformation sdpStatusInformation;
                CorrespondenceStatusInformation output1 = client.GetCorrespondenceStatusHistoryEC(shipment.Password,
                    shipment.Username, shipment.Request, out sdpStatusInformation);
                return new CorrespondenceStatusHistoryResultExEC2(output1, sdpStatusInformation);
            }
        }
    }
}
