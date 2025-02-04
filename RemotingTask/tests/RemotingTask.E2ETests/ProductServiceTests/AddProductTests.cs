using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemotingTask.Server.Common;
using System;

namespace RemotingTask.E2ETests.ProductServiceTests
{
    [TestClass]
    public class AddProductTests : BaseProductTest
    {

        [TestMethod]
        public void AddProduct_ReturnsProductCreatedSuccessfully_WhenProductDataValid()
        {
            var name = "Product 1";
            var price = 100m;

            var result = _productService.AddProduct(name, price);

            Assert.AreEqual(ResponseMessages.ProductCreatedSuccessfully, result);
        }

        [TestMethod]
        [DataRow("")]
        [DataRow(null)]
        public void AddProduct_ReturnsProductNameCannotBeEmpty_WhenProductNameIsNullOrEmpty(string name)
        {
            var price = 100m;

            var result = _productService.AddProduct(name, price);

            Assert.AreEqual(ResponseMessages.ProductNameCannotBeEmpty, result);
        }

        [TestMethod]
        [DataRow(0.0)]
        [DataRow(-1.0)]
        public void AddProduct_ReturnsProductPriceMustBeGreaterThanZero_WhenProductPriceIsZeroOrNegative(double price)
        {
            var name = "Product 1";

            var result = _productService.AddProduct(name, Convert.ToDecimal(price));

            Assert.AreEqual(ResponseMessages.ProductPriceCannotBeZeroOrNegative, result);
        }

        [TestMethod]
        public void AddProduct_ReturnsProductNameAlreadyExists_WhenProductNameExists()
        {
            var name = "Product 1";
            var price = 100m;
            _productRepository.AddProduct(name, price);

            var result = _productService.AddProduct(name, price);

            Assert.AreEqual(ResponseMessages.ProductNameAlreadyExists, result);
        }
    }
}
