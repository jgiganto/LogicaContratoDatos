﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CienteContratoDatos.ServicioAlumnos {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Alumno", Namespace="http://schemas.datacontract.org/2004/07/LogicaContratoDatos")]
    [System.SerializableAttribute()]
    public partial class Alumno : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdAlumnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NotaField;
        
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
        public string Apellidos {
            get {
                return this.ApellidosField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidosField, value) != true)) {
                    this.ApellidosField = value;
                    this.RaisePropertyChanged("Apellidos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdAlumno {
            get {
                return this.IdAlumnoField;
            }
            set {
                if ((this.IdAlumnoField.Equals(value) != true)) {
                    this.IdAlumnoField = value;
                    this.RaisePropertyChanged("IdAlumno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Nota {
            get {
                return this.NotaField;
            }
            set {
                if ((this.NotaField.Equals(value) != true)) {
                    this.NotaField = value;
                    this.RaisePropertyChanged("Nota");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioAlumnos.IContratoAlumno")]
    public interface IContratoAlumno {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContratoAlumno/GetAlumnos", ReplyAction="http://tempuri.org/IContratoAlumno/GetAlumnosResponse")]
        CienteContratoDatos.ServicioAlumnos.Alumno[] GetAlumnos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContratoAlumno/GetAlumnos", ReplyAction="http://tempuri.org/IContratoAlumno/GetAlumnosResponse")]
        System.Threading.Tasks.Task<CienteContratoDatos.ServicioAlumnos.Alumno[]> GetAlumnosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContratoAlumno/BuscarAlumno", ReplyAction="http://tempuri.org/IContratoAlumno/BuscarAlumnoResponse")]
        CienteContratoDatos.ServicioAlumnos.Alumno BuscarAlumno(string idalumno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContratoAlumno/BuscarAlumno", ReplyAction="http://tempuri.org/IContratoAlumno/BuscarAlumnoResponse")]
        System.Threading.Tasks.Task<CienteContratoDatos.ServicioAlumnos.Alumno> BuscarAlumnoAsync(string idalumno);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IContratoAlumnoChannel : CienteContratoDatos.ServicioAlumnos.IContratoAlumno, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ContratoAlumnoClient : System.ServiceModel.ClientBase<CienteContratoDatos.ServicioAlumnos.IContratoAlumno>, CienteContratoDatos.ServicioAlumnos.IContratoAlumno {
        
        public ContratoAlumnoClient() {
        }
        
        public ContratoAlumnoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ContratoAlumnoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContratoAlumnoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContratoAlumnoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CienteContratoDatos.ServicioAlumnos.Alumno[] GetAlumnos() {
            return base.Channel.GetAlumnos();
        }
        
        public System.Threading.Tasks.Task<CienteContratoDatos.ServicioAlumnos.Alumno[]> GetAlumnosAsync() {
            return base.Channel.GetAlumnosAsync();
        }
        
        public CienteContratoDatos.ServicioAlumnos.Alumno BuscarAlumno(string idalumno) {
            return base.Channel.BuscarAlumno(idalumno);
        }
        
        public System.Threading.Tasks.Task<CienteContratoDatos.ServicioAlumnos.Alumno> BuscarAlumnoAsync(string idalumno) {
            return base.Channel.BuscarAlumnoAsync(idalumno);
        }
    }
}
