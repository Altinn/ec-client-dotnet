using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Endpoint_Client.Functionality
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.ServiceModel;
    using System.ServiceModel.Channels;
    using System.ServiceModel.Description;
    using System.ServiceModel.Dispatcher;
    using System.Xml;
    using EC_Endpoint_Client.Classes;


    public class CustomMessageInspector : IClientMessageInspector
    {
        public void AfterReceiveReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
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
            ReturnMessageXML(holder, new EventArgs());
        }
        public object BeforeSendRequest(ref System.ServiceModel.Channels.Message request, System.ServiceModel.IClientChannel channel)
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
            ReturnMessageXML(holder, new EventArgs());
            return null;
        }
        public event EventHandler ReturnMessageXML;
    }

    public class InspectorBehavior : IEndpointBehavior
    {
        public event EventHandler ReturnMessageXML;
        public void AddBindingParameters(ServiceEndpoint serviceEndpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyClientBehavior(ServiceEndpoint serviceEndpoint, System.ServiceModel.Dispatcher.ClientRuntime behavior)
        {
            //Add the inspector
            CustomMessageInspector cmi = new CustomMessageInspector();
            cmi.ReturnMessageXML += cmi_ReturnMessageXML;
            behavior.MessageInspectors.Add(cmi);
        }

        void cmi_ReturnMessageXML(object sender, EventArgs e)
        {
            ReturnMessageXML(sender, e);
        }

        public void ApplyDispatchBehavior(ServiceEndpoint serviceEndpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher)
        {
        }
        public void Validate(ServiceEndpoint serviceEndpoint)
        {
        }

        
    }
}
