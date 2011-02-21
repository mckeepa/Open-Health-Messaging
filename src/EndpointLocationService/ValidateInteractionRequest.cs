namespace OpenHealthMessaging.Els.Service
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidateInteractionRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ns.electronichealth.net.au/els/svc/Lookup/2010", Order=0)]
        public ValidateInteraction validateInteraction;
        
        public ValidateInteractionRequest()
        {
        }
        
        public ValidateInteractionRequest(ValidateInteraction validateInteraction)
        {
            this.validateInteraction = validateInteraction;
        }
    }
}