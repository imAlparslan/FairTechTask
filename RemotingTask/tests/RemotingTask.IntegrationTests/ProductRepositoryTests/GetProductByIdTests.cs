using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RemotingTask.IntegrationTests.ProductRepositoryTests
{
    [TestClass]
    public class GetProductByIdTests : BaseProductRepositoryTesting
    {


        [TestMethod]
        public void GetProductById_ReturnsProduct_WhenGivenIdExists()
        {
            _repository.AddProduct("name", 1.1m);

            var product = _repository.GetProductById(1);

            Assert.IsNotNull(product);
        }


        [TestMethod]
        public void GetProductById_ReturnsNull_WhenGivenIdNotExists()
        {

            var product = _repository.GetProductById(1);

            Assert.IsNull(product);
        }
    }
}
