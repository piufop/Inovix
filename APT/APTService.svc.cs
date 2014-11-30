using Anatel;
using Inovix.Data;
using Inovix.Data.Portability;
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace APT
{
    public class APTService : IAPTService
    {
        public PortabilityTicket SolicitarBilhetePortabilidade(Customer customer, Account account)
        {
            
            return new PortabilityTicket();
        }
    }
}
