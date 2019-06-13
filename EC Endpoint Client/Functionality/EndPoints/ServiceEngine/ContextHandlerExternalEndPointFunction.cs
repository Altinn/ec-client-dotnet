using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Service_References.ContextHandler;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine
{
    public class ContextHandlerExternalEndPointFunction : EndPointFunctionalityBase
    {
        private string _context = "ContextHandler";

        private ContextHandlerECClient GenerateProxy(BaseShipment shipment)
        {
            return base.GenerateProxy<ContextHandlerECClient, IContextHandlerEC>(shipment.EndpointName,
                shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "Test";
            client.Test();
        }

        public ReporteeElementContextExternalBE GetReporteeElementcontextExternal(BaseReporteeElementIdShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = _context + "GetReporteeElementContextExternal";
            return client.GetReporteeElementContextExternalEC(shipment.Username, shipment.Password, shipment.ReporteeElementId);
        }
    }
}
