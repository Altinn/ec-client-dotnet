using EC_Endpoint_Client.Functionality.EndPoints.Authorization;
using System;
using System.Security.Cryptography.X509Certificates;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.Authorization;

namespace EC_Endpoint_Client.Forms.Authorization
{
    public partial class AuthorizationTokenFormEC2 : BaseForms.ClientBaseForm
    {
        public AuthorizationTokenEndPointFunctionalityEC2 AuthTokenEpFunc { get; set; }
        public GetTokenByAuthorizationCodeShipment GetTokenShipment { get; set; }
        public AuthorizationAccessTokenResponseContainer TokenResponse { get; set; }

        public AuthorizationTokenFormEC2()
        {
            InitializeComponent();
            GetTokenShipment = new GetTokenByAuthorizationCodeShipment();
            AuthTokenEpFunc = new AuthorizationTokenEndPointFunctionalityEC2();
            AuthTokenEpFunc.ReturnMessageXml += ReturnMessageXmlHandler;
            AssignActions();
        }

        public override void ReturnMessageXmlHandler(object sender, EventArgs e)
        {
        }

        private void AssignActions()
        {
            AssignAction(controllerGetRightsByToken, AuthTokenEpFunc.GetSelfContainedToken, GetTokenShipment, TokenResponse, "GetTokenService" );
            AssignAction(testController, AuthTokenEpFunc.Test, BaseShipment, "Test Service");
        }
        /*
        public override void SetBasicShipmentSettings(BaseShipment shipment)
        {
            base.SetBasicShipmentSettings(shipment);
            string spiThumbprint = System.Configuration.ConfigurationManager.AppSettings["SpiCertificateThumbprint"];
            ((GetTokenByAuthorizationCodeShipment)shipment).SpiCertificate = GetCertificateByThumbPrint(spiThumbprint);
        }
        */
    }
}
