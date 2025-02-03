using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemotingTask.Server;
using RemotingTask.Server.Database;
using System.Data.SqlClient;

namespace RemotingTask.IntegrationTests.ProductRepositoryTests
{
    public abstract class BaseProductRepositoryTesting
    {
        protected readonly IProductRepository _repository;
        private static DatabaseSettings setting;
        protected BaseProductRepositoryTesting()
        {
            _repository = new ProductRepository(setting.applicationConnectionString);
            ResetDB(setting.applicationConnectionString);
        }

        [ClassInitialize(InheritanceBehavior.BeforeEachDerivedClass)]
        public static void ClassInitialize(TestContext testContext)
        {
            setting = new DatabaseSettings("localhost", "14333", "IntegrationTestDb", "sa", "secret_pAssw0rd");
            Program.DbInit(setting);
        }

        [ClassCleanup(InheritanceBehavior.BeforeEachDerivedClass)]
        public static void ClassCleanup()
        {
            string command = "DROP TABLE Product;";
            using (SqlConnection connection = new SqlConnection(setting.applicationConnectionString))
            {
                connection.Open();
                using (SqlCommand truncateCommand = new SqlCommand(command, connection))
                {
                    truncateCommand.ExecuteNonQuery();
                }
            }
        }
        protected void ResetDB(string connStr)
        {
            string command = "TRUNCATE TABLE Product;";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                using (SqlCommand truncateCommand = new SqlCommand(command, connection))
                {
                    truncateCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
