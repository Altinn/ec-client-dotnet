using System.Security.Cryptography.X509Certificates;
using EC_Endpoint_Client.Classes.ExtendedClasses.Archive;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Service_References.SOArchive;
using EC_Endpoint_Client.Service_References.SOArchiveStreamed;

namespace EC_Endpoint_Client.Functionality.EndPoints.Archive
{
    public class ServiceOwnerArchiveEndpointFunctionality : EndPointFunctionalityBase
    {
        #region ServiceOwnerArchiveExternalEC
        private ServiceOwnerArchiveExternalECClient GenerateSoArchiveProxy(string selectedEndpointName, X509Certificate2 selectedCertificate)
        {
            return
                GenerateProxy<ServiceOwnerArchiveExternalECClient, IServiceOwnerArchiveExternalEC>(
                    selectedEndpointName, selectedCertificate);
        }

        public void TestSoArchive(BaseShipment shipment)
        {
            var client = GenerateSoArchiveProxy(shipment.EndpointName, shipment.Certificate);
            OperationContext = "SOATest";
            client.Test();
        }

        public ArchivedFormTaskV2 GetSoArchiveArchivedFormTaskV2(ArchiveBaseShipment shipment)
        {
            var client = GenerateSoArchiveProxy(shipment.EndpointName, shipment.Certificate);
            OperationContext = "SOAGetFormTaskV2";
            return client.GetArchivedFormTaskEC(shipment.Username, shipment.Password, shipment.ReporteeElementId, shipment.LanguageId ?? 1044);
        }
        #endregion

        #region ServiceOwnerArchiveExternalStreamedEC
        private ServiceOwnerArchiveExternalStreamedECClient GenerateSoArchiveStreamedProxy(string selectedEndpointName, X509Certificate2 selectedCertificate)
        {
            return
                GenerateProxy<ServiceOwnerArchiveExternalStreamedECClient, IServiceOwnerArchiveExternalStreamedEC>(
                    selectedEndpointName, selectedCertificate);
        }

        public void TestSoArchiveStreamed(BaseShipment shipment)
        {
            var client = GenerateSoArchiveStreamedProxy(shipment.EndpointName, shipment.Certificate);
            OperationContext = "SOAStreamedTest";
            client.Test();
        }

        public StreamedAttachmentResult GetSoArchiveAttachmentDataStreamed(AttachmentBaseShipment shipment)
        {
            var client = GenerateSoArchiveStreamedProxy(shipment.EndpointName, shipment.Certificate);
            OperationContext = "SOAStreamedGetAttachmentData";
            return new StreamedAttachmentResult()
            {
                Result = IoFunctionality.WriteStreamToFile(
                    client.GetAttachmentDataStreamedEC(shipment.Username, shipment.Password, shipment.AttachmentId))
            };
        }
            
        #endregion
    }
}
