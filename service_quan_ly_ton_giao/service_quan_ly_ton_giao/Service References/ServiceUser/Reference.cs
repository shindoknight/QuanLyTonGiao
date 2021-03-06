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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetInfo(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetInfoAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DanhSach", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable DanhSach();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DanhSach", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> DanhSachAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DoiMatKhau", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int DoiMatKhau(string mkmoi, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DoiMatKhau", ReplyAction="*")]
        System.Threading.Tasks.Task<int> DoiMatKhauAsync(string mkmoi, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Xoa", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int Xoa(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Xoa", ReplyAction="*")]
        System.Threading.Tasks.Task<int> XoaAsync(string id);
        
        // CODEGEN: Parameter 'f' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sua", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        service_quan_ly_ton_giao.ServiceUser.SuaResponse Sua(service_quan_ly_ton_giao.ServiceUser.SuaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sua", ReplyAction="*")]
        System.Threading.Tasks.Task<service_quan_ly_ton_giao.ServiceUser.SuaResponse> SuaAsync(service_quan_ly_ton_giao.ServiceUser.SuaRequest request);
        
        // CODEGEN: Parameter 'f' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ThemUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        service_quan_ly_ton_giao.ServiceUser.ThemUserResponse ThemUser(service_quan_ly_ton_giao.ServiceUser.ThemUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ThemUser", ReplyAction="*")]
        System.Threading.Tasks.Task<service_quan_ly_ton_giao.ServiceUser.ThemUserResponse> ThemUserAsync(service_quan_ly_ton_giao.ServiceUser.ThemUserRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Sua", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SuaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string id;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string hoten;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string Email;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public string ngaysinh;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public string hinhanh;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] f;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=6)]
        public string quyen;
        
        public SuaRequest() {
        }
        
        public SuaRequest(string id, string hoten, string Email, string ngaysinh, string hinhanh, byte[] f, string quyen) {
            this.id = id;
            this.hoten = hoten;
            this.Email = Email;
            this.ngaysinh = ngaysinh;
            this.hinhanh = hinhanh;
            this.f = f;
            this.quyen = quyen;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SuaResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SuaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string SuaResult;
        
        public SuaResponse() {
        }
        
        public SuaResponse(string SuaResult) {
            this.SuaResult = SuaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ThemUser", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ThemUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string user;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string pass;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string hoten;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public string Email;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public string ngaysinh;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        public string hinhanh;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] f;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=7)]
        public int phanquyen;
        
        public ThemUserRequest() {
        }
        
        public ThemUserRequest(string user, string pass, string hoten, string Email, string ngaysinh, string hinhanh, byte[] f, int phanquyen) {
            this.user = user;
            this.pass = pass;
            this.hoten = hoten;
            this.Email = Email;
            this.ngaysinh = ngaysinh;
            this.hinhanh = hinhanh;
            this.f = f;
            this.phanquyen = phanquyen;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ThemUserResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ThemUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string ThemUserResult;
        
        public ThemUserResponse() {
        }
        
        public ThemUserResponse(string ThemUserResult) {
            this.ThemUserResult = ThemUserResult;
        }
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
        
        public System.Data.DataTable GetInfo(string id) {
            return base.Channel.GetInfo(id);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetInfoAsync(string id) {
            return base.Channel.GetInfoAsync(id);
        }
        
        public System.Data.DataTable DanhSach() {
            return base.Channel.DanhSach();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> DanhSachAsync() {
            return base.Channel.DanhSachAsync();
        }
        
        public int DoiMatKhau(string mkmoi, string id) {
            return base.Channel.DoiMatKhau(mkmoi, id);
        }
        
        public System.Threading.Tasks.Task<int> DoiMatKhauAsync(string mkmoi, string id) {
            return base.Channel.DoiMatKhauAsync(mkmoi, id);
        }
        
        public int Xoa(string id) {
            return base.Channel.Xoa(id);
        }
        
        public System.Threading.Tasks.Task<int> XoaAsync(string id) {
            return base.Channel.XoaAsync(id);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        service_quan_ly_ton_giao.ServiceUser.SuaResponse service_quan_ly_ton_giao.ServiceUser.ServiceUserSoap.Sua(service_quan_ly_ton_giao.ServiceUser.SuaRequest request) {
            return base.Channel.Sua(request);
        }
        
        public string Sua(string id, string hoten, string Email, string ngaysinh, string hinhanh, byte[] f, string quyen) {
            service_quan_ly_ton_giao.ServiceUser.SuaRequest inValue = new service_quan_ly_ton_giao.ServiceUser.SuaRequest();
            inValue.id = id;
            inValue.hoten = hoten;
            inValue.Email = Email;
            inValue.ngaysinh = ngaysinh;
            inValue.hinhanh = hinhanh;
            inValue.f = f;
            inValue.quyen = quyen;
            service_quan_ly_ton_giao.ServiceUser.SuaResponse retVal = ((service_quan_ly_ton_giao.ServiceUser.ServiceUserSoap)(this)).Sua(inValue);
            return retVal.SuaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<service_quan_ly_ton_giao.ServiceUser.SuaResponse> service_quan_ly_ton_giao.ServiceUser.ServiceUserSoap.SuaAsync(service_quan_ly_ton_giao.ServiceUser.SuaRequest request) {
            return base.Channel.SuaAsync(request);
        }
        
        public System.Threading.Tasks.Task<service_quan_ly_ton_giao.ServiceUser.SuaResponse> SuaAsync(string id, string hoten, string Email, string ngaysinh, string hinhanh, byte[] f, string quyen) {
            service_quan_ly_ton_giao.ServiceUser.SuaRequest inValue = new service_quan_ly_ton_giao.ServiceUser.SuaRequest();
            inValue.id = id;
            inValue.hoten = hoten;
            inValue.Email = Email;
            inValue.ngaysinh = ngaysinh;
            inValue.hinhanh = hinhanh;
            inValue.f = f;
            inValue.quyen = quyen;
            return ((service_quan_ly_ton_giao.ServiceUser.ServiceUserSoap)(this)).SuaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        service_quan_ly_ton_giao.ServiceUser.ThemUserResponse service_quan_ly_ton_giao.ServiceUser.ServiceUserSoap.ThemUser(service_quan_ly_ton_giao.ServiceUser.ThemUserRequest request) {
            return base.Channel.ThemUser(request);
        }
        
        public string ThemUser(string user, string pass, string hoten, string Email, string ngaysinh, string hinhanh, byte[] f, int phanquyen) {
            service_quan_ly_ton_giao.ServiceUser.ThemUserRequest inValue = new service_quan_ly_ton_giao.ServiceUser.ThemUserRequest();
            inValue.user = user;
            inValue.pass = pass;
            inValue.hoten = hoten;
            inValue.Email = Email;
            inValue.ngaysinh = ngaysinh;
            inValue.hinhanh = hinhanh;
            inValue.f = f;
            inValue.phanquyen = phanquyen;
            service_quan_ly_ton_giao.ServiceUser.ThemUserResponse retVal = ((service_quan_ly_ton_giao.ServiceUser.ServiceUserSoap)(this)).ThemUser(inValue);
            return retVal.ThemUserResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<service_quan_ly_ton_giao.ServiceUser.ThemUserResponse> service_quan_ly_ton_giao.ServiceUser.ServiceUserSoap.ThemUserAsync(service_quan_ly_ton_giao.ServiceUser.ThemUserRequest request) {
            return base.Channel.ThemUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<service_quan_ly_ton_giao.ServiceUser.ThemUserResponse> ThemUserAsync(string user, string pass, string hoten, string Email, string ngaysinh, string hinhanh, byte[] f, int phanquyen) {
            service_quan_ly_ton_giao.ServiceUser.ThemUserRequest inValue = new service_quan_ly_ton_giao.ServiceUser.ThemUserRequest();
            inValue.user = user;
            inValue.pass = pass;
            inValue.hoten = hoten;
            inValue.Email = Email;
            inValue.ngaysinh = ngaysinh;
            inValue.hinhanh = hinhanh;
            inValue.f = f;
            inValue.phanquyen = phanquyen;
            return ((service_quan_ly_ton_giao.ServiceUser.ServiceUserSoap)(this)).ThemUserAsync(inValue);
        }
    }
}
