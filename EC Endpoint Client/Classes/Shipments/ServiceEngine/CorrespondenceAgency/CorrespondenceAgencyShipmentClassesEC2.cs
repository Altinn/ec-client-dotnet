using EC_Endpoint_Client.CorrespondenceAgencyEC2;
using EC_Endpoint_Client.CorrespondenceAgencyNoSystemEC2;
using CorrespondenceStatusFilterV3 = EC_Endpoint_Client.CorrespondenceAgencyEC2.CorrespondenceStatusFilterV3;
using CorrespondenceStatusInformation = EC_Endpoint_Client.CorrespondenceAgencyEC2.CorrespondenceStatusInformation;
using InsertCorrespondenceV2 = EC_Endpoint_Client.CorrespondenceAgencyEC2.InsertCorrespondenceV2;
using SdpStatusInformation = EC_Endpoint_Client.CorrespondenceAgencyEC2.SdpStatusInformation;

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine.CorrespondenceAgency
{
    public class InsertCorrespondenceShipmentEC2 : BaseShipment
    {
        public string SystemUserCode { get; set; }
        public string ExternalShipmentReference { get; set; }
        public InsertCorrespondenceV2 InsertCorrespondence { get; set; }
    }

    public class InsertCorrespondenceShipmentAec2 : BaseShipment
    {
        public string ExternalShipmentReference { get; set; }
        public CorrespondenceAgencyNoSystemEC2.InsertCorrespondenceV2 InsertCorrespondence { get; set; }
    }

    public class GetCorrespondenceStatusEC2 : BaseShipment
    {
        public CorrespondenceAgencyNoSystemEC2.CorrespondenceStatusFilterV3 CorrespondenceStatusFilter { get; set; }
    }

    public class GetCorrespondenceStatusDetailsShipmentEC2 : BaseShipment
    {
        public GetCorrespondenceStatusDetailsShipmentEC2()
        {
            Request = new CorrespondenceStatusFilterV3();
        }

        public CorrespondenceStatusFilterV3 Request { get; set; }
    }

    
    public class GetCorrespondenceStatusHistoryShipmentEC2 : BaseShipment
    {
        public GetCorrespondenceStatusHistoryShipmentEC2()
        {
        }

        public string[] Request { get; set; }
    }

    public class CorrespondenceStatusHistoryResultExEC2
    {
        public CorrespondenceStatusHistoryResultExEC2(CorrespondenceStatusInformation input1, SdpStatusInformation input2)
        {
            CorrespondenceStatusInformation = input1;
            SdpStatusInformation = input2;
        }

        public CorrespondenceStatusHistoryResultExEC2()
        {
            CorrespondenceStatusInformation = new CorrespondenceStatusInformation();
            SdpStatusInformation = new SdpStatusInformation();
        }

        public CorrespondenceStatusInformation CorrespondenceStatusInformation { get; set; }
        public SdpStatusInformation SdpStatusInformation { get; set; }
    }

    public class GetCorrespondenceStatusDetailsAec2Shipment : BaseShipment
    {
        public GetCorrespondenceStatusDetailsAec2Shipment()
        {
            Request = new CorrespondenceAgencyNoSystemEC2.CorrespondenceStatusFilterV3();
        }

        public CorrespondenceAgencyNoSystemEC2.CorrespondenceStatusFilterV3 Request { get; set; }
    }

    public class GetCorrespondenceStatusHistoryAec2Shipment : BaseShipment
    {
        public GetCorrespondenceStatusHistoryAec2Shipment()
        {
        }

        public string[] Request { get; set; }
    }

    public class CorrespondenceStatusHistoryAec2Result
    {
        public CorrespondenceStatusHistoryAec2Result(CorrespondenceAgencyNoSystemEC2.CorrespondenceStatusInformation corrStatus, CorrespondenceAgencyNoSystemEC2.SdpStatusInformation sdpStatus)
        {
            CorrespondenceStatusInformation = corrStatus;
            SdpStatusInformation = sdpStatus;
        }
        public CorrespondenceAgencyNoSystemEC2.CorrespondenceStatusInformation CorrespondenceStatusInformation { get; set; }
        public CorrespondenceAgencyNoSystemEC2.SdpStatusInformation SdpStatusInformation { get; set; }
    }
    
}
