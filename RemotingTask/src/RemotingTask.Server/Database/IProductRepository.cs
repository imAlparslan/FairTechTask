using RemotingTask.RemoteObjects;
using System.Collections.Generic;

namespace RemotingTask.Server.Database
{
    public interface IProductRepository
    {
        bool AddProduct(string name, decimal price);
        Product GetProductById(int id);
        List<Product> GetAllProducts();
        bool DeleteProduct(int id);
        bool UpdateProduct(int id, string name, decimal price);
        bool IsProductNameExists(string name);
    }
}
