﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace service_quan_ly_ton_giao.ServiceUser {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceUser.ServiceUserSoap")]
    public interface ServiceUserSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DangNhap", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable DangNhap(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DangNhap", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> DangNhapAsync(string username, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceUserSoapChannel : service_quan_ly_ton_giao.ServiceUser.ServiceUserSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceUserSoapClient : System.ServiceModel.ClientBase<service_quan_ly_ton_giao.ServiceUser.ServiceUserSoap>, service_quan_ly_ton_giao.ServiceUser.ServiceUserSoap {
        
        public ServiceUserSoapClient() {
        }
        
        public ServiceUserSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceUserSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceUserSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceUserSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable DangNhap(string username, string password) {
            return base.Channel.DangNhap(username, password);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> DangNhapAsync(string username, string password) {
            return base.Channel.DangNhapAsync(username, password);
        }
    }
}
