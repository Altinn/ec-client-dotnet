using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace EC_Endpoint_Client.Functionality
{
    class CertificateHandling
    {
        public static bool CertificateValidationCallback(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors sslPe)
        {
            return true;
        }
    }
}
