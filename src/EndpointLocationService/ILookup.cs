namespace OpenHealthMessaging.Els.Service
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ns.electronichealth.net.au/els/svc/Lookup/2010", ConfigurationName="OpenHealthMessaging.EndpointLocationService.Lookup.Lookup")]
    public interface ILookup
    {
        
        // CODEGEN: Generating message contract since the operation listInteractions is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://ns.electronichealth.net.au/els/svc/Lookup/2010/Lookup/listInteractionsRequ" +
                                                               "est", ReplyAction="http://ns.electronichealth.net.au/els/svc/Lookup/2010/Lookup/listInteractionsResp" +
                                                                                  "onse")]
        [System.ServiceModel.FaultContractAttribute(typeof(StandardErrorType), Action="http://ns.electronichealth.net.au/els/svc/Lookup/2010/Lookup/listInteractions/Fau" +
                                                                                      "lt/standardError", Name="standardError", Namespace="http://ns.electronichealth.net.au/wsp/xsd/StandardError/2010")]
        [System.ServiceModel.FaultContractAttribute(typeof(LookupErrorType), Action="http://ns.electronichealth.net.au/els/svc/Lookup/2010/Lookup/listInteractions/Fau" +
                                                                                    "lt/lookupError", Name="lookupError")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ListInteractionsResponse ListInteractions(ListInteractionsRequest request);
        
        // CODEGEN: Generating message contract since the operation validateInteraction is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://ns.electronichealth.net.au/els/svc/Lookup/2010/Lookup/validateInteractionR" +
                                                               "equest", ReplyAction="http://ns.electronichealth.net.au/els/svc/Lookup/2010/Lookup/validateInteractionR" +
                                                                                     "esponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(StandardErrorType), Action="http://ns.electronichealth.net.au/els/svc/Lookup/2010/Lookup/validateInteraction/" +
                                                                                      "Fault/standardError", Name="standardError", Namespace="http://ns.electronichealth.net.au/wsp/xsd/StandardError/2010")]
        [System.ServiceModel.FaultContractAttribute(typeof(LookupErrorType), Action="http://ns.electronichealth.net.au/els/svc/Lookup/2010/Lookup/validateInteraction/" +
                                                                                    "Fault/lookupError", Name="lookupError")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ValidateInteractionResponse1 ValidateInteraction(ValidateInteractionRequest request);
    }
}