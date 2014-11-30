using Anatel;
using Inovix.Data;
using Inovix.Data.Portability;
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

namespace APT
{
    public class APTService : IAPTService
    {
        public PortabilityTicket SolicitarBilhetePortabilidade(Customer customer, Account account)
        {
            ValidateCustomer(customer);

            ValidateAccount(account);

            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel, false);

            RemotingConfiguration.RegisterWellKnownClientType(
                Type.GetType("Anatel.Portability, Anatel"),
                "http://localhost:8080/solicitarPortabilidadeNumerica");

            Portability portability = new Portability();

            PortabilityTicket ticket = portability.SolicitarPortabilidadeNumerica();

            return ticket;
        }

        private void ValidateAccount(Account account)
        {
            // Validation stuff.
        }

        private void ValidateCustomer(Customer customer)
        {
            // Validation stuff.
        }
    }
}
