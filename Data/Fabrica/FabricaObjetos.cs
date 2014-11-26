using System.Collections.Generic;

namespace Inovix.Data.Fabrica
{
    /// <summary>
    /// Esta class simula o banco de dados
    /// </summary>
    public static class FabricaObjetos
    {
        public static IEnumerable<Customer> ListaCustomers()
        {
            return new List<Customer>
            {
                new Customer
                {
                    Name = "Hugo",
                    LastName = "Machado",
                    CPF = "322.391.544-38",
                    Address = new Address
                    {
                        City = "Belo Horizonte",
                        Street = "Guaicurus",
                        Number = 10,
                        CEP = 12345678
                    },
                    StatusFinanceiro = StatusFinanceiro.InadimplenteOutraOperadora
                },
                new Customer
                {
                    Name = "Felipe",
                    LastName = "Bleson",
                    CPF = "315.290.158-55",
                    Address = new Address
                    {
                        City = "Belo Horizonte",
                        Street = "Centro",
                        Number = 10,
                        CEP = 12345678
                    },
                    StatusFinanceiro = StatusFinanceiro.InadimplenteExterno
                },
                new Customer
                {
                    Name = "João",
                    LastName = "Thiago",
                    CPF = "711.465.728-59",
                    Address = new Address
                    {
                        City = "Belo Horizonte",
                        Street = "Horto",
                        Number = 15,
                        CEP = 12345676
                    },
                    StatusFinanceiro = StatusFinanceiro.InadimplenteInterno
                },
                new Customer
                {
                    Name = "Roberto",
                    LastName = "Thiago",
                    CPF = "729.671.170-13",
                    Address = new Address
                    {
                        City = "Belo Horizonte",
                        Street = "Centro",
                        Number = 15,
                        CEP = 12345678
                    },
                    StatusFinanceiro = StatusFinanceiro.Apto
                }
            };
        }
    }
}
