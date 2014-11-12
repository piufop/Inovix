using System;
using System.Runtime.Serialization;

namespace Inovix.Data
{
    [Serializable]
    [DataContract]
    public class Customer
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string CPF { get; set; }

        [DataMember]
        public Address Address { get; set; }

        [DataMember]
        public StatusFinanceiro StatusFinanceiro { get; set; }

    }

    public enum StatusFinanceiro
	{
	   InadimplenteInterno = 1,
       InadimplenteOutraOperadora = 2,
       InadimplenteExterno = 3,
       Apto=4      
	}
}
