using System;
using EC_Endpoint_Client.PrefillAgencyEC2;

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine.PrefillAgency
{
    public class SubmitAndInstantiatePrefillFormTaskShipmentEC2 : BaseShipment
    {
        public SubmitAndInstantiatePrefillFormTaskShipmentEC2()
        {
            PrefillFormTask = new PrefillFormTask();
            PrefillFormTask.PreFillAttachments = new PrefillAttachmentBEList();
            PrefillFormTask.PreFillForms = new PrefillFormBEList();
            PrefillFormTask.PreFillIdentityFields = new PreFillIdentityFieldBEList();
            PrefillFormTask.PrefillNotifications = new NotificationBEList();
        }
        
        public PrefillFormTask PrefillFormTask { get; set; }
        public string ExternalBatchId { get; set; }
        public bool DoSaveFormTask { get; set; }
        public bool DoInstantiateFormTask { get; set; }
        public int? CaseId { get; set; }
        public DateTime? DueDate { get; set; }
    }

    public class SubmitPrefillFormTaskShipmentEC2 : BaseShipment
    {
        public string ExternalBatchId { get; set; }
        public PrefillFormTaskDetails PrefillFormTask { get; set; }
    }
}
