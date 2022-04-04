﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference4 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Exam", Namespace="http://schemas.datacontract.org/2004/07/Assignment")]
    [System.SerializableAttribute()]
    public partial class Exam : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DueTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] QuestionsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TeacherField;
        
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
        public System.DateTime DueTime {
            get {
                return this.DueTimeField;
            }
            set {
                if ((this.DueTimeField.Equals(value) != true)) {
                    this.DueTimeField = value;
                    this.RaisePropertyChanged("DueTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Questions {
            get {
                return this.QuestionsField;
            }
            set {
                if ((object.ReferenceEquals(this.QuestionsField, value) != true)) {
                    this.QuestionsField = value;
                    this.RaisePropertyChanged("Questions");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Teacher {
            get {
                return this.TeacherField;
            }
            set {
                if ((object.ReferenceEquals(this.TeacherField, value) != true)) {
                    this.TeacherField = value;
                    this.RaisePropertyChanged("Teacher");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference4.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddExam", ReplyAction="http://tempuri.org/IService1/AddExamResponse")]
        bool AddExam(Client.ServiceReference4.Exam exam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddExam", ReplyAction="http://tempuri.org/IService1/AddExamResponse")]
        System.Threading.Tasks.Task<bool> AddExamAsync(Client.ServiceReference4.Exam exam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteExam", ReplyAction="http://tempuri.org/IService1/DeleteExamResponse")]
        bool DeleteExam(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteExam", ReplyAction="http://tempuri.org/IService1/DeleteExamResponse")]
        System.Threading.Tasks.Task<bool> DeleteExamAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetExam", ReplyAction="http://tempuri.org/IService1/GetExamResponse")]
        Client.ServiceReference4.Exam GetExam(int examid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetExam", ReplyAction="http://tempuri.org/IService1/GetExamResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference4.Exam> GetExamAsync(int examid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostExam", ReplyAction="http://tempuri.org/IService1/PostExamResponse")]
        bool PostExam(int examid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/PostExam", ReplyAction="http://tempuri.org/IService1/PostExamResponse")]
        System.Threading.Tasks.Task<bool> PostExamAsync(int examid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllPostedExam", ReplyAction="http://tempuri.org/IService1/GetAllPostedExamResponse")]
        Client.ServiceReference4.Exam[] GetAllPostedExam(string teacher);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllPostedExam", ReplyAction="http://tempuri.org/IService1/GetAllPostedExamResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference4.Exam[]> GetAllPostedExamAsync(string teacher);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllExam", ReplyAction="http://tempuri.org/IService1/GetAllExamResponse")]
        Client.ServiceReference4.Exam[] GetAllExam(string teacher);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllExam", ReplyAction="http://tempuri.org/IService1/GetAllExamResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference4.Exam[]> GetAllExamAsync(string teacher);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Client.ServiceReference4.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Client.ServiceReference4.IService1>, Client.ServiceReference4.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddExam(Client.ServiceReference4.Exam exam) {
            return base.Channel.AddExam(exam);
        }
        
        public System.Threading.Tasks.Task<bool> AddExamAsync(Client.ServiceReference4.Exam exam) {
            return base.Channel.AddExamAsync(exam);
        }
        
        public bool DeleteExam(int id) {
            return base.Channel.DeleteExam(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteExamAsync(int id) {
            return base.Channel.DeleteExamAsync(id);
        }
        
        public Client.ServiceReference4.Exam GetExam(int examid) {
            return base.Channel.GetExam(examid);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference4.Exam> GetExamAsync(int examid) {
            return base.Channel.GetExamAsync(examid);
        }
        
        public bool PostExam(int examid) {
            return base.Channel.PostExam(examid);
        }
        
        public System.Threading.Tasks.Task<bool> PostExamAsync(int examid) {
            return base.Channel.PostExamAsync(examid);
        }
        
        public Client.ServiceReference4.Exam[] GetAllPostedExam(string teacher) {
            return base.Channel.GetAllPostedExam(teacher);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference4.Exam[]> GetAllPostedExamAsync(string teacher) {
            return base.Channel.GetAllPostedExamAsync(teacher);
        }
        
        public Client.ServiceReference4.Exam[] GetAllExam(string teacher) {
            return base.Channel.GetAllExam(teacher);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference4.Exam[]> GetAllExamAsync(string teacher) {
            return base.Channel.GetAllExamAsync(teacher);
        }
    }
}