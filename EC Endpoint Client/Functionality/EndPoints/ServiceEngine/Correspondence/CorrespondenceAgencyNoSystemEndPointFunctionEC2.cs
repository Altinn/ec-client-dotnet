using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.CorrespondenceAgency;
using EC_Endpoint_Client.CorrespondenceAgencyNoSystemEC2;
using CorrespondenceStatusInformation = EC_Endpoint_Client.CorrespondenceAgencyEC2.CorrespondenceStatusInformation;
using ReceiptExternal = EC_Endpoint_Client.CorrespondenceAgencyNoSystemEC2.ReceiptExternal;
using SdpStatusInformation = EC_Endpoint_Client.CorrespondenceAgencyEC2.SdpStatusInformation;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine.Correspondence
{
    //TODO: Update this class to handle the https://at03.ai.basefarm.net/ServiceEngineExternal/CorrespondenceAgencyExternalAEC2.svc?wsdl
    public class CorrespondenceAgencyNoSystemEndPointFunctionEC2 : EndPointFunctionalityBase
    {
        private string _context = "CorrespondenceAgencyNoSystem";

        private CorrespondenceAgencyExternalAEC2Client GenerateProxy(BaseShipment shipment)
        {
            return
                base.GenerateProxy<CorrespondenceAgencyExternalAEC2Client, ICorrespondenceAgencyExternalAEC2>(
                    shipment.EndpointName, shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "Test";
            client.Test();
        }

        public ReceiptExternal InsertCorrespondence(InsertCorrespondenceShipmentAec2 shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "InsertCorrespondence";
            return client.InsertCorrespondenceAECV2(shipment.ExternalShipmentReference, shipment.InsertCorrespondence);
        }

        public CorrespondenceStatusResultV3 GetCorrespondenceDetailsV3(GetCorrespondenceStatusEC2 filter)
        {
            var client = GenerateProxy(filter);
            OperationContext = _context + "GetCorrespondenceDetails";
            return client.GetCorrespondenceStatusDetailsAECV3(filter.CorrespondenceStatusFilter);
        }


        public CorrespondenceStatusResultV3 GetCorrespondenceDetailsV3(GetCorrespondenceStatusDetailsAec2Shipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "GetCorrespondenceDetailsStatus";
            return client.GetCorrespondenceStatusDetailsAECV3(shipment.Request);
        }

        public CorrespondenceStatusHistoryAec2Result GetCorrespondenceStatusHistory(GetCorrespondenceStatusHistoryAec2Shipment shipment)
        {
            using (var client = GenerateProxy(shipment))
            {
                OperationContext = _context + "GetcorrespondenceStatusHistory";
                CorrespondenceAgencyNoSystemEC2.CorrespondenceStatusInformation result = client.GetCorrespondenceStatusHistoryAEC(shipment.Request, out var output);
                return new CorrespondenceStatusHistoryAec2Result(result, output);
            }
        }

    }
}
