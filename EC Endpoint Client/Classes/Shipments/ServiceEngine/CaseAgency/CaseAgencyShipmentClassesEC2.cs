using System;
using EC_Endpoint_Client.CaseAgencySystemEC2;

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine.CaseAgency
{
    public class CaseListShipmentEC2 : BaseShipment
    {
        public int CaseId { get; set; }
        public string ExternalServiceCode { get; set; }
        public int ExternalServiceEditionCode { get; set; }
        public int LanguageId { get; set; }
        public string ReporteeNumber { get; set; }
    }

    public class InstantiateCollaborationShipmentEC2 : BaseShipment
    {
        public string ExternalServiceCode { get; set; }
        public int ExternalServiceEditionCode { get; set; }
        public string ReporteeNumber { get; set; }
        public DateTime VisibleDateTime { get; set; }
        public DateTime DueDate { get; set; }
    }

    public class NotifyEventShipmentEC2 : BaseShipment
    {
        public NotifyEventShipmentEC2()
        {
            NotificationInfo = new StateMachineEventNotificationBE();
        }
        public StateMachineEventNotificationBE NotificationInfo { get; set; }
    }

    public class SetNoticeShipmentEC2 : BaseShipment
    {
        public SetNoticeShipmentEC2()
        {
            NoticeInfo = new NoticeBE();
            NoticeInfo.NoticeTokens = new NoticeTokenBEList();
        }
        public string ReporteeElementId { get; set; }
        public NoticeBE NoticeInfo { get; set; }
    }
}
