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
    public class OrderItemRepository:IOrderItemRepository
    {
        private readonly TechVerseContext _dbContext;

        public OrderItemRepository(TechVerseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<OrderItem>> GetAllOrderItems()
        {
            return await _dbContext.Set<OrderItem>().ToListAsync();
        }

        public async Task<OrderItem> GetOrderItemById(int id)
        {
            return await _dbContext.Set<OrderItem>().FindAsync(id);
        }

        public async Task AddOrderItem(OrderItem item)
        {
            await _dbContext.Set<OrderItem>().AddAsync(item);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateOrderItem(OrderItem item)
        {
            var existingEntity = _dbContext.Set<OrderItem>().Local.FirstOrDefault(e => e.Id == item.Id);
            if (existingEntity != null)
            {
                _dbContext.Entry(existingEntity).State = EntityState.Detached;
            }

            _dbContext.Entry(item).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteOrderItem(int id)
        {
            var item = await _dbContext.Set<OrderItem>().FindAsync(id);
            if (item != null)
            {
                _dbContext.Set<OrderItem>().Remove(item);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
