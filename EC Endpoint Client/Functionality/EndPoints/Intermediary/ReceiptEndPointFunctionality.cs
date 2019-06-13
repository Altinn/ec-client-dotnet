using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.Intermediary;
using EC_Endpoint_Client.Service_References.Receipt;

namespace EC_Endpoint_Client.Functionality.EndPoints.Intermediary
{
    public class ReceiptEndPointFunctionality : EndPointFunctionalityBase
    {
        private ReceiptExternalECClient GenerateProxy(BaseShipment shipment)
        {
            return base.GenerateProxy<ReceiptExternalECClient, IReceiptExternalEC>(shipment.EndpointName,
                shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptTest";
            client.Test();
        }

        public ReceiptExternal GetReceipt(ReceiptSearchExternalShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptGetReceipt";
            return client.GetReceiptEC(shipment.Username, shipment.Password, shipment.ReceiptSearch);
        }

        public Receipt GetReceiptV2(ReceiptV2SearchExternalShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptGetReceiptV2";
            return client.GetReceiptECV2(shipment.Username, shipment.Password, shipment.ReceiptSearch);
        }

        public ReceiptExternalList GetReceiptList(ReceiptListSearchExternalShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptGetReceipts";
            return client.GetReceiptListEC(shipment.Username, shipment.Password, shipment.ReceiptType, shipment.DateFrom, shipment.DateTo);
        }

        public ReceiptList GetReceiptListV2(ReceiptListV2SearchExternalShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptGetReceiptsV2";
            return client.GetReceiptListECV2(shipment.Username, shipment.Password, shipment.ReceiptType, shipment.DateFrom, shipment.DateTo);
        }

        public ReceiptExternal SaveReceipt(ReceiptSaveExternalShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptSaveReceipt";
            return client.SaveReceiptEC(shipment.Username, shipment.Password, shipment.ReceiptSave);
        }

        public Receipt UpdateReceipt(ReceiptUpdateExternalShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptUpdateReceipt";
            return client.UpdateReceiptEC(shipment.Username, shipment.Password, shipment.ReceiptSave);
        }
    }
}
