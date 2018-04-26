using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using TestApp.Service;
using TestApp.Contract;

namespace TestApp.BasketHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(BasketService)))
            {
                host.Open();
                Console.WriteLine("Basket host has started");
                Console.ReadLine();
            }
        }
    }
}
