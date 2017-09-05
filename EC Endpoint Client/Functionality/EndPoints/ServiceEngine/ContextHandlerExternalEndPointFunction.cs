using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.ContextHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Endpoint_Client.Functionality.EndPoints.ServiceEngine
{
    public class ContextHandlerExternalEndPointFunction : EndPointFunctionalityBase
    {
        private string Context = "ContextHandler";

        private ContextHandlerECClient GenerateProxy(BaseShipment shipment)
        {
            return base.GenerateProxy<ContextHandlerECClient, IContextHandlerEC>(shipment.EndpointName,
                shipment.Certificate);
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "Test";
            client.Test();
        }

        public ReporteeElementContextExternalBE GetReporteeElementcontextExternal(BaseReporteeElementIdShipment shipment)
        {
            var client = GenerateProxy(shipment);
            OperationContext = Context + "GetReporteeElementContextExternal";
            return client.GetReporteeElementContextExternalEC(shipment.Username, shipment.Password, shipment.ReporteeElementId);
        }
    }
}
