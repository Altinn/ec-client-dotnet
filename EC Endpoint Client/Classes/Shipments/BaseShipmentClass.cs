using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EC_Endpoint_Client.Classes
{
    /// <summary>
    /// This is the base shipment class.
    /// All information contained within it has been made unbrowsable and 
    /// it's not written to XML files. (The X509Certificate2 class will always fail being serialized into XML and
    /// the other information contained shouldn't be shown in the property grid or in the serialized shipment xml.)
    /// </summary>
    public class BaseShipment
    {
        [Browsable(false)]
        [XmlIgnore]
        public string Username { get; set; }
        [Browsable(false)]
        [XmlIgnore]
        public string Password { get; set; }
        [Browsable(false)]
        [XmlIgnore]
        public string EndpointName { get; set; }
        [Browsable(false)]
        [XmlIgnore]
        public X509Certificate2 Certificate { get; set; }
    }

    public class BaseShipmentClassWithVisibleMembers
    {
        /// <summary>
        /// Gets or sets the Username.
        /// </summary>
        [XmlIgnore]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the Password.
        /// </summary>
        [XmlIgnore]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the EndpointName
        /// </summary>
        [XmlIgnore]
        public string EndpointName { get; set; }

        /// <summary>
        /// Gets or sets the Certificate
        /// </summary>
        [XmlIgnore]
        public X509Certificate2 Certificate { get; set; }
    }

    /// <summary>
    /// This base shipment also takes a ReporteeElementId.
    /// </summary>
    public class BaseReporteeElementIdShipment : BaseShipment
    {
        /// <summary>
        /// Gets or sets the ReporteeElemenetId
        /// </summary>
        public int ReporteeElementId { get; set; }
    }
}
