namespace OpenHealthMessaging.Els.Service
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ns.electronichealth.net.au/els/svc/Lookup/2010")]
    public partial class ValidateInteraction
    {
        
        private InteractionType interactionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public InteractionType interaction
        {
            get
            {
                return this.interactionField;
            }
            set
            {
                this.interactionField = value;
            }
        }
    }
}