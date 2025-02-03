using RemotingTask.Server.Database;
using RemotingTask.Server.Services;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace RemotingTask.Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tcpPort = ConfigurationManager.AppSettings["TcpPort"];

            if (!string.IsNullOrEmpty(tcpPort) && int.TryParse(tcpPort, out int port))
            {
                TcpChannel channel = new TcpChannel(port);
                ChannelServices.RegisterChannel(channel, false);
            }
            else
            {
                throw new Exception("Lütfen App.Config -> TcpPort ayarlarınızı kontrol edin");
            }

            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(ProductService),
                "ProductService",
                WellKnownObjectMode.Singleton);

            Console.WriteLine("Server started...");

            DbInit();


            Console.ReadLine();
        }


        public static void DbInit()
        {

            try
            {
                var dbSettings = DatabaseSettings.Load();

                // check database connection
                var canConnect = CheckConnection(dbSettings.MasterDbConnectionString);
                if (!canConnect)
                {
                    throw new Exception("Veri tabanı bağlantısı sağlanamadı");
                }

                //create database if not exists
                var hasDatabase = CheckDbExists(dbSettings.MasterDbConnectionString, dbSettings.DBName);
                if (!hasDatabase)
                {
                    CreateDatabase(dbSettings.MasterDbConnectionString, dbSettings.DBName);
                }

                //check table exists
                var hasProductTable = CheckProductTableExists(dbSettings.applicationConnectionString);
                if (!hasProductTable)
                {
                    CreateProductTable(dbSettings.applicationConnectionString);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static bool CheckProductTableExists(string applicationConnectionString)
        {
            string sql = "SELECT COUNT(*) FROM sys.tables WHERE name = @tableName";
            using (SqlConnection connection = new SqlConnection(applicationConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@tableName", "Product");
                    int count = (int)command.ExecuteScalar();
                    return (count > 0);
                }
            }
        }

        static void CreateProductTable(string applicationConnectionString)
        {
            string sql = @"
                CREATE TABLE [dbo].[Product] (
                    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                    [Name] NVARCHAR(100) NOT NULL,
                    [Price] DECIMAL(18, 2) NOT NULL
                )";

            using (SqlConnection connection = new SqlConnection(applicationConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Product tablosu oluşturuldu.");
                }
            }
        }
        static void CreateDatabase(string connectionString, string dbName)
        {
            string query = $"CREATE DATABASE [{dbName}]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine($"{dbName} veritabanı oluşturuldu!");
            }
        }

        private static bool CheckDbExists(string connectionString, string dbName)
        {
            string query = $"SELECT database_id FROM sys.databases WHERE name = @DatabaseName";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DatabaseName", dbName);
                connection.Open();
                return command.ExecuteScalar() != null;

            }
        }
        private static bool CheckConnection(string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
