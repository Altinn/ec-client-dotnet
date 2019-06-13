using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.Correspondence;
using EC_Endpoint_Client.Service_References.Correspondence;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine.Correspondence
{
    public class CorrespondenceEndPointFunction : EndPointFunctionalityBase
    {
        private string _context = "Correspondence";
        private CorrespondenceExternalECClient GenerateProxy(BaseShipment shipment)
        {
            return base.GenerateProxy<CorrespondenceExternalECClient, ICorrespondenceExternalEC>(shipment.EndpointName,
                shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "Test";
            client.Test();
        }

        public Receipt ArchiveCorrespondence(CorrespondenceShipmentBase shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "ArchiveCorrespondence";
            return client.ArchiveCorrespondenceForEndUserSystemEC(shipment.Username, shipment.Password, shipment.ReporteeElementId);
        }

        public CorrespondenceForEndUserSystemV2 GetCorrespondence(GetCorrespondenceShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "GetCorrespondence";
            var corres =  client.GetCorrespondenceForEndUserSystemsEC(shipment.Username, shipment.Password, shipment.ReporteeElementId, shipment.LanguageId);
            return corres;
        }

        public void SaveCorrespondenceConfirmation(CorrespondenceShipmentBase shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "SaveCorrespondenceConfirmation";
            client.SaveCorrespondenceConfirmationEC(shipment.Username, shipment.Password, shipment.ReporteeElementId);
        }
    }
}
