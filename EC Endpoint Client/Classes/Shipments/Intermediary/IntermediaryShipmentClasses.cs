using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;
using EC_Endpoint_Client.IntermediaryInbound;

namespace EC_Endpoint_Client.Classes.Shipments.Intermediary
{
    public class IntermediaryInboundShipment : BaseShipment
    {
        public IntermediaryInboundShipment()
        {
            FormTaskShipment = new FormTaskShipmentBE();
            FormTaskShipment.FormTasks = new FormTask();
        }
        public FormTaskShipmentBE FormTaskShipment { get; set; }
    }

    public class UpdateFormDataInput : BaseShipment
    {
        public UpdateFormDataInput()
        {
            FormTaskUpdate = new FormTaskUpdate();
            FormTaskUpdate.FormUpdateList = new FormUpdateList();
        }

        public FormTaskUpdate FormTaskUpdate{ get; set; }
    }

    public class SubmissionStatusWrapper
    {
        public int SubmissionStatus { get; set; }
    }

    public class IntermediarySignShipment : BaseShipment
    {
        public IntermediarySignShipment()
        {
            SignatureList = new SignatureList();
        }
        public int ReporteeElementId { get; set; }
        [XmlIgnore]
        public Signature[] Signatures
        {
            get { return SignatureList.ToArray(); }
            set
            {
                SignatureList = new SignatureList();
                foreach (Signature sign in value)
                {
                    SignatureList.Add(sign);
                }
            }
        }
        [Browsable(false)]
        public SignatureList SignatureList { get; set; }
        public int LanguageId { get; set; }
    }

    public class IntermediaryStreamedSubmitAttachmentShipment : BaseShipment
    {
        [Category("Shipment Data")]
        public string AttachmentTypeName {get;set;}
        [Category("Shipment Data")]
        public string CheckSum { get; set; }
        [Category("Shipment Data")]
        public string EndUserSystemReference { get; set; }
        [Category("Shipment Data")]
        public string FileName { get; set; }
        [Category("Shipment Data")]
        public string Name { get; set; }
        [Category("Shipment Data")]
        public int ReporteeElementId { get; set; }
        [Category("Info")]
        public bool AttachmentDataLoaded
        {
            get
            {
                if(FilePath != null && FilePath.Length > 0)
                    return File.Exists(FilePath);
                return false;
            }
        }
        [Category("Info")]
        public string FileSize
        {
            get;
            set;
        }
        [Browsable(false)]
        public string FilePath { get; set; }
    }

    public class IntermediaryStreamedAttachmentResult
    {
        [Browsable(true)]
        [XmlIgnore]
        public int ParentReceiptId;
        [Browsable(true)]
        [XmlIgnore]
        public string ReceiptHistory;
        [Browsable(true)]
        [XmlIgnore]
        public int ReceiptId;
        [Browsable(true)]
        [XmlIgnore]
        public string ReceiptStatusCode;
        [Browsable(true)]
        [XmlIgnore]
        public string ReceiptText;
        [Browsable(true)]
        [XmlIgnore]
        public string ReceiptTypeName;
    }
}
