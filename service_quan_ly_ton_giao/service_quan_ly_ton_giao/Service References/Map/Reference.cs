﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace service_quan_ly_ton_giao.Map {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Map.ServiceMapSoap")]
    public interface ServiceMapSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HienThiSLTinDoTheoHuyen", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable HienThiSLTinDoTheoHuyen(string TenTonGiao, string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HienThiSLTinDoTheoHuyen", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> HienThiSLTinDoTheoHuyenAsync(string TenTonGiao, string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HienThiSLTinDoTheoTinh", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable HienThiSLTinDoTheoTinh(string TenTonGiao, string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HienThiSLTinDoTheoTinh", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> HienThiSLTinDoTheoTinhAsync(string TenTonGiao, string dieukien);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceMapSoapChannel : service_quan_ly_ton_giao.Map.ServiceMapSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceMapSoapClient : System.ServiceModel.ClientBase<service_quan_ly_ton_giao.Map.ServiceMapSoap>, service_quan_ly_ton_giao.Map.ServiceMapSoap {
        
        public ServiceMapSoapClient() {
        }
        
        public ServiceMapSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceMapSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceMapSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceMapSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable HienThiSLTinDoTheoHuyen(string TenTonGiao, string dieukien) {
            return base.Channel.HienThiSLTinDoTheoHuyen(TenTonGiao, dieukien);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> HienThiSLTinDoTheoHuyenAsync(string TenTonGiao, string dieukien) {
            return base.Channel.HienThiSLTinDoTheoHuyenAsync(TenTonGiao, dieukien);
        }
        
        public System.Data.DataTable HienThiSLTinDoTheoTinh(string TenTonGiao, string dieukien) {
            return base.Channel.HienThiSLTinDoTheoTinh(TenTonGiao, dieukien);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> HienThiSLTinDoTheoTinhAsync(string TenTonGiao, string dieukien) {
            return base.Channel.HienThiSLTinDoTheoTinhAsync(TenTonGiao, dieukien);
        }
    }
}