﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenHealthMessaging.CommonDataTypes
{
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StandardErrorCodeType", Namespace="http://ns.electronichealth.net.au/wsp/xsd/StandardError/2010")]
    public enum StandardErrorCodeType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        servicePermanentUnavailable = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        serviceTemporaryUnavailable = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        certificateSkiMissing = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        certificateKeyUsage = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        invalidCredentials = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        notAuthenticated = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        notAuthorised = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badParam = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badlyFormedMsg = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badTimestamp = 9,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badSignature = 10,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badEncryption = 11,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badSigEncOrder = 12,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badCertificateTransmitted = 13,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badWsaAction = 14,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badWsaMessageId = 15,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badWsaTo = 16,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badAlgorithmDataEncryption = 17,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badAlgorithmKeyEncryption = 18,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badAlgorithmC14N = 19,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badAlgorithmDigest = 20,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        badAlgorithmSignature = 21,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StandardErrorType", Namespace="http://ns.electronichealth.net.au/wsp/xsd/StandardError/2010")]
    public partial class StandardErrorType : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private OpenHealthMessaging.CommonDataTypes.StandardErrorCodeType errorCodeField;
        
        private string messageField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public OpenHealthMessaging.CommonDataTypes.StandardErrorCodeType errorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
}
