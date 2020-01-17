using System;
using System.Security.Cryptography.X509Certificates;
using System.IdentityModel.Tokens;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Classes.Shipments.Authorization;
using EC_Endpoint_Client.Forms.Authorization;
using EC_Endpoint_Client.TokenEC2;

namespace EC_Endpoint_Client.Functionality.EndPoints.Authorization
{
    public class AuthorizationTokenEndPointFunctionalityEC2 : EndPointFunctionalityBase
    {
        #region Public methods
        public AuthorizationAccessTokenResponseContainer GetSelfContainedToken(GetTokenByAuthorizationCodeShipment shipment)
        {
            var client = GenerateAuthorizationTokenProxy(shipment.EndpointName, shipment.Certificate);
            OperationContext = "AuthAccessTokenGet";

            var accessToken = client.GetAccessToken(shipment.Username, shipment.Password, shipment.AuthorizationCode, shipment.SelfContainedToken);

            SecurityToken validationResult = null;
            if (shipment.SelfContainedToken)
            {
                validationResult = ValidateToken(shipment.SpiCertificate, accessToken.SelfContainedToken);
            }

            return new AuthorizationAccessTokenResponseContainer() 
            { 
                UnwrappedToken = validationResult,
                SelfContainedToken = accessToken.SelfContainedToken,
                ReferenceToken = accessToken.ReferenceToken
            };
        }

        public void Test(BaseShipment shipment)
        {
            var client = GenerateAuthorizationTokenProxy(shipment.EndpointName, shipment.Certificate);
            OperationContext = "AuthAccessTokenTest";
            client.Test();
        }
        #endregion

        #region Private methods
        private SecurityToken ValidateToken(X509Certificate2 selectedCertificate, string tokenString)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            // Token Validation
            var validationParameters = new TokenValidationParameters()
            {
                IssuerSigningKey = new X509SecurityKey(selectedCertificate),
                ValidateAudience = false,
                ValidateIssuer = false,
                ValidateLifetime = true,
                ValidIssuer = "altinn.no"
            };

            SecurityToken securityToken;
            tokenHandler.ValidateToken(tokenString, validationParameters, out securityToken);

            return securityToken;
        }

        private AuthorizationTokenExternalEC2Client GenerateAuthorizationTokenProxy(string selectedEndpointName, 
            X509Certificate2 selectedCertificate)
        {
            return GenerateProxy<AuthorizationTokenExternalEC2Client, IAuthorizationTokenExternalEC2>(
                selectedEndpointName, selectedCertificate);
        }
        #endregion
    }
}
