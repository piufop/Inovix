using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Inovix.Data;
using Inovix.Data.Fabrica;
using Inovix.Data.Servico;

namespace YUMWebService
{
    /// <summary>
    /// Summary description for YumCustomer
    /// </summary>
    [WebService(Namespace = "http://yum.org/UpdateCustomer")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class YumCustomer : System.Web.Services.WebService
    {

        [WebMethod]
        public bool UpdateCustomer(Customer customer)
        {

            if (!string.IsNullOrEmpty(customer.Cpf))
            {
                var customerService = new KGBCustomer.CustomerWebServiceSoapClient();
                var customers = customerService.GetCustomerByCpf(customer.Cpf);
                RepositorioCustomer repositorioCustomer = new RepositorioCustomer();
                return repositorioCustomer.Editar(customer);
            }
            return false;
        }
    }
}
