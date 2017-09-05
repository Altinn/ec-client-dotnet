using EC_Endpoint_Client.BaseForms;
using EC_Endpoint_Client.Functionality;
using EC_Endpoint_Client.Functionality.EndPoints.Authorization;
using EC_Endpoint_Client.Token;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC_Endpoint_Client.Forms.Authorization
{
    public partial class AuthorizationTokenForm : ClientBaseForm
    {
        public AuthorizationTokenEndPointFunctionality AuthTokenEPFunc { get; set; }
        public GetTokenByAuthorizationCodeShipment GetTokenShipment { get; set; }

        public AuthorizationTokenForm()
        {
            InitializeComponent();
            GetTokenShipment = new GetTokenByAuthorizationCodeShipment();
            AuthTokenEPFunc = new AuthorizationTokenEndPointFunctionality();
            AuthTokenEPFunc.ReturnMessageXml += ReturnMessageXmlHandler;
        }

        void ReturnMessageXmlHandler(object sender, EventArgs e)
        {
        }

        private void btn_GetToken_Click(object sender, EventArgs e)
        {
            // Get token from text field
            Guid authorizationCode = GetTokenShipment.AuthorizationCode;
            string userName = SystemUsername;
            string password = SystemPassword;
            bool selfContained = GetTokenShipment.SelfContainedToken;

            // Querry service and populate response
            try
            {
                AuthorizationAccessTokenResponseContainer result = GetAccessToken(userName, password, authorizationCode,
                    selfContained);
                SetViewedItem(result, "Getting access token");
            }
            catch (Exception exception)
            {
                SetViewedItem(exception, "Error during test");
            }
        }

        private AuthorizationAccessTokenResponseContainer GetAccessToken(
            string userName, string password, Guid authorizationCode, bool selfContained)
        {
            // Get Altinn certificate for signing tokens
            string spiThumbprint = System.Configuration.ConfigurationManager.AppSettings["SpiCertificateThumbprint"];
            X509Certificate2 altinnCertificate = GetCertificateByThumbPrint(spiThumbprint);
            return AuthTokenEPFunc.GetSelfContainedToken(userName, password, SelectedEndpointName,
                SelectedCertificate, altinnCertificate, authorizationCode, selfContained);
        }

        private void btn_showTempKey_Click(object sender, EventArgs e)
        {
            SetViewedItem(GetTokenShipment, "Shipment to send to AuthorizationToken");
        }
    }
}
