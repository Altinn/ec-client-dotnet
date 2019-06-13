using System;
using EC_Endpoint_Client.Service_References.ReceiptAgency;

namespace EC_Endpoint_Client.Classes.Shipments.Intermediary.AgencyClasses
{
    public class ReceiptSearchExternalShipment : BaseShipment
    {
        public ReceiptSearchExternalShipment()
        {
            ReceiptSearch = new ReceiptSearchExternal();
            ReceiptSearch.References = new ReferenceList();
        }
        public ReceiptSearchExternal ReceiptSearch { get; set; }
    }
    public class ReceiptV2SearchExternalShipment : BaseShipment
    {
        public ReceiptV2SearchExternalShipment()
        {
            ReceiptSearch = new ReceiptSearchExternal();
            ReceiptSearch.References = new ReferenceList();
        }
        public ReceiptSearchExternal ReceiptSearch { get; set; }
    }
    public class ReceiptListSearchExternalShipment : BaseShipment
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public ReceiptTypeEnum ReceiptType { get; set; }
    }
    public class ReceiptListV2SearchExternalShipment : BaseShipment
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public ReceiptType ReceiptType { get; set; }
    }
    public class ReceiptSaveExternalShipment : BaseShipment
    {
        public ReceiptSaveExternalShipment()
        {
            ReceiptSave = new ReceiptSaveExternal();
            ReceiptSave.SubReceipts = new ReceiptSaveExternalList();
            ReceiptSave.References = new ReferenceList();
        }
        public ReceiptSaveExternal ReceiptSave { get; set; }
    }
    public class ReceiptUpdateExternalShipment : BaseShipment
    {
        public ReceiptUpdateExternalShipment()
        {
            ReceiptSave = new ReceiptSaveExternal();
            ReceiptSave.SubReceipts = new ReceiptSaveExternalList();
            ReceiptSave.References = new ReferenceList();
        }
        public ReceiptSaveExternal ReceiptSave { get; set; }
    }
}
