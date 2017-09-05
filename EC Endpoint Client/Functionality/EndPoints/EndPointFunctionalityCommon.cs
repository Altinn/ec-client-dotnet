using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using EC_Endpoint_Client.Classes;
using System.ServiceModel;

namespace EC_Endpoint_Client.Functionality
{
    /// <summary>
    /// This base class contains som functionality that every endpoint function uses for its proxy generation.
    /// Since all the endpoint code that uses the EndPointFunctionalityBase use the exact same implementation, 
    /// I will only comment the Archive/ArchiveCommonAgencyendpointFunctionality.cs file and the
    /// ServiceEngine/NotificationAgencyEndpointFunction.cs file.
    /// </summary>
    public class EndPointFunctionalityBase
    {
        public event EventHandler ReturnMessageXml;
        public string OperationContext { get; set; }

        protected T GenerateProxy<T, T1>(string EndpointName, X509Certificate2 SelectedCertificate, bool setInspectorBehavior = true) where T : ClientBase<T1>, T1 where T1 : class
        {
            T proxy = Activator.CreateInstance(typeof(T), EndpointName) as T;
            proxy.ClientCredentials.ClientCertificate.Certificate = SelectedCertificate;
            GetCredentialsForServiceCertificate(proxy.ClientCredentials.ServiceCertificate);
            if (setInspectorBehavior)
            {
                SetInspectorBehavior(proxy.Endpoint.EndpointBehaviors);
            }

            return proxy;
        }

        /// <summary>
        /// This function sets the Credentials that you can see in the app.config file under endPointBehavior/ServiceCertificate. It's always 
        /// set the same way, and since we're not using the App.config file to set the behavior when we generate proxies (so that users can dynamically set the clientcertificate), 
        /// we have to set these values programatically. The behavior is still in the app.config file, and is used to set a default certificate when the client starts.
        /// </summary>
        /// <param name="incredents"></param>
        protected void GetCredentialsForServiceCertificate(X509CertificateRecipientClientCredential incredents)
        {
            incredents.Authentication.CertificateValidationMode = X509CertificateValidationMode.ChainTrust;
            incredents.Authentication.RevocationMode = X509RevocationMode.NoCheck;
            incredents.Authentication.TrustedStoreLocation = StoreLocation.LocalMachine;
        }

        /// <summary>
        /// Used to return the soap messages that the proxies send and receive.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ReturnMessageXMLHandler(object sender, EventArgs e)
        {
            ((BaseSoapHolder)sender).Call = OperationContext;
            ReturnMessageXml(sender, e);
        }

        /// <summary>
        /// This is used to set the inspector behaviors for the proxies, so that we can grab the soap requests and responses when we make service calls.
        /// </summary>
        /// <param name="endpointBehaviors"></param>
        protected void SetInspectorBehavior(System.Collections.ObjectModel.KeyedCollection<Type, System.ServiceModel.Description.IEndpointBehavior> endpointBehaviors)
        {
            InspectorBehavior inspectorBehavior = new InspectorBehavior();
            inspectorBehavior.ReturnMessageXML += ReturnMessageXMLHandler;
            endpointBehaviors.Add(inspectorBehavior);
        }
    }
}
