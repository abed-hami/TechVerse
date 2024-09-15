using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechVerse.Core.Interfaces;
using TechVerse.Core.Models;

namespace TechVerse.Core.Repository
{
    public class ProductVariantRepository:IProductVariantRepository
    {
        private readonly TechVerseContext _dbContext;

        public ProductVariantRepository(TechVerseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<ProductVariant>> GetAllProductVariants()
        {
            return await _dbContext.Set<ProductVariant>().ToListAsync();
        }

        public async Task<ProductVariant> GetProductVariantById(int id)
        {
            return await _dbContext.Set<ProductVariant>().FindAsync(id);
        }

        public async Task AddProductVariant(ProductVariant variant)
        {
            await _dbContext.Set<ProductVariant>().AddAsync(variant);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateProductVariant(ProductVariant variant)
        {
            var existingEntity = _dbContext.Set<ProductVariant>().Local.FirstOrDefault(e => e.Id == variant.Id);
            if (existingEntity != null)
            {
                _dbContext.Entry(existingEntity).State = EntityState.Detached;
            }

            _dbContext.Entry(variant).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteProductVariant(int id)
        {
            var variant = await _dbContext.Set<ProductVariant>().FindAsync(id);
            if (variant != null)
            {
                _dbContext.Set<ProductVariant>().Remove(variant);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
