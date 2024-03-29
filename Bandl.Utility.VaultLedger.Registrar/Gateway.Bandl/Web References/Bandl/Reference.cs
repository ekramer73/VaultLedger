﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 1.1.4322.2032.
// 
namespace Bandl.Utility.VaultLedger.Registrar.Gateway.Bandl.Bandl {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BandlServiceSoap", Namespace="http://www.bandl.com")]
    public class BandlService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        public MethodHeader MethodHeaderValue;
        
        /// <remarks/>
        public BandlService() {
            string urlSetting = System.Configuration.ConfigurationSettings.AppSettings["Bandl.Utility.VaultLedger.Registrar.Gateway.Bandl.Bandl.BandlService"];
            if ((urlSetting != null)) {
                this.Url = string.Concat(urlSetting, "");
            }
            else {
                this.Url = "http://localhost/bandl.service.vaultledger.bandl/VaultLedger.asmx";
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("MethodHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.bandl.com/OnlineHelpParameters", RequestNamespace="http://www.bandl.com", ResponseNamespace="http://www.bandl.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void OnlineHelpParameters(ref string engine, ref string project, ref string window) {
            object[] results = this.Invoke("OnlineHelpParameters", new object[] {
                        engine,
                        project,
                        window});
            engine = ((string)(results[0]));
            project = ((string)(results[1]));
            window = ((string)(results[2]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginOnlineHelpParameters(string engine, string project, string window, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("OnlineHelpParameters", new object[] {
                        engine,
                        project,
                        window}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndOnlineHelpParameters(System.IAsyncResult asyncResult, out string engine, out string project, out string window) {
            object[] results = this.EndInvoke(asyncResult);
            engine = ((string)(results[0]));
            project = ((string)(results[1]));
            window = ((string)(results[2]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("MethodHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.bandl.com/GetMediumTypes", RequestNamespace="http://www.bandl.com", ResponseNamespace="http://www.bandl.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public MediumTypeDetails[] GetMediumTypes() {
            object[] results = this.Invoke("GetMediumTypes", new object[0]);
            return ((MediumTypeDetails[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetMediumTypes(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetMediumTypes", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public MediumTypeDetails[] EndGetMediumTypes(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((MediumTypeDetails[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("MethodHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.bandl.com/PublishException", RequestNamespace="http://www.bandl.com", ResponseNamespace="http://www.bandl.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void PublishException(string source, string message, string stackTrace) {
            this.Invoke("PublishException", new object[] {
                        source,
                        message,
                        stackTrace});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginPublishException(string source, string message, string stackTrace, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("PublishException", new object[] {
                        source,
                        message,
                        stackTrace}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndPublishException(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("MethodHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.bandl.com/NewScriptExists", RequestNamespace="http://www.bandl.com", ResponseNamespace="http://www.bandl.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool NewScriptExists(string clientVersion) {
            object[] results = this.Invoke("NewScriptExists", new object[] {
                        clientVersion});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginNewScriptExists(string clientVersion, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("NewScriptExists", new object[] {
                        clientVersion}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndNewScriptExists(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("MethodHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.bandl.com/DownloadNextScript", RequestNamespace="http://www.bandl.com", ResponseNamespace="http://www.bandl.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public System.Byte[] DownloadNextScript(string clientVersion, out string newVersion) {
            object[] results = this.Invoke("DownloadNextScript", new object[] {
                        clientVersion});
            newVersion = ((string)(results[1]));
            return ((System.Byte[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginDownloadNextScript(string clientVersion, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("DownloadNextScript", new object[] {
                        clientVersion}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Byte[] EndDownloadNextScript(System.IAsyncResult asyncResult, out string newVersion) {
            object[] results = this.EndInvoke(asyncResult);
            newVersion = ((string)(results[1]));
            return ((System.Byte[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("MethodHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.bandl.com/ReceiveSubaccounts", RequestNamespace="http://www.bandl.com", ResponseNamespace="http://www.bandl.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ReceiveSubaccounts(string[] subaccounts) {
            this.Invoke("ReceiveSubaccounts", new object[] {
                        subaccounts});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginReceiveSubaccounts(string[] subaccounts, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ReceiveSubaccounts", new object[] {
                        subaccounts}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndReceiveSubaccounts(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("MethodHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.bandl.com/RetrieveLicenses", RequestNamespace="http://www.bandl.com", ResponseNamespace="http://www.bandl.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ProductLicenseDetails[] RetrieveLicenses(string companyName) {
            object[] results = this.Invoke("RetrieveLicenses", new object[] {
                        companyName});
            return ((ProductLicenseDetails[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginRetrieveLicenses(string companyName, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("RetrieveLicenses", new object[] {
                        companyName}, callback, asyncState);
        }
        
        /// <remarks/>
        public ProductLicenseDetails[] EndRetrieveLicenses(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((ProductLicenseDetails[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("MethodHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.bandl.com/CreateAccount", RequestNamespace="http://www.bandl.com", ResponseNamespace="http://www.bandl.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CreateAccount(string companyName, string contactName, string phoneNo, string email, string accountNo, int accountType) {
            object[] results = this.Invoke("CreateAccount", new object[] {
                        companyName,
                        contactName,
                        phoneNo,
                        email,
                        accountNo,
                        accountType});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginCreateAccount(string companyName, string contactName, string phoneNo, string email, string accountNo, int accountType, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("CreateAccount", new object[] {
                        companyName,
                        contactName,
                        phoneNo,
                        email,
                        accountNo,
                        accountType}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndCreateAccount(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("MethodHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.bandl.com/DeleteSubscription", RequestElementName="DeleteSubscription", RequestNamespace="http://www.bandl.com", ResponseElementName="DeleteSubscriptionResponse", ResponseNamespace="http://www.bandl.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteAccount(string subscription) {
            this.Invoke("DeleteAccount", new object[] {
                        subscription});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginDeleteAccount(string subscription, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("DeleteAccount", new object[] {
                        subscription}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndDeleteAccount(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("MethodHeaderValue")]
        [System.Web.Services.WebMethodAttribute(MessageName="DeleteAccount1")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.bandl.com/DeleteAccount", RequestElementName="DeleteAccount", RequestNamespace="http://www.bandl.com", ResponseElementName="DeleteAccountResponse", ResponseNamespace="http://www.bandl.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteAccount(string accountNo, int accountType) {
            this.Invoke("DeleteAccount1", new object[] {
                        accountNo,
                        accountType});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginDeleteAccount1(string accountNo, int accountType, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("DeleteAccount1", new object[] {
                        accountNo,
                        accountType}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndDeleteAccount1(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("MethodHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.bandl.com/GrantLicense", RequestNamespace="http://www.bandl.com", ResponseNamespace="http://www.bandl.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void GrantLicense(string accountNo, int accountType, int licenseType, int units, System.DateTime expireDate) {
            this.Invoke("GrantLicense", new object[] {
                        accountNo,
                        accountType,
                        licenseType,
                        units,
                        expireDate});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGrantLicense(string accountNo, int accountType, int licenseType, int units, System.DateTime expireDate, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GrantLicense", new object[] {
                        accountNo,
                        accountType,
                        licenseType,
                        units,
                        expireDate}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndGrantLicense(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("MethodHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.bandl.com/AuditListXmitSend", RequestNamespace="http://www.bandl.com", ResponseNamespace="http://www.bandl.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AuditListXmitSend(System.DateTime actionTime, string listName, int numItems, int status, string exception) {
            this.Invoke("AuditListXmitSend", new object[] {
                        actionTime,
                        listName,
                        numItems,
                        status,
                        exception});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginAuditListXmitSend(System.DateTime actionTime, string listName, int numItems, int status, string exception, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("AuditListXmitSend", new object[] {
                        actionTime,
                        listName,
                        numItems,
                        status,
                        exception}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndAuditListXmitSend(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("MethodHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.bandl.com/AuditListXmitReceive", RequestNamespace="http://www.bandl.com", ResponseNamespace="http://www.bandl.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AuditListXmitReceive(string accountNo, int accountType, System.DateTime actionTime, string listName, int numItems, int status, string fileName) {
            this.Invoke("AuditListXmitReceive", new object[] {
                        accountNo,
                        accountType,
                        actionTime,
                        listName,
                        numItems,
                        status,
                        fileName});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginAuditListXmitReceive(string accountNo, int accountType, System.DateTime actionTime, string listName, int numItems, int status, string fileName, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("AuditListXmitReceive", new object[] {
                        accountNo,
                        accountType,
                        actionTime,
                        listName,
                        numItems,
                        status,
                        fileName}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndAuditListXmitReceive(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("MethodHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.bandl.com/GetWebVersionRange", RequestNamespace="http://www.bandl.com", ResponseNamespace="http://www.bandl.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetWebVersionRange(string databaseVersion) {
            object[] results = this.Invoke("GetWebVersionRange", new object[] {
                        databaseVersion});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetWebVersionRange(string databaseVersion, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetWebVersionRange", new object[] {
                        databaseVersion}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetWebVersionRange(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.bandl.com")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.bandl.com", IsNullable=false)]
    public class MethodHeader : System.Web.Services.Protocols.SoapHeader {
        
        /// <remarks/>
        public string AccountNo;
        
        /// <remarks/>
        public string Password;
        
        /// <remarks/>
        public int AccountType;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.bandl.com")]
    public class ProductLicenseDetails {
        
        /// <remarks/>
        public int Units;
        
        /// <remarks/>
        public int LicenseType;
        
        /// <remarks/>
        public System.DateTime IssueDate;
        
        /// <remarks/>
        public System.DateTime ExpireDate;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.bandl.com")]
    public class MediumTypeDetails {
        
        /// <remarks/>
        public string TypeName;
        
        /// <remarks/>
        public bool TwoSided;
        
        /// <remarks/>
        public bool Container;
    }
}
