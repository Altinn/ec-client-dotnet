using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using EC_Endpoint_Client.BrokerService;
using EC_Endpoint_Client.BrokerServiceStreamed;
using File = System.IO.File;

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine.BrokerService
{
    public class InitiateBrokerServiceShipment : BaseShipment
    {
        public BrokerServiceInitiation BrokerServiceInitiation { get; set; }

        public InitiateBrokerServiceShipment()
        {
            BrokerServiceInitiation = new BrokerServiceInitiation
            {
                Manifest = new Manifest(),
                RecipientList = new Recipient[] { }
            };
        }
    }

    public class GetAvailableFilesShipment : BaseShipment
    {
        public BrokerServiceSearch BrokerServiceSearch { get; set; }

        public GetAvailableFilesShipment()
        {
            BrokerServiceSearch = new BrokerServiceSearch();
        }
    }

    public class UploadFileStreamedShipment : BaseShipment
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

    public class DownloadFileStreamedShipment : BaseShipment
    {
        public string FileReference { get; set; }
        public string Reportee { get; set; }
    }

    public class UploadFileStreamedResult
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
        public int ReceiptID
        {
            get { return _ReceiptID; }
            set { _ReceiptID = value; }
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
