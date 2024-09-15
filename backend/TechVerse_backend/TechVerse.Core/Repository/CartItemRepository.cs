using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechVerse.Core.Interfaces;
using TechVerse.Core.Models;

namespace TechVerse.Core.Repository
{
    public class CartItemRepository : ICartItemRepository
    {
        private readonly TechVerseContext _dbContext;

        public CartItemRepository(TechVerseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<CartItem>> GetAllCartItems()
        {
            return await _dbContext.Set<CartItem>().ToListAsync();
        }

        public async Task<CartItem> GetCartItemById(int id)
        {
            return await _dbContext.Set<CartItem>().FindAsync(id);
        }

        public async Task AddCartItem(CartItem item)
        {
            await _dbContext.Set<CartItem>().AddAsync(item);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateCartItem(CartItem item)
        {
            var existingEntity = _dbContext.Set<CartItem>().Local.FirstOrDefault(e => e.Id == item.Id);
            if (existingEntity != null)
            {
                _dbContext.Entry(existingEntity).State = EntityState.Detached;
            }

            _dbContext.Entry(item).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteCartItem(int id)
        {
            var item = await _dbContext.Set<CartItem>().FindAsync(id);
            if (item != null)
            {
                _dbContext.Set<CartItem>().Remove(item);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
