using RemotingTask.RemoteObjects;
using RemotingTask.Server.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingTask.UnitTests.TestDoubles
{
    internal class StubFailProductRepository : IProductRepository
    {
        public bool AddProduct(string name, decimal price)
        {
           return false;
        }

        public bool DeleteProduct(int id)
        {
            return false;
        }

        public List<Product> GetAllProducts()
        {
            return null;
        }

        public Product GetProductById(int id)
        {
            return null;
        }

        public bool ProductNameExists(string name)
        {
            return false;
        }

        public bool UpdateProduct(int id, string name, decimal price)
        {
            return false;
        }
    }
}
