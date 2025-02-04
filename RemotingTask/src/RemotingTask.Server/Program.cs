using RemotingTask.Server.Common;
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
            Logger.Information("Sunucu başlatılıyor");

            string tcpPort = ConfigurationManager.AppSettings["TcpPort"];

            if (!string.IsNullOrEmpty(tcpPort) && int.TryParse(tcpPort, out int port))
            {
                TcpChannel channel = new TcpChannel(port);
                ChannelServices.RegisterChannel(channel, false);
            }
            else
            {
                Logger.Information("App.config hatalı");
                throw new Exception("Lütfen App.Config -> TcpPort ayarlarınızı kontrol edin");
            }

            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(ProductService),
                "ProductService",
                WellKnownObjectMode.Singleton);


            var dbSettings = DatabaseSettings.Load();

            DbInit(dbSettings);

            Logger.Information("Sunucu Hazır");
            Console.ReadLine();
        }


        public static void DbInit(DatabaseSettings dbSettings)
        {

            try
            {
                Logger.Information("Veri tabanı kontrolleri başlatılıyor");

                // check database connection
                var canConnect = CheckConnection(dbSettings.MasterDbConnectionString);
                if (!canConnect)
                {
                    throw new Exception("Veri tabanı bağlantısı sağlanamadı");
                }

                //create database if not exists
                Logger.Information($"Veri tabanı {dbSettings.DBName} kontrol ediliyor");
                var hasDatabase = CheckDbExists(dbSettings.MasterDbConnectionString, dbSettings.DBName);
                if (!hasDatabase)
                {
                    Logger.Information($"Veri tabanı {dbSettings.DBName} bulunamadı");

                    CreateDatabase(dbSettings.MasterDbConnectionString, dbSettings.DBName);
                }

                //check table exists
                var hasProductTable = CheckProductTableExists(dbSettings.applicationConnectionString);
                if (!hasProductTable)
                {
                    Logger.Information($"Product tablosu bulunamadı");
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
            Logger.Information($"Product tablosu kontrol ediliyor");
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
            Logger.Information("Product tablosu oluşturuluyor");
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
                    Logger.Information("Product tablosu oluşturuldu.");
                }
            }
        }
        static void CreateDatabase(string connectionString, string dbName)
        {
            Logger.Information($"Veri tabanı {dbName} oluşturuluyor");

            string query = $"CREATE DATABASE [{dbName}]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                Logger.Information($"{dbName} veritabanı oluşturuldu!");
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
                Logger.Information("Veri tabanına erişimi sağlandı");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception)
            {
                Logger.Error("Veri tabanına erişimi sağlanamadı");
                return false;
            }

        }
    }
}
