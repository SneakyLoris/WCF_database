using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Program
    {
        private static ServiceHost host;
        static void Main(string[] args)
        {
            host = new ServiceHost(typeof(Server.Service));
            host.Open();
            Console.WriteLine("Сервис запущен");
            Console.ReadKey();
        }
    }
}
