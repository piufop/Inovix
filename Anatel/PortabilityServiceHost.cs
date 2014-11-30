using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Anatel
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anatel Portability Service is running...");

            Portability port = new Portability();
            TcpChannel tcpChannel = new TcpChannel(8080);
            ChannelServices.RegisterChannel(tcpChannel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Portability), "SolicitarPortabilidadeNumerica", WellKnownObjectMode.Singleton);

            Console.ReadKey();
        }
    }
}
