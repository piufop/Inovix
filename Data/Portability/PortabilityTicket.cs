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

        public override string ToString()
        {
            return string.Format("Id: {0} \r\n Timestamp: {1} \r\n Status: {2} \r\n Error Code: {3}", TimeStamp.ToLocalTime(), Id, Status, ErrorCode );

        }
    }
}
