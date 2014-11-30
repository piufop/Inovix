using Inovix.Data;
using Inovix.Data.Servico;
using System.ComponentModel;
using System.Linq;
using System.Web.Services;

namespace KGBWebService.Asmx
{
    /// <summary>
    /// Summary description for Customer
    /// </summary>
    [WebService(Namespace = "http://kgb.org/GetCustomer")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class CustomerWebService : WebService
    {
        [WebMethod]
        public Customer GetCustomerByCpf(string cpf)
        {
            Customer customer = new Customer();

            RepositorioCustomer repositorioCustomer = new RepositorioCustomer();

            if (!string.IsNullOrEmpty(cpf))
            {
                var customers = repositorioCustomer.RetornaUsuarios();
                customer = customers.FirstOrDefault(u => u.Cpf.Equals(cpf));    
            }
            return customer;
        }   
    }
}
