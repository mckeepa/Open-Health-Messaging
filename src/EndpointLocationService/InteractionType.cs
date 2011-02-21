namespace OpenHealthMessaging.Els.Service
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ns.electronichealth.net.au/els/xsd/DataTypes/2010")]
    public partial class InteractionType
    {
        
        private string targetField;
        
        private string serviceCategoryField;
        
        private string serviceInterfaceField;
        
        private string serviceEndpointField;
        
        private string serviceProviderField;
        
        private ElsCertRefType[] certRefField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=1)]
        public string serviceCategory
        {
            get
            {
                return this.serviceCategoryField;
            }
            set
            {
                this.serviceCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=2)]
        public string serviceInterface
        {
            get
            {
                return this.serviceInterfaceField;
            }
            set
            {
                this.serviceInterfaceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=3)]
        public string serviceEndpoint
        {
            get
            {
                return this.serviceEndpointField;
            }
            set
            {
                this.serviceEndpointField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=4)]
        public string serviceProvider
        {
            get
            {
                return this.serviceProviderField;
            }
            set
            {
                this.serviceProviderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("certRef", Order=5)]
        public ElsCertRefType[] certRef
        {
            get
            {
                return this.certRefField;
            }
            set
            {
                this.certRefField = value;
            }
        }
    }
}