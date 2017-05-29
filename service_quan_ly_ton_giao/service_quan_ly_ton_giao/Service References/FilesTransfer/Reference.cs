﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace service_quan_ly_ton_giao.FilesTransfer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FilesTransfer.FilesTransferSoap")]
    public interface FilesTransferSoap {
        
        // CODEGEN: Generating message contract since element name f from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UploadFile", ReplyAction="*")]
        service_quan_ly_ton_giao.FilesTransfer.UploadFileResponse UploadFile(service_quan_ly_ton_giao.FilesTransfer.UploadFileRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UploadFile", ReplyAction="*")]
        System.Threading.Tasks.Task<service_quan_ly_ton_giao.FilesTransfer.UploadFileResponse> UploadFileAsync(service_quan_ly_ton_giao.FilesTransfer.UploadFileRequest request);
        
        // CODEGEN: Generating message contract since element name FName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DownloadFile", ReplyAction="*")]
        service_quan_ly_ton_giao.FilesTransfer.DownloadFileResponse DownloadFile(service_quan_ly_ton_giao.FilesTransfer.DownloadFileRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DownloadFile", ReplyAction="*")]
        System.Threading.Tasks.Task<service_quan_ly_ton_giao.FilesTransfer.DownloadFileResponse> DownloadFileAsync(service_quan_ly_ton_giao.FilesTransfer.DownloadFileRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadFileRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UploadFile", Namespace="http://tempuri.org/", Order=0)]
        public service_quan_ly_ton_giao.FilesTransfer.UploadFileRequestBody Body;
        
        public UploadFileRequest() {
        }
        
        public UploadFileRequest(service_quan_ly_ton_giao.FilesTransfer.UploadFileRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UploadFileRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] f;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string fileName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string type;
        
        public UploadFileRequestBody() {
        }
        
        public UploadFileRequestBody(byte[] f, string fileName, string type) {
            this.f = f;
            this.fileName = fileName;
            this.type = type;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadFileResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UploadFileResponse", Namespace="http://tempuri.org/", Order=0)]
        public service_quan_ly_ton_giao.FilesTransfer.UploadFileResponseBody Body;
        
        public UploadFileResponse() {
        }
        
        public UploadFileResponse(service_quan_ly_ton_giao.FilesTransfer.UploadFileResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UploadFileResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string UploadFileResult;
        
        public UploadFileResponseBody() {
        }
        
        public UploadFileResponseBody(string UploadFileResult) {
            this.UploadFileResult = UploadFileResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DownloadFileRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DownloadFile", Namespace="http://tempuri.org/", Order=0)]
        public service_quan_ly_ton_giao.FilesTransfer.DownloadFileRequestBody Body;
        
        public DownloadFileRequest() {
        }
        
        public DownloadFileRequest(service_quan_ly_ton_giao.FilesTransfer.DownloadFileRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DownloadFileRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string FName;
        
        public DownloadFileRequestBody() {
        }
        
        public DownloadFileRequestBody(string FName) {
            this.FName = FName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DownloadFileResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DownloadFileResponse", Namespace="http://tempuri.org/", Order=0)]
        public service_quan_ly_ton_giao.FilesTransfer.DownloadFileResponseBody Body;
        
        public DownloadFileResponse() {
        }
        
        public DownloadFileResponse(service_quan_ly_ton_giao.FilesTransfer.DownloadFileResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DownloadFileResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] DownloadFileResult;
        
        public DownloadFileResponseBody() {
        }
        
        public DownloadFileResponseBody(byte[] DownloadFileResult) {
            this.DownloadFileResult = DownloadFileResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FilesTransferSoapChannel : service_quan_ly_ton_giao.FilesTransfer.FilesTransferSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FilesTransferSoapClient : System.ServiceModel.ClientBase<service_quan_ly_ton_giao.FilesTransfer.FilesTransferSoap>, service_quan_ly_ton_giao.FilesTransfer.FilesTransferSoap {
        
        public FilesTransferSoapClient() {
        }
        
        public FilesTransferSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FilesTransferSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FilesTransferSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FilesTransferSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        service_quan_ly_ton_giao.FilesTransfer.UploadFileResponse service_quan_ly_ton_giao.FilesTransfer.FilesTransferSoap.UploadFile(service_quan_ly_ton_giao.FilesTransfer.UploadFileRequest request) {
            return base.Channel.UploadFile(request);
        }
        
        public string UploadFile(byte[] f, string fileName, string type) {
            service_quan_ly_ton_giao.FilesTransfer.UploadFileRequest inValue = new service_quan_ly_ton_giao.FilesTransfer.UploadFileRequest();
            inValue.Body = new service_quan_ly_ton_giao.FilesTransfer.UploadFileRequestBody();
            inValue.Body.f = f;
            inValue.Body.fileName = fileName;
            inValue.Body.type = type;
            service_quan_ly_ton_giao.FilesTransfer.UploadFileResponse retVal = ((service_quan_ly_ton_giao.FilesTransfer.FilesTransferSoap)(this)).UploadFile(inValue);
            return retVal.Body.UploadFileResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<service_quan_ly_ton_giao.FilesTransfer.UploadFileResponse> service_quan_ly_ton_giao.FilesTransfer.FilesTransferSoap.UploadFileAsync(service_quan_ly_ton_giao.FilesTransfer.UploadFileRequest request) {
            return base.Channel.UploadFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<service_quan_ly_ton_giao.FilesTransfer.UploadFileResponse> UploadFileAsync(byte[] f, string fileName, string type) {
            service_quan_ly_ton_giao.FilesTransfer.UploadFileRequest inValue = new service_quan_ly_ton_giao.FilesTransfer.UploadFileRequest();
            inValue.Body = new service_quan_ly_ton_giao.FilesTransfer.UploadFileRequestBody();
            inValue.Body.f = f;
            inValue.Body.fileName = fileName;
            inValue.Body.type = type;
            return ((service_quan_ly_ton_giao.FilesTransfer.FilesTransferSoap)(this)).UploadFileAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        service_quan_ly_ton_giao.FilesTransfer.DownloadFileResponse service_quan_ly_ton_giao.FilesTransfer.FilesTransferSoap.DownloadFile(service_quan_ly_ton_giao.FilesTransfer.DownloadFileRequest request) {
            return base.Channel.DownloadFile(request);
        }
        
        public byte[] DownloadFile(string FName) {
            service_quan_ly_ton_giao.FilesTransfer.DownloadFileRequest inValue = new service_quan_ly_ton_giao.FilesTransfer.DownloadFileRequest();
            inValue.Body = new service_quan_ly_ton_giao.FilesTransfer.DownloadFileRequestBody();
            inValue.Body.FName = FName;
            service_quan_ly_ton_giao.FilesTransfer.DownloadFileResponse retVal = ((service_quan_ly_ton_giao.FilesTransfer.FilesTransferSoap)(this)).DownloadFile(inValue);
            return retVal.Body.DownloadFileResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<service_quan_ly_ton_giao.FilesTransfer.DownloadFileResponse> service_quan_ly_ton_giao.FilesTransfer.FilesTransferSoap.DownloadFileAsync(service_quan_ly_ton_giao.FilesTransfer.DownloadFileRequest request) {
            return base.Channel.DownloadFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<service_quan_ly_ton_giao.FilesTransfer.DownloadFileResponse> DownloadFileAsync(string FName) {
            service_quan_ly_ton_giao.FilesTransfer.DownloadFileRequest inValue = new service_quan_ly_ton_giao.FilesTransfer.DownloadFileRequest();
            inValue.Body = new service_quan_ly_ton_giao.FilesTransfer.DownloadFileRequestBody();
            inValue.Body.FName = FName;
            return ((service_quan_ly_ton_giao.FilesTransfer.FilesTransferSoap)(this)).DownloadFileAsync(inValue);
        }
    }
}
