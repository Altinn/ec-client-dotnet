using EC_Endpoint_Client.Service_References.CorrespondenceAgency;
using EC_Endpoint_Client.Service_References.CorrespondenceAgencyNoSystem;
using CorrespondenceStatusFilterV3 = EC_Endpoint_Client.Service_References.CorrespondenceAgency.CorrespondenceStatusFilterV3;
using CorrespondenceStatusInformation = EC_Endpoint_Client.Service_References.CorrespondenceAgency.CorrespondenceStatusInformation;
using InsertCorrespondenceV2 = EC_Endpoint_Client.Service_References.CorrespondenceAgency.InsertCorrespondenceV2;
using SdpStatusInformation = EC_Endpoint_Client.Service_References.CorrespondenceAgency.SdpStatusInformation;

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
        public Service_References.CorrespondenceAgencyNoSystem.InsertCorrespondenceV2 InsertCorrespondence { get; set; }
    }

    public class GetCorrespondenceStatus : BaseShipment
    {
        public Service_References.CorrespondenceAgencyNoSystem.CorrespondenceStatusFilterV3 CorrespondenceStatusFilter { get; set; }
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
        public CorrespondenceStatusHistoryResultEx(CorrespondenceStatusHistoryResult input)
        {
            CorrespondenceStatusInformation = input.CorrespondenceStatusInformation;
            SdpStatusInformation = input.SdpStatusInformation;
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
            Request = new Service_References.CorrespondenceAgencyNoSystem.CorrespondenceStatusFilterV3();
        }

        public Service_References.CorrespondenceAgencyNoSystem.CorrespondenceStatusFilterV3 Request { get; set; }
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
        public CorrespondenceStatusHistoryAecResult(
            CorrespondenceStatusHistoryResultExternalBE input)
        {
            CorrespondenceStatusInformation = input.CorrespondenceStatusInformation;
            SdpStatusInformation = input.SdpStatusInformation;
        }
        public Service_References.CorrespondenceAgencyNoSystem.CorrespondenceStatusInformation CorrespondenceStatusInformation { get; set; }
        public Service_References.CorrespondenceAgencyNoSystem.SdpStatusInformation SdpStatusInformation { get; set; }
    }
}
