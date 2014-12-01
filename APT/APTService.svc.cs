using Anatel;
using Inovix.Data;
using Inovix.Data.Portability;
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels.Tcp;

namespace APT
{
    public class APTService : IAPTService
    {
        public PortabilityTicket SolicitarBilhetePortabilidade(Customer customer, Account account)
        {
            ValidateCustomer(customer);

            ValidateAccount(account);

            //HttpChannel channel = new HttpChannel();
            //ChannelServices.RegisterChannel(channel, false);

            //RemotingConfiguration.RegisterWellKnownClientType(
            //    Type.GetType("Anatel.Portability, Anatel"),
            //    "http://localhost:8080/solicitarPortabilidadeNumerica");

            //Portability portability = new Portability();

            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, false);
            var portability = (Portability)Activator.GetObject(
                typeof(Portability), "tcp://localhost:8080/solicitarPortabilidadeNumerica"
                );

            PortabilityTicket ticket = portability.SolicitarPortabilidadeNumerica();

            if (ticket.Status == PortabilityStatus.CreateFailed)
            {
                ObterRespostaAnatel(ticket.Id);
            }

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

        public PortabilityStatus ObterRespostaAnatel(Guid ticketId)
        {
            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel, false);

            RemotingConfiguration.RegisterWellKnownClientType(
                Type.GetType("Anatel.Portability, Anatel"),
                "http://localhost:8080/solicitarPortabilidadeNumerica");

            Portability portability = new Portability();

            return portability.ObterRespostaPortabilidade(ticketId);
        }
    }
}
