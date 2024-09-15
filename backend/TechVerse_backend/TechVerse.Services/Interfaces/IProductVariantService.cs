using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechVerse.Core.Models;

namespace TechVerse.Services.Interfaces
{
    public interface IProductVariantService
    {
        Task<IEnumerable<ProductVariant>> GetAllProductVariants();
        Task<ProductVariant> GetProductVariantById(int id);
        Task AddProductVariant(ProductVariant variant);
        Task UpdateProductVariant(ProductVariant variant);
        Task DeleteProductVariant(int id);
    }
}
