using Inovix.Data;
using InovixTeste.KGBAccountCustomer;
using InovixTeste.KGBFinanceiro;
using InovixTeste.Util;

namespace InovixTeste
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customerService = new KGBCustomer.CustomerWebServiceSoapClient();
            var financeiroService = new FinanceiroClient();
            var accountCustomerClient = new AccountCustomerClient();
            ConverteCustomer customerData = new ConverteCustomer();

            var customer = customerData.ConverteCustomerData(customerService.GetCustomerByCpf("322.391.544-38"));

            var finaceiro = financeiroService.ObterStatusFinanceiroCliente("322.391.544-38");
           
            var account = accountCustomerClient.ObterDadosConta(customer);

        }
    }
}
