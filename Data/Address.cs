using System;
using System.Runtime.Serialization;

namespace Inovix.Data
{
    [Serializable]
    [DataContract]
    public class Address
    {
        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Street { get; set; }

        [DataMember]
        public int Number { get; set; }

        [DataMember]
        public string Complement { get; set; }

        [DataMember]
        public int CEP { get; set; }
    }
}
