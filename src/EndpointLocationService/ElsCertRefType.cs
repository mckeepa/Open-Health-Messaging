namespace OpenHealthMessaging.Els.Service
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ns.electronichealth.net.au/els/xsd/DataTypes/2010")]
    public partial class ElsCertRefType
    {
        
        private string useQualifierField;
        
        private QualifiedCertRefType qualifiedCertRefField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string useQualifier
        {
            get
            {
                return this.useQualifierField;
            }
            set
            {
                this.useQualifierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://ns.electronichealth.net.au/qcr/xsd/QualifiedCertRef/2010", Order=1)]
        public QualifiedCertRefType qualifiedCertRef
        {
            get
            {
                return this.qualifiedCertRefField;
            }
            set
            {
                this.qualifiedCertRefField = value;
            }
        }
    }
}