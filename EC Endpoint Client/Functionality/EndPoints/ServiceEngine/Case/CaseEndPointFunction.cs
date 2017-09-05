using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.Case;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.Case;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine
{
    class CaseEndPointFunction : EndPointFunctionalityBase
    {
        private CaseECClient GenerateProxy(BaseShipment shipment)
        {
            return base.GenerateProxy<CaseECClient, ICaseEC>(shipment.EndpointName, shipment.Certificate);
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
            return client.ArchiveCaseEC(shipment.Username, shipment.Password, shipment.CaseID, shipment.ForceArchive);
        }

        public CaseBEList GetCaseList(CaseListShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "Case" + "GetCaseList";
            return client.GetCaseListEC(shipment.Username, shipment.Password, shipment.CaseID, shipment.ExternalServiceCode, shipment.ExternalServiceEditionCode, shipment.LanguageID, shipment.ReporteeNumber);
        }

        public int InstantiateCollaboration(InstantiateCollaborationShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "Case" + "InstantiateCollaboration";
            return client.InstantiateCollaborationEC(shipment.Username, shipment.Password, shipment.ExternalServiceCode, shipment.ExternalServiceEditionCode, shipment.ReporteeNumber, shipment.ExternalSystemReference, shipment.VisibleDateTime, shipment.DueDate);
        }
    }
}
