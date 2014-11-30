using Inovix.Data;
using Inovix.Data.Servico;
using System.ComponentModel;
using System.Web.Services;

namespace YUMWebService
{
    /// <summary>
    /// Summary description for YumCustomer
    /// </summary>
    [WebService(Namespace = "http://yum.org/UpdateCustomer")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class YumCustomer : WebService
    {

        [WebMethod]
        public bool UpdateCustomer(Customer customer)
        {

            if (!string.IsNullOrEmpty(customer.Cpf))
            {
                RepositorioCustomer repositorioCustomer = new RepositorioCustomer();
                return repositorioCustomer.Editar(customer);
            }
            return false;
        }
    }
}
