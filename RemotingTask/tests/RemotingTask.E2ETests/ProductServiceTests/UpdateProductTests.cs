using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemotingTask.Server.Common;
using System;

namespace RemotingTask.E2ETests.ProductServiceTests
{
    [TestClass]
    public class UpdateProductTests : BaseProductTest
    {

        [TestMethod]
        public void UpdateProduct_ReturnsProductUpdatedSuccessfully_WhenProductDataValid()
        {
            var id = 1;
            var name = "Product 1";
            var price = 100m;
            _productService.AddProduct(name, price);

            var result = _productService.UpdateProduct(id, name, price);

            Assert.AreEqual(ResponseMessages.ProductUpdatedSuccessfully, result);
        }
        [TestMethod]
        public void UpdateProduct_ReturnsProductNotFound_WhenProductDoesNotExist()
        {
            var id = 1;
            var name = "Product 1";
            var price = 100m;

            var result = _productService.UpdateProduct(id, name, price);

            Assert.AreEqual(ResponseMessages.ProductNotFound, result);
        }
        [TestMethod]
        [DataRow("")]
        [DataRow(null)]
        public void UpdateProduct_ReturnsProductNameCannotBeEmpty_WhenProductNameIsNullOrEmpty(string name)
        {
            var id = 1;
            var price = 100m;
            _productService.AddProduct("Product 1", price);

            var result = _productService.UpdateProduct(id, name, price);

            Assert.AreEqual(ResponseMessages.ProductNameCannotBeEmpty, result);
        }
        [TestMethod]
        [DataRow(0.0)]
        [DataRow(-1.0)]
        public void UpdateProduct_ReturnsProductPriceMustBeGreaterThanZero_WhenProductPriceIsZeroOrNegative(double price)
        {
            var id = 1;
            var name = "Product 1";
            _productService.AddProduct(name, 100m);

            var result = _productService.UpdateProduct(id, name, Convert.ToDecimal(price));

            Assert.AreEqual(ResponseMessages.ProductPriceCannotBeZeroOrNegative, result);
        }
        [TestMethod]
        public void UpdateProduct_ReturnsProductNameAlreadyExists_WhenProductNameExists()
        {
            var id = 1;
            var name = "Product 1";
            var price = 100m;
            _productService.AddProduct(name, price);
            _productService.AddProduct("Product 2", 200m);

            var result = _productService.UpdateProduct(id, "Product 2", 200m);

            Assert.AreEqual(ResponseMessages.ProductNameAlreadyExists, result);
        }
    }
}
