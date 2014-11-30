using Inovix.Data;
using Inovix.Data.Servico;
using System.Linq;

namespace KGBWebService.Wcf
{    
    public class AccountCustomer : IAccountCustomer
    {
        public Account ObterDadosConta(Customer customer)
        {
            Account account = null;
            if (customer!=null)
            {
                var repositorioAccont = new RepositorioAccont();
                account = repositorioAccont.RetornaAccounts().FirstOrDefault(c => c.Customer.Cpf == customer.Cpf);
            }
            return account;
        }
    }
}
