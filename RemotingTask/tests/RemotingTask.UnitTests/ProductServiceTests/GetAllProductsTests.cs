using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemotingTask.RemoteObjects;
using RemotingTask.Server.Common;
using RemotingTask.Server.Database;
using RemotingTask.Server.Services;
using RemotingTask.UnitTests.TestDoubles;

namespace RemotingTask.UnitTests.ProductServiceTests
{
    [TestClass]
    public class GetAllProductsTests
    {
        private readonly MockProductRepository _mockProductRepository;
        private readonly IProductService _productService;
        public GetAllProductsTests()
        {
            _mockProductRepository = new MockProductRepository();
            _productService = new ProductService(_mockProductRepository);

        }

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


        [TestMethod]
        public void GetAllProducts_ReturnsEmptyCollection_WhenExceptionOccur()
        {
            IProductRepository failRepo = new StubFailProductRepository();
            IProductService productService = new ProductService(failRepo);

            var result = productService.GetAllProducts();

            Assert.AreEqual(0, result.Count);

        }
    }
}
