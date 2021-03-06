﻿using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using EC_Endpoint_Client.Classes.ExtendedClasses.Archive;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.ReporteeArchiveEC2;
using EC_Endpoint_Client.ReporteeArchiveStreamedEC2;

namespace EC_Endpoint_Client.Functionality.EndPoints.Archive
{
    class ReporteeArchiveEndPointFunctionalityEC2 : EndPointFunctionalityBase
    {
        #region ReporteeArchiveForm
        private ReporteeArchiveExternalEC2Client GenerateReporteeArchiveProxy(string selectedEndpointName, X509Certificate2 selectedCertificate)
        {
            return GenerateProxy<ReporteeArchiveExternalEC2Client, IReporteeArchiveExternalEC2>(selectedEndpointName, selectedCertificate);
        }

        public ArchivedFormTaskV2 GetReporteeArchiveArchivedFormTaskV2(ArchiveBaseShipment shipment)
        {
            var client = GenerateReporteeArchiveProxy(shipment.EndpointName, shipment.Certificate);
            OperationContext = "RAGetFormTaskV2";
            return client.GetArchivedFormTaskEC(shipment.Username, shipment.Password, shipment.ReporteeElementId, shipment.LanguageId);
        }

        public ArchivedLookupExternal GetReporteeArchiveLookUp(ArchiveBaseShipment shipment)
        {
            var client = GenerateReporteeArchiveProxy(shipment.EndpointName, shipment.Certificate);
            OperationContext = "RAReporteeLookup";
            return client.GetArchivedLookupEC(shipment.Username, shipment.Password, shipment.ReporteeElementId, shipment.LanguageId ?? 1044);
        }

        public AttachmentBEV2 GetReporteeArchiveAttachment(AttachmentBaseShipment shipment)
        {
            var client = GenerateReporteeArchiveProxy(shipment.EndpointName, shipment.Certificate);
            OperationContext = "RAGetReporteeArchiveAttachment";
            return client.GetAttachmentDataEC(shipment.Username, shipment.Password, shipment.AttachmentId);
        }

        public void TestReporteeArchive(BaseShipment shipment)
        {
            var client = GenerateReporteeArchiveProxy(shipment.EndpointName, shipment.Certificate);
            OperationContext = "RATest";
            client.Test();
        }
        #endregion

        #region reporteeArchiveStreamed
        private ReporteeArchiveExternalStreamedEC2Client GenerateReporteeArchiveStreamedProxy(string selectedEndpointName, X509Certificate2 selectedCertificate)
        {
            return
                GenerateProxy<ReporteeArchiveExternalStreamedEC2Client, IReporteeArchiveExternalStreamedEC2>(
                    selectedEndpointName, selectedCertificate);
        }

        public void TestReporteeArchiveExternalStreamed(BaseShipment shipment)
        {
            var client = GenerateReporteeArchiveStreamedProxy(shipment.EndpointName, shipment.Certificate);
            OperationContext = "RAStreamedTest";
            client.Test();
        }

        public StreamedAttachmentResult GetReporteeArchiveAttachmentDataEcStreamed(AttachmentBaseShipment shipment)
        {
            var client = GenerateReporteeArchiveStreamedProxy(shipment.EndpointName, shipment.Certificate);
            OperationContext = "RAStreamedGetAttachmentData";
            return new StreamedAttachmentResult()
            {
                Result = IoFunctionality.WriteStreamToFile(
                    client.GetAttachmentDataECStreamed(shipment.Username, shipment.Password, shipment.AttachmentId))
            };
        }
        #endregion

    }
}
