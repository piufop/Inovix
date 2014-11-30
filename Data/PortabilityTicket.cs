using System;
using System.Runtime.Serialization;

namespace Inovix.Data
{
    [Serializable]
    [DataContract]
    public class PortabilityTicket
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public PortabilityStatus Status { get; set; }
    }
}
