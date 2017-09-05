using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.CorrespondenceAgency;
using EC_Endpoint_Client.Classes.Shipments.ServiceEngine.CorrespondenceAgency;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine
{
    public class CorrespondenceAgencyEndPointFunction : EndPointFunctionalityBase
    {
        private string Context = "CorrespondenceAgency";
        private CorrespondenceAgencyExternalECClient GenerateProxy(BaseShipment shipment)
        {
            return
                base.GenerateProxy<CorrespondenceAgencyExternalECClient, ICorrespondenceAgencyExternalEC>(
                    shipment.EndpointName, shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "Test";
            client.Test();
        }

        public ReceiptExternal InsertCorrespondence(InsertCorrespondenceShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "InsertCorrespondence";
            return client.InsertCorrespondenceEC(shipment.Username, shipment.Password, shipment.SystemUserCode, shipment.ExternalShipmentReference, shipment.InsertCorrespondence);
        }

        public CorrespondenceStatusResultV3 GetCorrespondenceDetailsV3(GetCorrespondenceStatusDetailsShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "GetCorrespondenceDetailsStatus";
            return client.GetCorrespondenceStatusDetailsECV3(shipment.Username, shipment.Password, shipment.request);
        }

        public CorrespondenceStatusHistoryResultEx GetCorrespondenceStatusHistory(GetCorrespondenceStatusHistoryShipment shipment)
        {
            using (var client = GenerateProxy(shipment))
            {
                OperationContext = Context + "GetcorrespondenceStatusHistory";
                return new CorrespondenceStatusHistoryResultEx(client.GetCorrespondenceStatusHistoryEC(shipment.Password, shipment.Username,
                    shipment.request));
            }
        }
    }
}
