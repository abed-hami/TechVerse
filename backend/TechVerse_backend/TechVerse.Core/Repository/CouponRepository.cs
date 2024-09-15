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
    public class CouponRepository:ICouponRepository
    {
        private readonly TechVerseContext _dbContext;

        public CouponRepository(TechVerseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Coupon>> GetAllCoupons()
        {
            return await _dbContext.Set<Coupon>().ToListAsync();
        }

        public async Task<Coupon> GetCouponById(int id)
        {
            return await _dbContext.Set<Coupon>().FindAsync(id);
        }

        public async Task AddCoupon(Coupon coupon)
        {
            await _dbContext.Set<Coupon>().AddAsync(coupon);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateCoupon(Coupon coupon)
        {
            var existingEntity = _dbContext.Set<Coupon>().Local.FirstOrDefault(e => e.Id == coupon.Id);
            if (existingEntity != null)
            {
                _dbContext.Entry(existingEntity).State = EntityState.Detached;
            }

            _dbContext.Entry(coupon).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteCoupon(int id)
        {
            var coupon = await _dbContext.Set<Coupon>().FindAsync(id);
            if (coupon != null)
            {
                _dbContext.Set<Coupon>().Remove(coupon);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
