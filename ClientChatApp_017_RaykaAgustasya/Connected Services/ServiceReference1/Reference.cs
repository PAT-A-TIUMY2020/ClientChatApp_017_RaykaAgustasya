﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientChatApp_017_RaykaAgustasya.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IClientCallback")]
    public interface IClientCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IClientCallback/gabung")]
        void gabung(string username);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IClientCallback/gabung")]
        System.Threading.Tasks.Task gabungAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IClientCallback/kirimPesan")]
        void kirimPesan(string pesan, string pesan1);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IClientCallback/kirimPesan")]
        System.Threading.Tasks.Task kirimPesanAsync(string pesan, string pesan1);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClientCallbackChannel : ClientChatApp_017_RaykaAgustasya.ServiceReference1.IClientCallback, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClientCallbackClient : System.ServiceModel.ClientBase<ClientChatApp_017_RaykaAgustasya.ServiceReference1.IClientCallback>, ClientChatApp_017_RaykaAgustasya.ServiceReference1.IClientCallback {
        
        public ClientCallbackClient() {
        }
        
        public ClientCallbackClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClientCallbackClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientCallbackClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientCallbackClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void gabung(string username) {
            base.Channel.gabung(username);
        }
        
        public System.Threading.Tasks.Task gabungAsync(string username) {
            return base.Channel.gabungAsync(username);
        }
        
        public void kirimPesan(string pesan, string pesan1) {
            base.Channel.kirimPesan(pesan, pesan1);
        }
        
        public System.Threading.Tasks.Task kirimPesanAsync(string pesan, string pesan1) {
            return base.Channel.kirimPesanAsync(pesan, pesan1);
        }
    }
}
