using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Inovix.Data;
using Inovix.Data.Fabrica;

namespace KGBWebService.Wcf
{    
    public class AccountCustomer : IAccountCustomer
    {
        public void DoWork()
        {
        }

        public Account ObterDadosConta(Customer customer)
        {
            Account account = null;
            if (customer!=null)
            {
                account = FabricaAccount.ListaAccounts().FirstOrDefault(c => c.Customer.Equals(customer));
            }
            return account;
        }
    }
}
