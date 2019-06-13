using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.Intermediary.AgencyClasses;
using EC_Endpoint_Client.Service_References.ReceiptAgency;

namespace EC_Endpoint_Client.Functionality.EndPoints.Intermediary
{
    class ReceiptAgencyEndpointFunctionality : EndPointFunctionalityBase
    {
        private ReceiptAgencyExternalECClient GenerateProxy(BaseShipment shipment)
        {
            return base.GenerateProxy<ReceiptAgencyExternalECClient, IReceiptAgencyExternalEC>(shipment.EndpointName, shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptAgencyTest";
            client.Test();
        }

        public ReceiptExternal GetReceipt(ReceiptSearchExternalShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptAgencyGetReceipt";
            return client.GetReceiptEC(shipment.Username, shipment.Password, shipment.ReceiptSearch);
        }

        public Receipt GetReceiptV2(ReceiptV2SearchExternalShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptAgencyGetReceiptV2";
            return client.GetReceiptECV2(shipment.Username, shipment.Password, shipment.ReceiptSearch);
        }

        public ReceiptExternalList GetReceiptList(ReceiptListSearchExternalShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptAgencyGetReceipts";
            return client.GetReceiptListEC(shipment.Username, shipment.Password, shipment.ReceiptType, shipment.DateFrom, shipment.DateTo);
        }

        public ReceiptList GetReceiptListV2(ReceiptListV2SearchExternalShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptAgencyGetReceiptsV2";
            return client.GetReceiptListECV2(shipment.Username, shipment.Password, shipment.ReceiptType, shipment.DateFrom, shipment.DateTo);
        }

        public ReceiptExternal SaveReceipt(ReceiptSaveExternalShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptAgencySaveReceipt";
            return client.SaveReceiptEC(shipment.Username, shipment.Password, shipment.ReceiptSave);
        }

        public Receipt UpdateReceipt(ReceiptUpdateExternalShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptAgencyUpdateReceipt";
            return client.UpdateReceiptEC(shipment.Username, shipment.Password, shipment.ReceiptSave);
        }
                
    }
}
