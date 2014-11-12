using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InovixTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer.CustomerWebServiceSoapClient c = new Customer.CustomerWebServiceSoapClient();

            var xx = c.GetCustomerByCpf("322.391.544-38");
        }
    }
}
