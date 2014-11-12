using Inovix.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace KGBWebService
{
    /// <summary>
    /// Summary description for Customer
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class CustomerWebService : WebService
    {
        List<Customer> Customers = new List<Customer>();

        public CustomerWebService()
        {
            PreencheListaCustomers();
        }

        [WebMethod]
        public Customer GetCustomerByCpf(string cpf)
        {
            return Customers.FirstOrDefault(u => u.CPF.Equals(cpf));
        }

        private void PreencheListaCustomers()
        {
             Customers.Add(new Customer()
            {
                Name = "Hugo",
                LastName = "Machado",
                CPF = "322.391.544-38",
                Address = new Address()
                {
                    City = "Belo Horizonte",
                    Street = "Guaicurus",
                    Number = 10,
                    CEP = 12345678
                }
            });

            Customers.Add(new Customer()
            {
                Name = "Felipe",
                LastName = "Bleson",
                CPF = "315.290.158-55",
                Address = new Address()
                {
                    City = "Belo Horizonte",
                    Street = "Centro",
                    Number = 10,
                    CEP = 12345678
                }
            });

            Customers.Add(new Customer()
            {
                Name = "João",
                LastName = "Thiago",
                CPF = "711.465.728-59",
                Address = new Address()
                {
                    City = "Belo Horizonte",
                    Street = "Horto",
                    Number = 15,
                    CEP = 12345678
                }
            });

        }
    }
}
