﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EC_Endpoint_Client.SOArchiveStreamedEC2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AltinnFault", Namespace="http://www.altinn.no/services/common/fault/2009/10")]
    [System.SerializableAttribute()]
    public partial class AltinnFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AltinnErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AltinnExtendedErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AltinnLocalizedErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorGuidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ErrorIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserGuidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AltinnErrorMessage {
            get {
                return this.AltinnErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.AltinnErrorMessageField, value) != true)) {
                    this.AltinnErrorMessageField = value;
                    this.RaisePropertyChanged("AltinnErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AltinnExtendedErrorMessage {
            get {
                return this.AltinnExtendedErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.AltinnExtendedErrorMessageField, value) != true)) {
                    this.AltinnExtendedErrorMessageField = value;
                    this.RaisePropertyChanged("AltinnExtendedErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AltinnLocalizedErrorMessage {
            get {
                return this.AltinnLocalizedErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.AltinnLocalizedErrorMessageField, value) != true)) {
                    this.AltinnLocalizedErrorMessageField = value;
                    this.RaisePropertyChanged("AltinnLocalizedErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorGuid {
            get {
                return this.ErrorGuidField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorGuidField, value) != true)) {
                    this.ErrorGuidField = value;
                    this.RaisePropertyChanged("ErrorGuid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ErrorID {
            get {
                return this.ErrorIDField;
            }
            set {
                if ((this.ErrorIDField.Equals(value) != true)) {
                    this.ErrorIDField = value;
                    this.RaisePropertyChanged("ErrorID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserGuid {
            get {
                return this.UserGuidField;
            }
            set {
                if ((object.ReferenceEquals(this.UserGuidField, value) != true)) {
                    this.UserGuidField = value;
                    this.RaisePropertyChanged("UserGuid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((object.ReferenceEquals(this.UserIdField, value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.altinn.no/services/Archive/ServiceOwnerArchive/2013/06", ConfigurationName="SOArchiveStreamedEC2.IServiceOwnerArchiveExternalStreamedEC2")]
    public interface IServiceOwnerArchiveExternalStreamedEC2 {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://www.altinn.no/services/2009/10) of message TestRequest does not match the default value (http://www.altinn.no/services/Archive/ServiceOwnerArchive/2013/06)
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/Test", ReplyAction="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EC_Endpoint_Client.SOArchiveStreamedEC2.AltinnFault), Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestAltinnFaultFault", Name="AltinnFault", Namespace="http://www.altinn.no/services/common/fault/2009/10")]
        EC_Endpoint_Client.SOArchiveStreamedEC2.TestResponse Test(EC_Endpoint_Client.SOArchiveStreamedEC2.TestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/Test", ReplyAction="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestResponse")]
        System.Threading.Tasks.Task<EC_Endpoint_Client.SOArchiveStreamedEC2.TestResponse> TestAsync(EC_Endpoint_Client.SOArchiveStreamedEC2.TestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/Archive/ServiceOwnerArchive/2013/06/IServiceOwnerAr" +
            "chiveExternalStreamedEC/GetAttachmentDataStreamedEC", ReplyAction="http://www.altinn.no/services/Archive/ServiceOwnerArchive/2013/06/IServiceOwnerAr" +
            "chiveExternalStreamedEC/GetAttachmentDataStreamedECResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EC_Endpoint_Client.SOArchiveStreamedEC2.AltinnFault), Action="http://www.altinn.no/services/Archive/ServiceOwnerArchive/2013/06/IServiceOwnerAr" +
            "chiveExternalStreamedEC/GetAttachmentDataStreamedECAltinnFaultFault", Name="AltinnFault", Namespace="http://www.altinn.no/services/common/fault/2009/10")]
        System.IO.Stream GetAttachmentDataStreamedEC(string systemUserName, string systemPassword, int attachmentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/Archive/ServiceOwnerArchive/2013/06/IServiceOwnerAr" +
            "chiveExternalStreamedEC/GetAttachmentDataStreamedEC", ReplyAction="http://www.altinn.no/services/Archive/ServiceOwnerArchive/2013/06/IServiceOwnerAr" +
            "chiveExternalStreamedEC/GetAttachmentDataStreamedECResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> GetAttachmentDataStreamedECAsync(string systemUserName, string systemPassword, int attachmentId);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Test", WrapperNamespace="http://www.altinn.no/services/2009/10", IsWrapped=true)]
    public partial class TestRequest {
        
        public TestRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="TestResponse", WrapperNamespace="http://www.altinn.no/services/2009/10", IsWrapped=true)]
    public partial class TestResponse {
        
        public TestResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceOwnerArchiveExternalStreamedEC2Channel : EC_Endpoint_Client.SOArchiveStreamedEC2.IServiceOwnerArchiveExternalStreamedEC2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceOwnerArchiveExternalStreamedEC2Client : System.ServiceModel.ClientBase<EC_Endpoint_Client.SOArchiveStreamedEC2.IServiceOwnerArchiveExternalStreamedEC2>, EC_Endpoint_Client.SOArchiveStreamedEC2.IServiceOwnerArchiveExternalStreamedEC2 {
        
        public ServiceOwnerArchiveExternalStreamedEC2Client() {
        }
        
        public ServiceOwnerArchiveExternalStreamedEC2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceOwnerArchiveExternalStreamedEC2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceOwnerArchiveExternalStreamedEC2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceOwnerArchiveExternalStreamedEC2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EC_Endpoint_Client.SOArchiveStreamedEC2.TestResponse EC_Endpoint_Client.SOArchiveStreamedEC2.IServiceOwnerArchiveExternalStreamedEC2.Test(EC_Endpoint_Client.SOArchiveStreamedEC2.TestRequest request) {
            return base.Channel.Test(request);
        }
        
        public void Test() {
            EC_Endpoint_Client.SOArchiveStreamedEC2.TestRequest inValue = new EC_Endpoint_Client.SOArchiveStreamedEC2.TestRequest();
            EC_Endpoint_Client.SOArchiveStreamedEC2.TestResponse retVal = ((EC_Endpoint_Client.SOArchiveStreamedEC2.IServiceOwnerArchiveExternalStreamedEC2)(this)).Test(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<EC_Endpoint_Client.SOArchiveStreamedEC2.TestResponse> EC_Endpoint_Client.SOArchiveStreamedEC2.IServiceOwnerArchiveExternalStreamedEC2.TestAsync(EC_Endpoint_Client.SOArchiveStreamedEC2.TestRequest request) {
            return base.Channel.TestAsync(request);
        }
        
        public System.Threading.Tasks.Task<EC_Endpoint_Client.SOArchiveStreamedEC2.TestResponse> TestAsync() {
            EC_Endpoint_Client.SOArchiveStreamedEC2.TestRequest inValue = new EC_Endpoint_Client.SOArchiveStreamedEC2.TestRequest();
            return ((EC_Endpoint_Client.SOArchiveStreamedEC2.IServiceOwnerArchiveExternalStreamedEC2)(this)).TestAsync(inValue);
        }
        
        public System.IO.Stream GetAttachmentDataStreamedEC(string systemUserName, string systemPassword, int attachmentId) {
            return base.Channel.GetAttachmentDataStreamedEC(systemUserName, systemPassword, attachmentId);
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> GetAttachmentDataStreamedECAsync(string systemUserName, string systemPassword, int attachmentId) {
            return base.Channel.GetAttachmentDataStreamedECAsync(systemUserName, systemPassword, attachmentId);
        }
    }
}
