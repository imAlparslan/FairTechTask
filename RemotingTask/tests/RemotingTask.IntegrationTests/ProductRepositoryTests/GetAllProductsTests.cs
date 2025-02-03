using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RemotingTask.IntegrationTests.ProductRepositoryTests
{
    [TestClass]
    public class GetAllProductsTests : BaseProductRepositoryTesting
    {

        [TestMethod]
        public void GetAllProducts_ReturnsListOfProduct_WhenProductsExists()
        {
            _repository.AddProduct("product 1", 1.1m);
            _repository.AddProduct("product 2", 1.1m);
            _repository.AddProduct("product 3", 1.1m);

            var result = _repository.GetAllProducts();

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void GetAllProducts_ReturnsEmptyList_WhenNoProductExists()
        {
            var result = _repository.GetAllProducts();

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }
    }
}
