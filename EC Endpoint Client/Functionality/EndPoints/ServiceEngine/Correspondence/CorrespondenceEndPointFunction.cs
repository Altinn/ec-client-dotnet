using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.Correspondence;
using EC_Endpoint_Client.Correspondence;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine
{
    public class CorrespondenceEndPointFunction : EndPointFunctionalityBase
    {
        private string Context = "Correspondence";
        private CorrespondenceExternalECClient GenerateProxy(BaseShipment shipment)
        {
            return base.GenerateProxy<CorrespondenceExternalECClient, ICorrespondenceExternalEC>(shipment.EndpointName,
                shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "Test";
            client.Test();
        }

        public Correspondence.Receipt ArchiveCorrespondence(CorrespondenceShipmentBase shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "ArchiveCorrespondence";
            return client.ArchiveCorrespondenceForEndUserSystemEC(shipment.Username, shipment.Password, shipment.ReporteeElementID);
        }

        public CorrespondenceForEndUserSystemV2 GetCorrespondence(GetCorrespondenceShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "GetCorrespondence";
            var corres =  client.GetCorrespondenceForEndUserSystemsEC(shipment.Username, shipment.Password, shipment.ReporteeElementID, shipment.LanguageID);
            return corres;
        }

        public void SaveCorrespondenceConfirmation(CorrespondenceShipmentBase shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "SaveCorrespondenceConfirmation";
            client.SaveCorrespondenceConfirmationEC(shipment.Username, shipment.Password, shipment.ReporteeElementID);
        }
    }
}
