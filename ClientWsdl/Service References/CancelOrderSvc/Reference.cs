﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientWsdl.CancelOrderSvc {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CancelOrder", Namespace="http://schemas.datacontract.org/2004/07/Host")]
    [System.SerializableAttribute()]
    public partial class CancelOrder : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrderIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OrderId {
            get {
                return this.OrderIdField;
            }
            set {
                if ((this.OrderIdField.Equals(value) != true)) {
                    this.OrderIdField = value;
                    this.RaisePropertyChanged("OrderId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ErrorCodes", Namespace="http://schemas.datacontract.org/2004/07/Host")]
    public enum ErrorCodes : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Success = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Fail = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CancelOrderSvc.IWcfServiceOf_CancelOrder_ErrorCodes")]
    public interface IWcfServiceOf_CancelOrder_ErrorCodes {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfServiceOf_CancelOrder_ErrorCodes/Process", ReplyAction="http://tempuri.org/IWcfServiceOf_CancelOrder_ErrorCodes/ProcessResponse")]
        ClientWsdl.CancelOrderSvc.ErrorCodes Process(ClientWsdl.CancelOrderSvc.CancelOrder request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfServiceOf_CancelOrder_ErrorCodes/Process", ReplyAction="http://tempuri.org/IWcfServiceOf_CancelOrder_ErrorCodes/ProcessResponse")]
        System.Threading.Tasks.Task<ClientWsdl.CancelOrderSvc.ErrorCodes> ProcessAsync(ClientWsdl.CancelOrderSvc.CancelOrder request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWcfServiceOf_CancelOrder_ErrorCodesChannel : ClientWsdl.CancelOrderSvc.IWcfServiceOf_CancelOrder_ErrorCodes, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WcfServiceOf_CancelOrder_ErrorCodesClient : System.ServiceModel.ClientBase<ClientWsdl.CancelOrderSvc.IWcfServiceOf_CancelOrder_ErrorCodes>, ClientWsdl.CancelOrderSvc.IWcfServiceOf_CancelOrder_ErrorCodes {
        
        public WcfServiceOf_CancelOrder_ErrorCodesClient() {
        }
        
        public WcfServiceOf_CancelOrder_ErrorCodesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WcfServiceOf_CancelOrder_ErrorCodesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfServiceOf_CancelOrder_ErrorCodesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfServiceOf_CancelOrder_ErrorCodesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClientWsdl.CancelOrderSvc.ErrorCodes Process(ClientWsdl.CancelOrderSvc.CancelOrder request) {
            return base.Channel.Process(request);
        }
        
        public System.Threading.Tasks.Task<ClientWsdl.CancelOrderSvc.ErrorCodes> ProcessAsync(ClientWsdl.CancelOrderSvc.CancelOrder request) {
            return base.Channel.ProcessAsync(request);
        }
    }
}
