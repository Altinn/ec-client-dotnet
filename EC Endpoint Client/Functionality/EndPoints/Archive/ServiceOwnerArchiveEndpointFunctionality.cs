using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.ArchiveCommonAgency;
using EC_Endpoint_Client.DownloadQueue;
using EC_Endpoint_Client.KeyManagement;
using EC_Endpoint_Client.ReporteeArchive;
using EC_Endpoint_Client.ReporteeArchiveStreamed;
using EC_Endpoint_Client.SOArchive;
using EC_Endpoint_Client.SOArchiveStreamed;

namespace EC_Endpoint_Client.Functionality
{
    public class ServiceOwnerArchiveEndpointFunctionality : EndPointFunctionalityBase
    {
        #region ServiceOwnerArchiveExternalEC
        private ServiceOwnerArchiveExternalECClient GenerateSOArchiveProxy(string selectedEndpointName, X509Certificate2 SelectedCertificate)
        {
            return
                GenerateProxy<ServiceOwnerArchiveExternalECClient, IServiceOwnerArchiveExternalEC>(
                    selectedEndpointName, SelectedCertificate);
        }

        public void TestSOArchive(string selectedEndpointName, X509Certificate2 SelectedCertificate)
        {
            var client = GenerateSOArchiveProxy(selectedEndpointName, SelectedCertificate);
            OperationContext = "SOATest";
            client.Test();
        }

        public SOArchive.ArchivedFormTaskV2 GetSOArchiveArchivedFormTaskV2(string username, string password, int reporteeElementId, int? languageId, string selectedEndpointName, X509Certificate2 SelectedCertificate)
        {
            var client = GenerateSOArchiveProxy(selectedEndpointName, SelectedCertificate);
            OperationContext = "SOAGetFormTaskV2";
            return client.GetArchivedFormTaskEC(username, password, reporteeElementId, languageId);
        }
        #endregion

        #region ServiceOwnerArchiveExternalStreamedEC
        private ServiceOwnerArchiveExternalStreamedECClient GenerateSOArchiveStreamedProxy(string selectedEndpointName, X509Certificate2 SelectedCertificate)
        {
            return
                GenerateProxy<ServiceOwnerArchiveExternalStreamedECClient, IServiceOwnerArchiveExternalStreamedEC>(
                    selectedEndpointName, SelectedCertificate);
        }

        public void TestSOArchiveStreamed(string selectedEndpointName, X509Certificate2 SelectedCertificate)
        {
            var client = GenerateSOArchiveStreamedProxy(selectedEndpointName, SelectedCertificate);
            OperationContext = "SOAStreamedTest";
            client.Test();
        }

        public System.IO.Stream GetSOArchiveAttachmentDataStreamed(string username, string password, int attachmentId, string selectedEndpointName, X509Certificate2 SelectedCertificate)
        {
            var client = GenerateSOArchiveStreamedProxy(selectedEndpointName, SelectedCertificate);
            OperationContext = "SOAStreamedGetAttachmentData";
            return client.GetAttachmentDataStreamedEC(username, password, attachmentId);
        }
            
        #endregion
    }
}
