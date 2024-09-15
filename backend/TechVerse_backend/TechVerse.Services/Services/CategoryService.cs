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
    public class CategoryService:ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _categoryRepository.GetAllCategories();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _categoryRepository.GetCategoryById(id);
        }

        public async Task AddCategory(Category category)
        {
            if (ValidateCategory(category))
            {
                await _categoryRepository.AddCategory(category);
            }
            else
            {
                throw new ArgumentException("Invalid category data");
            }
        }

        public async Task UpdateCategory(Category category)
        {
            await _categoryRepository.UpdateCategory(category);
        }

        public async Task DeleteCategory(int id)
        {
            await _categoryRepository.DeleteCategory(id);
        }

        private bool ValidateCategory(Category category)
        {
            if (category.Id != null)
            {
                return true;
            }
            return false;
        }
    }
}
