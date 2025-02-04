using RemotingTask.RemoteObjects;
using System.Collections.Generic;

namespace RemotingTask.Server.Database
{
    public interface IProductRepository
    {
        /// <summary>
        /// Veri tabanına ürünü kaydeder
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <returns>Kayıt başarılı ise True, değil ise False</returns>
        bool AddProduct(string name, decimal price);

        /// <summary>
        /// Verilen Id'ye ait ürünü verir
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Null yada Product</returns>
        Product GetProductById(int id);

        /// <summary>
        /// Tüm ürünleri getirir
        /// </summary>
        /// <returns>Ürün Listesi</returns>
        List<Product> GetAllProducts();

        /// <summary>
        /// Id'ye ait ürünü siler
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Silme işlemi başarılı ise True, değil ise false</returns>
        bool DeleteProduct(int id);

        /// <summary>
        /// Id'ye ait ürünü günceller
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <returns>Güncelleştirme başarılı ise True, değil ise False</returns>
        bool UpdateProduct(int id, string name, decimal price);

        /// <summary>
        /// Verilen isime sahip ürün var mı kontrol eder
        /// </summary>
        /// <param name="name"></param>
        /// <returns>İsim mevcut ise True değil ise False</returns>
        bool IsProductNameExists(string name);
    }
}
