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
    public class CategoryRepository:ICategoryRepository
    {
        private readonly TechVerseContext _dbContext;

        public CategoryRepository(TechVerseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _dbContext.Set<Category>().ToListAsync();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _dbContext.Set<Category>().FindAsync(id);
        }

        public async Task AddCategory(Category category)
        {
            await _dbContext.Set<Category>().AddAsync(category);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateCategory(Category category)
        {
            var existingEntity = _dbContext.Set<Category>().Local.FirstOrDefault(e => e.Id == category.Id);
            if (existingEntity != null)
            {
                _dbContext.Entry(existingEntity).State = EntityState.Detached;
            }

            _dbContext.Entry(category).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteCategory(int id)
        {
            var category = await _dbContext.Set<Category>().FindAsync(id);
            if (category != null)
            {
                _dbContext.Set<Category>().Remove(category);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
