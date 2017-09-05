using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Endpoint_Client.Classes.ExtendedClasses.Intermediary
{
    public class FormTaskShipment : EC_Endpoint_Client.IntermediaryInbound.FormTaskShipmentBE
    {
        public FormTaskShipment()
        {
            
        }
    }

    public class FormTask : EC_Endpoint_Client.IntermediaryInbound.FormTask
    {
        public FormTask()
        {
        }
    }

    public class Form : EC_Endpoint_Client.IntermediaryInbound.Form
    {
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FormDataField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 5)]
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string FormData
        {
            get
            {
                return this.FormDataField;
            }
            set
            {
                if ((object.ReferenceEquals(this.FormDataField, value) != true))
                {
                    this.FormDataField = value;
                    base.RaisePropertyChanged("FormData");
                }
            }
        }
        public Form()
        {
        }
    }
}
