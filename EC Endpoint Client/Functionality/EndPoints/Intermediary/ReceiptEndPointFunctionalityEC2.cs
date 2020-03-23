using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.Intermediary;
using EC_Endpoint_Client.ReceiptEC2;

namespace EC_Endpoint_Client.Functionality.EndPoints.Intermediary
{
    public class ReceiptEndPointFunctionalityEC2 : EndPointFunctionalityBase
    {
        private ReceiptExternalEC2Client GenerateProxy(BaseShipment shipment)
        {
            return base.GenerateProxy<ReceiptExternalEC2Client, IReceiptExternalEC2>(shipment.EndpointName,
                shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptTest";
            client.Test();
        }

        public ReceiptExternal GetReceipt(ReceiptSearchExternalShipmentEC2 shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptGetReceipt";
            return client.GetReceiptEC(shipment.Username, shipment.Password, shipment.ReceiptSearch);
        }

        public ReceiptEC2.Receipt GetReceiptV2(ReceiptV2SearchExternalShipmentEC2 shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptGetReceiptV2";
            return client.GetReceiptECV2(shipment.Username, shipment.Password, shipment.ReceiptSearch);
        }

        public ReceiptExternalList GetReceiptList(ReceiptListSearchExternalShipmentEC2 shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptGetReceipts";
            return client.GetReceiptListEC(shipment.Username, shipment.Password, shipment.ReceiptType, shipment.DateFrom, shipment.DateTo);
        }

        public ReceiptEC2.ReceiptList GetReceiptListV2(ReceiptListV2SearchExternalShipmentEC2 shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptGetReceiptsV2";
            return client.GetReceiptListECV2(shipment.Username, shipment.Password, shipment.ReceiptType, shipment.DateFrom, shipment.DateTo);
        }

        public ReceiptExternal SaveReceipt(ReceiptSaveExternalShipmentEC2 shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptSaveReceipt";
            return client.SaveReceiptEC(shipment.Username, shipment.Password, shipment.ReceiptSave);
        }

        public ReceiptEC2.Receipt UpdateReceipt(ReceiptUpdateExternalShipmentEC2 shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptUpdateReceipt";
            return client.UpdateReceiptEC(shipment.Username, shipment.Password, shipment.ReceiptSave);
        }
    }
}
