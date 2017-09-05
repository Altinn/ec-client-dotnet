using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.ReceiptAgency;

namespace EC_Endpoint_Client.Classes.Shipments.Intermediary.ReceiptAgency
{
    public class ReceiptSearchExternalShipment : BaseShipment
    {
        public ReceiptSearchExternalShipment()
        {
            this.ReceiptSearch = new ReceiptSearchExternal();
            this.ReceiptSearch.References = new ReferenceList();
        }
        public ReceiptSearchExternal ReceiptSearch { get; set; }
    }
    public class ReceiptV2SearchExternalShipment : BaseShipment
    {
        public ReceiptV2SearchExternalShipment()
        {
            this.ReceiptSearch = new ReceiptSearchExternal();
            this.ReceiptSearch.References = new ReferenceList();
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
            this.ReceiptSave = new ReceiptSaveExternal();
            this.ReceiptSave.SubReceipts = new ReceiptSaveExternalList();
            this.ReceiptSave.References = new ReferenceList();
        }
        public ReceiptSaveExternal ReceiptSave { get; set; }
    }
    public class ReceiptUpdateExternalShipment : BaseShipment
    {
        public ReceiptUpdateExternalShipment()
        {
            this.ReceiptSave = new ReceiptSaveExternal();
            this.ReceiptSave.SubReceipts = new ReceiptSaveExternalList();
            this.ReceiptSave.References = new ReferenceList();
        }
        public ReceiptSaveExternal ReceiptSave { get; set; }
    }
}
