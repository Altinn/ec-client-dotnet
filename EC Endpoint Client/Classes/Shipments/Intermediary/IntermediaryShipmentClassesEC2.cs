using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;
using EC_Endpoint_Client.IntermediaryInboundEC2;

namespace EC_Endpoint_Client.Classes.Shipments.Intermediary
{
    public class IntermediaryInboundShipmentEC2 : BaseShipment
    {
        public IntermediaryInboundShipmentEC2()
        {
            FormTaskShipment = new FormTaskShipmentBE();
            FormTaskShipment.FormTasks = new FormTask();
        }
        public FormTaskShipmentBE FormTaskShipment { get; set; }
    }

    public class UpdateFormDataInputEC2 : BaseShipment
    {
        public UpdateFormDataInputEC2()
        {
            FormTaskUpdate = new FormTaskUpdate();
            FormTaskUpdate.FormUpdateList = new FormUpdateList();
        }

        public FormTaskUpdate FormTaskUpdate{ get; set; }
    }

    public class SubmissionStatusWrapperEC2
    {
        public int SubmissionStatus { get; set; }
    }

    public class IntermediarySignShipmentEC2 : BaseShipment
    {
        public IntermediarySignShipmentEC2()
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

    public class IntermediaryStreamedSubmitAttachmentShipmentEC2 : BaseShipment
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
        public bool AttachmentDataLoaded => !string.IsNullOrEmpty(FilePath) && File.Exists(FilePath);

        [Category("Info")]
        public string FileSize
        {
            get;
            set;
        }
        [Browsable(false)]
        public string FilePath { get; set; }
    }

    public class IntermediaryStreamedAttachmentResultEC2
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
