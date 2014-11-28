using System;
using System.Collections.Generic;

namespace Inovix.Data.Fabrica
{
    /// <summary>
    /// Esta class simula o banco de dados
    /// </summary>
    public static class FabricaCustomer
    {
        public static IEnumerable<Customer> ListaCustomers()
        {
            return new List<Customer>
            {
                new Customer
                {
                    IdCustomer = 1,
                    Name = "Hugo",
                    LastName = "Machado",
                    Cpf = "322.391.544-38",
                    Address = new Address
                    {
                        City = "Belo Horizonte",
                        Street = "Guaicurus",
                        Number = 10,
                        Cep = 12345678
                    },
                    StatusFinanceiro = StatusFinanceiro.InadimplenteOutraOperadora
                },
                new Customer
                {
                    IdCustomer = 2,
                    Name = "Felipe",
                    LastName = "Bleson",
                    Cpf = "315.290.158-55",
                    Address = new Address
                    {
                        City = "Belo Horizonte",
                        Street = "Centro",
                        Number = 10,
                        Cep = 12345678
                    },
                    StatusFinanceiro = StatusFinanceiro.InadimplenteExterno
                },
                new Customer
                {
                    IdCustomer = 3,
                    Name = "João",
                    LastName = "Thiago",
                    Cpf = "711.465.728-59",
                    Address = new Address
                    {
                        City = "Belo Horizonte",
                        Street = "Horto",
                        Number = 15,
                        Cep = 12345676
                    },
                    StatusFinanceiro = StatusFinanceiro.InadimplenteInterno
                    },
                new Customer
                {
                    IdCustomer = 4,
                    Name = "Roberto",
                    LastName = "Thiago",
                    Cpf = "729.671.170-13",
                    Address = new Address
                    {
                        City = "Belo Horizonte",
                        Street = "Centro",
                        Number = 15,
                        Cep = 12345678
                    },
                    StatusFinanceiro = StatusFinanceiro.Apto,                    
                }
            };
        }
    }
}
