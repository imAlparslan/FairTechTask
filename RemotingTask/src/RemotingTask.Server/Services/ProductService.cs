using RemotingTask.RemoteObjects;
using RemotingTask.Server.Common;
using RemotingTask.Server.Database;
using System;
using System.Collections.Generic;

namespace RemotingTask.Server.Services
{
    public class ProductService : MarshalByRefObject, IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
        }
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public string AddProduct(string name, decimal price)
        {
            if (IsProductNameInvalid(name))
            {
                return ResponseMessages.ProductNameCannotBeEmpty;
            }
            if (IsProductPriceInvalid(price))
            {
                return ResponseMessages.ProductPriceCannotBeZeroOrNegative;
            }

            if (IsProductNameExists(name))
            {
                return ResponseMessages.ProductNameAlreadyExists;
            }

            var isAdded = _productRepository.AddProduct(name, price);

            if (isAdded)
            {
                return ResponseMessages.ProductCreatedSuccessfully;
            }
            return ResponseMessages.ProductCouldNotBeAdded;
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public string DeleteProduct(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product is null)
            {
                return ResponseMessages.ProductNotFound;
            }
            
            var isDeleted = _productRepository.DeleteProduct(id);
            
            if (isDeleted)
            {
                return ResponseMessages.ProductDeletedSuccessfully;
            }
            return ResponseMessages.ProductCouldNotBeDeleted;
        }

        public string UpdateProduct(int id, string name, decimal price)
        {
            var product = _productRepository.GetProductById(id);
            if (product is null)
            {
                return ResponseMessages.ProductNotFound;
            }
            if (product.Name != name)
            {
                if (IsProductNameExists(name))
                {
                    return ResponseMessages.ProductNameAlreadyExists;
                }
            }
            if (IsProductNameInvalid(name))
            {
                return ResponseMessages.ProductNameCannotBeEmpty;
            }
            if (IsProductPriceInvalid(price))
            {
                return ResponseMessages.ProductPriceCannotBeZeroOrNegative;
            }

            var isUpdated = _productRepository.UpdateProduct(id, name, price);

            if (isUpdated)
            {
                return ResponseMessages.ProductUpdatedSuccessfully;
            }
            return ResponseMessages.ProductCouldNotBeUpdated;
        }

        private bool IsProductNameInvalid(string name)
        {
            return string.IsNullOrWhiteSpace(name);
        }

        private bool IsProductNameExists(string name)
        {
            return _productRepository.ProductNameExists(name);
        }
        private bool IsProductPriceInvalid(decimal price)
        {
            return price <= 0;
        }
    }
}
