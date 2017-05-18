﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace service_quan_ly_ton_giao.ServiceTonGiao {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceTonGiao.ServiceTonGiaoSoap")]
    public interface ServiceTonGiaoSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LayDanhSach", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable LayDanhSach();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LayDanhSach", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> LayDanhSachAsync();
        
        // CODEGEN: Parameter 'f' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ThemTonGiao", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        service_quan_ly_ton_giao.ServiceTonGiao.ThemTonGiaoResponse ThemTonGiao(service_quan_ly_ton_giao.ServiceTonGiao.ThemTonGiaoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ThemTonGiao", ReplyAction="*")]
        System.Threading.Tasks.Task<service_quan_ly_ton_giao.ServiceTonGiao.ThemTonGiaoResponse> ThemTonGiaoAsync(service_quan_ly_ton_giao.ServiceTonGiao.ThemTonGiaoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SuaTonGiao", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int SuaTonGiao(string id, string Ten, string gioithieu, string hinhanh, string sltindo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SuaTonGiao", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SuaTonGiaoAsync(string id, string Ten, string gioithieu, string hinhanh, string sltindo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Xoa", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int Xoa(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Xoa", ReplyAction="*")]
        System.Threading.Tasks.Task<int> XoaAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Exec", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string Exec(string sql);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Exec", ReplyAction="*")]
        System.Threading.Tasks.Task<string> ExecAsync(string sql);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTable", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetTable(string sql, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTable", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetTableAsync(string sql, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTable2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetTable2(string sql);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTable2", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetTable2Async(string sql);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PhucHoi", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string PhucHoi(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PhucHoi", ReplyAction="*")]
        System.Threading.Tasks.Task<string> PhucHoiAsync(string path);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ThemTonGiao", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ThemTonGiaoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string Ten;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string gioithieu;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string hinhanh;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] f;
        
        public ThemTonGiaoRequest() {
        }
        
        public ThemTonGiaoRequest(string Ten, string gioithieu, string hinhanh, byte[] f) {
            this.Ten = Ten;
            this.gioithieu = gioithieu;
            this.hinhanh = hinhanh;
            this.f = f;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ThemTonGiaoResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ThemTonGiaoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string ThemTonGiaoResult;
        
        public ThemTonGiaoResponse() {
        }
        
        public ThemTonGiaoResponse(string ThemTonGiaoResult) {
            this.ThemTonGiaoResult = ThemTonGiaoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceTonGiaoSoapChannel : service_quan_ly_ton_giao.ServiceTonGiao.ServiceTonGiaoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceTonGiaoSoapClient : System.ServiceModel.ClientBase<service_quan_ly_ton_giao.ServiceTonGiao.ServiceTonGiaoSoap>, service_quan_ly_ton_giao.ServiceTonGiao.ServiceTonGiaoSoap {
        
        public ServiceTonGiaoSoapClient() {
        }
        
        public ServiceTonGiaoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceTonGiaoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceTonGiaoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceTonGiaoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable LayDanhSach() {
            return base.Channel.LayDanhSach();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> LayDanhSachAsync() {
            return base.Channel.LayDanhSachAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        service_quan_ly_ton_giao.ServiceTonGiao.ThemTonGiaoResponse service_quan_ly_ton_giao.ServiceTonGiao.ServiceTonGiaoSoap.ThemTonGiao(service_quan_ly_ton_giao.ServiceTonGiao.ThemTonGiaoRequest request) {
            return base.Channel.ThemTonGiao(request);
        }
        
        public string ThemTonGiao(string Ten, string gioithieu, string hinhanh, byte[] f) {
            service_quan_ly_ton_giao.ServiceTonGiao.ThemTonGiaoRequest inValue = new service_quan_ly_ton_giao.ServiceTonGiao.ThemTonGiaoRequest();
            inValue.Ten = Ten;
            inValue.gioithieu = gioithieu;
            inValue.hinhanh = hinhanh;
            inValue.f = f;
            service_quan_ly_ton_giao.ServiceTonGiao.ThemTonGiaoResponse retVal = ((service_quan_ly_ton_giao.ServiceTonGiao.ServiceTonGiaoSoap)(this)).ThemTonGiao(inValue);
            return retVal.ThemTonGiaoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<service_quan_ly_ton_giao.ServiceTonGiao.ThemTonGiaoResponse> service_quan_ly_ton_giao.ServiceTonGiao.ServiceTonGiaoSoap.ThemTonGiaoAsync(service_quan_ly_ton_giao.ServiceTonGiao.ThemTonGiaoRequest request) {
            return base.Channel.ThemTonGiaoAsync(request);
        }
        
        public System.Threading.Tasks.Task<service_quan_ly_ton_giao.ServiceTonGiao.ThemTonGiaoResponse> ThemTonGiaoAsync(string Ten, string gioithieu, string hinhanh, byte[] f) {
            service_quan_ly_ton_giao.ServiceTonGiao.ThemTonGiaoRequest inValue = new service_quan_ly_ton_giao.ServiceTonGiao.ThemTonGiaoRequest();
            inValue.Ten = Ten;
            inValue.gioithieu = gioithieu;
            inValue.hinhanh = hinhanh;
            inValue.f = f;
            return ((service_quan_ly_ton_giao.ServiceTonGiao.ServiceTonGiaoSoap)(this)).ThemTonGiaoAsync(inValue);
        }
        
        public int SuaTonGiao(string id, string Ten, string gioithieu, string hinhanh, string sltindo) {
            return base.Channel.SuaTonGiao(id, Ten, gioithieu, hinhanh, sltindo);
        }
        
        public System.Threading.Tasks.Task<int> SuaTonGiaoAsync(string id, string Ten, string gioithieu, string hinhanh, string sltindo) {
            return base.Channel.SuaTonGiaoAsync(id, Ten, gioithieu, hinhanh, sltindo);
        }
        
        public int Xoa(string id) {
            return base.Channel.Xoa(id);
        }
        
        public System.Threading.Tasks.Task<int> XoaAsync(string id) {
            return base.Channel.XoaAsync(id);
        }
        
        public string Exec(string sql) {
            return base.Channel.Exec(sql);
        }
        
        public System.Threading.Tasks.Task<string> ExecAsync(string sql) {
            return base.Channel.ExecAsync(sql);
        }
        
        public System.Data.DataTable GetTable(string sql, string name) {
            return base.Channel.GetTable(sql, name);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetTableAsync(string sql, string name) {
            return base.Channel.GetTableAsync(sql, name);
        }
        
        public System.Data.DataTable GetTable2(string sql) {
            return base.Channel.GetTable2(sql);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetTable2Async(string sql) {
            return base.Channel.GetTable2Async(sql);
        }
        
        public string PhucHoi(string path) {
            return base.Channel.PhucHoi(path);
        }
        
        public System.Threading.Tasks.Task<string> PhucHoiAsync(string path) {
            return base.Channel.PhucHoiAsync(path);
        }
    }
}
