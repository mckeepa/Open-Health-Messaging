namespace OpenHealthMessaging.Els.Service
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ns.electronichealth.net.au/els/xsd/DataTypes/2010")]
    public partial class InteractionRequestType
    {
        
        private string targetField;
        
        private string[] serviceCategoryField;
        
        private string[] serviceInterfaceField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("serviceCategory", DataType="anyURI", Order=1)]
        public string[] serviceCategory
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
        [System.Xml.Serialization.XmlElementAttribute("serviceInterface", DataType="anyURI", Order=2)]
        public string[] serviceInterface
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
    }
}