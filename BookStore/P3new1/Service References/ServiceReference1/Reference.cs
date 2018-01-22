﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace P3new1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/P3new1")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string authorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float priceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int stockField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int yearField;
        
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
        public string ID {
            get {
                return this.IDField;
            }
            set {
                if ((object.ReferenceEquals(this.IDField, value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string author {
            get {
                return this.authorField;
            }
            set {
                if ((object.ReferenceEquals(this.authorField, value) != true)) {
                    this.authorField = value;
                    this.RaisePropertyChanged("author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float price {
            get {
                return this.priceField;
            }
            set {
                if ((this.priceField.Equals(value) != true)) {
                    this.priceField = value;
                    this.RaisePropertyChanged("price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int stock {
            get {
                return this.stockField;
            }
            set {
                if ((this.stockField.Equals(value) != true)) {
                    this.stockField = value;
                    this.RaisePropertyChanged("stock");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int year {
            get {
                return this.yearField;
            }
            set {
                if ((this.yearField.Equals(value) != true)) {
                    this.yearField = value;
                    this.RaisePropertyChanged("year");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IP3newWCF")]
    public interface IP3newWCF {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IP3newWCF/DoWork", ReplyAction="http://tempuri.org/IP3newWCF/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IP3newWCF/DoWork", ReplyAction="http://tempuri.org/IP3newWCF/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IP3newWCF/GetAllBooks", ReplyAction="http://tempuri.org/IP3newWCF/GetAllBooksResponse")]
        System.Collections.Generic.List<P3new1.ServiceReference1.Book> GetAllBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IP3newWCF/GetAllBooks", ReplyAction="http://tempuri.org/IP3newWCF/GetAllBooksResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<P3new1.ServiceReference1.Book>> GetAllBooksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IP3newWCF/AddBook", ReplyAction="http://tempuri.org/IP3newWCF/AddBookResponse")]
        bool AddBook(string ID, string name, string author, int year, float price, int stock);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IP3newWCF/AddBook", ReplyAction="http://tempuri.org/IP3newWCF/AddBookResponse")]
        System.Threading.Tasks.Task<bool> AddBookAsync(string ID, string name, string author, int year, float price, int stock);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IP3newWCF/DeleteBook", ReplyAction="http://tempuri.org/IP3newWCF/DeleteBookResponse")]
        bool DeleteBook(string dropkey, string textkey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IP3newWCF/DeleteBook", ReplyAction="http://tempuri.org/IP3newWCF/DeleteBookResponse")]
        System.Threading.Tasks.Task<bool> DeleteBookAsync(string dropkey, string textkey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IP3newWCF/SearchBook", ReplyAction="http://tempuri.org/IP3newWCF/SearchBookResponse")]
        System.Collections.Generic.List<P3new1.ServiceReference1.Book> SearchBook(string dropkey, string textkey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IP3newWCF/SearchBook", ReplyAction="http://tempuri.org/IP3newWCF/SearchBookResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<P3new1.ServiceReference1.Book>> SearchBookAsync(string dropkey, string textkey);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IP3newWCFChannel : P3new1.ServiceReference1.IP3newWCF, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class P3newWCFClient : System.ServiceModel.ClientBase<P3new1.ServiceReference1.IP3newWCF>, P3new1.ServiceReference1.IP3newWCF {
        
        public P3newWCFClient() {
        }
        
        public P3newWCFClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public P3newWCFClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public P3newWCFClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public P3newWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public System.Collections.Generic.List<P3new1.ServiceReference1.Book> GetAllBooks() {
            return base.Channel.GetAllBooks();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<P3new1.ServiceReference1.Book>> GetAllBooksAsync() {
            return base.Channel.GetAllBooksAsync();
        }
        
        public bool AddBook(string ID, string name, string author, int year, float price, int stock) {
            return base.Channel.AddBook(ID, name, author, year, price, stock);
        }
        
        public System.Threading.Tasks.Task<bool> AddBookAsync(string ID, string name, string author, int year, float price, int stock) {
            return base.Channel.AddBookAsync(ID, name, author, year, price, stock);
        }
        
        public bool DeleteBook(string dropkey, string textkey) {
            return base.Channel.DeleteBook(dropkey, textkey);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteBookAsync(string dropkey, string textkey) {
            return base.Channel.DeleteBookAsync(dropkey, textkey);
        }
        
        public System.Collections.Generic.List<P3new1.ServiceReference1.Book> SearchBook(string dropkey, string textkey) {
            return base.Channel.SearchBook(dropkey, textkey);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<P3new1.ServiceReference1.Book>> SearchBookAsync(string dropkey, string textkey) {
            return base.Channel.SearchBookAsync(dropkey, textkey);
        }
    }
}
