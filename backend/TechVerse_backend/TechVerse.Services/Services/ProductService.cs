using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechVerse.Core.Interfaces;
using TechVerse.Core.Models;
using TechVerse.Services.Interfaces;

namespace TechVerse.Services.Services
{
    public class ProductService:IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _productRepository.GetAllProducts();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _productRepository.GetProductById(id);
        }

        public async Task AddProduct(Product product)
        {
            if (ValidateProduct(product))
            {
                await _productRepository.AddProduct(product);
            }
            else
            {
                throw new ArgumentException("Invalid product data");
            }
        }

        public async Task UpdateProduct(Product product)
        {
            await _productRepository.UpdateProduct(product);
        }

        public async Task DeleteProduct(int id)
        {
            await _productRepository.DeleteProduct(id);
        }

        private bool ValidateProduct(Product product)
        {
            if (product.Id != null)
            {
                return true;
            }
            return false;
        }
    }
}
