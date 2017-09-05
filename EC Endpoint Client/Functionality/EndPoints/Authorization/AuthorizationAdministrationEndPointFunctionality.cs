using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.Administration;

namespace EC_Endpoint_Client.Functionality
{
    public class AuthorizationAdministrationEndPointFunctionality : EndPointFunctionalityBase
    {
        public void TestAuthorizationAdministration(string selectedEndpointName, X509Certificate2 SelectedCertificate)
        {
            var client = GenerateAuthorizationAdministrationProxy(selectedEndpointName, SelectedCertificate);
            OperationContext = "AuthAdminTest";
            client.Test();
        }

        public ExternalReporteeBE GetReporteeByTempKeyEC(string username, string password, Guid tempKey, string selectedEndpointName, X509Certificate2 SelectedCertificate)
        {
            var client = GenerateAuthorizationAdministrationProxy(selectedEndpointName, SelectedCertificate);
            OperationContext = "AuthAdminGetReportee";
            return client.GetReporteeByTempKeyEC(username, password, tempKey);
        }

        public ExternalReporteeBEList GetReporteesEC(GetReporteesShipment shipment)
        {
            var client = GenerateAuthorizationAdministrationProxy(shipment.EndpointName, shipment.Certificate);
            OperationContext = "AuthAtminGetReportees";
            return client.GetReporteesEC(shipment.Username, shipment.Password, shipment.SSN, shipment.RetrieveInactiveReportee, shipment.RetrieveSubEntity, shipment.MaximumReporteeCount);
        }

        public AuthorizationAdministrationECClient GenerateAuthorizationAdministrationProxy(string selectedEndpointName, X509Certificate2 SelectedCertificate)
        {
            return
                GenerateProxy<AuthorizationAdministrationECClient, IAuthorizationAdministrationEC>(
                    selectedEndpointName, SelectedCertificate);
        }
    }
}
