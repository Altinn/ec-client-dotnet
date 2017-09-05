using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.DownloadQueue;

namespace EC_Endpoint_Client.Functionality
{
    public class DownloadQueueEndPointFunctionality : EndPointFunctionalityBase
    {
        #region downloadQueue

        public void TestDownloadQueue(string selectedEndpointName, X509Certificate2 SelectedCertificate)
        {
            var client = this.GenerateDownloadQueueProxy(selectedEndpointName, SelectedCertificate);
            this.OperationContext = "DQTest";
            client.Test();
        }

        public DownloadQueueItemBEList GetDownloadQueueItemBEList(string username, string password, string serviceCode, string selectedEndpointName, X509Certificate2 SelectedCertificate)
        {
            var client = this.GenerateDownloadQueueProxy(selectedEndpointName, SelectedCertificate);
            this.OperationContext = "DQGetDQItemBEList";
            return client.GetDownloadQueueItems(username, password, serviceCode);
        }

        public ArchivedFormTaskDQBE GetArchivedFormTaskDQBE(string username, string password, string archiveReference, int? languageID, string selectedEndpointName, X509Certificate2 SelectedCertificate)
        {
            var client = this.GenerateDownloadQueueProxy(selectedEndpointName, SelectedCertificate);
            this.OperationContext = "DQGetArchivedFormTask";
            return client.GetArchivedFormTaskECDQ(username, password, archiveReference, languageID);
        }

        public byte[] GetFormSetPdf(string username, string password, string archiveReference, int languageId, string selectedEndpointName, X509Certificate2 selectedCertificate)
        {
            var client = this.GenerateDownloadQueueProxy(selectedEndpointName, selectedCertificate);
            this.OperationContext = "DQGetFormSetPdf";
            return client.GetFormSetPdfEc(username, password, archiveReference, languageId);
        }

        public string PurgeDQItem(string username, string password, string archiveReference, string selectedEndpointName, X509Certificate2 SelectedCertificate)
        {
            var client = this.GenerateDownloadQueueProxy(selectedEndpointName, SelectedCertificate);
            this.OperationContext = "PurgeDQItem";
            return client.PurgeItem(username, password, archiveReference);
        }

        private DownloadQueueExternalECClient GenerateDownloadQueueProxy(string selectedEndpointName, X509Certificate2 SelectedCertificate)
        {
            return GenerateProxy<DownloadQueueExternalECClient, IDownloadQueueExternalEC>(selectedEndpointName, SelectedCertificate);
        }
        #endregion

    }
}
