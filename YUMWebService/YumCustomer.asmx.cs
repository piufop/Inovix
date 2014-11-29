using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Inovix.Data;
using Inovix.Data.Fabrica;

namespace YUMWebService
{
    /// <summary>
    /// Summary description for YumCustomer
    /// </summary>
    [WebService(Namespace = "http://yum.org/UpdateCustomer")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class YumCustomer : System.Web.Services.WebService
    {

        [WebMethod]
        public bool UpdateCustomer(Customer customer)
        {

            if (!string.IsNullOrEmpty(customer.Cpf))
            {
                var customerService = new KGBCustomer.CustomerWebServiceSoapClient();
                var customers = customerService.GetCustomerByCpf(customer.Cpf);//TODO Criar para armazenar dados na base

            }
            return false;//TODO Trocar o retorno

        }
    }
}
