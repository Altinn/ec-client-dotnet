﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EC_Endpoint_Client.Token {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthorizationAccessTokenResponseExternalBE", Namespace="http://schemas.datacontract.org/2004/07/Altinn.Common.SBL.Entities.Authorization")]
    [System.SerializableAttribute()]
    public partial class AuthorizationAccessTokenResponseExternalBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.Guid> ReferenceTokenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SelfContainedTokenField;
        
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
        public System.Nullable<System.Guid> ReferenceToken {
            get {
                return this.ReferenceTokenField;
            }
            set {
                if ((this.ReferenceTokenField.Equals(value) != true)) {
                    this.ReferenceTokenField = value;
                    this.RaisePropertyChanged("ReferenceToken");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SelfContainedToken {
            get {
                return this.SelfContainedTokenField;
            }
            set {
                if ((object.ReferenceEquals(this.SelfContainedTokenField, value) != true)) {
                    this.SelfContainedTokenField = value;
                    this.RaisePropertyChanged("SelfContainedToken");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.altinn.no/services/Authorization/Administration/2016/02", ConfigurationName="Token.IAuthorizationTokenExternalEC")]
    public interface IAuthorizationTokenExternalEC {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://www.altinn.no/services/2009/10) of message TestRequest does not match the default value (http://www.altinn.no/services/Authorization/Administration/2016/02)
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/Test", ReplyAction="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EC_Endpoint_Client.Token.AltinnFault), Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestAltinnFaultFault", Name="AltinnFault", Namespace="http://www.altinn.no/services/common/fault/2009/10")]
        EC_Endpoint_Client.Token.TestResponse Test(EC_Endpoint_Client.Token.TestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/Test", ReplyAction="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestResponse")]
        System.Threading.Tasks.Task<EC_Endpoint_Client.Token.TestResponse> TestAsync(EC_Endpoint_Client.Token.TestRequest request);
        
        // CODEGEN: Generating message contract since element name userName from namespace http://www.altinn.no/services/Authorization/Administration/2016/02 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/Authorization/Administration/2016/02/IAuthorization" +
            "TokenExternalEC/GetAccessToken", ReplyAction="http://www.altinn.no/services/Authorization/Administration/2016/02/IAuthorization" +
            "TokenExternalEC/GetAccessTokenResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EC_Endpoint_Client.Token.AltinnFault), Action="http://www.altinn.no/services/Authorization/Administration/2016/02/IAuthorization" +
            "TokenExternalEC/GetAccessTokenAltinnFaultFault", Name="AltinnFault", Namespace="http://www.altinn.no/services/common/fault/2009/10")]
        EC_Endpoint_Client.Token.GetAccessTokenResponse GetAccessToken(EC_Endpoint_Client.Token.GetAccessTokenRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/Authorization/Administration/2016/02/IAuthorization" +
            "TokenExternalEC/GetAccessToken", ReplyAction="http://www.altinn.no/services/Authorization/Administration/2016/02/IAuthorization" +
            "TokenExternalEC/GetAccessTokenResponse")]
        System.Threading.Tasks.Task<EC_Endpoint_Client.Token.GetAccessTokenResponse> GetAccessTokenAsync(EC_Endpoint_Client.Token.GetAccessTokenRequest request);
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
    public partial class GetAccessTokenRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAccessToken", Namespace="http://www.altinn.no/services/Authorization/Administration/2016/02", Order=0)]
        public EC_Endpoint_Client.Token.GetAccessTokenRequestBody Body;
        
        public GetAccessTokenRequest() {
        }
        
        public GetAccessTokenRequest(EC_Endpoint_Client.Token.GetAccessTokenRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.altinn.no/services/Authorization/Administration/2016/02")]
    public partial class GetAccessTokenRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public System.Guid authorizationCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public bool selfContained;
        
        public GetAccessTokenRequestBody() {
        }
        
        public GetAccessTokenRequestBody(string userName, string password, System.Guid authorizationCode, bool selfContained) {
            this.userName = userName;
            this.password = password;
            this.authorizationCode = authorizationCode;
            this.selfContained = selfContained;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAccessTokenResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAccessTokenResponse", Namespace="http://www.altinn.no/services/Authorization/Administration/2016/02", Order=0)]
        public EC_Endpoint_Client.Token.GetAccessTokenResponseBody Body;
        
        public GetAccessTokenResponse() {
        }
        
        public GetAccessTokenResponse(EC_Endpoint_Client.Token.GetAccessTokenResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.altinn.no/services/Authorization/Administration/2016/02")]
    public partial class GetAccessTokenResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public EC_Endpoint_Client.Token.AuthorizationAccessTokenResponseExternalBE GetAccessTokenResult;
        
        public GetAccessTokenResponseBody() {
        }
        
        public GetAccessTokenResponseBody(EC_Endpoint_Client.Token.AuthorizationAccessTokenResponseExternalBE GetAccessTokenResult) {
            this.GetAccessTokenResult = GetAccessTokenResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuthorizationTokenExternalECChannel : EC_Endpoint_Client.Token.IAuthorizationTokenExternalEC, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthorizationTokenExternalECClient : System.ServiceModel.ClientBase<EC_Endpoint_Client.Token.IAuthorizationTokenExternalEC>, EC_Endpoint_Client.Token.IAuthorizationTokenExternalEC {
        
        public AuthorizationTokenExternalECClient() {
        }
        
        public AuthorizationTokenExternalECClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthorizationTokenExternalECClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthorizationTokenExternalECClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthorizationTokenExternalECClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EC_Endpoint_Client.Token.TestResponse EC_Endpoint_Client.Token.IAuthorizationTokenExternalEC.Test(EC_Endpoint_Client.Token.TestRequest request) {
            return base.Channel.Test(request);
        }
        
        public void Test() {
            EC_Endpoint_Client.Token.TestRequest inValue = new EC_Endpoint_Client.Token.TestRequest();
            EC_Endpoint_Client.Token.TestResponse retVal = ((EC_Endpoint_Client.Token.IAuthorizationTokenExternalEC)(this)).Test(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<EC_Endpoint_Client.Token.TestResponse> EC_Endpoint_Client.Token.IAuthorizationTokenExternalEC.TestAsync(EC_Endpoint_Client.Token.TestRequest request) {
            return base.Channel.TestAsync(request);
        }
        
        public System.Threading.Tasks.Task<EC_Endpoint_Client.Token.TestResponse> TestAsync() {
            EC_Endpoint_Client.Token.TestRequest inValue = new EC_Endpoint_Client.Token.TestRequest();
            return ((EC_Endpoint_Client.Token.IAuthorizationTokenExternalEC)(this)).TestAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EC_Endpoint_Client.Token.GetAccessTokenResponse EC_Endpoint_Client.Token.IAuthorizationTokenExternalEC.GetAccessToken(EC_Endpoint_Client.Token.GetAccessTokenRequest request) {
            return base.Channel.GetAccessToken(request);
        }
        
        public EC_Endpoint_Client.Token.AuthorizationAccessTokenResponseExternalBE GetAccessToken(string userName, string password, System.Guid authorizationCode, bool selfContained) {
            EC_Endpoint_Client.Token.GetAccessTokenRequest inValue = new EC_Endpoint_Client.Token.GetAccessTokenRequest();
            inValue.Body = new EC_Endpoint_Client.Token.GetAccessTokenRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            inValue.Body.authorizationCode = authorizationCode;
            inValue.Body.selfContained = selfContained;
            EC_Endpoint_Client.Token.GetAccessTokenResponse retVal = ((EC_Endpoint_Client.Token.IAuthorizationTokenExternalEC)(this)).GetAccessToken(inValue);
            return retVal.Body.GetAccessTokenResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<EC_Endpoint_Client.Token.GetAccessTokenResponse> EC_Endpoint_Client.Token.IAuthorizationTokenExternalEC.GetAccessTokenAsync(EC_Endpoint_Client.Token.GetAccessTokenRequest request) {
            return base.Channel.GetAccessTokenAsync(request);
        }
        
        public System.Threading.Tasks.Task<EC_Endpoint_Client.Token.GetAccessTokenResponse> GetAccessTokenAsync(string userName, string password, System.Guid authorizationCode, bool selfContained) {
            EC_Endpoint_Client.Token.GetAccessTokenRequest inValue = new EC_Endpoint_Client.Token.GetAccessTokenRequest();
            inValue.Body = new EC_Endpoint_Client.Token.GetAccessTokenRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            inValue.Body.authorizationCode = authorizationCode;
            inValue.Body.selfContained = selfContained;
            return ((EC_Endpoint_Client.Token.IAuthorizationTokenExternalEC)(this)).GetAccessTokenAsync(inValue);
        }
    }
}
