using System.Xml;

namespace EC_Endpoint_Client.Classes
{
    public class BaseSoapHolder
    {
        public XmlDocument XmlDocument { get; set; }
        public SoapContext SoapContext { get; set; }
        public string Call { get; set; }
    }

    public enum SoapContext
    {
        Request,
        Reply
    }
}
