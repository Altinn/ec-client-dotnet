using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using EC_Endpoint_Client.IntermediaryInbound;
using EC_Endpoint_Client.IntermediaryInboundStreamed;

namespace EC_Endpoint_Client.Classes.Shipments
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
        public int ReporteeElementID { get; set; }
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
        public int LanguageID { get; set; }
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
        public int ReporteeElementID { get; set; }
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
        public int _ParentReceiptID;
        [Browsable(true)]
        [XmlIgnore]
        public string _ReceiptHistory;
        [Browsable(true)]
        [XmlIgnore]
        public int _ReceiptID;
        [Browsable(true)]
        [XmlIgnore]
        public string _ReceiptStatusCode;
        [Browsable(true)]
        [XmlIgnore]
        public string _ReceiptText;
        [Browsable(true)]
        [XmlIgnore]
        public string _ReceiptTypeName;
        public int ParentReceiptID
        { 
            get { return _ParentReceiptID; }
            set { _ParentReceiptID = value; }
        }
        public string ReceiptHistory 
        { 
            get { return _ReceiptHistory; }
            set { _ReceiptHistory = value; }
        }
        public int ReceiptID { 
            get { return _ReceiptID; }
            set { _ReceiptID = value; }
        }
        public string ReceiptStatusCode { get { return _ReceiptStatusCode; }
            set { _ReceiptStatusCode = value; }
        }
        public string ReceiptText { get { return _ReceiptText; }
            set { _ReceiptText = value; }
        }
        public string ReceiptTypeName { get { return _ReceiptTypeName; }
            set { _ReceiptTypeName = value; }
        }
    }
}
