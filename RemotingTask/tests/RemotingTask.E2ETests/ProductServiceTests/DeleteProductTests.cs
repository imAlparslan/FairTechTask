using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemotingTask.Server.Common;

namespace RemotingTask.E2ETests.ProductServiceTests
{
    [TestClass]
    public class DeleteProductTests : BaseProductTest
    {

        [TestMethod]
        public void DeleteProduct_ReturnsProductDeletedSuccessfully_WhenProductExists()
        {
            var name = "Product 1";
            var price = 100m;
            var id = 1;
            _productService.AddProduct(name, price);

            var result = _productService.DeleteProduct(id);

            Assert.AreEqual(ResponseMessages.ProductDeletedSuccessfully, result);
        }
        [TestMethod]
        public void DeleteProduct_ReturnsProductNotFound_WhenProductDoesNotExist()
        {
            var id = 1;

            var result = _productService.DeleteProduct(id);

            Assert.AreEqual(ResponseMessages.ProductNotFound, result);
        }
    }
}
