using System;
using System.IO;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Xml;
using EC_Endpoint_Client.Classes;

namespace EC_Endpoint_Client.Functionality.EndPoints
{
    public class CustomMessageInspector : IClientMessageInspector
    {
        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
            MessageBuffer buffer = reply.CreateBufferedCopy(int.MaxValue);
            Message mess = buffer.CreateMessage();
            MemoryStream ms = new MemoryStream();
            XmlWriter writer = XmlWriter.Create(ms);
            mess.WriteMessage(writer);
            writer.Flush();
            ms.Position = 0;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(ms);
            //this.ChangeMessage(xmlDoc);
            reply = buffer.CreateMessage();
            BaseSoapHolder holder = new BaseSoapHolder();
            holder.SoapContext = SoapContext.Reply;
            holder.XmlDocument = xmlDoc;
            ReturnMessageXml?.Invoke(holder, new EventArgs());
        }
        public object BeforeSendRequest(ref Message request, System.ServiceModel.IClientChannel channel)
        {
            MessageBuffer buffer = request.CreateBufferedCopy(int.MaxValue);
            Message mess = buffer.CreateMessage();
            MemoryStream ms = new MemoryStream();
            XmlWriter writer = XmlWriter.Create(ms);
            mess.WriteMessage(writer);
            writer.Flush();
            ms.Position = 0;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(ms);
            //this.ChangeMessage(xmlDoc);
            BaseSoapHolder holder = new BaseSoapHolder();
            holder.SoapContext = SoapContext.Request;
            holder.XmlDocument = xmlDoc;
            request = buffer.CreateMessage() ;
            ReturnMessageXml?.Invoke(holder, new EventArgs());
            return null;
        }
        public event EventHandler ReturnMessageXml;
    }

    public class InspectorBehavior : IEndpointBehavior
    {
        public event EventHandler ReturnMessageXml;
        public void AddBindingParameters(ServiceEndpoint serviceEndpoint, BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyClientBehavior(ServiceEndpoint serviceEndpoint, ClientRuntime behavior)
        {
            //Add the inspector
            CustomMessageInspector cmi = new CustomMessageInspector();
            cmi.ReturnMessageXml += cmi_ReturnMessageXML;
            behavior.MessageInspectors.Add(cmi);
        }

        void cmi_ReturnMessageXML(object sender, EventArgs e)
        {
            ReturnMessageXml?.Invoke(sender, e);
        }

        public void ApplyDispatchBehavior(ServiceEndpoint serviceEndpoint, EndpointDispatcher endpointDispatcher)
        {
        }
        public void Validate(ServiceEndpoint serviceEndpoint)
        {
        }

        
    }
}
