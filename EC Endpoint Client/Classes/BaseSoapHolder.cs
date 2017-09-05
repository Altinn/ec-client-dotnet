using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
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
