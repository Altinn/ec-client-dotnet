using System.Security.Cryptography.X509Certificates;
using EC_Endpoint_Client.Classes.Shipments.Archive;
using EC_Endpoint_Client.DownloadQueueEC2;
using ArchivedFormTaskDQBE = EC_Endpoint_Client.DownloadQueueEC2.ArchivedFormTaskDQBE;
using DownloadQueueItemBEList = EC_Endpoint_Client.DownloadQueueEC2.DownloadQueueItemBEList;

namespace EC_Endpoint_Client.Functionality.EndPoints.Archive
{
    public class DownloadQueueEndPointFunctionalityEC2 : EndPointFunctionalityBase
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
            return client.GetArchivedFormTaskECDQ(shipment.Username, shipment.Password, shipment.ArchiveReference, shipment.LanguageId, false);
        }

        public byte[] GetFormSetPdf(DownloadQueueExtendedShipment shipment)
        {
            var client = GenerateDownloadQueueProxy(shipment.EndpointName, shipment.Certificate);
            OperationContext = "DQGetFormSetPdf";
            return client.GetFormSetPdfEc(shipment.Username, shipment.Password, shipment.ArchiveReference, shipment.LanguageId ?? 0, null, null);
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

        private DownloadQueueExternalEC2Client GenerateDownloadQueueProxy(string selectedEndpointName, X509Certificate2 selectedCertificate)
        {
            return GenerateProxy<DownloadQueueExternalEC2Client, IDownloadQueueExternalEC2>(selectedEndpointName, selectedCertificate);
        }
        #endregion

    }
}
