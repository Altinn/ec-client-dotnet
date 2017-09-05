using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.ReporteeArchive;
using EC_Endpoint_Client.ReporteeArchiveStreamed;

namespace EC_Endpoint_Client.Functionality
{
    class ReporteeArchiveEndPointFunctionality : EndPointFunctionalityBase
    {
        #region ReporteeArchiveForm
        private ReporteeArchiveExternalECClient GenerateReporteeArchiveProxy(string selectedEndpointName, X509Certificate2 SelectedCertificate)
        {
            return GenerateProxy<ReporteeArchiveExternalECClient, IReporteeArchiveExternalEC>(selectedEndpointName,
                SelectedCertificate);
        }

        public ReporteeArchive.ArchivedFormTaskV2 GetReporteeArchiveArchivedFormTaskV2(string username, string password, int reporteeElementId, int? languageId, string selectedEndpointName, X509Certificate2 SelectedCertificate)
        {
            var client = GenerateReporteeArchiveProxy(selectedEndpointName, SelectedCertificate);
            OperationContext = "RAGetFormTaskV2";
            return client.GetArchivedFormTaskEC(username, password, reporteeElementId, languageId);
        }

        public ArchivedLookupExternal GetReporteeArchiveLookUp(string username, string password, int reporteeElementId, int languageId, string selectedEndpointName, X509Certificate2 SelectedCertificate)
        {
            var client = GenerateReporteeArchiveProxy(selectedEndpointName, SelectedCertificate);
            OperationContext = "RAReporteeLookup";
            return client.GetArchivedLookupEC(username, password, reporteeElementId, languageId);
        }

        public AttachmentBEV2 GetReporteeArchiveAttachment(string username, string password, int attachmenId, string selectedEndpointName, X509Certificate2 SelectedCertificate)
        {
            var client = GenerateReporteeArchiveProxy(selectedEndpointName, SelectedCertificate);
            OperationContext = "RAGetReporteeArchiveAttachment";
            return client.GetAttachmentDataEC(username, password, attachmenId);
        }

        public void TestReporteeArchive(string selectedEndpointName, X509Certificate2 SelectedCertificate)
        {
            var client = GenerateReporteeArchiveProxy(selectedEndpointName, SelectedCertificate);
            OperationContext = "RATest";
            client.Test();
        }
        #endregion

        #region reporteeArchiveStreamed
        private ReporteeArchiveExternalStreamedECClient GenerateReporteeArchiveStreamedProxy(string selectedEndpointName, X509Certificate2 SelectedCertificate)
        {
            return
                GenerateProxy<ReporteeArchiveExternalStreamedECClient, IReporteeArchiveExternalStreamedEC>(
                    selectedEndpointName, SelectedCertificate);
        }

        public void TestReporteeArchiveExternalStreamed(string selectedEndpointName, X509Certificate2 SelectedCertificate)
        {
            var client = GenerateReporteeArchiveStreamedProxy(selectedEndpointName, SelectedCertificate);
            OperationContext = "RAStreamedTest";
            client.Test();
        }

        public System.IO.Stream GetReporteeArchiveAttachmentDataECStreamed(string username, string password, int attachmentId, string selectedEndpointName, X509Certificate2 SelectedCertificate)
        {
            var client = GenerateReporteeArchiveStreamedProxy(selectedEndpointName, SelectedCertificate);
            OperationContext = "RAStreamedGetAttachmentData";
            return client.GetAttachmentDataECStreamed(username, password, attachmentId);
        }
        #endregion

    }
}
