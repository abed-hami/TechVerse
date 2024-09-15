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
    public class ProductVariantService:IProductVariantService
    {
        private readonly IProductVariantRepository _variantRepository;

        public ProductVariantService(IProductVariantRepository variantRepository)
        {
            _variantRepository = variantRepository;
        }

        public async Task<IEnumerable<ProductVariant>> GetAllProductVariants()
        {
            return await _variantRepository.GetAllProductVariants();
        }

        public async Task<ProductVariant> GetProductVariantById(int id)
        {
            return await _variantRepository.GetProductVariantById(id);
        }

        public async Task AddProductVariant(ProductVariant variant)
        {
            if (ValidateProductVariant(variant))
            {
                await _variantRepository.AddProductVariant(variant);
            }
            else
            {
                throw new ArgumentException("Invalid variant data");
            }
        }

        public async Task UpdateProductVariant(ProductVariant variant)
        {
            await _variantRepository.UpdateProductVariant(variant);
        }

        public async Task DeleteProductVariant(int id)
        {
            await _variantRepository.DeleteProductVariant(id);
        }

        private bool ValidateProductVariant(ProductVariant variant)
        {
            if (variant.Id != null)
            {
                return true;
            }
            return false;
        }
    }
}
