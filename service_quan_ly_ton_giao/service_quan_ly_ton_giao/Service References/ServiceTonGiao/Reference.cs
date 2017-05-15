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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ThemTonGiao", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int ThemTonGiao(string Ten, string gioithieu, string hinhanh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ThemTonGiao", ReplyAction="*")]
        System.Threading.Tasks.Task<int> ThemTonGiaoAsync(string Ten, string gioithieu, string hinhanh);
        
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LoadAnh", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MarshalByRefObject))]
        service_quan_ly_ton_giao.ServiceTonGiao.Image LoadAnh(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LoadAnh", ReplyAction="*")]
        System.Threading.Tasks.Task<service_quan_ly_ton_giao.ServiceTonGiao.Image> LoadAnhAsync(string path);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class Image : MarshalByRefObject {
        
        private object tagField;
        
        private ColorPalette paletteField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public object Tag {
            get {
                return this.tagField;
            }
            set {
                this.tagField = value;
                this.RaisePropertyChanged("Tag");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ColorPalette Palette {
            get {
                return this.paletteField;
            }
            set {
                this.paletteField = value;
                this.RaisePropertyChanged("Palette");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ColorPalette : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Image))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class MarshalByRefObject : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
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
        
        public int ThemTonGiao(string Ten, string gioithieu, string hinhanh) {
            return base.Channel.ThemTonGiao(Ten, gioithieu, hinhanh);
        }
        
        public System.Threading.Tasks.Task<int> ThemTonGiaoAsync(string Ten, string gioithieu, string hinhanh) {
            return base.Channel.ThemTonGiaoAsync(Ten, gioithieu, hinhanh);
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
        
        public service_quan_ly_ton_giao.ServiceTonGiao.Image LoadAnh(string path) {
            return base.Channel.LoadAnh(path);
        }
        
        public System.Threading.Tasks.Task<service_quan_ly_ton_giao.ServiceTonGiao.Image> LoadAnhAsync(string path) {
            return base.Channel.LoadAnhAsync(path);
        }
    }
}
