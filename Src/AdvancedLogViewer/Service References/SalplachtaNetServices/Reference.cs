﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdvancedLogViewer.SalplachtaNetServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SalplachtaNetServices.MyServicesSoap")]
    public interface MyServicesSoap {
        
        // CODEGEN: Generating message contract since element name cred from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendEmail", ReplyAction="*")]
        AdvancedLogViewer.SalplachtaNetServices.SendEmailResponse SendEmail(AdvancedLogViewer.SalplachtaNetServices.SendEmailRequest request);
        
        // CODEGEN: Generating message contract since element name cred from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendEmail2", ReplyAction="*")]
        AdvancedLogViewer.SalplachtaNetServices.SendEmail2Response SendEmail2(AdvancedLogViewer.SalplachtaNetServices.SendEmail2Request request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendEmailRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendEmail", Namespace="http://tempuri.org/", Order=0)]
        public AdvancedLogViewer.SalplachtaNetServices.SendEmailRequestBody Body;
        
        public SendEmailRequest() {
        }
        
        public SendEmailRequest(AdvancedLogViewer.SalplachtaNetServices.SendEmailRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SendEmailRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string cred;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string toEmail;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string subject;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string body;
        
        public SendEmailRequestBody() {
        }
        
        public SendEmailRequestBody(string cred, string toEmail, string subject, string body) {
            this.cred = cred;
            this.toEmail = toEmail;
            this.subject = subject;
            this.body = body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendEmailResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendEmailResponse", Namespace="http://tempuri.org/", Order=0)]
        public AdvancedLogViewer.SalplachtaNetServices.SendEmailResponseBody Body;
        
        public SendEmailResponse() {
        }
        
        public SendEmailResponse(AdvancedLogViewer.SalplachtaNetServices.SendEmailResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class SendEmailResponseBody {
        
        public SendEmailResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendEmail2Request {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendEmail2", Namespace="http://tempuri.org/", Order=0)]
        public AdvancedLogViewer.SalplachtaNetServices.SendEmail2RequestBody Body;
        
        public SendEmail2Request() {
        }
        
        public SendEmail2Request(AdvancedLogViewer.SalplachtaNetServices.SendEmail2RequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SendEmail2RequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string cred;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string fromEmail;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string toEmail;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string subject;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string body;
        
        public SendEmail2RequestBody() {
        }
        
        public SendEmail2RequestBody(string cred, string fromEmail, string toEmail, string subject, string body) {
            this.cred = cred;
            this.fromEmail = fromEmail;
            this.toEmail = toEmail;
            this.subject = subject;
            this.body = body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendEmail2Response {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendEmail2Response", Namespace="http://tempuri.org/", Order=0)]
        public AdvancedLogViewer.SalplachtaNetServices.SendEmail2ResponseBody Body;
        
        public SendEmail2Response() {
        }
        
        public SendEmail2Response(AdvancedLogViewer.SalplachtaNetServices.SendEmail2ResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class SendEmail2ResponseBody {
        
        public SendEmail2ResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MyServicesSoapChannel : AdvancedLogViewer.SalplachtaNetServices.MyServicesSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyServicesSoapClient : System.ServiceModel.ClientBase<AdvancedLogViewer.SalplachtaNetServices.MyServicesSoap>, AdvancedLogViewer.SalplachtaNetServices.MyServicesSoap {
        
        public MyServicesSoapClient() {
        }
        
        public MyServicesSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyServicesSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServicesSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServicesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AdvancedLogViewer.SalplachtaNetServices.SendEmailResponse AdvancedLogViewer.SalplachtaNetServices.MyServicesSoap.SendEmail(AdvancedLogViewer.SalplachtaNetServices.SendEmailRequest request) {
            return base.Channel.SendEmail(request);
        }
        
        public void SendEmail(string cred, string toEmail, string subject, string body) {
            AdvancedLogViewer.SalplachtaNetServices.SendEmailRequest inValue = new AdvancedLogViewer.SalplachtaNetServices.SendEmailRequest();
            inValue.Body = new AdvancedLogViewer.SalplachtaNetServices.SendEmailRequestBody();
            inValue.Body.cred = cred;
            inValue.Body.toEmail = toEmail;
            inValue.Body.subject = subject;
            inValue.Body.body = body;
            AdvancedLogViewer.SalplachtaNetServices.SendEmailResponse retVal = ((AdvancedLogViewer.SalplachtaNetServices.MyServicesSoap)(this)).SendEmail(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AdvancedLogViewer.SalplachtaNetServices.SendEmail2Response AdvancedLogViewer.SalplachtaNetServices.MyServicesSoap.SendEmail2(AdvancedLogViewer.SalplachtaNetServices.SendEmail2Request request) {
            return base.Channel.SendEmail2(request);
        }
        
        public void SendEmail2(string cred, string fromEmail, string toEmail, string subject, string body) {
            AdvancedLogViewer.SalplachtaNetServices.SendEmail2Request inValue = new AdvancedLogViewer.SalplachtaNetServices.SendEmail2Request();
            inValue.Body = new AdvancedLogViewer.SalplachtaNetServices.SendEmail2RequestBody();
            inValue.Body.cred = cred;
            inValue.Body.fromEmail = fromEmail;
            inValue.Body.toEmail = toEmail;
            inValue.Body.subject = subject;
            inValue.Body.body = body;
            AdvancedLogViewer.SalplachtaNetServices.SendEmail2Response retVal = ((AdvancedLogViewer.SalplachtaNetServices.MyServicesSoap)(this)).SendEmail2(inValue);
        }
    }
}
