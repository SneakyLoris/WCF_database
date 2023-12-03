﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IContract")]
    public interface IContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/AddComputer", ReplyAction="http://tempuri.org/IContract/AddComputerResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Server.SQLError), Action="http://tempuri.org/IContract/AddComputerSQLErrorFault", Name="SQLError", Namespace="http://schemas.datacontract.org/2004/07/Server")]
        [System.ServiceModel.FaultContractAttribute(typeof(Server.ValueError), Action="http://tempuri.org/IContract/AddComputerValueErrorFault", Name="ValueError", Namespace="http://schemas.datacontract.org/2004/07/Server")]
        void AddComputer(Server.Computer comp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/AddComputer", ReplyAction="http://tempuri.org/IContract/AddComputerResponse")]
        System.Threading.Tasks.Task AddComputerAsync(Server.Computer comp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/UpdateComputer", ReplyAction="http://tempuri.org/IContract/UpdateComputerResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Server.SQLError), Action="http://tempuri.org/IContract/UpdateComputerSQLErrorFault", Name="SQLError", Namespace="http://schemas.datacontract.org/2004/07/Server")]
        [System.ServiceModel.FaultContractAttribute(typeof(Server.ValueError), Action="http://tempuri.org/IContract/UpdateComputerValueErrorFault", Name="ValueError", Namespace="http://schemas.datacontract.org/2004/07/Server")]
        void UpdateComputer(Server.Computer comp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/UpdateComputer", ReplyAction="http://tempuri.org/IContract/UpdateComputerResponse")]
        System.Threading.Tasks.Task UpdateComputerAsync(Server.Computer comp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/GetComputers", ReplyAction="http://tempuri.org/IContract/GetComputersResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Server.SQLError), Action="http://tempuri.org/IContract/GetComputersSQLErrorFault", Name="SQLError", Namespace="http://schemas.datacontract.org/2004/07/Server")]
        Server.Computer[] GetComputers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/GetComputers", ReplyAction="http://tempuri.org/IContract/GetComputersResponse")]
        System.Threading.Tasks.Task<Server.Computer[]> GetComputersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/DeleteComputer", ReplyAction="http://tempuri.org/IContract/DeleteComputerResponse")]
        void DeleteComputer(Server.Computer comp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/DeleteComputer", ReplyAction="http://tempuri.org/IContract/DeleteComputerResponse")]
        System.Threading.Tasks.Task DeleteComputerAsync(Server.Computer comp);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IContractChannel : Client.ServiceReference1.IContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ContractClient : System.ServiceModel.ClientBase<Client.ServiceReference1.IContract>, Client.ServiceReference1.IContract {
        
        public ContractClient() {
        }
        
        public ContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddComputer(Server.Computer comp) {
            base.Channel.AddComputer(comp);
        }
        
        public System.Threading.Tasks.Task AddComputerAsync(Server.Computer comp) {
            return base.Channel.AddComputerAsync(comp);
        }
        
        public void UpdateComputer(Server.Computer comp) {
            base.Channel.UpdateComputer(comp);
        }
        
        public System.Threading.Tasks.Task UpdateComputerAsync(Server.Computer comp) {
            return base.Channel.UpdateComputerAsync(comp);
        }
        
        public Server.Computer[] GetComputers() {
            return base.Channel.GetComputers();
        }
        
        public System.Threading.Tasks.Task<Server.Computer[]> GetComputersAsync() {
            return base.Channel.GetComputersAsync();
        }
        
        public void DeleteComputer(Server.Computer comp) {
            base.Channel.DeleteComputer(comp);
        }
        
        public System.Threading.Tasks.Task DeleteComputerAsync(Server.Computer comp) {
            return base.Channel.DeleteComputerAsync(comp);
        }
    }
}
