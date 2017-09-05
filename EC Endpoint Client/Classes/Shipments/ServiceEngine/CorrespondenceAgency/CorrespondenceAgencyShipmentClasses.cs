using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.CorrespondenceAgency;
using CorrespondenceStatusFilterV3 = EC_Endpoint_Client.CorrespondenceAgency.CorrespondenceStatusFilterV3;
using InsertCorrespondenceV2 = EC_Endpoint_Client.CorrespondenceAgency.InsertCorrespondenceV2;

namespace EC_Endpoint_Client.Classes.Shipments.ServiceEngine.CorrespondenceAgency
{
    public class InsertCorrespondenceShipment : BaseShipment
    {
        public string SystemUserCode { get; set; }
        public string ExternalShipmentReference { get; set; }
        public InsertCorrespondenceV2 InsertCorrespondence { get; set; }
    }

    public class InsertCorrespondenceShipmentAEC : BaseShipment
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
            request = new CorrespondenceStatusFilterV3();
        }

        public CorrespondenceStatusFilterV3 request { get; set; }
    }

    
    public class GetCorrespondenceStatusHistoryShipment : BaseShipment
    {
        public GetCorrespondenceStatusHistoryShipment()
        {
        }

        public string[] request { get; set; }
    }

    public class CorrespondenceStatusHistoryResultEx
    {
        public CorrespondenceStatusHistoryResultEx(CorrespondenceStatusHistoryResult input)
        {
            correspondenceStatusInformation = input.CorrespondenceStatusInformation;
            sdpStatusInformation = input.SdpStatusInformation;
        }

        public CorrespondenceStatusHistoryResultEx()
        {
            correspondenceStatusInformation = new CorrespondenceStatusInformation();
            sdpStatusInformation = new SdpStatusInformation();
        }

        public CorrespondenceStatusInformation correspondenceStatusInformation { get; set; }
        public SdpStatusInformation sdpStatusInformation { get; set; }
    }

    public class GetCorrespondenceStatusDetailsAECShipment : BaseShipment
    {
        public GetCorrespondenceStatusDetailsAECShipment()
        {
            request = new CorrespondenceAgencyNoSystem.CorrespondenceStatusFilterV3();
        }

        public CorrespondenceAgencyNoSystem.CorrespondenceStatusFilterV3 request { get; set; }
    }

    public class GetCorrespondenceStatusHistoryAECShipment : BaseShipment
    {
        public GetCorrespondenceStatusHistoryAECShipment()
        {
        }

        public string[] request { get; set; }
    }

    public class CorrespondenceStatusHistoryAECResult
    {
        public CorrespondenceStatusHistoryAECResult(
            CorrespondenceAgencyNoSystem.CorrespondenceStatusHistoryResultExternalBE input)
        {
            this.CorrespondenceStatusInformation = input.CorrespondenceStatusInformation;
            this.SdpStatusInformation = input.SdpStatusInformation;
        }
        public CorrespondenceAgencyNoSystem.CorrespondenceStatusInformation CorrespondenceStatusInformation { get; set; }
        public CorrespondenceAgencyNoSystem.SdpStatusInformation SdpStatusInformation { get; set; }
    }
}
