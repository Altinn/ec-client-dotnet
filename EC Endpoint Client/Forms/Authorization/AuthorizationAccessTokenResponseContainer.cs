using System;
using System.IdentityModel.Tokens;

namespace EC_Endpoint_Client.Forms.Authorization
{
    /// <summary>
    /// Simple container that contains encrypted and decrypted Response
    /// </summary>
    public class AuthorizationAccessTokenResponseContainer
    {
        public String SelfContainedToken { get; set; }

        public SecurityToken UnwrappedToken { get; set; }

        public Guid? ReferenceToken { get; set; }
    }
}
