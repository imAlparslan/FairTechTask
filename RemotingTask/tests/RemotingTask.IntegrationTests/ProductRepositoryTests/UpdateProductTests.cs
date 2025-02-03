using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RemotingTask.IntegrationTests.ProductRepositoryTests
{
    [TestClass]
    public class UpdateProductTests : BaseProductRepositoryTesting
    {

        [TestMethod]
        public void UpdateProduct_ReturnsTrue_WhenProductUpdated()
        {
            string productName = "product name";
            string updateName = "new product name";
            decimal updatePrice = 5.0m;
            _repository.AddProduct(productName, 1.1m);

            var result = _repository.UpdateProduct(1, updateName, updatePrice);

            Assert.IsTrue(result);
            Assert.IsFalse(_repository.IsProductNameExists(productName));
            Assert.IsTrue(_repository.IsProductNameExists(updateName));
            var product = _repository.GetProductById(1);
            Assert.IsNotNull(product);
            Assert.AreEqual(updateName, product.Name);
            Assert.AreEqual(updatePrice, product.Price);
        }

        [TestMethod]
        public void UpdateProduct_ReturnsFalse_WhenGivenIdNotExists()
        {
            var result = _repository.UpdateProduct(1, "name", 1.1m);

            Assert.IsFalse(result);
        }
    }
}
