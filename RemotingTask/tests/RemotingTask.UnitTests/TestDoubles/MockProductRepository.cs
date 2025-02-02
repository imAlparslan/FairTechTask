using RemotingTask.RemoteObjects;
using RemotingTask.Server.Database;
using System.Collections.Generic;
using System.Linq;

namespace RemotingTask.UnitTests.TestDoubles
{
    public class MockProductRepository : HashSet<Product>, IProductRepository
    {
        public MockProductRepository() { }
        public MockProductRepository(IEnumerable<Product> products) : base(products) { }
        public bool AddProduct(string name, decimal price)
        {
            return Add(new Product(Count + 1, name, price));
        }

        public bool DeleteProduct(int id)
        {
            return RemoveWhere(x => x.Id == id) > 0;
        }

        public List<Product> GetAllProducts()
        {
            return this.ToList();
        }

        public Product GetProductById(int id)
        {
            return this.FirstOrDefault(x => x.Id == id);
        }

        public bool ProductNameExists(string name)
        {
            return this.Any(x => x.Name == name);
        }

        public bool UpdateProduct(int id, string name, decimal price)
        {
            var product = GetProductById(id);
            if (product == null)
            {
                return false;
            }
            product.Name = name;
            product.Price = price;
            return true;
        }
    }
}
