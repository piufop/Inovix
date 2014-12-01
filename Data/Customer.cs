using System;
using System.Runtime.Serialization;

namespace Inovix.Data
{
    [Serializable]
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int IdCustomer { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Cpf { get; set; }

        [DataMember]
        public Address Address { get; set; } 
        [DataMember]
        public StatusFinanceiro StatusFinanceiro { get; set; }

    }

    public enum StatusFinanceiro
    {
        InadimplenteInterno = 0,
        InadimplenteOutraOperadora = 1,
        InadimplenteExterno = 2,
        Apto = 3
    }
}
