namespace OpenHealthMessaging.Els.Service
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListInteractionsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="listInteractionsResponse", Namespace="http://ns.electronichealth.net.au/els/svc/Lookup/2010", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("interaction", IsNullable=false)]
        public InteractionType[] listInteractionsResponse1;
        
        public ListInteractionsResponse()
        {
        }
        
        public ListInteractionsResponse(InteractionType[] listInteractionsResponse1)
        {
            this.listInteractionsResponse1 = listInteractionsResponse1;
        }
    }
}