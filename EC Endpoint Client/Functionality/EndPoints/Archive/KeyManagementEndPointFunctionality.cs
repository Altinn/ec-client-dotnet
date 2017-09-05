using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.KeyManagement;

namespace EC_Endpoint_Client.Functionality
{
    public class KeyManagementEndPointFunctionality : EndPointFunctionalityBase
    {
        #region KeyManagement
        private KeyManagementExternalECClient GenerateKeyManangementProxy(string selectedEndpointname, X509Certificate2 SelectedCertificate)
        {
            return GenerateProxy<KeyManagementExternalECClient, IKeyManagementExternalEC>(selectedEndpointname,
                SelectedCertificate);
        }

        public CertificateBEList GetKeyManagementCertificatesBEList(KeyManagementShipmentClass shipment)
        {
            var client = GenerateKeyManangementProxy(shipment.EndpointName, shipment.Certificate);
            OperationContext = "GetKeyMgmtCertBEList";
            return client.GetCertificatesEC(shipment.Username, shipment.Password, shipment.ExternalServiceCode, shipment.ExternalServiceEditionCode);
        }

        public void TestKeyManagement(string selectedEnpointname, X509Certificate2 SelectedCertificate)
        {
            var client = GenerateKeyManangementProxy(selectedEnpointname, SelectedCertificate);
            OperationContext = "KeyMgmTest";
            client.Test();
        }
        #endregion
    }
}
