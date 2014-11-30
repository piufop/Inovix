using Inovix.Data.Portability;
using System;

namespace Anatel
{
    public class Portability : IPortability
    {
        public PortabilityTicket SolicitarPortabilidadeNumerica()
        {
            return new PortabilityTicket()
            {
                TimeStamp = DateTime.Now,
                Id = Guid.NewGuid(),
                Status = PortabilityStatus.Success,
                ErrorCode = PortabilityError.NoError
            };
        }
    }
}
