using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.IntermediaryInboundStreamed;

namespace EC_Endpoint_Client.Functionality.EndPoints.Intermediary
{
    public class IntermediaryInboundStreamedEndPointFunctionality : EndPointFunctionalityBase
    {
        private IntermediaryInboundExternalECStreamedClient GenerateProxy(string EndpointName, X509Certificate2 SelectedCertificate)
        {
            var proxy = new IntermediaryInboundExternalECStreamedClient(EndpointName);
            proxy.ClientCredentials.ClientCertificate.Certificate = SelectedCertificate;
            GetCredentialsForServiceCertificate(proxy.ClientCredentials.ServiceCertificate);
            
            SetInspectorBehavior(proxy.Endpoint.EndpointBehaviors);
            return proxy;
        }

        public void Test(Classes.BaseShipment shipment)
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
                    shipment.Name, shipment.ReporteeElementID, shipment.Password, shipment.Username, fs,
                    out result._ParentReceiptID,out result._ReceiptHistory, out result._ReceiptID, out result._ReceiptStatusCode, out result._ReceiptText, out result._ReceiptTypeName);
            }
            return result;
        }
    }
}
