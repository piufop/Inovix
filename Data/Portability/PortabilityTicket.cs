using System;
using System.Runtime.Serialization;

namespace Inovix.Data.Portability
{
    [Serializable]
    [DataContract]
    public class PortabilityTicket
    {
        [DataMember]
        public DateTime TimeStamp { get; set; }

        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public PortabilityStatus Status { get; set; }

        [DataMember]
        public PortabilityError ErrorCode { get; set; }
    }
}
