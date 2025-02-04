using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemotingTask.RemoteObjects;
using RemotingTask.Server;
using RemotingTask.Server.Database;
using RemotingTask.Server.Services;
using System.Data.SqlClient;

namespace RemotingTask.E2ETests.ProductServiceTests
{
    public abstract class BaseProductTest
    {
        protected readonly IProductRepository _productRepository;
        protected readonly IProductService _productService;
        private static DatabaseSettings setting;
        protected BaseProductTest()
        {
            _productRepository = new ProductRepository(setting.applicationConnectionString);
            _productService = new ProductService(_productRepository);
            ResetDB(setting.applicationConnectionString);
        }

        [ClassInitialize(InheritanceBehavior.BeforeEachDerivedClass)]
        public static void ClassInitialize(TestContext testContext)
        {

            setting = DatabaseSettings.Load();
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
