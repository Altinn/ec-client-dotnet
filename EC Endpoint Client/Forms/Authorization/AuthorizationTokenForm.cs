using EC_Endpoint_Client.Functionality.EndPoints.Authorization;
using System;
using System.Security.Cryptography.X509Certificates;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.Authorization;

namespace EC_Endpoint_Client.Forms.Authorization
{
    public partial class AuthorizationTokenForm : BaseForms.ClientBaseForm
    {
        public AuthorizationTokenEndPointFunctionality AuthTokenEpFunc { get; set; }
        public GetTokenByAuthorizationCodeShipment GetTokenShipment { get; set; }
        public AuthorizationAccessTokenResponseContainer TokenResponse { get; set; }

        public AuthorizationTokenForm()
        {
            InitializeComponent();
            GetTokenShipment = new GetTokenByAuthorizationCodeShipment();
            AuthTokenEpFunc = new AuthorizationTokenEndPointFunctionality();
            AuthTokenEpFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            AssignActions();
        }

        public override void ReturnMessageXmlHandler(object sender, EventArgs e)
        {
        }

        private void AssignActions()
        {
            AssignAction(controllerGetRightsByToken, AuthTokenEpFunc.GetSelfContainedToken, GetTokenShipment, TokenResponse, "GetTokenService" );
        }

        public override void SetBasicShipmentSettings(BaseShipment shipment)
        {
            base.SetBasicShipmentSettings(shipment);
            string spiThumbprint = System.Configuration.ConfigurationManager.AppSettings["SpiCertificateThumbprint"];
            ((GetTokenByAuthorizationCodeShipment)shipment).SpiCertificate = GetCertificateByThumbPrint(spiThumbprint);
        }
    }
}
