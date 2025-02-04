using RemotingTask.RemoteObjects;
using RemotingTask.Server.Common;
using RemotingTask.Server.Database;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;

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
            try
            {
                Logger.Information($"İşlem: 'AddProduct' Params: [name:{name}, price:{price}]");
                if (IsProductNameInvalid(name))
                {
                    Logger.Information($"Sonuç: [{ResponseMessages.ProductNameCannotBeEmpty}]");
                    return ResponseMessages.ProductNameCannotBeEmpty;
                }
                if (IsProductPriceInvalid(price))
                {
                    Logger.Information($"Sonuç: [{ResponseMessages.ProductPriceCannotBeZeroOrNegative}]");
                    return ResponseMessages.ProductPriceCannotBeZeroOrNegative;
                }

                if (IsProductNameExists(name))
                {
                    Logger.Information($"Sonuç: [{ResponseMessages.ProductNameAlreadyExists}]");
                    return ResponseMessages.ProductNameAlreadyExists;

                }

                var isAdded = _productRepository.AddProduct(name, price);

                if (isAdded)
                {
                    Logger.Information($"Sonuç: [{ResponseMessages.ProductCreatedSuccessfully}]");
                    return ResponseMessages.ProductCreatedSuccessfully;
                }

                Logger.Information($"Sonuç: [{ResponseMessages.ProductCouldNotBeAdded}]");
                return ResponseMessages.ProductCouldNotBeAdded;

            }
            catch (DatabaseException ex)
            {
                Logger.Error($"İşlem sırasında hata meydana geldi \n {ex.Message}");

                return ResponseMessages.ServerError;

            }

        }

        public List<Product> GetAllProducts()
        {
            try
            {
                Logger.Information($"İşlem: 'GetAllProducts'");

                var result =  _productRepository.GetAllProducts();

                Logger.Information($"Sonuç: 'Başarılı'");
                return result;
            }
            catch (DatabaseException ex)
            {
                Logger.Error($"İşlem sırasında hata meydana geldi \n {ex.Message}");

                return new List<Product>();
            }
        }

        public string DeleteProduct(int id)
        {
            try
            {
                Logger.Information($"İşlem: 'DeleteProduct' Params: [id:{id}]");

                var product = _productRepository.GetProductById(id);
                if (product is null)
                {
                    Logger.Information($"Sonuç: [{ResponseMessages.ProductNotFound}]");
                    return ResponseMessages.ProductNotFound;
                }

                var isDeleted = _productRepository.DeleteProduct(id);

                if (isDeleted)
                {
                    Logger.Information($"Sonuç: [{ResponseMessages.ProductDeletedSuccessfully}]");
                    return ResponseMessages.ProductDeletedSuccessfully;
                }

                Logger.Information($"Sonuç: [{ResponseMessages.ProductDeletedSuccessfully}]");
                return ResponseMessages.ProductDeletedSuccessfully;
            }
            catch (DatabaseException ex) 
            {
                Logger.Error($"İşlem sırasında hata meydana geldi \n {ex.Message}");
                Logger.Information($"Sonuç: [{ResponseMessages.ServerError}]");

                return ResponseMessages.ServerError;
            }

        }

        public string UpdateProduct(int id, string name, decimal price)
        {
            try
            {
                Logger.Information($"İşlem: 'UpdateProduct' Params: [id:{id}, name:{name}, price:{price}]");

                var product = _productRepository.GetProductById(id);
                if (product is null)
                {
                    Logger.Information($"Sonuç: [{ResponseMessages.ProductNotFound}]");
                    return ResponseMessages.ProductNotFound;
                }
                if (product.Name != name)
                {
                    if (IsProductNameExists(name))
                    {
                        Logger.Information($"Sonuç: [{ResponseMessages.ProductNameAlreadyExists}]");
                        return ResponseMessages.ProductNameAlreadyExists;
                    }
                }
                if (IsProductNameInvalid(name))
                {
                    Logger.Information($"Sonuç: [{ResponseMessages.ProductNameCannotBeEmpty}]");
                    return ResponseMessages.ProductNameCannotBeEmpty;
                }
                if (IsProductPriceInvalid(price))
                {
                    Logger.Information($"Sonuç: [{ResponseMessages.ProductPriceCannotBeZeroOrNegative}]");
                    return ResponseMessages.ProductPriceCannotBeZeroOrNegative;
                }

                var isUpdated = _productRepository.UpdateProduct(id, name, price);

                if (isUpdated)
                {
                    Logger.Information($"Sonuç: [{ResponseMessages.ProductUpdatedSuccessfully}]");
                    return ResponseMessages.ProductUpdatedSuccessfully;
                }

                Logger.Information($"Sonuç: [{ResponseMessages.ProductCouldNotBeUpdated}]");
                return ResponseMessages.ProductCouldNotBeUpdated;
            }
            catch (DatabaseException ex)
            {
                Logger.Error($"İşlem sırasında hata meydana geldi \n {ex.Message}");
                
                Logger.Information($"Sonuç: [{ResponseMessages.ServerError}]");
                return ResponseMessages.ServerError;
            }


        }

        private bool IsProductNameInvalid(string name)
        {
            Logger.Information($"İşlem: 'IsProductNameInvalid' Params: [name:{name}]");

            return string.IsNullOrWhiteSpace(name);
        }

        private bool IsProductNameExists(string name)
        {
            Logger.Information($"İşlem: 'IsProductNameExists' Params: [name:{name}]");

            return _productRepository.IsProductNameExists(name);
        }
        private bool IsProductPriceInvalid(decimal price)
        {
            Logger.Information($"İşlem: 'IsProductPriceInvalid' Params: [name:{price}]");

            return price <= 0;
        }
    }
}
