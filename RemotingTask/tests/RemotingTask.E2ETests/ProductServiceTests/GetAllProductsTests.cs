using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RemotingTask.E2ETests.ProductServiceTests
{
    [TestClass]
    public class GetAllProductsTests : BaseProductTest
    {

        [TestMethod]
        public void GetAllProducts_ReturnsAllProducts_WhenProductsExist()
        {
            var name = "Product 1";
            var price = 100m;
            _productService.AddProduct(name, price);

            var result = _productService.GetAllProducts();

            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void GetAllProducts_ReturnsEmptyList_WhenNoProductsExist()
        {
            var result = _productService.GetAllProducts();

            Assert.AreEqual(0, result.Count);
        }
    }
}
