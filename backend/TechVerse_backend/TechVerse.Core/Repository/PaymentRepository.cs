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
    public class PaymentRepository:IPaymentRepository
    {
        private readonly TechVerseContext _dbContext;

        public PaymentRepository(TechVerseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Payment>> GetAllPayments()
        {
            return await _dbContext.Set<Payment>().ToListAsync();
        }

        public async Task<Payment> GetPaymentById(int id)
        {
            return await _dbContext.Set<Payment>().FindAsync(id);
        }

        public async Task AddPayment(Payment payment)
        {
            await _dbContext.Set<Payment>().AddAsync(payment);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdatePayment(Payment payment)
        {
            var existingEntity = _dbContext.Set<Payment>().Local.FirstOrDefault(e => e.Id == payment.Id);
            if (existingEntity != null)
            {
                _dbContext.Entry(existingEntity).State = EntityState.Detached;
            }

            _dbContext.Entry(payment).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeletePayment(int id)
        {
            var payment = await _dbContext.Set<Payment>().FindAsync(id);
            if (payment != null)
            {
                _dbContext.Set<Payment>().Remove(payment);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
