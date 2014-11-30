using Inovix.APT;
using Inovix.Data.Servico;
using Inovix.KGBAccountCustomer;
using Inovix.KGBCustomer;
using Inovix.KGBFinanceiro;
using Inovix.Util;

namespace Inovix
{
    public class Program
    {
        static void Main(string[] args)
        {

            RepositorioCustomer repositorioCustomer = new RepositorioCustomer();
            RepositorioAccont repositorioAccont = new RepositorioAccont();

            repositorioCustomer.InicializaRepositorioCustomer();

            repositorioAccont.InicializarRepositorioAccont();

            var customerService = new CustomerWebServiceSoapClient();
            var financeiroService = new FinanceiroClient();
            var accountCustomerClient = new AccountCustomerClient();
            var customerData = new ConverteCustomer();

            //var customer = customerData.ConverteCustomerData(customerService.GetCustomerByCpf("322.391.544-38"));
            //var customer = customerService.GetCustomerByCpf("322.391.544-38");

            var finaceiro = financeiroService.ObterStatusFinanceiroCliente("322.391.544-38");
           
            //var account = accountCustomerClient.ObterDadosConta(customer);
            

            APTServiceClient aptClient = new APTServiceClient();
            //aptClient.SolicitarBilhetePortabilidade(new Customer(), new Account());

        }
    }
}
