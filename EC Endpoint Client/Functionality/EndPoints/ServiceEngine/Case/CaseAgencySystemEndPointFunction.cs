using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.CaseAgency;
using EC_Endpoint_Client.CaseAgencySystem;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine.Case
{
    class CaseAgencySystemEndPointFunction : EndPointFunctionalityBase
    {
        private CaseAgencySystemECClient GenerateProxy(BaseShipment shipment)
        {
            return base.GenerateProxy<CaseAgencySystemECClient, ICaseAgencySystemEC>(shipment.EndpointName,
                shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "CaseAgencyTest";
            client.Test();
        }

        public ExternalCaseBEList GetCaseList(CaseListShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "CaseAgencyGetCaseList";
            return client.GetCaseListAgencySystemEC(shipment.Username, shipment.Password, shipment.CaseId, shipment.ExternalServiceCode, shipment.ExternalServiceEditionCode, shipment.LanguageId, shipment.ReporteeNumber);
        }

        public int InstantiateCollaboration(InstantiateCollaborationShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "CaseAgencyGetInstantiateCollaboration";
            return client.InstantiateCollaborationAgencySystemEC(shipment.Username, shipment.Password, shipment.ExternalServiceCode, shipment.ExternalServiceEditionCode, shipment.ReporteeNumber, shipment.VisibleDateTime, shipment.DueDate);
        }

        public StateMachineNotificationResultBEList NotifyEvent(NotifyEventShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "CaseAgencyNotifyEvent";
            return client.NotifyEventAgencySystemEC(shipment.Username, shipment.Password, shipment.NotificationInfo);
        }

        public void SetNotice(SetNoticeShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "CaseAgencySetNotice";
            client.SetNoticeAgencySystemEC(shipment.Username, shipment.Password, shipment.ReporteeElementId, shipment.NoticeInfo);
        }
    }
}
