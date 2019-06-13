using System.Security.Cryptography.X509Certificates;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Forms.Archive;
using EC_Endpoint_Client.Service_References.ArchiveCommonAgency;

namespace EC_Endpoint_Client.Functionality.EndPoints.Archive
{
    public class ArchiveCommonAgencyEndPointFunctionality : EndPointFunctionalityBase
    {

        #region Archivecommonagency
        /// <summary>
        /// This function generates the ArchiveCommonProxy, and uses this client to make a service call.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="exSoaSearchBe"></param>
        /// <param name="languageId"></param>
        /// <param name="selectedEndpointName"></param>
        /// <param name="selectedCertificate"></param>
        /// <returns></returns>
        public ServiceOwnerArchiveReporteeElementBEV2List GetArchiveCommonAgencyReporteeElementsEc(ArchiveCommonAgencyShipment shipment)
        {
            ServiceOwnerArchiveReporteeElementBEV2List soaRebev2List;
            var client = GenerateArchiveCommonProxy(shipment.EndpointName, shipment.Certificate);
            
            OperationContext = "GetArchiveCommonAgencyReporteeElmeentsEC";
            soaRebev2List = client.GetServiceOwnerArchiveReporteeElementsEC(shipment.Username, shipment.Password, shipment.SoaSearch, shipment.LanguageId);
            return soaRebev2List;
        }

        public void TestArchiveCommonAgency(BaseShipment shipment)
        {
            var client = GenerateArchiveCommonProxy(shipment.EndpointName, shipment.Certificate);
            OperationContext = "ArchiveCommonAgencyTest";
            client.Test();
        }

        /// <summary>
        /// This function generates the ArchiveCommonProxy and returns the client for use.
        /// All the different endpointfunctionality code fiels generate proxies the exact same way, but I haven't found a way to generalize this
        /// method, so they have to implement this function in every file.
        /// The function gets the endpoint configuration from the app.config file, minus endpointbehaviors, which it sets programmatically through
        /// the base class. (It also adds an inspector to grab soap requests and responses.)
        /// </summary>
        /// <param name="selectedEndpointName"></param>
        /// <param name="selectedCertificate"></param>
        /// <returns></returns>
        private ArchiveCommonAgencyExternalECClient GenerateArchiveCommonProxy(string selectedEndpointName, X509Certificate2 selectedCertificate)
        {
            return GenerateProxy<ArchiveCommonAgencyExternalECClient, IArchiveCommonAgencyExternalEC>(selectedEndpointName, selectedCertificate);
        }

        #endregion
    }
}
