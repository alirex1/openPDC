﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3603
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 3.0.40624.0
// 
namespace openPDCManager.Silverlight.LivePhasorDataServiceProxy {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DuplexMessage", Namespace="http://samples.microsoft.com/silverlight2/duplex")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(openPDCManager.Silverlight.LivePhasorDataServiceProxy.ConnectMessage))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(openPDCManager.Silverlight.LivePhasorDataServiceProxy.DisconnectMessage))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(openPDCManager.Silverlight.LivePhasorDataServiceProxy.ServiceUpdateMessage))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(openPDCManager.Silverlight.LivePhasorDataServiceProxy.TimeTaggedDataMessage))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(openPDCManager.Silverlight.LivePhasorDataServiceProxy.LivePhasorDataMessage))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(openPDCManager.Silverlight.LivePhasorDataServiceProxy.TimeSeriesDataMessage))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(openPDCManager.Silverlight.LivePhasorDataServiceProxy.ServiceRequestMessage))]
    public partial class DuplexMessage : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ConnectMessage", Namespace="http://samples.microsoft.com/silverlight2/duplex")]
    public partial class ConnectMessage : openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexMessage {
        
        private openPDCManager.Silverlight.LivePhasorDataServiceProxy.DisplayType CurrentDisplayTypeField;
        
        private int DataPointIDField;
        
        private string NodeIDField;
        
        private string TimeSeriesDataRootUrlField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public openPDCManager.Silverlight.LivePhasorDataServiceProxy.DisplayType CurrentDisplayType {
            get {
                return this.CurrentDisplayTypeField;
            }
            set {
                if ((this.CurrentDisplayTypeField.Equals(value) != true)) {
                    this.CurrentDisplayTypeField = value;
                    this.RaisePropertyChanged("CurrentDisplayType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DataPointID {
            get {
                return this.DataPointIDField;
            }
            set {
                if ((this.DataPointIDField.Equals(value) != true)) {
                    this.DataPointIDField = value;
                    this.RaisePropertyChanged("DataPointID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NodeID {
            get {
                return this.NodeIDField;
            }
            set {
                if ((object.ReferenceEquals(this.NodeIDField, value) != true)) {
                    this.NodeIDField = value;
                    this.RaisePropertyChanged("NodeID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TimeSeriesDataRootUrl {
            get {
                return this.TimeSeriesDataRootUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.TimeSeriesDataRootUrlField, value) != true)) {
                    this.TimeSeriesDataRootUrlField = value;
                    this.RaisePropertyChanged("TimeSeriesDataRootUrl");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DisconnectMessage", Namespace="http://samples.microsoft.com/silverlight2/duplex")]
    public partial class DisconnectMessage : openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexMessage {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceUpdateMessage", Namespace="http://schemas.datacontract.org/2004/07/openPDCManager.Services.DuplexService")]
    public partial class ServiceUpdateMessage : openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexMessage {
        
        private string ServiceUpdateField;
        
        private openPDCManager.Silverlight.LivePhasorDataServiceProxy.UpdateType ServiceUpdateTypeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServiceUpdate {
            get {
                return this.ServiceUpdateField;
            }
            set {
                if ((object.ReferenceEquals(this.ServiceUpdateField, value) != true)) {
                    this.ServiceUpdateField = value;
                    this.RaisePropertyChanged("ServiceUpdate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public openPDCManager.Silverlight.LivePhasorDataServiceProxy.UpdateType ServiceUpdateType {
            get {
                return this.ServiceUpdateTypeField;
            }
            set {
                if ((this.ServiceUpdateTypeField.Equals(value) != true)) {
                    this.ServiceUpdateTypeField = value;
                    this.RaisePropertyChanged("ServiceUpdateType");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimeTaggedDataMessage", Namespace="http://schemas.datacontract.org/2004/07/openPDCManager.Services.DuplexService")]
    public partial class TimeTaggedDataMessage : openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexMessage {
        
        private System.Collections.Generic.Dictionary<int, openPDCManager.Silverlight.LivePhasorDataServiceProxy.TimeTaggedMeasurement> TimeTaggedMeasurementsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<int, openPDCManager.Silverlight.LivePhasorDataServiceProxy.TimeTaggedMeasurement> TimeTaggedMeasurements {
            get {
                return this.TimeTaggedMeasurementsField;
            }
            set {
                if ((object.ReferenceEquals(this.TimeTaggedMeasurementsField, value) != true)) {
                    this.TimeTaggedMeasurementsField = value;
                    this.RaisePropertyChanged("TimeTaggedMeasurements");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LivePhasorDataMessage", Namespace="http://schemas.datacontract.org/2004/07/openPDCManager.Services.DuplexService")]
    public partial class LivePhasorDataMessage : openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexMessage {
        
        private System.Collections.Generic.Dictionary<string, int> DeviceDistributionListField;
        
        private System.Collections.ObjectModel.ObservableCollection<openPDCManager.Silverlight.LivePhasorDataServiceProxy.InterconnectionStatus> InterconnectionStatusListField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, int> DeviceDistributionList {
            get {
                return this.DeviceDistributionListField;
            }
            set {
                if ((object.ReferenceEquals(this.DeviceDistributionListField, value) != true)) {
                    this.DeviceDistributionListField = value;
                    this.RaisePropertyChanged("DeviceDistributionList");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.ObjectModel.ObservableCollection<openPDCManager.Silverlight.LivePhasorDataServiceProxy.InterconnectionStatus> InterconnectionStatusList {
            get {
                return this.InterconnectionStatusListField;
            }
            set {
                if ((object.ReferenceEquals(this.InterconnectionStatusListField, value) != true)) {
                    this.InterconnectionStatusListField = value;
                    this.RaisePropertyChanged("InterconnectionStatusList");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimeSeriesDataMessage", Namespace="http://schemas.datacontract.org/2004/07/openPDCManager.Services.DuplexService")]
    public partial class TimeSeriesDataMessage : openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexMessage {
        
        private System.Collections.ObjectModel.ObservableCollection<openPDCManager.Silverlight.LivePhasorDataServiceProxy.TimeSeriesDataPoint> TimeSeriesDataField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.ObjectModel.ObservableCollection<openPDCManager.Silverlight.LivePhasorDataServiceProxy.TimeSeriesDataPoint> TimeSeriesData {
            get {
                return this.TimeSeriesDataField;
            }
            set {
                if ((object.ReferenceEquals(this.TimeSeriesDataField, value) != true)) {
                    this.TimeSeriesDataField = value;
                    this.RaisePropertyChanged("TimeSeriesData");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceRequestMessage", Namespace="http://schemas.datacontract.org/2004/07/openPDCManager.Services.DuplexService")]
    public partial class ServiceRequestMessage : openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexMessage {
        
        private string RequestField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Request {
            get {
                return this.RequestField;
            }
            set {
                if ((object.ReferenceEquals(this.RequestField, value) != true)) {
                    this.RequestField = value;
                    this.RaisePropertyChanged("Request");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DisplayType", Namespace="http://schemas.datacontract.org/2004/07/openPDCManager.Services.DuplexService")]
    public enum DisplayType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Home = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ServiceClient = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DeviceMeasurements = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UpdateType", Namespace="http://schemas.datacontract.org/2004/07/TVA.Services")]
    public enum UpdateType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Information = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Warning = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Alarm = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimeTaggedMeasurement", Namespace="http://schemas.datacontract.org/2004/07/openPDCManager.Web.Data.BusinessObjects")]
    public partial class TimeTaggedMeasurement : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string CurrentValueField;
        
        private string QualityField;
        
        private string TimeTagField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CurrentValue {
            get {
                return this.CurrentValueField;
            }
            set {
                if ((object.ReferenceEquals(this.CurrentValueField, value) != true)) {
                    this.CurrentValueField = value;
                    this.RaisePropertyChanged("CurrentValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Quality {
            get {
                return this.QualityField;
            }
            set {
                if ((object.ReferenceEquals(this.QualityField, value) != true)) {
                    this.QualityField = value;
                    this.RaisePropertyChanged("Quality");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TimeTag {
            get {
                return this.TimeTagField;
            }
            set {
                if ((object.ReferenceEquals(this.TimeTagField, value) != true)) {
                    this.TimeTagField = value;
                    this.RaisePropertyChanged("TimeTag");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InterconnectionStatus", Namespace="http://schemas.datacontract.org/2004/07/openPDCManager.Web.Data.BusinessObjects")]
    public partial class InterconnectionStatus : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string InterConnectionField;
        
        private System.Collections.ObjectModel.ObservableCollection<openPDCManager.Silverlight.LivePhasorDataServiceProxy.MemberStatus> MemberStatusListField;
        
        private string TotalDevicesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InterConnection {
            get {
                return this.InterConnectionField;
            }
            set {
                if ((object.ReferenceEquals(this.InterConnectionField, value) != true)) {
                    this.InterConnectionField = value;
                    this.RaisePropertyChanged("InterConnection");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.ObjectModel.ObservableCollection<openPDCManager.Silverlight.LivePhasorDataServiceProxy.MemberStatus> MemberStatusList {
            get {
                return this.MemberStatusListField;
            }
            set {
                if ((object.ReferenceEquals(this.MemberStatusListField, value) != true)) {
                    this.MemberStatusListField = value;
                    this.RaisePropertyChanged("MemberStatusList");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TotalDevices {
            get {
                return this.TotalDevicesField;
            }
            set {
                if ((object.ReferenceEquals(this.TotalDevicesField, value) != true)) {
                    this.TotalDevicesField = value;
                    this.RaisePropertyChanged("TotalDevices");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MemberStatus", Namespace="http://schemas.datacontract.org/2004/07/openPDCManager.Web.Data.BusinessObjects")]
    public partial class MemberStatus : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string CompanyAcronymField;
        
        private string CompanyNameField;
        
        private int MeasuredLinesField;
        
        private int TotalDevicesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CompanyAcronym {
            get {
                return this.CompanyAcronymField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyAcronymField, value) != true)) {
                    this.CompanyAcronymField = value;
                    this.RaisePropertyChanged("CompanyAcronym");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CompanyName {
            get {
                return this.CompanyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyNameField, value) != true)) {
                    this.CompanyNameField = value;
                    this.RaisePropertyChanged("CompanyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MeasuredLines {
            get {
                return this.MeasuredLinesField;
            }
            set {
                if ((this.MeasuredLinesField.Equals(value) != true)) {
                    this.MeasuredLinesField = value;
                    this.RaisePropertyChanged("MeasuredLines");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalDevices {
            get {
                return this.TotalDevicesField;
            }
            set {
                if ((this.TotalDevicesField.Equals(value) != true)) {
                    this.TotalDevicesField = value;
                    this.RaisePropertyChanged("TotalDevices");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TimeSeriesDataPoint", Namespace="http://schemas.datacontract.org/2004/07/openPDCManager.Web.Data.BusinessObjects")]
    public partial class TimeSeriesDataPoint : object, System.ComponentModel.INotifyPropertyChanged {
        
        private long IndexField;
        
        private double ValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Index {
            get {
                return this.IndexField;
            }
            set {
                if ((this.IndexField.Equals(value) != true)) {
                    this.IndexField = value;
                    this.RaisePropertyChanged("Index");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Value {
            get {
                return this.ValueField;
            }
            set {
                if ((this.ValueField.Equals(value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LivePhasorDataServiceProxy.DuplexService", CallbackContract=typeof(openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexServiceCallback))]
    public interface DuplexService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, AsyncPattern=true, Action="http://tempuri.org/DuplexService/SendToService")]
        System.IAsyncResult BeginSendToService(openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexMessage msg, System.AsyncCallback callback, object asyncState);
        
        void EndSendToService(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface DuplexServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/DuplexService/SendToClient")]
        void SendToClient(openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexMessage msg);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface DuplexServiceChannel : openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class DuplexServiceClient : System.ServiceModel.DuplexClientBase<openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexService>, openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexService {
        
        private BeginOperationDelegate onBeginSendToServiceDelegate;
        
        private EndOperationDelegate onEndSendToServiceDelegate;
        
        private System.Threading.SendOrPostCallback onSendToServiceCompletedDelegate;
        
        private bool useGeneratedCallback;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public DuplexServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public DuplexServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                this(new DuplexServiceClientCallback(), binding, remoteAddress) {
        }
        
        private DuplexServiceClient(DuplexServiceClientCallback callbackImpl, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                this(new System.ServiceModel.InstanceContext(callbackImpl), binding, remoteAddress) {
            useGeneratedCallback = true;
            callbackImpl.Initialize(this);
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
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> SendToServiceCompleted;
        
        public event System.EventHandler<SendToClientReceivedEventArgs> SendToClientReceived;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexService.BeginSendToService(openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexMessage msg, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginSendToService(msg, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexService.EndSendToService(System.IAsyncResult result) {
            base.Channel.EndSendToService(result);
        }
        
        private System.IAsyncResult OnBeginSendToService(object[] inValues, System.AsyncCallback callback, object asyncState) {
            openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexMessage msg = ((openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexMessage)(inValues[0]));
            return ((openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexService)(this)).BeginSendToService(msg, callback, asyncState);
        }
        
        private object[] OnEndSendToService(System.IAsyncResult result) {
            ((openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexService)(this)).EndSendToService(result);
            return null;
        }
        
        private void OnSendToServiceCompleted(object state) {
            if ((this.SendToServiceCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.SendToServiceCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void SendToServiceAsync(openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexMessage msg) {
            this.SendToServiceAsync(msg, null);
        }
        
        public void SendToServiceAsync(openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexMessage msg, object userState) {
            if ((this.onBeginSendToServiceDelegate == null)) {
                this.onBeginSendToServiceDelegate = new BeginOperationDelegate(this.OnBeginSendToService);
            }
            if ((this.onEndSendToServiceDelegate == null)) {
                this.onEndSendToServiceDelegate = new EndOperationDelegate(this.OnEndSendToService);
            }
            if ((this.onSendToServiceCompletedDelegate == null)) {
                this.onSendToServiceCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnSendToServiceCompleted);
            }
            base.InvokeAsync(this.onBeginSendToServiceDelegate, new object[] {
                        msg}, this.onEndSendToServiceDelegate, this.onSendToServiceCompletedDelegate, userState);
        }
        
        private void OnSendToClientReceived(object state) {
            if ((this.SendToClientReceived != null)) {
                object[] results = ((object[])(state));
                this.SendToClientReceived(this, new SendToClientReceivedEventArgs(results, null, false, null));
            }
        }
        
        private void VerifyCallbackEvents() {
            if (((this.useGeneratedCallback != true) 
                        && (this.SendToClientReceived != null))) {
                throw new System.InvalidOperationException("Callback events cannot be used when the callback InstanceContext is specified. Pl" +
                        "ease choose between specifying the callback InstanceContext or subscribing to th" +
                        "e callback events.");
            }
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            this.VerifyCallbackEvents();
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
        
        protected override openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexService CreateChannel() {
            return new DuplexServiceClientChannel(this);
        }
        
        private class DuplexServiceClientCallback : object, DuplexServiceCallback {
            
            private DuplexServiceClient proxy;
            
            public void Initialize(DuplexServiceClient proxy) {
                this.proxy = proxy;
            }
            
            public void SendToClient(openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexMessage msg) {
                this.proxy.OnSendToClientReceived(new object[] {
                            msg});
            }
        }
        
        private class DuplexServiceClientChannel : ChannelBase<openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexService>, openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexService {
            
            public DuplexServiceClientChannel(System.ServiceModel.DuplexClientBase<openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginSendToService(openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexMessage msg, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = msg;
                System.IAsyncResult _result = base.BeginInvoke("SendToService", _args, callback, asyncState);
                return _result;
            }
            
            public void EndSendToService(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("SendToService", _args, result);
            }
        }
    }
    
    public class SendToClientReceivedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public SendToClientReceivedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexMessage msg {
            get {
                base.RaiseExceptionIfNecessary();
                return ((openPDCManager.Silverlight.LivePhasorDataServiceProxy.DuplexMessage)(this.results[0]));
            }
        }
    }
}
