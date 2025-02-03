using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RemotingTask.IntegrationTests.ProductRepositoryTests
{
    [TestClass]
    public class DeleteProductTests : BaseProductRepositoryTesting
    {

        [TestMethod]
        public void DeleteProduct_ReturnsTrue_WhenProductDeleted()
        {
            _repository.AddProduct("prodcut 1", 1.1m);

            var result = _repository.DeleteProduct(1);

            Assert.IsTrue(result);
            Assert.IsNull(_repository.GetProductById(1));
        }

        [TestMethod]
        public void DeleteProducts_ReturnsFalse_WhenGivenIdNotExists()
        {
            var result = _repository.DeleteProduct(1);

            Assert.IsFalse(result);
        }
    }
}
