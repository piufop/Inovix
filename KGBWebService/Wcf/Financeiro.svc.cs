using System.Linq;
using Inovix.Data.Fabrica;

namespace KGBWebService.Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Financeiro" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Financeiro.svc or Financeiro.svc.cs at the Solution Explorer and start debugging.
    public class Financeiro : IFinanceiro
    {
        public void DoWork()
        {
        }

        public int ObterStatusFinanceiroCliente(string cpf)
        {
            if (!string.IsNullOrEmpty(cpf))
            {
                var customers = FabricaCustomer.ListaCustomers();

                var customer = customers.FirstOrDefault(u => u.Cpf.Equals(cpf));

                if (customer != null)
                    return (int)customer.StatusFinanceiro;
            }

            return 0;
        }
    }
}
