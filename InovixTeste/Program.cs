using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InovixTeste.KGBCustomer;

namespace InovixTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerService = new CustomerWebServiceSoapClient();

            var financeiroService = new KGBFinanceiro.FinanceiroClient();
            
            var curtomer = customerService.GetCustomerByCpf("322.391.544-38");

            var finaceiro = financeiroService.ObterStatusFinanceiroCliente("322.391.544-38");
            
        }
    }
}
