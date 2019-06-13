using System.Security.Cryptography.X509Certificates;
using EC_Endpoint_Client.Classes.Shipments.Archive;
using EC_Endpoint_Client.Service_References.KeyManagement;

namespace EC_Endpoint_Client.Functionality.EndPoints.Archive
{
    public class KeyManagementEndPointFunctionality : EndPointFunctionalityBase
    {
        #region KeyManagement
        private KeyManagementExternalECClient GenerateKeyManangementProxy(string selectedEndpointname, X509Certificate2 selectedCertificate)
        {
            return GenerateProxy<KeyManagementExternalECClient, IKeyManagementExternalEC>(selectedEndpointname,
                selectedCertificate);
        }

        public CertificateBEList GetKeyManagementCertificatesBeList(KeyManagementShipmentClass shipment)
        {
            var client = GenerateKeyManangementProxy(shipment.EndpointName, shipment.Certificate);
            OperationContext = "GetKeyMgmtCertBEList";
            return client.GetCertificatesEC(shipment.Username, shipment.Password, shipment.ExternalServiceCode, shipment.ExternalServiceEditionCode);
        }

        public void TestKeyManagement(string selectedEnpointname, X509Certificate2 selectedCertificate)
        {
            var client = GenerateKeyManangementProxy(selectedEnpointname, selectedCertificate);
            OperationContext = "KeyMgmTest";
            client.Test();
        }
        #endregion
    }
}
