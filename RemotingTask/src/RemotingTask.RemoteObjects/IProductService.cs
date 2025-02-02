using System.Collections.Generic;

namespace RemotingTask.RemoteObjects
{
    public interface IProductService
    {
        /// <summary>
        /// Veri tabanına yeni ürün ekler.
        /// <list type="bullet">
        /// <item>Ürün adı boş veya null olmamalıdır.</item> 
        /// <item>Fiyat sıfır veya negatif olmamalıdır.</item>
        /// <item>Aynı isimde ürün varsa eklenemez.</item>
        /// </list>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <returns>Başarılı veya başarısız hata mesajı</returns>
        string AddProduct(string name, decimal price);

        /// <summary>
        /// Ürünü siler.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Başarılı veya başarısız hata mesajı</returns>
        string DeleteProduct(int id);
        /// <summary>
        /// Tüm ürünleri getirir.
        /// </summary>
        /// <returns></returns>
        List<Product> GetAllProducts();

        /// <summary>
        /// Ürün bilgilerini günceller.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <returns>Başarılı veya başarısız hata mesajı</returns>
        string UpdateProduct(int id, string name, decimal price);
    }
}
