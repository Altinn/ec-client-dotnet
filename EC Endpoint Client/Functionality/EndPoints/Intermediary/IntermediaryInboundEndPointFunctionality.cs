using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.Intermediary;
using EC_Endpoint_Client.Service_References.IntermediaryInbound;

namespace EC_Endpoint_Client.Functionality.EndPoints.Intermediary
{
    public class IntermediaryInboundEndPointFunctionality : EndPointFunctionalityBase
    {
        public IntermediaryInboundExternalECClient GenerateIntermediaryInboundProxy(BaseShipment shipment)
        {
            return GenerateProxy<IntermediaryInboundExternalECClient, IIntermediaryInboundExternalEC>(shipment.EndpointName, shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            OperationContext = "IntTest";
            using (var client = GenerateIntermediaryInboundProxy(shipment))
            {
                client.Test();
            }
        }

        public int GetAltinnSubmissionStatusEc(BaseShipment shipment)
        {
            OperationContext = "IntGetAltinnSubmissionStatus";
            using (var client = GenerateIntermediaryInboundProxy(shipment))
            {
                return client.GetAltinnSubmissionStatusEC(shipment.Username, shipment.Password);
            }
        }

        public ReceiptExternalBE SubmitFormTaskEc(IntermediaryInboundShipment shipment)
        {
            OperationContext = "IntSubmitFormTask";
            using (var client = GenerateIntermediaryInboundProxy(shipment))
            {
                var receipt = client.SubmitFormTaskEC(shipment.Username, shipment.Password, shipment.FormTaskShipment);
                return receipt;
            }
        }

        public ReceiptExternal CompleteAndSignShipment(IntermediarySignShipment shipment)
        {
            OperationContext = "IntSignAndComplet";
            using (var client = GenerateIntermediaryInboundProxy(shipment))
            {
                return client.CompleteAndSignShipmentEC(shipment.Username, shipment.Password, shipment.ReporteeElementId, shipment.SignatureList, shipment.LanguageId);
            }
        }

        public ReceiptExternal UpdateFormData(UpdateFormDataInput updateFormData)
        {
            OperationContext = "IntUpdateFormData";
            using (var client = GenerateIntermediaryInboundProxy(updateFormData))
            {
                return client.UpdateFormDataEC(updateFormData.Username, updateFormData.Password, updateFormData.FormTaskUpdate);
            }
        }

    }
}
