using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine;
using EC_Endpoint_Client.ReporteeElementList;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine
{
    class ReporteeElementListEndPointFunction : EndPointFunctionalityBase
    {
        private string Context = "ReporteeElementList";
        private ReporteeElementListECClient GenerateProxy(BaseShipment shipment)
        {
            return base.GenerateProxy<ReporteeElementListECClient, IReporteeElementListEC>(shipment.EndpointName,
                shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "Test";
            client.Test();
        }

        public void DeleteReporteeElement(DeleteReporteeElementShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "DeleteReporteeElement";
            client.DeleteReporteeElementEC(shipment.Username, shipment.Password, shipment.ReporteeElementCode );
        }

        public ReporteeElementBEV2Lis GetCorrespondenceListForArchiveRef(ReporteeElemenetListShipmentBase shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "GetCorrespondenceListForArchiveRef";
            return client.GetCorrespondenceListForArchiveRefEC(shipment.Username, shipment.Password, shipment.Reportee, shipment.ArchiveReference, shipment.FromDate, shipment.ToDate, shipment.LanguageID);
        }

        public ReporteeElementBEV2Lis GetCorrespondenceListForReportee(ReporteeElemenetListShipmentBase shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "GetCorrespondenceListForReportee";
            return client.GetCorrespondenceListForReporteeEC(shipment.Username, shipment.Password, shipment.Reportee, shipment.FromDate, shipment.ToDate, shipment.LanguageID);
        }

        public FormSetElementExternalBEV2List GetFormSetElements(GetFormSetShipmentBase shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "GetFormSetElements";
            return client.GetFormSetElementsEC(shipment.Username, shipment.Password, shipment.ReporteeElementID, shipment.LanguageID);
        }

        public ReporteeElementBEV2Lis GetReporteeElementList(GetReporteeElementListShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "GetReporteeElementList";
            return client.GetReporteeElementListEC(shipment.Username, shipment.Password, shipment.ExternalSearch, shipment.LanguageID);
        }
    }
}
