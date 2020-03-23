using EC_Endpoint_Client.CorrespondenceAgency;
using EC_Endpoint_Client.CorrespondenceAgencyNoSystem;
using CorrespondenceStatusFilterV3 = EC_Endpoint_Client.CorrespondenceAgency.CorrespondenceStatusFilterV3;
using CorrespondenceStatusInformation = EC_Endpoint_Client.CorrespondenceAgency.CorrespondenceStatusInformation;
using InsertCorrespondenceV2 = EC_Endpoint_Client.CorrespondenceAgency.InsertCorrespondenceV2;
using SdpStatusInformation = EC_Endpoint_Client.CorrespondenceAgency.SdpStatusInformation;

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine.CorrespondenceAgency
{
    public class InsertCorrespondenceShipment : BaseShipment
    {
        public string SystemUserCode { get; set; }
        public string ExternalShipmentReference { get; set; }
        public InsertCorrespondenceV2 InsertCorrespondence { get; set; }
    }

    public class InsertCorrespondenceShipmentAec : BaseShipment
    {
        public string ExternalShipmentReference { get; set; }
        public CorrespondenceAgencyNoSystem.InsertCorrespondenceV2 InsertCorrespondence { get; set; }
    }

    public class GetCorrespondenceStatus : BaseShipment
    {
        public CorrespondenceAgencyNoSystem.CorrespondenceStatusFilterV3 CorrespondenceStatusFilter { get; set; }
    }

    public class GetCorrespondenceStatusDetailsShipment : BaseShipment
    {
        public GetCorrespondenceStatusDetailsShipment()
        {
            Request = new CorrespondenceStatusFilterV3();
        }

        public CorrespondenceStatusFilterV3 Request { get; set; }
    }

    
    public class GetCorrespondenceStatusHistoryShipment : BaseShipment
    {
        public GetCorrespondenceStatusHistoryShipment()
        {
        }

        public string[] Request { get; set; }
    }

    public class CorrespondenceStatusHistoryResultEx
    {
        public CorrespondenceStatusHistoryResultEx(CorrespondenceStatusInformation input, SdpStatusInformation inputsdp)
        {
            CorrespondenceStatusInformation = input;
            SdpStatusInformation = inputsdp;
        }

        public CorrespondenceStatusHistoryResultEx()
        {
            CorrespondenceStatusInformation = new CorrespondenceStatusInformation();
            SdpStatusInformation = new SdpStatusInformation();
        }

        public CorrespondenceStatusInformation CorrespondenceStatusInformation { get; set; }
        public SdpStatusInformation SdpStatusInformation { get; set; }
    }

    public class GetCorrespondenceStatusDetailsAecShipment : BaseShipment
    {
        public GetCorrespondenceStatusDetailsAecShipment()
        {
            Request = new CorrespondenceAgencyNoSystem.CorrespondenceStatusFilterV3();
        }

        public CorrespondenceAgencyNoSystem.CorrespondenceStatusFilterV3 Request { get; set; }
    }

    public class GetCorrespondenceStatusHistoryAecShipment : BaseShipment
    {
        public GetCorrespondenceStatusHistoryAecShipment()
        {
        }

        public string[] Request { get; set; }
    }

    public class CorrespondenceStatusHistoryAecResult
    {
        public CorrespondenceStatusHistoryAecResult(CorrespondenceAgencyNoSystem.CorrespondenceStatusInformation corrInfo, CorrespondenceAgencyNoSystem.SdpStatusInformation sdpInfo)
        {
            CorrespondenceStatusInformation = corrInfo;
            SdpStatusInformation = sdpInfo;
        }

        public CorrespondenceStatusHistoryAecResult(
            CorrespondenceStatusHistoryResultExternalBE input)
        {
            CorrespondenceStatusInformation = input.CorrespondenceStatusInformation;
            SdpStatusInformation = input.SdpStatusInformation;
        }
        public CorrespondenceAgencyNoSystem.CorrespondenceStatusInformation CorrespondenceStatusInformation { get; set; }
        public CorrespondenceAgencyNoSystem.SdpStatusInformation SdpStatusInformation { get; set; }
    }
}
