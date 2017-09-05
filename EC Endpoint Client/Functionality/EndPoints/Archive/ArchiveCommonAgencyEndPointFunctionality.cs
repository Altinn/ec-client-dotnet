using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.ArchiveCommonAgency;
using EC_Endpoint_Client.Classes;

namespace EC_Endpoint_Client.Functionality
{
    public class ArchiveCommonAgencyEndPointFunctionality : EndPointFunctionalityBase
    {

        #region Archivecommonagency
        /// <summary>
        /// This function generates the ArchiveCommonProxy, and uses this client to make a service call.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="exSOASearchBE"></param>
        /// <param name="languageId"></param>
        /// <param name="selectedEndpointName"></param>
        /// <param name="SelectedCertificate"></param>
        /// <returns></returns>
        public ServiceOwnerArchiveReporteeElementBEV2List GetArchiveCommonAgencyReporteeElementsEC(string userName, string password, ExternalSOASearchBE exSOASearchBE, int languageId, string selectedEndpointName, X509Certificate2 SelectedCertificate)
        {
            ServiceOwnerArchiveReporteeElementBEV2List soaREBEV2List;
            var client = GenerateArchiveCommonProxy(selectedEndpointName, SelectedCertificate);
            
            OperationContext = "GetArchiveCommonAgencyReporteeElmeentsEC";
            soaREBEV2List = client.GetServiceOwnerArchiveReporteeElementsEC(userName, password, exSOASearchBE, languageId);
            return soaREBEV2List;
        }

        public void TestArchiveCommonAgency(string selectedEndpointName, X509Certificate2 SelectedCertificate)
        {
            var client = GenerateArchiveCommonProxy(selectedEndpointName, SelectedCertificate);
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
        /// <param name="SelectedCertificate"></param>
        /// <returns></returns>
        private ArchiveCommonAgencyExternalECClient GenerateArchiveCommonProxy(string selectedEndpointName, X509Certificate2 SelectedCertificate)
        {
            return GenerateProxy<ArchiveCommonAgencyExternalECClient, IArchiveCommonAgencyExternalEC>(selectedEndpointName, SelectedCertificate);
        }

        #endregion
    }
}
