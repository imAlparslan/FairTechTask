using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RemotingTask.IntegrationTests.ProductRepositoryTests
{
    [TestClass]
    public class AddProductTests : BaseProductRepositoryTesting
    {
        [TestMethod]
        public void AddProduct_ReturnsTrue_WhenProductInserted()
        {

            var result = _repository.AddProduct("valid", 1.1m);

            Assert.IsNotNull(result);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddProduct2()
        {

            var result = _repository.AddProduct("valid", 1.1m);

            Assert.IsNotNull(result);
            Assert.IsTrue(result);
        }
    }
}
