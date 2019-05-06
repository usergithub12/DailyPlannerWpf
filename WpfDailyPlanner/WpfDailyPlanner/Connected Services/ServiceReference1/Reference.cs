﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfDailyPlanner.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordConfirmationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelephoneField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
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
        public string Login {
            get {
                return this.LoginField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginField, value) != true)) {
                    this.LoginField = value;
                    this.RaisePropertyChanged("Login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PasswordConfirmation {
            get {
                return this.PasswordConfirmationField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordConfirmationField, value) != true)) {
                    this.PasswordConfirmationField = value;
                    this.RaisePropertyChanged("PasswordConfirmation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telephone {
            get {
                return this.TelephoneField;
            }
            set {
                if ((object.ReferenceEquals(this.TelephoneField, value) != true)) {
                    this.TelephoneField = value;
                    this.RaisePropertyChanged("Telephone");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DailyTaskNotes", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class DailyTaskNotes : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EndDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfDailyPlanner.ServiceReference1.Group GroupField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartDateField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EndDate {
            get {
                return this.EndDateField;
            }
            set {
                if ((this.EndDateField.Equals(value) != true)) {
                    this.EndDateField = value;
                    this.RaisePropertyChanged("EndDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfDailyPlanner.ServiceReference1.Group Group {
            get {
                return this.GroupField;
            }
            set {
                if ((object.ReferenceEquals(this.GroupField, value) != true)) {
                    this.GroupField = value;
                    this.RaisePropertyChanged("Group");
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
        public string Location {
            get {
                return this.LocationField;
            }
            set {
                if ((object.ReferenceEquals(this.LocationField, value) != true)) {
                    this.LocationField = value;
                    this.RaisePropertyChanged("Location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartDate {
            get {
                return this.StartDateField;
            }
            set {
                if ((this.StartDateField.Equals(value) != true)) {
                    this.StartDateField = value;
                    this.RaisePropertyChanged("StartDate");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Group", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class Group : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfDailyPlanner.ServiceReference1.DailyTaskNotes[] TasksField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfDailyPlanner.ServiceReference1.DailyTaskNotes[] Tasks {
            get {
                return this.TasksField;
            }
            set {
                if ((object.ReferenceEquals(this.TasksField, value) != true)) {
                    this.TasksField = value;
                    this.RaisePropertyChanged("Tasks");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUser", ReplyAction="http://tempuri.org/IService1/GetUserResponse")]
        void GetUser(WpfDailyPlanner.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUser", ReplyAction="http://tempuri.org/IService1/GetUserResponse")]
        System.Threading.Tasks.Task GetUserAsync(WpfDailyPlanner.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTaskToAdd", ReplyAction="http://tempuri.org/IService1/GetTaskToAddResponse")]
        void GetTaskToAdd(WpfDailyPlanner.ServiceReference1.DailyTaskNotes task);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTaskToAdd", ReplyAction="http://tempuri.org/IService1/GetTaskToAddResponse")]
        System.Threading.Tasks.Task GetTaskToAddAsync(WpfDailyPlanner.ServiceReference1.DailyTaskNotes task);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTasks", ReplyAction="http://tempuri.org/IService1/GetTasksResponse")]
        WpfDailyPlanner.ServiceReference1.DailyTaskNotes[] GetTasks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTasks", ReplyAction="http://tempuri.org/IService1/GetTasksResponse")]
        System.Threading.Tasks.Task<WpfDailyPlanner.ServiceReference1.DailyTaskNotes[]> GetTasksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetGroups", ReplyAction="http://tempuri.org/IService1/GetGroupsResponse")]
        WpfDailyPlanner.ServiceReference1.Group[] GetGroups();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetGroups", ReplyAction="http://tempuri.org/IService1/GetGroupsResponse")]
        System.Threading.Tasks.Task<WpfDailyPlanner.ServiceReference1.Group[]> GetGroupsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTasksFromGroup", ReplyAction="http://tempuri.org/IService1/GetTasksFromGroupResponse")]
        WpfDailyPlanner.ServiceReference1.DailyTaskNotes[] GetTasksFromGroup(string groupname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTasksFromGroup", ReplyAction="http://tempuri.org/IService1/GetTasksFromGroupResponse")]
        System.Threading.Tasks.Task<WpfDailyPlanner.ServiceReference1.DailyTaskNotes[]> GetTasksFromGroupAsync(string groupname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetGroupbyName", ReplyAction="http://tempuri.org/IService1/GetGroupbyNameResponse")]
        WpfDailyPlanner.ServiceReference1.Group GetGroupbyName(string groupname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetGroupbyName", ReplyAction="http://tempuri.org/IService1/GetGroupbyNameResponse")]
        System.Threading.Tasks.Task<WpfDailyPlanner.ServiceReference1.Group> GetGroupbyNameAsync(string groupname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetGroupToAdd", ReplyAction="http://tempuri.org/IService1/GetGroupToAddResponse")]
        void GetGroupToAdd(WpfDailyPlanner.ServiceReference1.Group group);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetGroupToAdd", ReplyAction="http://tempuri.org/IService1/GetGroupToAddResponse")]
        System.Threading.Tasks.Task GetGroupToAddAsync(WpfDailyPlanner.ServiceReference1.Group group);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUserbyName", ReplyAction="http://tempuri.org/IService1/GetUserbyNameResponse")]
        WpfDailyPlanner.ServiceReference1.User GetUserbyName(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUserbyName", ReplyAction="http://tempuri.org/IService1/GetUserbyNameResponse")]
        System.Threading.Tasks.Task<WpfDailyPlanner.ServiceReference1.User> GetUserbyNameAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateUser", ReplyAction="http://tempuri.org/IService1/UpdateUserResponse")]
        void UpdateUser(WpfDailyPlanner.ServiceReference1.User user, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateUser", ReplyAction="http://tempuri.org/IService1/UpdateUserResponse")]
        System.Threading.Tasks.Task UpdateUserAsync(WpfDailyPlanner.ServiceReference1.User user, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTasksByDate", ReplyAction="http://tempuri.org/IService1/GetTasksByDateResponse")]
        WpfDailyPlanner.ServiceReference1.DailyTaskNotes[] GetTasksByDate(System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTasksByDate", ReplyAction="http://tempuri.org/IService1/GetTasksByDateResponse")]
        System.Threading.Tasks.Task<WpfDailyPlanner.ServiceReference1.DailyTaskNotes[]> GetTasksByDateAsync(System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteTaskByName", ReplyAction="http://tempuri.org/IService1/DeleteTaskByNameResponse")]
        void DeleteTaskByName(string taskname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteTaskByName", ReplyAction="http://tempuri.org/IService1/DeleteTaskByNameResponse")]
        System.Threading.Tasks.Task DeleteTaskByNameAsync(string taskname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteGroupByName", ReplyAction="http://tempuri.org/IService1/DeleteGroupByNameResponse")]
        void DeleteGroupByName(string groupname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteGroupByName", ReplyAction="http://tempuri.org/IService1/DeleteGroupByNameResponse")]
        System.Threading.Tasks.Task DeleteGroupByNameAsync(string groupname);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WpfDailyPlanner.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WpfDailyPlanner.ServiceReference1.IService1>, WpfDailyPlanner.ServiceReference1.IService1 {
        
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
        
        public void GetUser(WpfDailyPlanner.ServiceReference1.User user) {
            base.Channel.GetUser(user);
        }
        
        public System.Threading.Tasks.Task GetUserAsync(WpfDailyPlanner.ServiceReference1.User user) {
            return base.Channel.GetUserAsync(user);
        }
        
        public void GetTaskToAdd(WpfDailyPlanner.ServiceReference1.DailyTaskNotes task) {
            base.Channel.GetTaskToAdd(task);
        }
        
        public System.Threading.Tasks.Task GetTaskToAddAsync(WpfDailyPlanner.ServiceReference1.DailyTaskNotes task) {
            return base.Channel.GetTaskToAddAsync(task);
        }
        
        public WpfDailyPlanner.ServiceReference1.DailyTaskNotes[] GetTasks() {
            return base.Channel.GetTasks();
        }
        
        public System.Threading.Tasks.Task<WpfDailyPlanner.ServiceReference1.DailyTaskNotes[]> GetTasksAsync() {
            return base.Channel.GetTasksAsync();
        }
        
        public WpfDailyPlanner.ServiceReference1.Group[] GetGroups() {
            return base.Channel.GetGroups();
        }
        
        public System.Threading.Tasks.Task<WpfDailyPlanner.ServiceReference1.Group[]> GetGroupsAsync() {
            return base.Channel.GetGroupsAsync();
        }
        
        public WpfDailyPlanner.ServiceReference1.DailyTaskNotes[] GetTasksFromGroup(string groupname) {
            return base.Channel.GetTasksFromGroup(groupname);
        }
        
        public System.Threading.Tasks.Task<WpfDailyPlanner.ServiceReference1.DailyTaskNotes[]> GetTasksFromGroupAsync(string groupname) {
            return base.Channel.GetTasksFromGroupAsync(groupname);
        }
        
        public WpfDailyPlanner.ServiceReference1.Group GetGroupbyName(string groupname) {
            return base.Channel.GetGroupbyName(groupname);
        }
        
        public System.Threading.Tasks.Task<WpfDailyPlanner.ServiceReference1.Group> GetGroupbyNameAsync(string groupname) {
            return base.Channel.GetGroupbyNameAsync(groupname);
        }
        
        public void GetGroupToAdd(WpfDailyPlanner.ServiceReference1.Group group) {
            base.Channel.GetGroupToAdd(group);
        }
        
        public System.Threading.Tasks.Task GetGroupToAddAsync(WpfDailyPlanner.ServiceReference1.Group group) {
            return base.Channel.GetGroupToAddAsync(group);
        }
        
        public WpfDailyPlanner.ServiceReference1.User GetUserbyName(string login) {
            return base.Channel.GetUserbyName(login);
        }
        
        public System.Threading.Tasks.Task<WpfDailyPlanner.ServiceReference1.User> GetUserbyNameAsync(string login) {
            return base.Channel.GetUserbyNameAsync(login);
        }
        
        public void UpdateUser(WpfDailyPlanner.ServiceReference1.User user, string login) {
            base.Channel.UpdateUser(user, login);
        }
        
        public System.Threading.Tasks.Task UpdateUserAsync(WpfDailyPlanner.ServiceReference1.User user, string login) {
            return base.Channel.UpdateUserAsync(user, login);
        }
        
        public WpfDailyPlanner.ServiceReference1.DailyTaskNotes[] GetTasksByDate(System.DateTime date) {
            return base.Channel.GetTasksByDate(date);
        }
        
        public System.Threading.Tasks.Task<WpfDailyPlanner.ServiceReference1.DailyTaskNotes[]> GetTasksByDateAsync(System.DateTime date) {
            return base.Channel.GetTasksByDateAsync(date);
        }
        
        public void DeleteTaskByName(string taskname) {
            base.Channel.DeleteTaskByName(taskname);
        }
        
        public System.Threading.Tasks.Task DeleteTaskByNameAsync(string taskname) {
            return base.Channel.DeleteTaskByNameAsync(taskname);
        }
        
        public void DeleteGroupByName(string groupname) {
            base.Channel.DeleteGroupByName(groupname);
        }
        
        public System.Threading.Tasks.Task DeleteGroupByNameAsync(string groupname) {
            return base.Channel.DeleteGroupByNameAsync(groupname);
        }
    }
}
