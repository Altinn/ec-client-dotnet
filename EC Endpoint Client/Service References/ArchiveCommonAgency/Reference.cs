﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EC_Endpoint_Client.ArchiveCommonAgency {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ExternalSOASearchBE", Namespace="http://schemas.altinn.no/services/Archive/2009/10")]
    [System.SerializableAttribute()]
    public partial class ExternalSOASearchBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> CaseIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DateFromField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DateToField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReferenceIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SSNOrOrgNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubjectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public System.Nullable<int> CaseID {
            get {
                return this.CaseIDField;
            }
            set {
                if ((this.CaseIDField.Equals(value) != true)) {
                    this.CaseIDField = value;
                    this.RaisePropertyChanged("CaseID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DateFrom {
            get {
                return this.DateFromField;
            }
            set {
                if ((this.DateFromField.Equals(value) != true)) {
                    this.DateFromField = value;
                    this.RaisePropertyChanged("DateFrom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DateTo {
            get {
                return this.DateToField;
            }
            set {
                if ((this.DateToField.Equals(value) != true)) {
                    this.DateToField = value;
                    this.RaisePropertyChanged("DateTo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReferenceId {
            get {
                return this.ReferenceIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ReferenceIdField, value) != true)) {
                    this.ReferenceIdField = value;
                    this.RaisePropertyChanged("ReferenceId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SSNOrOrgNumber {
            get {
                return this.SSNOrOrgNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.SSNOrOrgNumberField, value) != true)) {
                    this.SSNOrOrgNumberField = value;
                    this.RaisePropertyChanged("SSNOrOrgNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Subject {
            get {
                return this.SubjectField;
            }
            set {
                if ((object.ReferenceEquals(this.SubjectField, value) != true)) {
                    this.SubjectField = value;
                    this.RaisePropertyChanged("Subject");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ServiceOwnerArchiveReporteeElementBEV2List", Namespace="http://schemas.altinn.no/services/Archive/2009/10", ItemName="ServiceOwnerArchiveReporteeElementBEV2")]
    [System.SerializableAttribute()]
    public class ServiceOwnerArchiveReporteeElementBEV2List : System.Collections.Generic.List<EC_Endpoint_Client.ArchiveCommonAgency.ServiceOwnerArchiveReporteeElementBEV2> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceOwnerArchiveReporteeElementBEV2", Namespace="http://schemas.altinn.no/services/Archive/2010/10")]
    [System.SerializableAttribute()]
    public partial class ServiceOwnerArchiveReporteeElementBEV2 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Altinn1AMReferenceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<long> Altinn1ArchiveUnitIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> Altinn1FormCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ArchiveReferenceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private EC_Endpoint_Client.ArchiveCommonAgency.ElementTypeV2 ElementTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> EndUserSystemIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ExpiryDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsAltinn1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> IsCorrespondenceConfirmationRequiredField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsSubjectMessageTitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LastChangedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ReporteeElementIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ReporteeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReporteeNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SSNOrOrganizationNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> SendCompleteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubjectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SystemTypeNameField;
        
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
        public string Altinn1AMReference {
            get {
                return this.Altinn1AMReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.Altinn1AMReferenceField, value) != true)) {
                    this.Altinn1AMReferenceField = value;
                    this.RaisePropertyChanged("Altinn1AMReference");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> Altinn1ArchiveUnitId {
            get {
                return this.Altinn1ArchiveUnitIdField;
            }
            set {
                if ((this.Altinn1ArchiveUnitIdField.Equals(value) != true)) {
                    this.Altinn1ArchiveUnitIdField = value;
                    this.RaisePropertyChanged("Altinn1ArchiveUnitId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Altinn1FormCode {
            get {
                return this.Altinn1FormCodeField;
            }
            set {
                if ((this.Altinn1FormCodeField.Equals(value) != true)) {
                    this.Altinn1FormCodeField = value;
                    this.RaisePropertyChanged("Altinn1FormCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ArchiveReference {
            get {
                return this.ArchiveReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.ArchiveReferenceField, value) != true)) {
                    this.ArchiveReferenceField = value;
                    this.RaisePropertyChanged("ArchiveReference");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EC_Endpoint_Client.ArchiveCommonAgency.ElementTypeV2 ElementType {
            get {
                return this.ElementTypeField;
            }
            set {
                if ((this.ElementTypeField.Equals(value) != true)) {
                    this.ElementTypeField = value;
                    this.RaisePropertyChanged("ElementType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> EndUserSystemId {
            get {
                return this.EndUserSystemIdField;
            }
            set {
                if ((this.EndUserSystemIdField.Equals(value) != true)) {
                    this.EndUserSystemIdField = value;
                    this.RaisePropertyChanged("EndUserSystemId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ExpiryDate {
            get {
                return this.ExpiryDateField;
            }
            set {
                if ((this.ExpiryDateField.Equals(value) != true)) {
                    this.ExpiryDateField = value;
                    this.RaisePropertyChanged("ExpiryDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsAltinn1 {
            get {
                return this.IsAltinn1Field;
            }
            set {
                if ((this.IsAltinn1Field.Equals(value) != true)) {
                    this.IsAltinn1Field = value;
                    this.RaisePropertyChanged("IsAltinn1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> IsCorrespondenceConfirmationRequired {
            get {
                return this.IsCorrespondenceConfirmationRequiredField;
            }
            set {
                if ((this.IsCorrespondenceConfirmationRequiredField.Equals(value) != true)) {
                    this.IsCorrespondenceConfirmationRequiredField = value;
                    this.RaisePropertyChanged("IsCorrespondenceConfirmationRequired");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsSubjectMessageTitle {
            get {
                return this.IsSubjectMessageTitleField;
            }
            set {
                if ((this.IsSubjectMessageTitleField.Equals(value) != true)) {
                    this.IsSubjectMessageTitleField = value;
                    this.RaisePropertyChanged("IsSubjectMessageTitle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LastChangedDate {
            get {
                return this.LastChangedDateField;
            }
            set {
                if ((this.LastChangedDateField.Equals(value) != true)) {
                    this.LastChangedDateField = value;
                    this.RaisePropertyChanged("LastChangedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ReporteeElementId {
            get {
                return this.ReporteeElementIdField;
            }
            set {
                if ((this.ReporteeElementIdField.Equals(value) != true)) {
                    this.ReporteeElementIdField = value;
                    this.RaisePropertyChanged("ReporteeElementId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ReporteeId {
            get {
                return this.ReporteeIdField;
            }
            set {
                if ((this.ReporteeIdField.Equals(value) != true)) {
                    this.ReporteeIdField = value;
                    this.RaisePropertyChanged("ReporteeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReporteeName {
            get {
                return this.ReporteeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ReporteeNameField, value) != true)) {
                    this.ReporteeNameField = value;
                    this.RaisePropertyChanged("ReporteeName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SSNOrOrganizationNumber {
            get {
                return this.SSNOrOrganizationNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.SSNOrOrganizationNumberField, value) != true)) {
                    this.SSNOrOrganizationNumberField = value;
                    this.RaisePropertyChanged("SSNOrOrganizationNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> SendComplete {
            get {
                return this.SendCompleteField;
            }
            set {
                if ((this.SendCompleteField.Equals(value) != true)) {
                    this.SendCompleteField = value;
                    this.RaisePropertyChanged("SendComplete");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Subject {
            get {
                return this.SubjectField;
            }
            set {
                if ((object.ReferenceEquals(this.SubjectField, value) != true)) {
                    this.SubjectField = value;
                    this.RaisePropertyChanged("Subject");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SystemTypeName {
            get {
                return this.SystemTypeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SystemTypeNameField, value) != true)) {
                    this.SystemTypeNameField = value;
                    this.RaisePropertyChanged("SystemTypeName");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ElementTypeV2", Namespace="http://schemas.altinn.no/services/altinnservice/2009/10")]
    public enum ElementTypeV2 : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Archive = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Active = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Correspondence = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ArchiveCorrespondence = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LookUp = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Collaboration = 6,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.altinn.no/services/Archive/ArchiveCommon/2010/10", ConfigurationName="ArchiveCommonAgency.IArchiveCommonAgencyExternalEC")]
    public interface IArchiveCommonAgencyExternalEC {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://www.altinn.no/services/2009/10) of message TestRequest does not match the default value (http://www.altinn.no/services/Archive/ArchiveCommon/2010/10)
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/Test", ReplyAction="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EC_Endpoint_Client.ArchiveCommonAgency.AltinnFault), Action="http://www.altinn.no/services/2009/10/IAltinnContractBase/TestAltinnFaultFault", Name="AltinnFault", Namespace="http://www.altinn.no/services/common/fault/2009/10")]
        EC_Endpoint_Client.ArchiveCommonAgency.TestResponse Test(EC_Endpoint_Client.ArchiveCommonAgency.TestRequest request);
        
        // CODEGEN: Generating message contract since element name systemUserName from namespace http://www.altinn.no/services/Archive/ArchiveCommon/2010/10 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.altinn.no/services/Archive/ArchiveCommon/2010/10/IArchiveCommonAgencyE" +
            "xternalEC/GetServiceOwnerArchiveReporteeElementsEC", ReplyAction="http://www.altinn.no/services/Archive/ArchiveCommon/2010/10/IArchiveCommonAgencyE" +
            "xternalEC/GetServiceOwnerArchiveReporteeElementsECResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(EC_Endpoint_Client.ArchiveCommonAgency.AltinnFault), Action="http://www.altinn.no/services/Archive/ArchiveCommon/2010/10/IArchiveCommonAgencyE" +
            "xternalEC/GetServiceOwnerArchiveReporteeElementsECAltinnFaultFault", Name="AltinnFault", Namespace="http://www.altinn.no/services/common/fault/2009/10")]
        EC_Endpoint_Client.ArchiveCommonAgency.GetServiceOwnerArchiveReporteeElementsECResponse GetServiceOwnerArchiveReporteeElementsEC(EC_Endpoint_Client.ArchiveCommonAgency.GetServiceOwnerArchiveReporteeElementsECRequest request);
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
    public partial class GetServiceOwnerArchiveReporteeElementsECRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetServiceOwnerArchiveReporteeElementsEC", Namespace="http://www.altinn.no/services/Archive/ArchiveCommon/2010/10", Order=0)]
        public EC_Endpoint_Client.ArchiveCommonAgency.GetServiceOwnerArchiveReporteeElementsECRequestBody Body;
        
        public GetServiceOwnerArchiveReporteeElementsECRequest() {
        }
        
        public GetServiceOwnerArchiveReporteeElementsECRequest(EC_Endpoint_Client.ArchiveCommonAgency.GetServiceOwnerArchiveReporteeElementsECRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.altinn.no/services/Archive/ArchiveCommon/2010/10")]
    public partial class GetServiceOwnerArchiveReporteeElementsECRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string systemUserName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string systemPassword;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public EC_Endpoint_Client.ArchiveCommonAgency.ExternalSOASearchBE searchServiceOwnerArchive;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int languageID;
        
        public GetServiceOwnerArchiveReporteeElementsECRequestBody() {
        }
        
        public GetServiceOwnerArchiveReporteeElementsECRequestBody(string systemUserName, string systemPassword, EC_Endpoint_Client.ArchiveCommonAgency.ExternalSOASearchBE searchServiceOwnerArchive, int languageID) {
            this.systemUserName = systemUserName;
            this.systemPassword = systemPassword;
            this.searchServiceOwnerArchive = searchServiceOwnerArchive;
            this.languageID = languageID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetServiceOwnerArchiveReporteeElementsECResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetServiceOwnerArchiveReporteeElementsECResponse", Namespace="http://www.altinn.no/services/Archive/ArchiveCommon/2010/10", Order=0)]
        public EC_Endpoint_Client.ArchiveCommonAgency.GetServiceOwnerArchiveReporteeElementsECResponseBody Body;
        
        public GetServiceOwnerArchiveReporteeElementsECResponse() {
        }
        
        public GetServiceOwnerArchiveReporteeElementsECResponse(EC_Endpoint_Client.ArchiveCommonAgency.GetServiceOwnerArchiveReporteeElementsECResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.altinn.no/services/Archive/ArchiveCommon/2010/10")]
    public partial class GetServiceOwnerArchiveReporteeElementsECResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public EC_Endpoint_Client.ArchiveCommonAgency.ServiceOwnerArchiveReporteeElementBEV2List GetServiceOwnerArchiveReporteeElementsECResult;
        
        public GetServiceOwnerArchiveReporteeElementsECResponseBody() {
        }
        
        public GetServiceOwnerArchiveReporteeElementsECResponseBody(EC_Endpoint_Client.ArchiveCommonAgency.ServiceOwnerArchiveReporteeElementBEV2List GetServiceOwnerArchiveReporteeElementsECResult) {
            this.GetServiceOwnerArchiveReporteeElementsECResult = GetServiceOwnerArchiveReporteeElementsECResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IArchiveCommonAgencyExternalECChannel : EC_Endpoint_Client.ArchiveCommonAgency.IArchiveCommonAgencyExternalEC, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ArchiveCommonAgencyExternalECClient : System.ServiceModel.ClientBase<EC_Endpoint_Client.ArchiveCommonAgency.IArchiveCommonAgencyExternalEC>, EC_Endpoint_Client.ArchiveCommonAgency.IArchiveCommonAgencyExternalEC {
        
        public ArchiveCommonAgencyExternalECClient() {
        }
        
        public ArchiveCommonAgencyExternalECClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ArchiveCommonAgencyExternalECClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ArchiveCommonAgencyExternalECClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ArchiveCommonAgencyExternalECClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EC_Endpoint_Client.ArchiveCommonAgency.TestResponse EC_Endpoint_Client.ArchiveCommonAgency.IArchiveCommonAgencyExternalEC.Test(EC_Endpoint_Client.ArchiveCommonAgency.TestRequest request) {
            return base.Channel.Test(request);
        }
        
        public void Test() {
            EC_Endpoint_Client.ArchiveCommonAgency.TestRequest inValue = new EC_Endpoint_Client.ArchiveCommonAgency.TestRequest();
            EC_Endpoint_Client.ArchiveCommonAgency.TestResponse retVal = ((EC_Endpoint_Client.ArchiveCommonAgency.IArchiveCommonAgencyExternalEC)(this)).Test(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EC_Endpoint_Client.ArchiveCommonAgency.GetServiceOwnerArchiveReporteeElementsECResponse EC_Endpoint_Client.ArchiveCommonAgency.IArchiveCommonAgencyExternalEC.GetServiceOwnerArchiveReporteeElementsEC(EC_Endpoint_Client.ArchiveCommonAgency.GetServiceOwnerArchiveReporteeElementsECRequest request) {
            return base.Channel.GetServiceOwnerArchiveReporteeElementsEC(request);
        }
        
        public EC_Endpoint_Client.ArchiveCommonAgency.ServiceOwnerArchiveReporteeElementBEV2List GetServiceOwnerArchiveReporteeElementsEC(string systemUserName, string systemPassword, EC_Endpoint_Client.ArchiveCommonAgency.ExternalSOASearchBE searchServiceOwnerArchive, int languageID) {
            EC_Endpoint_Client.ArchiveCommonAgency.GetServiceOwnerArchiveReporteeElementsECRequest inValue = new EC_Endpoint_Client.ArchiveCommonAgency.GetServiceOwnerArchiveReporteeElementsECRequest();
            inValue.Body = new EC_Endpoint_Client.ArchiveCommonAgency.GetServiceOwnerArchiveReporteeElementsECRequestBody();
            inValue.Body.systemUserName = systemUserName;
            inValue.Body.systemPassword = systemPassword;
            inValue.Body.searchServiceOwnerArchive = searchServiceOwnerArchive;
            inValue.Body.languageID = languageID;
            EC_Endpoint_Client.ArchiveCommonAgency.GetServiceOwnerArchiveReporteeElementsECResponse retVal = ((EC_Endpoint_Client.ArchiveCommonAgency.IArchiveCommonAgencyExternalEC)(this)).GetServiceOwnerArchiveReporteeElementsEC(inValue);
            return retVal.Body.GetServiceOwnerArchiveReporteeElementsECResult;
        }
    }
}
