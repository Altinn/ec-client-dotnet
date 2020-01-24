using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.Intermediary;
using EC_Endpoint_Client.IntermediaryInboundEC2;

namespace EC_Endpoint_Client.Functionality.EndPoints.Intermediary
{
    public class IntermediaryInboundEndPointFunctionalityEC2 : EndPointFunctionalityBase
    {
        public IntermediaryInboundExternalEC2Client GenerateIntermediaryInboundProxy(BaseShipment shipment)
        {
            return GenerateProxy<IntermediaryInboundExternalEC2Client, IIntermediaryInboundExternalEC2>(shipment.EndpointName, shipment.Certificate);
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

        public ReceiptExternalBE SubmitFormTaskEc(IntermediaryInboundShipmentEC2 shipment)
        {
            OperationContext = "IntSubmitFormTask";
            using (var client = GenerateIntermediaryInboundProxy(shipment))
            {
                var receipt = client.SubmitFormTaskEC(shipment.Username, shipment.Password, shipment.FormTaskShipment);
                return receipt;
            }
        }

        public ReceiptExternal CompleteAndSignShipment(IntermediarySignShipmentEC2 shipment)
        {
            OperationContext = "IntSignAndComplet";
            using (var client = GenerateIntermediaryInboundProxy(shipment))
            {
                return client.CompleteAndSignShipmentEC(shipment.Username, shipment.Password, shipment.ReporteeElementId, shipment.SignatureList, shipment.LanguageId);
            }
        }

        public ReceiptExternal UpdateFormData(UpdateFormDataInputEC2 updateFormData)
        {
            OperationContext = "IntUpdateFormData";
            using (var client = GenerateIntermediaryInboundProxy(updateFormData))
            {
                return client.UpdateFormDataEC(updateFormData.Username, updateFormData.Password, updateFormData.FormTaskUpdate);
            }
        }

    }
}
