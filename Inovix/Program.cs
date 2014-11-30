using System;
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
            CriarDados();
            var customerService = new CustomerWebServiceSoapClient();
            var financeiroService = new FinanceiroClient();
            var accountCustomerClient = new AccountCustomerClient();
            var customerData = new ConverteCustomer();

            var customer = customerData.ConverteCustomerData(customerService.GetCustomerByCpf("322.391.544-38"));

            if (customer != null)
            {
                var finaceiro = financeiroService.ObterStatusFinanceiroCliente(customer.Cpf);
                var account = accountCustomerClient.ObterDadosConta(customer);
                if (finaceiro == (int)StatusFinanceiro.Apto)
                {
                    APTServiceClient aptClient = new APTServiceClient();
                    aptClient.SolicitarBilhetePortabilidade(customer, account);
                }
                else
                {
                    Console.WriteLine("Este usuario está Inadimplente");
                }
            }
            else
            {
                Console.WriteLine("Não foi possível encontrar o usuário!");
            }
        }

        private static void CriarDados()
        {
            RepositorioCustomer repositorioCustomer = new RepositorioCustomer();
            RepositorioAccont repositorioAccont = new RepositorioAccont();

            repositorioCustomer.InicializaRepositorioCustomer();

            repositorioAccont.InicializarRepositorioAccont();
        }
    }
}
