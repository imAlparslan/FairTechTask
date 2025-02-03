using RemotingTask.RemoteObjects;
using RemotingTask.Server.Database;
using System.Collections.Generic;

namespace RemotingTask.UnitTests.TestDoubles
{
    public class StubFailProductRepository : IProductRepository
    {
        public bool AddProduct(string name, decimal price)
        {
            throw new DatabaseException("Veri tabanına erişim sağlanamadı");

        }

        public bool DeleteProduct(int id)
        {
            throw new DatabaseException("Veri tabanına erişim sağlanamadı");
        }

        public List<Product> GetAllProducts()
        {
            throw new DatabaseException("Veri tabanına erişim sağlanamadı");
        }

        public Product GetProductById(int id)
        {
            throw new DatabaseException("Veri tabanına erişim sağlanamadı");
        }

        public bool IsProductNameExists(string name)
        {
            throw new DatabaseException("Veri tabanına erişim sağlanamadı");
        }

        public bool UpdateProduct(int id, string name, decimal price)
        {
            throw new DatabaseException("Veri tabanına erişim sağlanamadı");
        }
    }
}
