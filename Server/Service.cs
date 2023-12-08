using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Service : IContract
    {
        private string connSql = @"Data Source = DESKTOP-V4RVBT2;Initial Catalog = 'computers';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        // DESKTOP-V4RVBT2
        // localhost\SQLEXPRESS

        public BindingList<Computer> GetComputers()
        {
            BindingList<Computer> comps = new BindingList<Computer>();
            if (Database.Connect(connSql))
                comps = Database.GetDataPC();
            else 
                comps.Add(new Computer());

            return comps;
        }

        public void AddComputer(Computer comp)
        {
            if (Database.Connect(connSql))
                Database.InsertDataPC(comp);
        }

        public void UpdateComputer(Computer comp)
        {
            if (Database.Connect(connSql))
                Database.UpdateDataPC(comp);
        }

        public void DeleteComputer(Computer comp)
        {
            if (Database.Connect(connSql))
                Database.DeleteDataPC(comp);
        }
    }
}
