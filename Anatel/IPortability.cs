using Inovix.Data.Portability;
using System;

namespace Anatel
{
    public interface IPortability
    {
        PortabilityTicket SolicitarPortabilidadeNumerica();

        PortabilityStatus ObterRespostaPortabilidade(Guid ticketId);
    }
}
