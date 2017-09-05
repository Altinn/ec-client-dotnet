using EC_Endpoint_Client.Token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Tokens;
using System.Security.Claims;
using System.IdentityModel.Protocols.WSTrust;
using System.ServiceModel.Security.Tokens;
using EC_Endpoint_Client.Forms.Authorization;

namespace EC_Endpoint_Client.Functionality.EndPoints.Authorization
{
    public class AuthorizationTokenEndPointFunctionality : EndPointFunctionalityBase
    {
        #region Public methods
        public AuthorizationAccessTokenResponseContainer GetSelfContainedToken(string userName, string password,
            string selectedEndpointName, X509Certificate2 selectedCertificate, X509Certificate2 altinnCertificate, 
            Guid authorizationCode, bool selfContained)
        {
            var client = GenerateAuthorizationTokenProxy(selectedEndpointName, selectedCertificate);
            OperationContext = "AuthAccessTokenTest";

            var accessToken = client.GetAccessToken(userName, password, authorizationCode, selfContained);

            SecurityToken validationResult = null;
            if (selfContained)
            {
                validationResult = ValidateToken(altinnCertificate, accessToken.SelfContainedToken);
            }

            return new AuthorizationAccessTokenResponseContainer() 
                { 
                    UnwrappedToken = validationResult,
                    SelfContainedToken = accessToken.SelfContainedToken,
                    ReferenceToken = accessToken.ReferenceToken
                };
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

        private AuthorizationTokenExternalECClient GenerateAuthorizationTokenProxy(string selectedEndpointName, 
            X509Certificate2 selectedCertificate)
        {
            return GenerateProxy<AuthorizationTokenExternalECClient, IAuthorizationTokenExternalEC>(
                selectedEndpointName, selectedCertificate);
        }
        #endregion
    }
}
