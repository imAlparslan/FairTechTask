using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemotingTask.RemoteObjects;
using RemotingTask.Server.Common;
using RemotingTask.Server.Services;
using RemotingTask.UnitTests.TestDoubles;

namespace RemotingTask.UnitTests.ProductServiceTests
{
    [TestClass]
    public class DeleteProductTests
    {
        private readonly MockProductRepository _mockProductRepository;
        private readonly IProductService _productService;
        public DeleteProductTests()
        {
            _mockProductRepository = new MockProductRepository();
            _productService = new ProductService(_mockProductRepository);

        }
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
