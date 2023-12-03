using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    [ServiceContract]
    public interface IContract
    {
        // Сделать проверку подключения типа try SqlConnect conn.Open();
        // либо добавить operation contract UpdateComputer()

        [FaultContract(typeof(SQLError))]
        [FaultContract(typeof(ValueError))]
        [OperationContract]
        void AddComputer(Computer comp); //ok

        [FaultContract(typeof(SQLError))]
        [FaultContract(typeof(ValueError))]
        [OperationContract]
        void UpdateComputer(Computer comp); //ok

        [FaultContract(typeof(SQLError))]
        [OperationContract]
        BindingList<Computer> GetComputers(); //ok

        [OperationContract]
        void DeleteComputer(Computer comp); // ok

    }

}
