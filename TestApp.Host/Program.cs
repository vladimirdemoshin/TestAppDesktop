using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using TestApp.Service;

namespace TestApp.Host
{
    class Program
    {
        static void Main()
        {
            using (var host = new ServiceHost(typeof(DataAccessService)))
            {
                host.Open();
                Console.WriteLine("Host has started");
                Console.ReadLine();
            }
        }
    }
}
