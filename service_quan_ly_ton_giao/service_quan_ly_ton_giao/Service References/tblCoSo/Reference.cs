﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace service_quan_ly_ton_giao.tblCoSo {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="tblCoSo.ServiceCoSoSoap")]
    public interface ServiceCoSoSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ThemDLCoSo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int ThemDLCoSo(string TenCoSo, string DiaChi, int NguoiQuanLy, string HinhAnh, int IDToChuc, string GioiThieu, int ChucNang, int DaXoa, string TenThuongGoi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ThemDLCoSo", ReplyAction="*")]
        System.Threading.Tasks.Task<int> ThemDLCoSoAsync(string TenCoSo, string DiaChi, int NguoiQuanLy, string HinhAnh, int IDToChuc, string GioiThieu, int ChucNang, int DaXoa, string TenThuongGoi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SuaDLCoSo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int SuaDLCoSo(int IDCoSo, string TenCoSo, string DiaChi, int NguoiQuanLy, string HinhAnh, int IDToChuc, string GioiThieu, int ChucNang, int DaXoa, string TenThuongGoi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SuaDLCoSo", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SuaDLCoSoAsync(int IDCoSo, string TenCoSo, string DiaChi, int NguoiQuanLy, string HinhAnh, int IDToChuc, string GioiThieu, int ChucNang, int DaXoa, string TenThuongGoi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XoaLogicDLCoSo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int XoaLogicDLCoSo(int IDCoSo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XoaLogicDLCoSo", ReplyAction="*")]
        System.Threading.Tasks.Task<int> XoaLogicDLCoSoAsync(int IDCoSo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HienThiDSCoSo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable HienThiDSCoSo(string GioiThieu, string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HienThiDSCoSo", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> HienThiDSCoSoAsync(string GioiThieu, string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DuLieuTinh", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable DuLieuTinh(string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DuLieuTinh", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> DuLieuTinhAsync(string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TruyVanTenHuyen", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable TruyVanTenHuyen(string tinh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TruyVanTenHuyen", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> TruyVanTenHuyenAsync(string tinh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TruyVanTenXa", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable TruyVanTenXa(string huyen);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TruyVanTenXa", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> TruyVanTenXaAsync(string huyen);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TruyVanTenTonGiao", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable TruyVanTenTonGiao(string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TruyVanTenTonGiao", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> TruyVanTenTonGiaoAsync(string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimViTri", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable TimViTri(string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimViTri", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> TimViTriAsync(string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimViTriTheoHuyen", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable TimViTriTheoHuyen(string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimViTriTheoHuyen", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> TimViTriTheoHuyenAsync(string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimViTriTheoTinh", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable TimViTriTheoTinh(string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TimViTriTheoTinh", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> TimViTriTheoTinhAsync(string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DuLieuTonGiao", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable DuLieuTonGiao(string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DuLieuTonGiao", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> DuLieuTonGiaoAsync(string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DuLieuVung", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable DuLieuVung(string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DuLieuVung", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> DuLieuVungAsync(string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DuLieuToChucQuanTri", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable DuLieuToChucQuanTri(string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DuLieuToChucQuanTri", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> DuLieuToChucQuanTriAsync(string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DuLieuTinDo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable DuLieuTinDo(string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DuLieuTinDo", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> DuLieuTinDoAsync(string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DuLieuXa", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable DuLieuXa(string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DuLieuXa", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> DuLieuXaAsync(string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DuLieuHuyen", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable DuLieuHuyen(string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DuLieuHuyen", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> DuLieuHuyenAsync(string dieukien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TaoIDCoSo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable TaoIDCoSo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TaoIDCoSo", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> TaoIDCoSoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XoaCoSotblTinDo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int XoaCoSotblTinDo(int IDCoSo, string DieuKien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/XoaCoSotblTinDo", ReplyAction="*")]
        System.Threading.Tasks.Task<int> XoaCoSotblTinDoAsync(int IDCoSo, string DieuKien);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceCoSoSoapChannel : service_quan_ly_ton_giao.tblCoSo.ServiceCoSoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceCoSoSoapClient : System.ServiceModel.ClientBase<service_quan_ly_ton_giao.tblCoSo.ServiceCoSoSoap>, service_quan_ly_ton_giao.tblCoSo.ServiceCoSoSoap {
        
        public ServiceCoSoSoapClient() {
        }
        
        public ServiceCoSoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceCoSoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCoSoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCoSoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int ThemDLCoSo(string TenCoSo, string DiaChi, int NguoiQuanLy, string HinhAnh, int IDToChuc, string GioiThieu, int ChucNang, int DaXoa, string TenThuongGoi) {
            return base.Channel.ThemDLCoSo(TenCoSo, DiaChi, NguoiQuanLy, HinhAnh, IDToChuc, GioiThieu, ChucNang, DaXoa, TenThuongGoi);
        }
        
        public System.Threading.Tasks.Task<int> ThemDLCoSoAsync(string TenCoSo, string DiaChi, int NguoiQuanLy, string HinhAnh, int IDToChuc, string GioiThieu, int ChucNang, int DaXoa, string TenThuongGoi) {
            return base.Channel.ThemDLCoSoAsync(TenCoSo, DiaChi, NguoiQuanLy, HinhAnh, IDToChuc, GioiThieu, ChucNang, DaXoa, TenThuongGoi);
        }
        
        public int SuaDLCoSo(int IDCoSo, string TenCoSo, string DiaChi, int NguoiQuanLy, string HinhAnh, int IDToChuc, string GioiThieu, int ChucNang, int DaXoa, string TenThuongGoi) {
            return base.Channel.SuaDLCoSo(IDCoSo, TenCoSo, DiaChi, NguoiQuanLy, HinhAnh, IDToChuc, GioiThieu, ChucNang, DaXoa, TenThuongGoi);
        }
        
        public System.Threading.Tasks.Task<int> SuaDLCoSoAsync(int IDCoSo, string TenCoSo, string DiaChi, int NguoiQuanLy, string HinhAnh, int IDToChuc, string GioiThieu, int ChucNang, int DaXoa, string TenThuongGoi) {
            return base.Channel.SuaDLCoSoAsync(IDCoSo, TenCoSo, DiaChi, NguoiQuanLy, HinhAnh, IDToChuc, GioiThieu, ChucNang, DaXoa, TenThuongGoi);
        }
        
        public int XoaLogicDLCoSo(int IDCoSo) {
            return base.Channel.XoaLogicDLCoSo(IDCoSo);
        }
        
        public System.Threading.Tasks.Task<int> XoaLogicDLCoSoAsync(int IDCoSo) {
            return base.Channel.XoaLogicDLCoSoAsync(IDCoSo);
        }
        
        public System.Data.DataTable HienThiDSCoSo(string GioiThieu, string dieukien) {
            return base.Channel.HienThiDSCoSo(GioiThieu, dieukien);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> HienThiDSCoSoAsync(string GioiThieu, string dieukien) {
            return base.Channel.HienThiDSCoSoAsync(GioiThieu, dieukien);
        }
        
        public System.Data.DataTable DuLieuTinh(string dieukien) {
            return base.Channel.DuLieuTinh(dieukien);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> DuLieuTinhAsync(string dieukien) {
            return base.Channel.DuLieuTinhAsync(dieukien);
        }
        
        public System.Data.DataTable TruyVanTenHuyen(string tinh) {
            return base.Channel.TruyVanTenHuyen(tinh);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> TruyVanTenHuyenAsync(string tinh) {
            return base.Channel.TruyVanTenHuyenAsync(tinh);
        }
        
        public System.Data.DataTable TruyVanTenXa(string huyen) {
            return base.Channel.TruyVanTenXa(huyen);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> TruyVanTenXaAsync(string huyen) {
            return base.Channel.TruyVanTenXaAsync(huyen);
        }
        
        public System.Data.DataTable TruyVanTenTonGiao(string dieukien) {
            return base.Channel.TruyVanTenTonGiao(dieukien);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> TruyVanTenTonGiaoAsync(string dieukien) {
            return base.Channel.TruyVanTenTonGiaoAsync(dieukien);
        }
        
        public System.Data.DataTable TimViTri(string dieukien) {
            return base.Channel.TimViTri(dieukien);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> TimViTriAsync(string dieukien) {
            return base.Channel.TimViTriAsync(dieukien);
        }
        
        public System.Data.DataTable TimViTriTheoHuyen(string dieukien) {
            return base.Channel.TimViTriTheoHuyen(dieukien);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> TimViTriTheoHuyenAsync(string dieukien) {
            return base.Channel.TimViTriTheoHuyenAsync(dieukien);
        }
        
        public System.Data.DataTable TimViTriTheoTinh(string dieukien) {
            return base.Channel.TimViTriTheoTinh(dieukien);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> TimViTriTheoTinhAsync(string dieukien) {
            return base.Channel.TimViTriTheoTinhAsync(dieukien);
        }
        
        public System.Data.DataTable DuLieuTonGiao(string dieukien) {
            return base.Channel.DuLieuTonGiao(dieukien);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> DuLieuTonGiaoAsync(string dieukien) {
            return base.Channel.DuLieuTonGiaoAsync(dieukien);
        }
        
        public System.Data.DataTable DuLieuVung(string dieukien) {
            return base.Channel.DuLieuVung(dieukien);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> DuLieuVungAsync(string dieukien) {
            return base.Channel.DuLieuVungAsync(dieukien);
        }
        
        public System.Data.DataTable DuLieuToChucQuanTri(string dieukien) {
            return base.Channel.DuLieuToChucQuanTri(dieukien);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> DuLieuToChucQuanTriAsync(string dieukien) {
            return base.Channel.DuLieuToChucQuanTriAsync(dieukien);
        }
        
        public System.Data.DataTable DuLieuTinDo(string dieukien) {
            return base.Channel.DuLieuTinDo(dieukien);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> DuLieuTinDoAsync(string dieukien) {
            return base.Channel.DuLieuTinDoAsync(dieukien);
        }
        
        public System.Data.DataTable DuLieuXa(string dieukien) {
            return base.Channel.DuLieuXa(dieukien);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> DuLieuXaAsync(string dieukien) {
            return base.Channel.DuLieuXaAsync(dieukien);
        }
        
        public System.Data.DataTable DuLieuHuyen(string dieukien) {
            return base.Channel.DuLieuHuyen(dieukien);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> DuLieuHuyenAsync(string dieukien) {
            return base.Channel.DuLieuHuyenAsync(dieukien);
        }
        
        public System.Data.DataTable TaoIDCoSo() {
            return base.Channel.TaoIDCoSo();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> TaoIDCoSoAsync() {
            return base.Channel.TaoIDCoSoAsync();
        }
        
        public int XoaCoSotblTinDo(int IDCoSo, string DieuKien) {
            return base.Channel.XoaCoSotblTinDo(IDCoSo, DieuKien);
        }
        
        public System.Threading.Tasks.Task<int> XoaCoSotblTinDoAsync(int IDCoSo, string DieuKien) {
            return base.Channel.XoaCoSotblTinDoAsync(IDCoSo, DieuKien);
        }
    }
}
