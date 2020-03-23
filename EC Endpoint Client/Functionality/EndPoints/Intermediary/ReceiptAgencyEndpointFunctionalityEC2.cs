using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.Intermediary.AgencyClasses;
using EC_Endpoint_Client.ReceiptAgencyEC2;

namespace EC_Endpoint_Client.Functionality.EndPoints.Intermediary
{
    class ReceiptAgencyEndpointFunctionalityEC2 : EndPointFunctionalityBase
    {
        private ReceiptAgencyExternalEC2Client GenerateProxy(BaseShipment shipment)
        {
            return base.GenerateProxy<ReceiptAgencyExternalEC2Client, IReceiptAgencyExternalEC2>(shipment.EndpointName, shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptAgencyTest";
            client.Test();
        }

        public ReceiptExternal GetReceipt(ReceiptSearchExternalShipmentEC2 shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptAgencyGetReceipt";
            return client.GetReceiptEC(shipment.Username, shipment.Password, shipment.ReceiptSearch);
        }

        public ReceiptAgencyEC2.Receipt GetReceiptV2(ReceiptV2SearchExternalShipmentEC2 shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptAgencyGetReceiptV2";
            return client.GetReceiptECV2(shipment.Username, shipment.Password, shipment.ReceiptSearch);
        }

        public ReceiptExternalList GetReceiptList(ReceiptListSearchExternalShipmentEC2 shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptAgencyGetReceipts";
            return client.GetReceiptListEC(shipment.Username, shipment.Password, shipment.ReceiptType, shipment.DateFrom, shipment.DateTo);
        }

        public ReceiptList GetReceiptListV2(ReceiptListV2SearchExternalShipmentEC2 shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptAgencyGetReceiptsV2";
            return client.GetReceiptListECV2(shipment.Username, shipment.Password, shipment.ReceiptType, shipment.DateFrom, shipment.DateTo);
        }

        public ReceiptAgencyEC2.ReceiptExternal SaveReceipt(ReceiptSaveExternalShipmentEC2 shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptAgencySaveReceipt";
            return client.SaveReceiptEC(shipment.Username, shipment.Password, shipment.ReceiptSave);
        }

        public ReceiptAgencyEC2.Receipt UpdateReceipt(ReceiptUpdateExternalShipmentEC2 shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = "ReceiptAgencyUpdateReceipt";
            return client.UpdateReceiptEC(shipment.Username, shipment.Password, shipment.ReceiptSave);
        }
                
    }
}
