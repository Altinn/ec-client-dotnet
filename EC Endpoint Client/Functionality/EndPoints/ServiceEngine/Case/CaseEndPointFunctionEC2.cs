using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.Case;
using EC_Endpoint_Client.CaseEC2;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine.Case
{
    class CaseEndPointFunctionEC2 : EndPointFunctionalityBase
    {
        private CaseEC2Client GenerateProxy(BaseShipment shipment)
        {
            return base.GenerateProxy<CaseEC2Client, ICaseEC2>(shipment.EndpointName, shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "CaseTest";
            client.Test();
        }

        public int ArchiveCase(ArchiveCaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "CaseArchiveCase";
            return client.ArchiveCaseEC(shipment.Username, shipment.Password, shipment.CaseId, shipment.ForceArchive);
        }

        public CaseBEList GetCaseList(CaseListShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "Case" + "GetCaseList";
            return client.GetCaseListEC(shipment.Username, shipment.Password, shipment.CaseId, shipment.ExternalServiceCode, shipment.ExternalServiceEditionCode, shipment.LanguageId, shipment.ReporteeNumber);
        }

        public int InstantiateCollaboration(InstantiateCollaborationShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "Case" + "InstantiateCollaboration";
            return client.InstantiateCollaborationEC(shipment.Username, shipment.Password, shipment.ExternalServiceCode, shipment.ExternalServiceEditionCode, shipment.ReporteeNumber, shipment.ExternalSystemReference, shipment.VisibleDateTime, shipment.DueDate);
        }
    }
}
