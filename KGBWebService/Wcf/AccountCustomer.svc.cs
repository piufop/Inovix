using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Inovix.Data;
using Inovix.Data.Fabrica;
using Inovix.Data.Servico;

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
