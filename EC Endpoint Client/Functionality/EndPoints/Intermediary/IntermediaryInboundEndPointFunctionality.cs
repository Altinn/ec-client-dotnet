using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.IntermediaryInbound;

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

        public int GetAltinnSubmissionStatusEC(BaseShipment shipment)
        {
            OperationContext = "IntGetAltinnSubmissionStatus";
            using (var client = GenerateIntermediaryInboundProxy(shipment))
            {
                return client.GetAltinnSubmissionStatusEC(shipment.Username, shipment.Password);
            }
        }

        public ReceiptExternalBE SubmitFormTaskEC(IntermediaryInboundShipment shipment)
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
                return client.CompleteAndSignShipmentEC(shipment.Username, shipment.Password, shipment.ReporteeElementID, shipment.SignatureList, shipment.LanguageID);
            }
        }

    }
}
