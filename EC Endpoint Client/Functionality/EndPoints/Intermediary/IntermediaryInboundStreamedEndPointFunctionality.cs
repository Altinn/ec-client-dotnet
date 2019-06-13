using System.IO;
using System.Security.Cryptography.X509Certificates;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.Intermediary;
using EC_Endpoint_Client.Service_References.IntermediaryInboundStreamed;

namespace EC_Endpoint_Client.Functionality.EndPoints.Intermediary
{
    public class IntermediaryInboundStreamedEndPointFunctionality : EndPointFunctionalityBase
    {
        private IntermediaryInboundExternalECStreamedClient GenerateProxy(string endpointName, X509Certificate2 selectedCertificate)
        {
            var proxy = new IntermediaryInboundExternalECStreamedClient(endpointName);
            proxy.ClientCredentials.ClientCertificate.Certificate = selectedCertificate;
            GetCredentialsForServiceCertificate(proxy.ClientCredentials.ServiceCertificate);
            
            SetInspectorBehavior(proxy.Endpoint.EndpointBehaviors);
            return proxy;
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment.EndpointName, shipment.Certificate);
            OperationContext = "IntStreamedTest";
            client.Test();
        }

        public IntermediaryStreamedAttachmentResult SubmitAttachmentStreamed(IntermediaryStreamedSubmitAttachmentShipment shipment)
        {
            IntermediaryStreamedAttachmentResult result = new IntermediaryStreamedAttachmentResult();
            var client = GenerateProxy(shipment.EndpointName, shipment.Certificate);
            using(FileStream fs = new FileStream(shipment.FilePath, FileMode.Open))
            {
                OperationContext = "IntStreamedSubmitAttachment";
                client.SubmitAttachmentStreamedEC(shipment.AttachmentTypeName, shipment.CheckSum, shipment.EndUserSystemReference, shipment.FileName,
                    shipment.Name, shipment.ReporteeElementId, shipment.Password, shipment.Username, fs,
                    out result.ParentReceiptId,out result.ReceiptHistory, out result.ReceiptId, out result.ReceiptStatusCode, out result.ReceiptText, out result.ReceiptTypeName);
            }
            return result;
        }
    }
}
