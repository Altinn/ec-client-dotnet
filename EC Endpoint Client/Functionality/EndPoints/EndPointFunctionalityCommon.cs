using System;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Security;
using EC_Endpoint_Client.Classes;
using EC_Endpoint_Client.Classes.Shipments;
using EC_Endpoint_Client.Configuration;

namespace EC_Endpoint_Client.Functionality.EndPoints
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

        protected T GenerateProxy<T, T1, TShipment>(TShipment shipment, bool setInspectorBehavior = true)
            where T : ClientBase<T1>, T1 where T1 : class where TShipment : BaseShipment
        {
            return GenerateProxy<T, T1>(shipment.EndpointName, shipment.Certificate, setInspectorBehavior);
        }

        protected T GenerateProxy<T, T1>(string endpointName, X509Certificate2 selectedCertificate, bool setInspectorBehavior = true) 
            where T : ClientBase<T1>, T1 where T1 : class
        {
            var proxy = Activator.CreateInstance(typeof(T)) as T;
            if (proxy?.ClientCredentials == null)
                return null;
            Tuple<string, string, int, bool?> replacement = GetHostForEnvironment(endpointName);
            var builder = new UriBuilder(proxy.Endpoint.Address.Uri) { Host = replacement.Item2, Scheme = replacement.Item1, Port = replacement.Item3 };

            if(replacement.Item4 != null)
            {
                if (builder.Query.Length > 1)
                {
                    builder.Query += "&bigiptestversion=" + replacement.Item4.ToString().ToLower();
                }
                else
                {
                    builder.Query = "bigiptestversion=" + replacement.Item4.ToString().ToLower();
                }
            }

            proxy.Endpoint.Address = new EndpointAddress(builder.Uri);
            proxy.ClientCredentials.ClientCertificate.Certificate = selectedCertificate;
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
            ReturnMessageXml?.Invoke(sender, e);
        }

        /// <summary>
        /// This is used to set the inspector behaviors for the proxies, so that we can grab the soap requests and responses when we make service calls.
        /// </summary>
        /// <param name="endpointBehaviors"></param>
        protected void SetInspectorBehavior(System.Collections.ObjectModel.KeyedCollection<Type, System.ServiceModel.Description.IEndpointBehavior> endpointBehaviors)
        {
            InspectorBehavior inspectorBehavior = new InspectorBehavior();
            inspectorBehavior.ReturnMessageXml += ReturnMessageXMLHandler;
            endpointBehaviors.Add(inspectorBehavior);
        }

        private Tuple<string, string, int, bool?> GetHostForEnvironment(string environment)
        {
            UriBuilder builder = new UriBuilder();
            builder.Host = "localhost";
            bool? useTestMode = null;
            foreach (EnvironmentUrl eu in EcClientConfiguration.GetConfig().EnvironmentUrlCollection)
            {
                if (eu.Name == environment)
                {
                    builder = new UriBuilder(eu.Environment);
                    useTestMode = eu.UseTestMode;
                    break;
                }
            }
            return new Tuple<string, string, int, bool?>(builder.Scheme, builder.Host, builder.Port, useTestMode);
        }
    }
}
