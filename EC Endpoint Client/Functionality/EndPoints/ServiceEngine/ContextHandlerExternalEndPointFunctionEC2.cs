using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.ContextHandlerEC2;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine
{
    public class ContextHandlerExternalEndPointFunctionEC2 : EndPointFunctionalityBase
    {
        private string _context = "ContextHandler";

        private ContextHandlerEC2Client GenerateProxy(BaseShipment shipment)
        {
            return base.GenerateProxy<ContextHandlerEC2Client, IContextHandlerEC2>(shipment.EndpointName,
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
