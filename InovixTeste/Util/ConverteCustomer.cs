using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inovix.Data;

namespace InovixTeste.Util
{
    public class ConverteCustomer
    {
        public Customer ConverteCustomerData(KGBCustomer.Customer customer)
        {
            return new Customer()
            {
                IdCustomer = customer.IdCustomer,
                Cpf = customer.Cpf,
                LastName = customer.LastName,
                Name = customer.Name,
                StatusFinanceiro = (StatusFinanceiro)customer.StatusFinanceiro,
                Address = new Address()
                {
                    Cep = customer.Address.Cep,
                    City = customer.Address.City,
                    Complement = customer.Address.Complement,
                    IdAddress = customer.IdCustomer,
                    Number = customer.Address.Number,
                    Street = customer.Address.Street
                }

            };
        }
    }
}

