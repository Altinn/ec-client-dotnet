using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
