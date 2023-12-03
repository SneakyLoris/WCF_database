using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSQLConnection
{
    internal class Program
    {
        private static string connSql = @"Data Source = DESKTOP-V4RVBT2;Initial Catalog = 'computers';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        // DESKTOP-V4RVBT2
        // localhost\SQLEXPRESS
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(connSql);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM Computer;";

            Console.WriteLine('\u0027');
            Console.ReadKey();
        }
    }
}
