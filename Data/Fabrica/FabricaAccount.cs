using System;
using System.Collections.Generic;

namespace Inovix.Data.Fabrica
{
    public class FabricaAccount
    {
        public static List<Account> ListaAccounts()
        {
            return new List<Account>
            {
                new Account
                {
                    IdAccount = 1,
                    Data = DateTime.Now,                    
                    Valor = 100,
                    NumeroCelular = "(31)9999-9999",
                    Customer = new Customer
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
                },
                new Account
                {
                    IdAccount = 2,
                    Data = DateTime.Now,
                    NumeroCelular = "(31)8888-8888",
                    Valor = 100,
                    Customer =  new Customer
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
                    }

                },
                new Account
                {
                    IdAccount = 3,
                    Data = DateTime.Now,
                    NumeroCelular = "(31)7777-7777",
                    Valor = 100,
                    Customer = new Customer
                    {
                        IdCustomer = 3,
                        Name = "João",
                        LastName = "Thiago",
                        Cpf = "711.465.728-59",
                        Address = new Address
                        {
                            City = "Belo Horizonte",
                            Street = "Centro",
                            Number = 15,
                            Cep = 12345678
                        },
                        StatusFinanceiro = StatusFinanceiro.Apto,                    
                    }
                },
                new Account
                {
                    IdAccount = 4,
                    Data = DateTime.Now,
                    NumeroCelular = "(31)5555-5555",
                    Valor = 100,
                    Customer = new Customer
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
                }
            };
        }
    }
}
