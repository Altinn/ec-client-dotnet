using System;
using EC_Endpoint_Client.Service_References.CaseAgencySystem;

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine.CaseAgency
{
    public class CaseListShipment : BaseShipment
    {
        public int CaseId { get; set; }
        public string ExternalServiceCode { get; set; }
        public int ExternalServiceEditionCode { get; set; }
        public int LanguageId { get; set; }
        public string ReporteeNumber { get; set; }
    }

    public class InstantiateCollaborationShipment : BaseShipment
    {
        public string ExternalServiceCode { get; set; }
        public int ExternalServiceEditionCode { get; set; }
        public string ReporteeNumber { get; set; }
        public DateTime VisibleDateTime { get; set; }
        public DateTime DueDate { get; set; }
    }

    public class NotifyEventShipment : BaseShipment
    {
        public NotifyEventShipment()
        {
            NotificationInfo = new StateMachineEventNotificationBE();
        }
        public StateMachineEventNotificationBE NotificationInfo { get; set; }
    }

    public class SetNoticeShipment : BaseShipment
    {
        public SetNoticeShipment()
        {
            NoticeInfo = new NoticeBE();
            NoticeInfo.NoticeTokens = new NoticeTokenBEList();
        }
        public string ReporteeElementId { get; set; }
        public NoticeBE NoticeInfo { get; set; }
    }
}
