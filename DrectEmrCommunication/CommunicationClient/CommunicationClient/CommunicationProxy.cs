﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.1
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace YidanSoft.Core.Communication
{
    using System.Runtime.Serialization;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "CommunicationUser", Namespace = "http://schemas.datacontract.org/2004/07/YidanSoft.Core.Communication")]
    public partial class CommunicationUser : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string IPField;

        private string ProcessIDField;

        private string UserIDField;

        private string UserNameField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IP
        {
            get
            {
                return this.IPField;
            }
            set
            {
                this.IPField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProcessID
        {
            get
            {
                return this.ProcessIDField;
            }
            set
            {
                this.ProcessIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserID
        {
            get
            {
                return this.UserIDField;
            }
            set
            {
                this.UserIDField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName
        {
            get
            {
                return this.UserNameField;
            }
            set
            {
                this.UserNameField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "YidanSoft.Core.Communication.ICommunicationService", CallbackContract = typeof(YidanSoft.Core.Communication.ICommunicationServiceCallback), SessionMode = System.ServiceModel.SessionMode.Required)]
    public interface ICommunicationService
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICommunicationService/Join", ReplyAction = "http://tempuri.org/ICommunicationService/JoinResponse")]
        void Join(string name);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://tempuri.org/ICommunicationService/Join", ReplyAction = "http://tempuri.org/ICommunicationService/JoinResponse")]
        System.IAsyncResult BeginJoin(string name, System.AsyncCallback callback, object asyncState);

        void EndJoin(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, IsTerminating = true, IsInitiating = false, Action = "http://tempuri.org/ICommunicationService/Leave")]
        void Leave(YidanSoft.Core.Communication.CommunicationUser user);

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, IsTerminating = true, IsInitiating = false, AsyncPattern = true, Action = "http://tempuri.org/ICommunicationService/Leave")]
        System.IAsyncResult BeginLeave(YidanSoft.Core.Communication.CommunicationUser user, System.AsyncCallback callback, object asyncState);

        void EndLeave(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/ICommunicationService/SendMessage")]
        void SendMessage(string message, YidanSoft.Core.Communication.CommunicationUser userFrom, YidanSoft.Core.Communication.CommunicationUser userTo);

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, AsyncPattern = true, Action = "http://tempuri.org/ICommunicationService/SendMessage")]
        System.IAsyncResult BeginSendMessage(string message, YidanSoft.Core.Communication.CommunicationUser userFrom, YidanSoft.Core.Communication.CommunicationUser userTo, System.AsyncCallback callback, object asyncState);

        void EndSendMessage(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICommunicationService/GetAllOnLineUsers", ReplyAction = "http://tempuri.org/ICommunicationService/GetAllOnLineUsersResponse")]
        YidanSoft.Core.Communication.CommunicationUser[] GetAllOnLineUsers();

        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://tempuri.org/ICommunicationService/GetAllOnLineUsers", ReplyAction = "http://tempuri.org/ICommunicationService/GetAllOnLineUsersResponse")]
        System.IAsyncResult BeginGetAllOnLineUsers(System.AsyncCallback callback, object asyncState);

        YidanSoft.Core.Communication.CommunicationUser[] EndGetAllOnLineUsers(System.IAsyncResult result);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICommunicationServiceCallback
    {

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/ICommunicationService/UserLeave")]
        void UserLeave(YidanSoft.Core.Communication.CommunicationUser user);

        //[System.ServiceModel.OperationContractAttribute(IsOneWay = true, AsyncPattern = true, Action = "http://tempuri.org/ICommunicationService/UserLeave")]
        //System.IAsyncResult BeginUserLeave(YidanSoft.Core.Communication.CommunicationUser user, System.AsyncCallback callback, object asyncState);

        //void EndUserLeave(System.IAsyncResult result);

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/ICommunicationService/ShowMessage")]
        void ShowMessage(string message, YidanSoft.Core.Communication.CommunicationUser user);

        //[System.ServiceModel.OperationContractAttribute(IsOneWay = true, AsyncPattern = true, Action = "http://tempuri.org/ICommunicationService/ShowMessage")]
        //System.IAsyncResult BeginShowMessage(string message, YidanSoft.Core.Communication.CommunicationUser user, System.AsyncCallback callback, object asyncState);

        //void EndShowMessage(System.IAsyncResult result);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICommunicationServiceChannel : YidanSoft.Core.Communication.ICommunicationService, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CommunicationServiceClient : System.ServiceModel.DuplexClientBase<YidanSoft.Core.Communication.ICommunicationService>, YidanSoft.Core.Communication.ICommunicationService
    {

        public CommunicationServiceClient(System.ServiceModel.InstanceContext callbackInstance) :
            base(callbackInstance)
        {
        }

        public CommunicationServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) :
            base(callbackInstance, endpointConfigurationName)
        {
        }

        public CommunicationServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) :
            base(callbackInstance, endpointConfigurationName, remoteAddress)
        {
        }

        public CommunicationServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(callbackInstance, endpointConfigurationName, remoteAddress)
        {
        }

        public CommunicationServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(callbackInstance, binding, remoteAddress)
        {
        }

        public void Join(string name)
        {
            base.Channel.Join(name);
        }

        public System.IAsyncResult BeginJoin(string name, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginJoin(name, callback, asyncState);
        }

        public void EndJoin(System.IAsyncResult result)
        {
            base.Channel.EndJoin(result);
        }

        public void Leave(YidanSoft.Core.Communication.CommunicationUser user)
        {
            base.Channel.Leave(user);
        }

        public System.IAsyncResult BeginLeave(YidanSoft.Core.Communication.CommunicationUser user, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginLeave(user, callback, asyncState);
        }

        public void EndLeave(System.IAsyncResult result)
        {
            base.Channel.EndLeave(result);
        }

        public void SendMessage(string message, YidanSoft.Core.Communication.CommunicationUser userFrom, YidanSoft.Core.Communication.CommunicationUser userTo)
        {
            base.Channel.SendMessage(message, userFrom, userTo);
        }

        public System.IAsyncResult BeginSendMessage(string message, YidanSoft.Core.Communication.CommunicationUser userFrom, YidanSoft.Core.Communication.CommunicationUser userTo, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginSendMessage(message, userFrom, userTo, callback, asyncState);
        }

        public void EndSendMessage(System.IAsyncResult result)
        {
            base.Channel.EndSendMessage(result);
        }

        public YidanSoft.Core.Communication.CommunicationUser[] GetAllOnLineUsers()
        {
            return base.Channel.GetAllOnLineUsers();
        }

        public System.IAsyncResult BeginGetAllOnLineUsers(System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginGetAllOnLineUsers(callback, asyncState);
        }

        public YidanSoft.Core.Communication.CommunicationUser[] EndGetAllOnLineUsers(System.IAsyncResult result)
        {
            return base.Channel.EndGetAllOnLineUsers(result);
        }
    }
}