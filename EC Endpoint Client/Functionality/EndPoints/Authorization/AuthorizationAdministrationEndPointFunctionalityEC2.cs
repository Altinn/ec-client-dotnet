using System;
using System.Security.Cryptography.X509Certificates;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.Authorization;
using EC_Endpoint_Client.AdministrationEC2;

namespace EC_Endpoint_Client.Functionality.EndPoints.Authorization
{
    public class AuthorizationAdministrationEndPointFunctionalityEC2 : EndPointFunctionalityBase
    {
        public void TestAuthorizationAdministration(BaseShipment shipment)
        {
            var client = GenerateAuthorizationAdministrationProxy(shipment.EndpointName, shipment.Certificate);
            OperationContext = "AuthAdminTest";
            client.Test();
        }

        public ExternalReporteeBE GetReporteeByTempKeyEc(GetReporteeByTempKeyShipment shipment)
        {
            var client = GenerateAuthorizationAdministrationProxy(shipment.EndpointName, shipment.Certificate);
            OperationContext = "AuthAdminGetReportee";
            return client.GetReporteeByTempKeyEC(shipment.Username, shipment.Password, shipment.TempKey);
        }

        public ExternalReporteeBEList GetReporteesEc(GetReporteesShipment shipment)
        {
            var client = GenerateAuthorizationAdministrationProxy(shipment.EndpointName, shipment.Certificate);
            OperationContext = "AuthAtminGetReportees";
            return client.GetReporteesEC(shipment.Username, shipment.Password, shipment.Ssn, shipment.RetrieveInactiveReportee, shipment.RetrieveSubEntity, shipment.MaximumReporteeCount);
        }

        public AuthorizationAdministrationEC2Client GenerateAuthorizationAdministrationProxy(string selectedEndpointName, X509Certificate2 selectedCertificate)
        {
            return
                GenerateProxy<AuthorizationAdministrationEC2Client, IAuthorizationAdministrationEC2>(
                    selectedEndpointName, selectedCertificate);
        }
    }
}
