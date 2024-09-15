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
    public class ProductRepository:IProductRepository
    {
        private readonly TechVerseContext _dbContext;

        public ProductRepository(TechVerseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _dbContext.Set<Product>().ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _dbContext.Set<Product>().FindAsync(id);
        }

        public async Task AddProduct(Product product)
        {
            await _dbContext.Set<Product>().AddAsync(product);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateProduct(Product product)
        {
            var existingEntity = _dbContext.Set<Product>().Local.FirstOrDefault(e => e.Id == product.Id);
            if (existingEntity != null)
            {
                _dbContext.Entry(existingEntity).State = EntityState.Detached;
            }

            _dbContext.Entry(product).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteProduct(int id)
        {
            var product = await _dbContext.Set<Product>().FindAsync(id);
            if (product != null)
            {
                _dbContext.Set<Product>().Remove(product);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
