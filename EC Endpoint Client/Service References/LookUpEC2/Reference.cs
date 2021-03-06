﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EC_Endpoint_Client.LookUpEC2 {
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LookUpRequest", Namespace="http://www.altinn.no/services/ServiceEngine/LookUp/2016/02")]
    [System.SerializableAttribute()]
    public partial class LookUpRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string QueryDataField;
        
        private string ReporteeField;
        
        private string ServiceCodeField;
        
        private int ServiceEditionCodeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string QueryData {
            get {
                return this.QueryDataField;
            }
            set {
                if ((object.ReferenceEquals(this.QueryDataField, value) != true)) {
                    this.QueryDataField = value;
                    this.RaisePropertyChanged("QueryData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Reportee {
            get {
                return this.ReporteeField;
            }
            set {
                if ((object.ReferenceEquals(this.ReporteeField, value) != true)) {
                    this.ReporteeField = value;
                    this.RaisePropertyChanged("Reportee");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string ServiceCode {
            get {
                return this.ServiceCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ServiceCodeField, value) != true)) {
                    this.ServiceCodeField = value;
                    this.RaisePropertyChanged("ServiceCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int ServiceEditionCode {
            get {
                return this.ServiceEditionCodeField;
            }
            set {
                if ((this.ServiceEditionCodeField.Equals(value) != true)) {
                    this.ServiceEditionCodeField = value;
                    this.RaisePropertyChanged("ServiceEditionCode");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.altinn.no/services/ServiceEngine/LookUp/2016/02", ConfigurationName="LookUpEC2.ILookUpExternalEC2")]
    public interface ILookUpExternalEC2 {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://www.altinn.no/services/2009/10) of message TestRequest does not match the default value (http://www.altinn.no/services/ServiceEngine/LookUp/2016/02)
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/Test", ReplyAction="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EC_Endpoint_Client.LookUpEC2.AltinnFault), Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestAltinnFaultFault", Name="AltinnFault", Namespace="http://www.altinn.no/services/common/fault/2009/10")]
        EC_Endpoint_Client.LookUpEC2.TestResponse Test(EC_Endpoint_Client.LookUpEC2.TestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/Test", ReplyAction="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestResponse")]
        System.Threading.Tasks.Task<EC_Endpoint_Client.LookUpEC2.TestResponse> TestAsync(EC_Endpoint_Client.LookUpEC2.TestRequest request);
        
        // CODEGEN: Generating message contract since element name userName from namespace http://www.altinn.no/services/ServiceEngine/LookUp/2016/02 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/ServiceEngine/LookUp/2016/02/ILookUpExternalEC/Exec" +
            "uteLookUp", ReplyAction="http://www.altinn.no/services/ServiceEngine/LookUp/2016/02/ILookUpExternalEC/Exec" +
            "uteLookUpResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EC_Endpoint_Client.LookUpEC2.AltinnFault), Action="http://www.altinn.no/services/ServiceEngine/LookUp/2016/02/ILookUpExternalEC/Exec" +
            "uteLookUpAltinnFaultFault", Name="AltinnFault", Namespace="http://www.altinn.no/services/common/fault/2009/10")]
        EC_Endpoint_Client.LookUpEC2.ExecuteLookUpResponse ExecuteLookUp(EC_Endpoint_Client.LookUpEC2.ExecuteLookUpRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/ServiceEngine/LookUp/2016/02/ILookUpExternalEC/Exec" +
            "uteLookUp", ReplyAction="http://www.altinn.no/services/ServiceEngine/LookUp/2016/02/ILookUpExternalEC/Exec" +
            "uteLookUpResponse")]
        System.Threading.Tasks.Task<EC_Endpoint_Client.LookUpEC2.ExecuteLookUpResponse> ExecuteLookUpAsync(EC_Endpoint_Client.LookUpEC2.ExecuteLookUpRequest request);
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExecuteLookUpRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExecuteLookUp", Namespace="http://www.altinn.no/services/ServiceEngine/LookUp/2016/02", Order=0)]
        public EC_Endpoint_Client.LookUpEC2.ExecuteLookUpRequestBody Body;
        
        public ExecuteLookUpRequest() {
        }
        
        public ExecuteLookUpRequest(EC_Endpoint_Client.LookUpEC2.ExecuteLookUpRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.altinn.no/services/ServiceEngine/LookUp/2016/02")]
    public partial class ExecuteLookUpRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public EC_Endpoint_Client.LookUpEC2.LookUpRequest lookUpRequest;
        
        public ExecuteLookUpRequestBody() {
        }
        
        public ExecuteLookUpRequestBody(string userName, string password, EC_Endpoint_Client.LookUpEC2.LookUpRequest lookUpRequest) {
            this.userName = userName;
            this.password = password;
            this.lookUpRequest = lookUpRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExecuteLookUpResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ExecuteLookUpResponse", Namespace="http://www.altinn.no/services/ServiceEngine/LookUp/2016/02", Order=0)]
        public EC_Endpoint_Client.LookUpEC2.ExecuteLookUpResponseBody Body;
        
        public ExecuteLookUpResponse() {
        }
        
        public ExecuteLookUpResponse(EC_Endpoint_Client.LookUpEC2.ExecuteLookUpResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.altinn.no/services/ServiceEngine/LookUp/2016/02")]
    public partial class ExecuteLookUpResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public string ExecuteLookUpResult;
        
        public ExecuteLookUpResponseBody() {
        }
        
        public ExecuteLookUpResponseBody(string ExecuteLookUpResult) {
            this.ExecuteLookUpResult = ExecuteLookUpResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILookUpExternalEC2Channel : EC_Endpoint_Client.LookUpEC2.ILookUpExternalEC2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LookUpExternalEC2Client : System.ServiceModel.ClientBase<EC_Endpoint_Client.LookUpEC2.ILookUpExternalEC2>, EC_Endpoint_Client.LookUpEC2.ILookUpExternalEC2 {
        
        public LookUpExternalEC2Client() {
        }
        
        public LookUpExternalEC2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LookUpExternalEC2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LookUpExternalEC2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LookUpExternalEC2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EC_Endpoint_Client.LookUpEC2.TestResponse EC_Endpoint_Client.LookUpEC2.ILookUpExternalEC2.Test(EC_Endpoint_Client.LookUpEC2.TestRequest request) {
            return base.Channel.Test(request);
        }
        
        public void Test() {
            EC_Endpoint_Client.LookUpEC2.TestRequest inValue = new EC_Endpoint_Client.LookUpEC2.TestRequest();
            EC_Endpoint_Client.LookUpEC2.TestResponse retVal = ((EC_Endpoint_Client.LookUpEC2.ILookUpExternalEC2)(this)).Test(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<EC_Endpoint_Client.LookUpEC2.TestResponse> EC_Endpoint_Client.LookUpEC2.ILookUpExternalEC2.TestAsync(EC_Endpoint_Client.LookUpEC2.TestRequest request) {
            return base.Channel.TestAsync(request);
        }
        
        public System.Threading.Tasks.Task<EC_Endpoint_Client.LookUpEC2.TestResponse> TestAsync() {
            EC_Endpoint_Client.LookUpEC2.TestRequest inValue = new EC_Endpoint_Client.LookUpEC2.TestRequest();
            return ((EC_Endpoint_Client.LookUpEC2.ILookUpExternalEC2)(this)).TestAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EC_Endpoint_Client.LookUpEC2.ExecuteLookUpResponse EC_Endpoint_Client.LookUpEC2.ILookUpExternalEC2.ExecuteLookUp(EC_Endpoint_Client.LookUpEC2.ExecuteLookUpRequest request) {
            return base.Channel.ExecuteLookUp(request);
        }
        
        public string ExecuteLookUp(string userName, string password, EC_Endpoint_Client.LookUpEC2.LookUpRequest lookUpRequest) {
            EC_Endpoint_Client.LookUpEC2.ExecuteLookUpRequest inValue = new EC_Endpoint_Client.LookUpEC2.ExecuteLookUpRequest();
            inValue.Body = new EC_Endpoint_Client.LookUpEC2.ExecuteLookUpRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            inValue.Body.lookUpRequest = lookUpRequest;
            EC_Endpoint_Client.LookUpEC2.ExecuteLookUpResponse retVal = ((EC_Endpoint_Client.LookUpEC2.ILookUpExternalEC2)(this)).ExecuteLookUp(inValue);
            return retVal.Body.ExecuteLookUpResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<EC_Endpoint_Client.LookUpEC2.ExecuteLookUpResponse> EC_Endpoint_Client.LookUpEC2.ILookUpExternalEC2.ExecuteLookUpAsync(EC_Endpoint_Client.LookUpEC2.ExecuteLookUpRequest request) {
            return base.Channel.ExecuteLookUpAsync(request);
        }
        
        public System.Threading.Tasks.Task<EC_Endpoint_Client.LookUpEC2.ExecuteLookUpResponse> ExecuteLookUpAsync(string userName, string password, EC_Endpoint_Client.LookUpEC2.LookUpRequest lookUpRequest) {
            EC_Endpoint_Client.LookUpEC2.ExecuteLookUpRequest inValue = new EC_Endpoint_Client.LookUpEC2.ExecuteLookUpRequest();
            inValue.Body = new EC_Endpoint_Client.LookUpEC2.ExecuteLookUpRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            inValue.Body.lookUpRequest = lookUpRequest;
            return ((EC_Endpoint_Client.LookUpEC2.ILookUpExternalEC2)(this)).ExecuteLookUpAsync(inValue);
        }
    }
}
