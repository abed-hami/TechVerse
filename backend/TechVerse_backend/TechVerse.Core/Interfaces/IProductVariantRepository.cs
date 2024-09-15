using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechVerse.Core.Models;

namespace TechVerse.Core.Interfaces
{
    public interface IProductVariantRepository
    {
        Task<IEnumerable<ProductVariant>> GetAllProductVariants();
        Task<ProductVariant> GetProductVariantById(int id);
        Task AddProductVariant(ProductVariant variant);
        Task UpdateProductVariant(ProductVariant variant);
        Task DeleteProductVariant(int id);
    }
}
