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
    public class OrderRepository:IOrderRepository
    {
        private readonly TechVerseContext _dbContext;

        public OrderRepository(TechVerseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Order>> GetAllOrders()
        {
            return await _dbContext.Set<Order>().ToListAsync();
        }

        public async Task<Order> GetOrderById(int id)
        {
            return await _dbContext.Set<Order>().FindAsync(id);
        }

        public async Task AddOrder(Order order)
        {
            await _dbContext.Set<Order>().AddAsync(order);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateOrder(Order order)
        {
            var existingEntity = _dbContext.Set<Order>().Local.FirstOrDefault(e => e.Id == order.Id);
            if (existingEntity != null)
            {
                _dbContext.Entry(existingEntity).State = EntityState.Detached;
            }

            _dbContext.Entry(order).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteOrder(int id)
        {
            var order = await _dbContext.Set<Order>().FindAsync(id);
            if (order != null)
            {
                _dbContext.Set<Order>().Remove(order);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
