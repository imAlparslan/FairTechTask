using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RemotingTask.IntegrationTests.ProductRepositoryTests
{
    [TestClass]
    public class IsProductNameExistsTests : BaseProductRepositoryTesting
    {

        [TestMethod]
        public void IsProductNameExists_ReturnsTrue_WhenNameExists()
        {
            var productName = "product name";
            _repository.AddProduct(productName, 1.1m);

            var result = _repository.IsProductNameExists(productName);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsProductNameExists_ReturnsFalse_WhenNameNotExists()
        {
            var result = _repository.IsProductNameExists("no");

            Assert.IsFalse(result);
        }
    }
}
