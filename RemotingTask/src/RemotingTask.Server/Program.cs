using RemotingTask.Server.Services;
using System;
using System.Data.SQLite;
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

            DbInit();

            Console.WriteLine("Server started...");

            Console.ReadLine();
        }


        public static void DbInit()
        {

            Console.WriteLine("Creating database...");
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=RemotingTask.db"))
            {
                connection.Open();

                var tableCreateCommand = connection.CreateCommand();

                tableCreateCommand.CommandText = @"CREATE TABLE IF NOT EXISTS Products (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Price REAL NOT NULL
                )";


                tableCreateCommand.ExecuteNonQuery();

            };

        }
    }
}
