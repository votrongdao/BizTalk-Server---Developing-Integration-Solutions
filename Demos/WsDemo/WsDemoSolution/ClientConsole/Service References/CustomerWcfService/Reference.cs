﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientConsole.CustomerWcfService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CustomerWcfService.CustomerWcfService")]
    public interface CustomerWcfService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CustomerWcfService/GetCustomerNumber", ReplyAction="http://tempuri.org/CustomerWcfService/GetCustomerNumberResponse")]
        int GetCustomerNumber(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CustomerWcfServiceChannel : ClientConsole.CustomerWcfService.CustomerWcfService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerWcfServiceClient : System.ServiceModel.ClientBase<ClientConsole.CustomerWcfService.CustomerWcfService>, ClientConsole.CustomerWcfService.CustomerWcfService {
        
        public CustomerWcfServiceClient() {
        }
        
        public CustomerWcfServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerWcfServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerWcfServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerWcfServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetCustomerNumber(string name) {
            return base.Channel.GetCustomerNumber(name);
        }
    }
}
