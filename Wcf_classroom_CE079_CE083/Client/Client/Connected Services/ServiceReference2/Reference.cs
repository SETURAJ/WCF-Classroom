﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Que", Namespace="http://schemas.datacontract.org/2004/07/Question")]
    [System.SerializableAttribute()]
    public partial class Que : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AnswerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Option1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Option2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Option3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Option4Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string QuestionValField;
        
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
        public string Answer {
            get {
                return this.AnswerField;
            }
            set {
                if ((object.ReferenceEquals(this.AnswerField, value) != true)) {
                    this.AnswerField = value;
                    this.RaisePropertyChanged("Answer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Option1 {
            get {
                return this.Option1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Option1Field, value) != true)) {
                    this.Option1Field = value;
                    this.RaisePropertyChanged("Option1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Option2 {
            get {
                return this.Option2Field;
            }
            set {
                if ((object.ReferenceEquals(this.Option2Field, value) != true)) {
                    this.Option2Field = value;
                    this.RaisePropertyChanged("Option2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Option3 {
            get {
                return this.Option3Field;
            }
            set {
                if ((object.ReferenceEquals(this.Option3Field, value) != true)) {
                    this.Option3Field = value;
                    this.RaisePropertyChanged("Option3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Option4 {
            get {
                return this.Option4Field;
            }
            set {
                if ((object.ReferenceEquals(this.Option4Field, value) != true)) {
                    this.Option4Field = value;
                    this.RaisePropertyChanged("Option4");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string QuestionVal {
            get {
                return this.QuestionValField;
            }
            set {
                if ((object.ReferenceEquals(this.QuestionValField, value) != true)) {
                    this.QuestionValField = value;
                    this.RaisePropertyChanged("QuestionVal");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllQuestions", ReplyAction="http://tempuri.org/IService1/GetAllQuestionsResponse")]
        Client.ServiceReference2.Que[] GetAllQuestions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllQuestions", ReplyAction="http://tempuri.org/IService1/GetAllQuestionsResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference2.Que[]> GetAllQuestionsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FindQuestion", ReplyAction="http://tempuri.org/IService1/FindQuestionResponse")]
        Client.ServiceReference2.Que FindQuestion(string question);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FindQuestion", ReplyAction="http://tempuri.org/IService1/FindQuestionResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference2.Que> FindQuestionAsync(string question);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddQuestion", ReplyAction="http://tempuri.org/IService1/AddQuestionResponse")]
        bool AddQuestion(Client.ServiceReference2.Que question);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddQuestion", ReplyAction="http://tempuri.org/IService1/AddQuestionResponse")]
        System.Threading.Tasks.Task<bool> AddQuestionAsync(Client.ServiceReference2.Que question);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateQuestion", ReplyAction="http://tempuri.org/IService1/UpdateQuestionResponse")]
        bool UpdateQuestion(string question, Client.ServiceReference2.Que updatedVal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateQuestion", ReplyAction="http://tempuri.org/IService1/UpdateQuestionResponse")]
        System.Threading.Tasks.Task<bool> UpdateQuestionAsync(string question, Client.ServiceReference2.Que updatedVal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteQuestion", ReplyAction="http://tempuri.org/IService1/DeleteQuestionResponse")]
        bool DeleteQuestion(string question);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteQuestion", ReplyAction="http://tempuri.org/IService1/DeleteQuestionResponse")]
        System.Threading.Tasks.Task<bool> DeleteQuestionAsync(string question);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsCorrect", ReplyAction="http://tempuri.org/IService1/IsCorrectResponse")]
        bool IsCorrect(string question, string answer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsCorrect", ReplyAction="http://tempuri.org/IService1/IsCorrectResponse")]
        System.Threading.Tasks.Task<bool> IsCorrectAsync(string question, string answer);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Client.ServiceReference2.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Client.ServiceReference2.IService1>, Client.ServiceReference2.IService1 {
        
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
        
        public Client.ServiceReference2.Que[] GetAllQuestions() {
            return base.Channel.GetAllQuestions();
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference2.Que[]> GetAllQuestionsAsync() {
            return base.Channel.GetAllQuestionsAsync();
        }
        
        public Client.ServiceReference2.Que FindQuestion(string question) {
            return base.Channel.FindQuestion(question);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference2.Que> FindQuestionAsync(string question) {
            return base.Channel.FindQuestionAsync(question);
        }
        
        public bool AddQuestion(Client.ServiceReference2.Que question) {
            return base.Channel.AddQuestion(question);
        }
        
        public System.Threading.Tasks.Task<bool> AddQuestionAsync(Client.ServiceReference2.Que question) {
            return base.Channel.AddQuestionAsync(question);
        }
        
        public bool UpdateQuestion(string question, Client.ServiceReference2.Que updatedVal) {
            return base.Channel.UpdateQuestion(question, updatedVal);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateQuestionAsync(string question, Client.ServiceReference2.Que updatedVal) {
            return base.Channel.UpdateQuestionAsync(question, updatedVal);
        }
        
        public bool DeleteQuestion(string question) {
            return base.Channel.DeleteQuestion(question);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteQuestionAsync(string question) {
            return base.Channel.DeleteQuestionAsync(question);
        }
        
        public bool IsCorrect(string question, string answer) {
            return base.Channel.IsCorrect(question, answer);
        }
        
        public System.Threading.Tasks.Task<bool> IsCorrectAsync(string question, string answer) {
            return base.Channel.IsCorrectAsync(question, answer);
        }
    }
}
