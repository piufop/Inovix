using Inovix.Data;
using Inovix.Data.Portability;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Anatel
{
    public class Portability : MarshalByRefObject, IPortability
    {
        private Dictionary<Guid, PortabilityTicket> tickets = new Dictionary<Guid, PortabilityTicket>();

        public PortabilityTicket SolicitarPortabilidadeNumerica()
        {
            Thread.Sleep(2000);

            return new PortabilityTicket()
            {
                TimeStamp = DateTime.Now,
                Id = Guid.NewGuid(),
                Status = PortabilityStatus.Created,
                ErrorCode = PortabilityError.NoError
            };
        }

        public PortabilityStatus ObterRespostaPortabilidade(Guid ticketId)
        {
            return tickets[ticketId].Status;
        }
    }
}
