﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAT.Services.ConsultaCFDIService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Acuse", Namespace="http://schemas.datacontract.org/2004/07/Sat.Cfdi.Negocio.ConsultaCfdi.Servicio")]
    [System.SerializableAttribute()]
    public partial class Acuse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoEstatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EsCancelableField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstatusCancelacionField;
        
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
        public string CodigoEstatus {
            get {
                return this.CodigoEstatusField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoEstatusField, value) != true)) {
                    this.CodigoEstatusField = value;
                    this.RaisePropertyChanged("CodigoEstatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EsCancelable {
            get {
                return this.EsCancelableField;
            }
            set {
                if ((object.ReferenceEquals(this.EsCancelableField, value) != true)) {
                    this.EsCancelableField = value;
                    this.RaisePropertyChanged("EsCancelable");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EstatusCancelacion {
            get {
                return this.EstatusCancelacionField;
            }
            set {
                if ((object.ReferenceEquals(this.EstatusCancelacionField, value) != true)) {
                    this.EstatusCancelacionField = value;
                    this.RaisePropertyChanged("EstatusCancelacion");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ConsultaCFDIService.IConsultaCFDIService")]
    public interface IConsultaCFDIService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsultaCFDIService/Consulta", ReplyAction="http://tempuri.org/IConsultaCFDIService/ConsultaResponse")]
        SAT.Services.ConsultaCFDIService.Acuse Consulta(string expresionImpresa);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IConsultaCFDIServiceChannel : SAT.Services.ConsultaCFDIService.IConsultaCFDIService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ConsultaCFDIServiceClient : System.ServiceModel.ClientBase<SAT.Services.ConsultaCFDIService.IConsultaCFDIService>, SAT.Services.ConsultaCFDIService.IConsultaCFDIService {
        
        public ConsultaCFDIServiceClient() {
        }
        
        public ConsultaCFDIServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ConsultaCFDIServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConsultaCFDIServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConsultaCFDIServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SAT.Services.ConsultaCFDIService.Acuse Consulta(string expresionImpresa) {
            return base.Channel.Consulta(expresionImpresa);
        }
    }
}
