using System.ComponentModel;
using System.Xml.Serialization;
using EC_Endpoint_Client.BrokerServiceEC2;
using File = System.IO.File;
// ReSharper disable InconsistentNaming

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine.BrokerService
{
    public class InitiateBrokerServiceShipmentEC2 : BaseShipment
    {
        public BrokerServiceInitiation BrokerServiceInitiation { get; set; }

        public InitiateBrokerServiceShipmentEC2()
        {
            BrokerServiceInitiation = new BrokerServiceInitiation
            {
                Manifest = new Manifest(),
                RecipientList = new Recipient[] { }
            };
        }
    }

    public class GetAvailableFilesShipmentEC2 : BaseShipment
    {
        public BrokerServiceSearch BrokerServiceSearch { get; set; }

        public GetAvailableFilesShipmentEC2()
        {
            BrokerServiceSearch = new BrokerServiceSearch();
        }
    }

    public class UploadFileStreamedShipmentEC2 : BaseShipment
    {
        public string Reportee { get; set; }
        public string FileReference { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }

        public bool AttachmentDataLoaded
        {
            get
            {
                if (!string.IsNullOrEmpty(FilePath))
                    return File.Exists(FilePath);
                return false;
            }
        }
    }

    public class BrokerServicePollShipment : BaseShipment
    {
        public BrokerServicePoll Poll { get; set; }
        public BrokerServicePollShipment()
        {
            Poll = new BrokerServicePoll();
        }
    }

    public class DownloadFileStreamedShipmentEC2 : BaseShipment
    {
        public string FileReference { get; set; }
        public string Reportee { get; set; }
    }

    public class UploadFileStreamedResultEC2
    {
        [Browsable(true)]
        [XmlIgnore]
        public int _ParentReceiptId;
        [Browsable(true)]
        [XmlIgnore]
        public string _ReceiptHistory;
        [Browsable(true)]
        [XmlIgnore]
        public int _ReceiptId;
        [Browsable(true)]
        [XmlIgnore]
        public string _ReceiptStatusCode;
        [Browsable(true)]
        [XmlIgnore]
        public string _ReceiptText;
        [Browsable(true)]
        [XmlIgnore]
        public string _ReceiptTypeName;
        public int ParentReceiptId
        {
            get { return _ParentReceiptId; }
            set { _ParentReceiptId = value; }
        }
        public string ReceiptHistory
        {
            get { return _ReceiptHistory; }
            set { _ReceiptHistory = value; }
        }
        public int ReceiptId
        {
            get { return _ReceiptId; }
            set { _ReceiptId = value; }
        }
        public string ReceiptStatusCode
        {
            get { return _ReceiptStatusCode; }
            set { _ReceiptStatusCode = value; }
        }
        public string ReceiptText
        {
            get { return _ReceiptText; }
            set { _ReceiptText = value; }
        }
        public string ReceiptTypeName
        {
            get { return _ReceiptTypeName; }
            set { _ReceiptTypeName = value; }
        }
    }
}
