using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.Forms;

namespace EC_Endpoint_Client
{
    class CertificateHandling
    {
        public static bool CertificateValidationCallback(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors sslPE)
        {
            return true;
        }
    }
}
