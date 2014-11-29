using System.ComponentModel;
using System.Linq;
using System.Web.Services;
using Inovix.Data;
using Inovix.Data.Fabrica;

namespace KGBWebService.Asmx
{
    /// <summary>
    /// Summary description for Customer
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class CustomerWebService : WebService
    {

        [WebMethod]
        public Customer GetCustomerByCpf(string cpf)
        {
            Customer customer = new Customer();

            if (!string.IsNullOrEmpty(cpf))
            {
                var customers = FabricaCustomer.ListaCustomers();
                customer = customers.FirstOrDefault(u => u.Cpf.Equals(cpf));    
            }
            return customer;
        }   
    }
}
