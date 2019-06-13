using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine;
using EC_Endpoint_Client.ReporteeElementList;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine
{
    class ReporteeElementListEndPointFunction : EndPointFunctionalityBase
    {
        private string _context = "ReporteeElementList";
        private ReporteeElementListECClient GenerateProxy(BaseShipment shipment)
        {
            return base.GenerateProxy<ReporteeElementListECClient, IReporteeElementListEC>(shipment.EndpointName,
                shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "Test";
            client.Test();
        }

        public void DeleteReporteeElement(DeleteReporteeElementShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "DeleteReporteeElement";
            client.DeleteReporteeElementEC(shipment.Username, shipment.Password, shipment.ReporteeElementCode );
        }

        public ReporteeElementBEV2Lis GetCorrespondenceListForArchiveRef(ReporteeElemenetListShipmentBase shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "GetCorrespondenceListForArchiveRef";
            return client.GetCorrespondenceListForArchiveRefEC(shipment.Username, shipment.Password, shipment.Reportee, shipment.ArchiveReference, shipment.FromDate, shipment.ToDate, shipment.LanguageId);
        }

        public ReporteeElementBEV2Lis GetCorrespondenceListForReportee(ReporteeElemenetListShipmentBase shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "GetCorrespondenceListForReportee";
            return client.GetCorrespondenceListForReporteeEC(shipment.Username, shipment.Password, shipment.Reportee, shipment.FromDate, shipment.ToDate, shipment.LanguageId);
        }

        public FormSetElementExternalBEV2List GetFormSetElements(GetFormSetShipmentBase shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "GetFormSetElements";
            return client.GetFormSetElementsEC(shipment.Username, shipment.Password, shipment.ReporteeElementId, shipment.LanguageId);
        }

        public ReporteeElementBEV2Lis GetReporteeElementList(GetReporteeElementListShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "GetReporteeElementList";
            return client.GetReporteeElementListEC(shipment.Username, shipment.Password, shipment.ExternalSearch, shipment.LanguageId);
        }

        public FormSetDataBEList GetFormTaskData(BaseReporteeElementIdShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "GetFormTaskData";
            return client.GetFormSetDataEC(shipment.Username, shipment.Password, shipment.ReporteeElementId, shipment.LanguageId);
        }
    }
}
