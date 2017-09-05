using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.CaseAgencySystem;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.CaseAgency;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine
{
    class CaseAgencySystemEndPointFunction : EndPointFunctionalityBase
    {
        private CaseAgencySystemECClient GenerateProxy(BaseShipment shipment)
        {
            return base.GenerateProxy<CaseAgencySystemECClient, ICaseAgencySystemEC>(shipment.EndpointName,
                shipment.Certificate);
        }

        public void Test(BaseShipment Shipment)
        {
            var client = GenerateProxy(Shipment);
            OperationContext = "CaseAgencyTest";
            client.Test();
        }

        public ExternalCaseBEList GetCaseList(CaseListShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "CaseAgencyGetCaseList";
            return client.GetCaseListAgencySystemEC(shipment.Username, shipment.Password, shipment.CaseID, shipment.ExternalServiceCode, shipment.ExternalServiceEditionCode, shipment.LanguageID, shipment.ReporteeNumber);
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
            client.SetNoticeAgencySystemEC(shipment.Username, shipment.Password, shipment.ReporteeElementID, shipment.NoticeInfo);
        }
    }
}
