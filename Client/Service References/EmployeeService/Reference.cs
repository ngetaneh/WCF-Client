﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.EmployeeService {
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeType", Namespace="http://schemas.datacontract.org/2004/07/EmployeeService")]
    public enum EmployeeType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FullTimeEmployee = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PartTimeEmployee = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeService.IEmployeeService")]
    public interface IEmployeeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployee", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeResponse")]
        Client.EmployeeService.EmployeeInfo GetEmployee(Client.EmployeeService.EmployeeRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployee", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeResponse")]
        System.Threading.Tasks.Task<Client.EmployeeService.EmployeeInfo> GetEmployeeAsync(Client.EmployeeService.EmployeeRequest request);
        
        // CODEGEN: Generating message contract since the operation SaveEmployee is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/SaveEmployee", ReplyAction="http://tempuri.org/IEmployeeService/SaveEmployeeResponse")]
        Client.EmployeeService.SaveEmployeeResponse SaveEmployee(Client.EmployeeService.EmployeeInfo request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/SaveEmployee", ReplyAction="http://tempuri.org/IEmployeeService/SaveEmployeeResponse")]
        System.Threading.Tasks.Task<Client.EmployeeService.SaveEmployeeResponse> SaveEmployeeAsync(Client.EmployeeService.EmployeeInfo request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EmployeeRequestObject", WrapperNamespace="http://MyCompany.Com/Employee", IsWrapped=true)]
    public partial class EmployeeRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://MyCompany.Com/Employee")]
        public string LicenseKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://MyCompany.Com/Employee", Order=0)]
        public int EmployeeId;
        
        public EmployeeRequest() {
        }
        
        public EmployeeRequest(string LicenseKey, int EmployeeId) {
            this.LicenseKey = LicenseKey;
            this.EmployeeId = EmployeeId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EmployeeInfoObject", WrapperNamespace="http://MyCompany.Com/Employee", IsWrapped=true)]
    public partial class EmployeeInfo {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://MyCompany.com/Employee", Order=0)]
        public int ID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://MyCompany.com/Employee", Order=1)]
        public string Name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://MyCompany.com/Employee", Order=2)]
        public string Gender;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://MyCompany.com/Employee", Order=3)]
        public System.DateTime DOB;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://MyCompany.com/Employee", Order=4)]
        public Client.EmployeeService.EmployeeType Type;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://MyCompany.com/Employee", Order=5)]
        public int AnnualSalary;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://MyCompany.com/Employee", Order=6)]
        public int HourlyPay;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://MyCompany.com/Employee", Order=7)]
        public int HoursWorked;
        
        public EmployeeInfo() {
        }
        
        public EmployeeInfo(int ID, string Name, string Gender, System.DateTime DOB, Client.EmployeeService.EmployeeType Type, int AnnualSalary, int HourlyPay, int HoursWorked) {
            this.ID = ID;
            this.Name = Name;
            this.Gender = Gender;
            this.DOB = DOB;
            this.Type = Type;
            this.AnnualSalary = AnnualSalary;
            this.HourlyPay = HourlyPay;
            this.HoursWorked = HoursWorked;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaveEmployeeResponse {
        
        public SaveEmployeeResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeServiceChannel : Client.EmployeeService.IEmployeeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeServiceClient : System.ServiceModel.ClientBase<Client.EmployeeService.IEmployeeService>, Client.EmployeeService.IEmployeeService {
        
        public EmployeeServiceClient() {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.EmployeeService.EmployeeInfo Client.EmployeeService.IEmployeeService.GetEmployee(Client.EmployeeService.EmployeeRequest request) {
            return base.Channel.GetEmployee(request);
        }
        
        public int GetEmployee(string LicenseKey, int EmployeeId, out string Name, out string Gender, out System.DateTime DOB, out Client.EmployeeService.EmployeeType Type, out int AnnualSalary, out int HourlyPay, out int HoursWorked) {
            Client.EmployeeService.EmployeeRequest inValue = new Client.EmployeeService.EmployeeRequest();
            inValue.LicenseKey = LicenseKey;
            inValue.EmployeeId = EmployeeId;
            Client.EmployeeService.EmployeeInfo retVal = ((Client.EmployeeService.IEmployeeService)(this)).GetEmployee(inValue);
            Name = retVal.Name;
            Gender = retVal.Gender;
            DOB = retVal.DOB;
            Type = retVal.Type;
            AnnualSalary = retVal.AnnualSalary;
            HourlyPay = retVal.HourlyPay;
            HoursWorked = retVal.HoursWorked;
            return retVal.ID;
        }
        
        public System.Threading.Tasks.Task<Client.EmployeeService.EmployeeInfo> GetEmployeeAsync(Client.EmployeeService.EmployeeRequest request) {
            return base.Channel.GetEmployeeAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.EmployeeService.SaveEmployeeResponse Client.EmployeeService.IEmployeeService.SaveEmployee(Client.EmployeeService.EmployeeInfo request) {
            return base.Channel.SaveEmployee(request);
        }
        
        public void SaveEmployee(int ID, string Name, string Gender, System.DateTime DOB, Client.EmployeeService.EmployeeType Type, int AnnualSalary, int HourlyPay, int HoursWorked) {
            Client.EmployeeService.EmployeeInfo inValue = new Client.EmployeeService.EmployeeInfo();
            inValue.ID = ID;
            inValue.Name = Name;
            inValue.Gender = Gender;
            inValue.DOB = DOB;
            inValue.Type = Type;
            inValue.AnnualSalary = AnnualSalary;
            inValue.HourlyPay = HourlyPay;
            inValue.HoursWorked = HoursWorked;
            Client.EmployeeService.SaveEmployeeResponse retVal = ((Client.EmployeeService.IEmployeeService)(this)).SaveEmployee(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Client.EmployeeService.SaveEmployeeResponse> Client.EmployeeService.IEmployeeService.SaveEmployeeAsync(Client.EmployeeService.EmployeeInfo request) {
            return base.Channel.SaveEmployeeAsync(request);
        }
        
        public System.Threading.Tasks.Task<Client.EmployeeService.SaveEmployeeResponse> SaveEmployeeAsync(int ID, string Name, string Gender, System.DateTime DOB, Client.EmployeeService.EmployeeType Type, int AnnualSalary, int HourlyPay, int HoursWorked) {
            Client.EmployeeService.EmployeeInfo inValue = new Client.EmployeeService.EmployeeInfo();
            inValue.ID = ID;
            inValue.Name = Name;
            inValue.Gender = Gender;
            inValue.DOB = DOB;
            inValue.Type = Type;
            inValue.AnnualSalary = AnnualSalary;
            inValue.HourlyPay = HourlyPay;
            inValue.HoursWorked = HoursWorked;
            return ((Client.EmployeeService.IEmployeeService)(this)).SaveEmployeeAsync(inValue);
        }
    }
}