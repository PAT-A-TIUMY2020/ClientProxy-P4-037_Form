﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientProxy_P4_037_Form.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Koordinat", Namespace="http://schemas.datacontract.org/2004/07/ServiceMtk_P1_037")]
    [System.SerializableAttribute()]
    public partial class Koordinat : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int XField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YField;
        
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
        public int X {
            get {
                return this.XField;
            }
            set {
                if ((this.XField.Equals(value) != true)) {
                    this.XField = value;
                    this.RaisePropertyChanged("X");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Y {
            get {
                return this.YField;
            }
            set {
                if ((this.YField.Equals(value) != true)) {
                    this.YField = value;
                    this.RaisePropertyChanged("Y");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.Imatematika")]
    public interface Imatematika {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Imatematika/Tambah", ReplyAction="http://tempuri.org/Imatematika/TambahResponse")]
        int Tambah(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Imatematika/Tambah", ReplyAction="http://tempuri.org/Imatematika/TambahResponse")]
        System.Threading.Tasks.Task<int> TambahAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Imatematika/Kurang", ReplyAction="http://tempuri.org/Imatematika/KurangResponse")]
        int Kurang(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Imatematika/Kurang", ReplyAction="http://tempuri.org/Imatematika/KurangResponse")]
        System.Threading.Tasks.Task<int> KurangAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Imatematika/Kali", ReplyAction="http://tempuri.org/Imatematika/KaliResponse")]
        int Kali(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Imatematika/Kali", ReplyAction="http://tempuri.org/Imatematika/KaliResponse")]
        System.Threading.Tasks.Task<int> KaliAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Imatematika/Bagi", ReplyAction="http://tempuri.org/Imatematika/BagiResponse")]
        int Bagi(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Imatematika/Bagi", ReplyAction="http://tempuri.org/Imatematika/BagiResponse")]
        System.Threading.Tasks.Task<int> BagiAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Imatematika/TKoordinat", ReplyAction="http://tempuri.org/Imatematika/TKoordinatResponse")]
        ClientProxy_P4_037_Form.ServiceReference2.Koordinat TKoordinat(ClientProxy_P4_037_Form.ServiceReference2.Koordinat a, ClientProxy_P4_037_Form.ServiceReference2.Koordinat b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Imatematika/TKoordinat", ReplyAction="http://tempuri.org/Imatematika/TKoordinatResponse")]
        System.Threading.Tasks.Task<ClientProxy_P4_037_Form.ServiceReference2.Koordinat> TKoordinatAsync(ClientProxy_P4_037_Form.ServiceReference2.Koordinat a, ClientProxy_P4_037_Form.ServiceReference2.Koordinat b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ImatematikaChannel : ClientProxy_P4_037_Form.ServiceReference2.Imatematika, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ImatematikaClient : System.ServiceModel.ClientBase<ClientProxy_P4_037_Form.ServiceReference2.Imatematika>, ClientProxy_P4_037_Form.ServiceReference2.Imatematika {
        
        public ImatematikaClient() {
        }
        
        public ImatematikaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ImatematikaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImatematikaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImatematikaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Tambah(int a, int b) {
            return base.Channel.Tambah(a, b);
        }
        
        public System.Threading.Tasks.Task<int> TambahAsync(int a, int b) {
            return base.Channel.TambahAsync(a, b);
        }
        
        public int Kurang(int a, int b) {
            return base.Channel.Kurang(a, b);
        }
        
        public System.Threading.Tasks.Task<int> KurangAsync(int a, int b) {
            return base.Channel.KurangAsync(a, b);
        }
        
        public int Kali(int a, int b) {
            return base.Channel.Kali(a, b);
        }
        
        public System.Threading.Tasks.Task<int> KaliAsync(int a, int b) {
            return base.Channel.KaliAsync(a, b);
        }
        
        public int Bagi(int a, int b) {
            return base.Channel.Bagi(a, b);
        }
        
        public System.Threading.Tasks.Task<int> BagiAsync(int a, int b) {
            return base.Channel.BagiAsync(a, b);
        }
        
        public ClientProxy_P4_037_Form.ServiceReference2.Koordinat TKoordinat(ClientProxy_P4_037_Form.ServiceReference2.Koordinat a, ClientProxy_P4_037_Form.ServiceReference2.Koordinat b) {
            return base.Channel.TKoordinat(a, b);
        }
        
        public System.Threading.Tasks.Task<ClientProxy_P4_037_Form.ServiceReference2.Koordinat> TKoordinatAsync(ClientProxy_P4_037_Form.ServiceReference2.Koordinat a, ClientProxy_P4_037_Form.ServiceReference2.Koordinat b) {
            return base.Channel.TKoordinatAsync(a, b);
        }
    }
}
