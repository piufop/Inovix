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

            TcpChannel tcpChannel = new TcpChannel(8080);
            ChannelServices.RegisterChannel(tcpChannel, false);

            //Portability portability = new Portability();
            
            //ObjRef portRef = RemotingServices.Marshal(portability, "solicitarPortabilidadeNumerica");
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Portability), "solicitarPortabilidadeNumerica", WellKnownObjectMode.Singleton);

            Console.ReadKey();
        }
    }
}
