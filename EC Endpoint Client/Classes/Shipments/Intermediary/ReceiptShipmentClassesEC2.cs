using System;
using EC_Endpoint_Client.ReceiptEC2;

namespace EC_Endpoint_Client.Classes.Shipments.Intermediary
{
    public class ReceiptSearchExternalShipmentEC2 : BaseShipment
    {
        public ReceiptSearchExternalShipmentEC2()
        {
            ReceiptSearch = new ReceiptSearchExternal();
            ReceiptSearch.References = new ReferenceList();
        }
        public ReceiptSearchExternal ReceiptSearch { get; set; }
    }
    public class ReceiptV2SearchExternalShipmentEC2 : BaseShipment
    {
        public ReceiptV2SearchExternalShipmentEC2()
        {
            ReceiptSearch = new ReceiptSearch();
            ReceiptSearch.References = new ReferenceList1();
        }
        public ReceiptSearch ReceiptSearch { get; set; }
    }
    public class ReceiptListSearchExternalShipmentEC2 : BaseShipment
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public ReceiptTypeEnum ReceiptType { get; set; }
    }
    public class ReceiptListV2SearchExternalShipmentEC2 : BaseShipment
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public ReceiptType ReceiptType { get; set; }
    }
    public class ReceiptSaveExternalShipmentEC2 : BaseShipment
    {
        public ReceiptSaveExternalShipmentEC2()
        {
            ReceiptSave = new ReceiptSaveExternal();
            ReceiptSave.SubReceipts = new ReceiptSaveExternalList();
            ReceiptSave.References = new ReferenceList();
        }
        public ReceiptSaveExternal ReceiptSave { get; set; }
    }
    public class ReceiptUpdateExternalShipmentEC2 : BaseShipment
    {
        public ReceiptUpdateExternalShipmentEC2()
        {
            ReceiptSave = new ReceiptSave();
            ReceiptSave.SubReceipts = new ReceiptSaveList();
            ReceiptSave.References = new ReferenceList1();
        }
        public ReceiptSave ReceiptSave { get; set; }
    }
}
