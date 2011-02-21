namespace OpenHealthMessaging.Els.Service
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListInteractionsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ns.electronichealth.net.au/els/svc/Lookup/2010", Order=0)]
        public ListInteractions listInteractions;
        
        public ListInteractionsRequest()
        {
        }
        
        public ListInteractionsRequest(ListInteractions listInteractions)
        {
            this.listInteractions = listInteractions;
        }
    }
}