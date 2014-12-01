using System;
using Inovix.APT;
using Inovix.Data.Servico;
using Inovix.KGBAccountCustomer;
using Inovix.KGBCustomer;
using Inovix.KGBFinanceiro;
using Inovix.Util;
using Inovix.Data.Portability;

namespace Inovix
{
    public class Program
    {
        static void Main(string[] args)
        {
            CriarMassaDados();
            var customerService = new CustomerWebServiceSoapClient();
            var financeiroService = new FinanceiroClient();
            var accountCustomerClient = new AccountCustomerClient();            
            var yum = new YumService.YumCustomerSoapClient();

            var customer = Converter.Convert<KGBCustomer.Customer, Data.Customer>(customerService.GetCustomerByCpf("729.671.170-13"));

            if (customer != null)
            {
                var finaceiro = financeiroService.ObterStatusFinanceiroCliente(customer.Cpf);
                var account = accountCustomerClient.ObterDadosConta(customer);
                if (finaceiro == (int)StatusFinanceiro.Apto)
                {
                    APTServiceClient aptClient = new APTServiceClient();
                    PortabilityTicket ticket = aptClient.SolicitarBilhetePortabilidade(customer, account);

                    if (ticket.ErrorCode != PortabilityError.NoError)
                    {
                        aptClient.ObterRespostaAnatel(ticket.Id);
                    }

                    Console.WriteLine("Ticket:\r\n" + ticket.ToString());

                    if (ticket.Status == PortabilityStatus.Success)
                    {
                        yum.UpdateCustomer(Converter.Convert<Data.Customer, YumService.Customer>(customer));
                    }
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

            Console.ReadKey();
        }

        private static void CriarMassaDados()
        {
            RepositorioCustomer repositorioCustomer = new RepositorioCustomer();
            RepositorioAccont repositorioAccont = new RepositorioAccont();

            repositorioCustomer.InicializaRepositorioCustomer();

            repositorioAccont.InicializarRepositorioAccont();
        }
    }
}
