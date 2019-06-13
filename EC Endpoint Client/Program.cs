using System;
using System.Net;
using System.Windows.Forms;
using EC_Endpoint_Client.Functionality;

namespace EC_Endpoint_Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ServicePointManager.ServerCertificateValidationCallback = CertificateHandling.CertificateValidationCallback;
            //ServicePointManager.ServerCertificateValidationCallback = ((o, ce, ch, s) => true);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EcEndPointClient());
        }
    }
}
