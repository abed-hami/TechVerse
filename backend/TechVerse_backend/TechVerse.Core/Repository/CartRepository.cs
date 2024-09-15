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
    public class CartRepository:ICartRepository
    {
        private readonly TechVerseContext _dbContext;

        public CartRepository(TechVerseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Cart>> GetAllCarts()
        {
            return await _dbContext.Set<Cart>().ToListAsync();
        }

        public async Task<Cart> GetCartById(int id)
        {
            return await _dbContext.Set<Cart>().FindAsync(id);
        }

        public async Task AddCart(Cart cart)
        {
            await _dbContext.Set<Cart>().AddAsync(cart);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateCart(Cart cart)
        {
            var existingEntity = _dbContext.Set<Cart>().Local.FirstOrDefault(e => e.Id == cart.Id);
            if (existingEntity != null)
            {
                _dbContext.Entry(existingEntity).State = EntityState.Detached;
            }

            _dbContext.Entry(cart).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteCart(int id)
        {
            var cart = await _dbContext.Set<Cart>().FindAsync(id);
            if (cart != null)
            {
                _dbContext.Set<Cart>().Remove(cart);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
