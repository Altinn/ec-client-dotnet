using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.CaseAgencySystem;

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine.CaseAgency
{
    public class CaseListShipment : BaseShipment
    {
        public int CaseID { get; set; }
        public string ExternalServiceCode { get; set; }
        public int ExternalServiceEditionCode { get; set; }
        public int LanguageID { get; set; }
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
            this.NotificationInfo = new StateMachineEventNotificationBE();
        }
        public StateMachineEventNotificationBE NotificationInfo { get; set; }
    }

    public class SetNoticeShipment : BaseShipment
    {
        public SetNoticeShipment()
        {
            this.NoticeInfo = new NoticeBE();
            this.NoticeInfo.NoticeTokens = new NoticeTokenBEList();
        }
        public string ReporteeElementID { get; set; }
        public NoticeBE NoticeInfo { get; set; }
    }
}
