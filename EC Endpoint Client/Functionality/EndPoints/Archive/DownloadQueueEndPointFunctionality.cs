using System.Security.Cryptography.X509Certificates;
using EC_Endpoint_Client.Classes.Shipments.Archive;
using EC_Endpoint_Client.Service_References.DownloadQueue;

namespace EC_Endpoint_Client.Functionality.EndPoints.Archive
{
    public class DownloadQueueEndPointFunctionality : EndPointFunctionalityBase
    {
        #region downloadQueue

        public void TestDownloadQueue(string selectedEndpointName, X509Certificate2 selectedCertificate)
        {
            var client = GenerateDownloadQueueProxy(selectedEndpointName, selectedCertificate);
            OperationContext = "DQTest";
            client.Test();
        }

        public DownloadQueueItemBEList GetDownloadQueueItemBeList(GetDownloadQueueShipment shipment)
        {
            var client = GenerateDownloadQueueProxy(shipment.EndpointName, shipment.Certificate);
            OperationContext = "DQGetDQItemBEList";
            return client.GetDownloadQueueItems(shipment.Username, shipment.Password, shipment.ServiceCode);
        }

        public ArchivedFormTaskDQBE GetArchivedFormTaskDqbe(DownloadQueueExtendedShipment shipment)
        {
            var client = GenerateDownloadQueueProxy(shipment.EndpointName, shipment.Certificate);
            OperationContext = "DQGetArchivedFormTask";
            return client.GetArchivedFormTaskECDQ(shipment.Username, shipment.Password, shipment.ArchiveReference, shipment.LanguageId);
        }

        public byte[] GetFormSetPdf(DownloadQueueExtendedShipment shipment)
        {
            var client = GenerateDownloadQueueProxy(shipment.EndpointName, shipment.Certificate);
            OperationContext = "DQGetFormSetPdf";
            return client.GetFormSetPdfEc(shipment.Username, shipment.Password, shipment.ArchiveReference, shipment.LanguageId ?? 0);
        }

        public BaseResult PurgeDqItem(DownloadQueueBaseShipment shipment)
        {
            var client = GenerateDownloadQueueProxy(shipment.EndpointName, shipment.Certificate);
            OperationContext = "PurgeDQItem";
            return new BaseResult()
            {

                Result = client.PurgeItem(shipment.Username, shipment.Password, shipment.ArchiveReference)
            };
        }

        private DownloadQueueExternalECClient GenerateDownloadQueueProxy(string selectedEndpointName, X509Certificate2 selectedCertificate)
        {
            return GenerateProxy<DownloadQueueExternalECClient, IDownloadQueueExternalEC>(selectedEndpointName, selectedCertificate);
        }
        #endregion

    }
}
