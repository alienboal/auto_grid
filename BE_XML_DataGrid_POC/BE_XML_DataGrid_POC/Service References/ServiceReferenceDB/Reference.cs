﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 5.0.61118.0
// 
namespace BE_XML_DataGrid_POC.ServiceReferenceDB {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SQLResult", Namespace="BE_XML_DataGrid")]
    public partial class SQLResult : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Collections.Generic.Dictionary<string, System.Type> TableColumnsField;
        
        private string XmlQuerryResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, System.Type> TableColumns {
            get {
                return this.TableColumnsField;
            }
            set {
                if ((object.ReferenceEquals(this.TableColumnsField, value) != true)) {
                    this.TableColumnsField = value;
                    this.RaisePropertyChanged("TableColumns");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string XmlQuerryResult {
            get {
                return this.XmlQuerryResultField;
            }
            set {
                if ((object.ReferenceEquals(this.XmlQuerryResultField, value) != true)) {
                    this.XmlQuerryResultField = value;
                    this.RaisePropertyChanged("XmlQuerryResult");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceDB.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService/Test", ReplyAction="http://tempuri.org/IService/TestResponse")]
        System.IAsyncResult BeginTest(System.AsyncCallback callback, object asyncState);
        
        string EndTest(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService/GetTableFromDB", ReplyAction="http://tempuri.org/IService/GetTableFromDBResponse")]
        System.IAsyncResult BeginGetTableFromDB(string p_sqlQuerry, System.AsyncCallback callback, object asyncState);
        
        BE_XML_DataGrid_POC.ServiceReferenceDB.SQLResult EndGetTableFromDB(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : BE_XML_DataGrid_POC.ServiceReferenceDB.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TestCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public TestCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetTableFromDBCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetTableFromDBCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public BE_XML_DataGrid_POC.ServiceReferenceDB.SQLResult Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((BE_XML_DataGrid_POC.ServiceReferenceDB.SQLResult)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<BE_XML_DataGrid_POC.ServiceReferenceDB.IService>, BE_XML_DataGrid_POC.ServiceReferenceDB.IService {
        
        private BeginOperationDelegate onBeginTestDelegate;
        
        private EndOperationDelegate onEndTestDelegate;
        
        private System.Threading.SendOrPostCallback onTestCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetTableFromDBDelegate;
        
        private EndOperationDelegate onEndGetTableFromDBDelegate;
        
        private System.Threading.SendOrPostCallback onGetTableFromDBCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<TestCompletedEventArgs> TestCompleted;
        
        public event System.EventHandler<GetTableFromDBCompletedEventArgs> GetTableFromDBCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult BE_XML_DataGrid_POC.ServiceReferenceDB.IService.BeginTest(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginTest(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string BE_XML_DataGrid_POC.ServiceReferenceDB.IService.EndTest(System.IAsyncResult result) {
            return base.Channel.EndTest(result);
        }
        
        private System.IAsyncResult OnBeginTest(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((BE_XML_DataGrid_POC.ServiceReferenceDB.IService)(this)).BeginTest(callback, asyncState);
        }
        
        private object[] OnEndTest(System.IAsyncResult result) {
            string retVal = ((BE_XML_DataGrid_POC.ServiceReferenceDB.IService)(this)).EndTest(result);
            return new object[] {
                    retVal};
        }
        
        private void OnTestCompleted(object state) {
            if ((this.TestCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.TestCompleted(this, new TestCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void TestAsync() {
            this.TestAsync(null);
        }
        
        public void TestAsync(object userState) {
            if ((this.onBeginTestDelegate == null)) {
                this.onBeginTestDelegate = new BeginOperationDelegate(this.OnBeginTest);
            }
            if ((this.onEndTestDelegate == null)) {
                this.onEndTestDelegate = new EndOperationDelegate(this.OnEndTest);
            }
            if ((this.onTestCompletedDelegate == null)) {
                this.onTestCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnTestCompleted);
            }
            base.InvokeAsync(this.onBeginTestDelegate, null, this.onEndTestDelegate, this.onTestCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult BE_XML_DataGrid_POC.ServiceReferenceDB.IService.BeginGetTableFromDB(string p_sqlQuerry, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetTableFromDB(p_sqlQuerry, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BE_XML_DataGrid_POC.ServiceReferenceDB.SQLResult BE_XML_DataGrid_POC.ServiceReferenceDB.IService.EndGetTableFromDB(System.IAsyncResult result) {
            return base.Channel.EndGetTableFromDB(result);
        }
        
        private System.IAsyncResult OnBeginGetTableFromDB(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string p_sqlQuerry = ((string)(inValues[0]));
            return ((BE_XML_DataGrid_POC.ServiceReferenceDB.IService)(this)).BeginGetTableFromDB(p_sqlQuerry, callback, asyncState);
        }
        
        private object[] OnEndGetTableFromDB(System.IAsyncResult result) {
            BE_XML_DataGrid_POC.ServiceReferenceDB.SQLResult retVal = ((BE_XML_DataGrid_POC.ServiceReferenceDB.IService)(this)).EndGetTableFromDB(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetTableFromDBCompleted(object state) {
            if ((this.GetTableFromDBCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetTableFromDBCompleted(this, new GetTableFromDBCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetTableFromDBAsync(string p_sqlQuerry) {
            this.GetTableFromDBAsync(p_sqlQuerry, null);
        }
        
        public void GetTableFromDBAsync(string p_sqlQuerry, object userState) {
            if ((this.onBeginGetTableFromDBDelegate == null)) {
                this.onBeginGetTableFromDBDelegate = new BeginOperationDelegate(this.OnBeginGetTableFromDB);
            }
            if ((this.onEndGetTableFromDBDelegate == null)) {
                this.onEndGetTableFromDBDelegate = new EndOperationDelegate(this.OnEndGetTableFromDB);
            }
            if ((this.onGetTableFromDBCompletedDelegate == null)) {
                this.onGetTableFromDBCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetTableFromDBCompleted);
            }
            base.InvokeAsync(this.onBeginGetTableFromDBDelegate, new object[] {
                        p_sqlQuerry}, this.onEndGetTableFromDBDelegate, this.onGetTableFromDBCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override BE_XML_DataGrid_POC.ServiceReferenceDB.IService CreateChannel() {
            return new ServiceClientChannel(this);
        }
        
        private class ServiceClientChannel : ChannelBase<BE_XML_DataGrid_POC.ServiceReferenceDB.IService>, BE_XML_DataGrid_POC.ServiceReferenceDB.IService {
            
            public ServiceClientChannel(System.ServiceModel.ClientBase<BE_XML_DataGrid_POC.ServiceReferenceDB.IService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginTest(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("Test", _args, callback, asyncState);
                return _result;
            }
            
            public string EndTest(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("Test", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetTableFromDB(string p_sqlQuerry, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = p_sqlQuerry;
                System.IAsyncResult _result = base.BeginInvoke("GetTableFromDB", _args, callback, asyncState);
                return _result;
            }
            
            public BE_XML_DataGrid_POC.ServiceReferenceDB.SQLResult EndGetTableFromDB(System.IAsyncResult result) {
                object[] _args = new object[0];
                BE_XML_DataGrid_POC.ServiceReferenceDB.SQLResult _result = ((BE_XML_DataGrid_POC.ServiceReferenceDB.SQLResult)(base.EndInvoke("GetTableFromDB", _args, result)));
                return _result;
            }
        }
    }
}
