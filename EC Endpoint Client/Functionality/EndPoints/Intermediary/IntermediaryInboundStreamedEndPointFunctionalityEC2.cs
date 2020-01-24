using System.IO;
using System.Security.Cryptography.X509Certificates;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.Intermediary;
using EC_Endpoint_Client.IntermediaryInboundEC2Streamed;

namespace EC_Endpoint_Client.Functionality.EndPoints.Intermediary
{
    public class IntermediaryInboundStreamedEndPointFunctionalityEC2 : EndPointFunctionalityBase
    {
        private IntermediaryInboundExternalEC2StreamedClient GenerateProxy(BaseShipment shipment)
        {
            return base.GenerateProxy<IntermediaryInboundExternalEC2StreamedClient, IIntermediaryInboundExternalEC2Streamed>(shipment.EndpointName,
                shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "IntStreamedTest";
            client.Test();
        }

        public IntermediaryStreamedAttachmentResult SubmitAttachmentStreamed(IntermediaryStreamedSubmitAttachmentShipment shipment)
        {
            IntermediaryStreamedAttachmentResult result = new IntermediaryStreamedAttachmentResult();
            var client = GenerateProxy(shipment);
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
