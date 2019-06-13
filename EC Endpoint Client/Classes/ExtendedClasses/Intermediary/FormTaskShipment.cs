using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using EC_Endpoint_Client.Service_References.IntermediaryInbound;

namespace EC_Endpoint_Client.Classes.ExtendedClasses.Intermediary
{
    public class FormTaskShipment : FormTaskShipmentBE
    {
        public FormTaskShipment()
        {
            
        }
    }

    public class FormTask : Service_References.IntermediaryInbound.FormTask
    {
        public FormTask()
        {
        }
    }

    public class Form : Service_References.IntermediaryInbound.Form
    {
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _formDataField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 5)]
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string FormData
        {
            get
            {
                return _formDataField;
            }
            set
            {
                if ((ReferenceEquals(_formDataField, value) != true))
                {
                    _formDataField = value;
                    RaisePropertyChanged("FormData");
                }
            }
        }
        public Form()
        {
        }
    }
}
