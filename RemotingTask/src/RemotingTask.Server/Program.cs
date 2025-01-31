using RemotingTask.RemoteObjects;
using RemotingTask.Server.Services;
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace RemotingTask.Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // read from config file
            TcpChannel channel = new TcpChannel(1234);
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(ProductService),
                "ProductService",
                WellKnownObjectMode.Singleton);

            Console.WriteLine("Server started...");

            Console.ReadLine();
        }
    }
}
