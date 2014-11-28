using System;
using System.Runtime.Serialization;

namespace Inovix.Data
{
    [Serializable]
    [DataContract]
    public class Account
    {
        [DataMember]
        public int IdAccount { get; set; }                        
        [DataMember]
        public DateTime Data { get; set; }
        [DataMember]
        public Double Valor { get; set; }
        [DataMember]
        public string NumeroCelular { get; set; }
        [DataMember]
        public Customer Customer { get; set; }
    }
}
