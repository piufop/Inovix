using Inovix.Data.Servico;
using InovixTeste.KGBAccountCustomer;
using InovixTeste.KGBFinanceiro;
using InovixTeste.Util;

namespace InovixTeste
{
    public class Program
    {
        static void Main(string[] args)
        {

            RepositorioCustomer repositorioCustomer = new RepositorioCustomer();
            RepositorioAccont repositorioAccont = new RepositorioAccont();

            repositorioCustomer.InicializaRepositorioCustomer();

            repositorioAccont.InicializarRepositorioAccont();

            var customerService = new KGBCustomer.CustomerWebServiceSoapClient();
            var financeiroService = new FinanceiroClient();
            var accountCustomerClient = new AccountCustomerClient();
            var customerData = new ConverteCustomer();

            var customer = customerData.ConverteCustomerData(customerService.GetCustomerByCpf("322.391.544-38"));

            var finaceiro = financeiroService.ObterStatusFinanceiroCliente("322.391.544-38");
           
            var account = accountCustomerClient.ObterDadosConta(customer);

        }
    }
}
