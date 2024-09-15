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
    public class CouponService:ICouponService
    {
        private readonly ICouponRepository _couponRepository;

        public CouponService(ICouponRepository couponRepository)
        {
            _couponRepository = couponRepository;
        }

        public async Task<IEnumerable<Coupon>> GetAllCoupons()
        {
            return await _couponRepository.GetAllCoupons();
        }

        public async Task<Coupon> GetCouponById(int id)
        {
            return await _couponRepository.GetCouponById(id);
        }

        public async Task AddCoupon(Coupon coupon)
        {
            if (ValidateCoupon(coupon))
            {
                await _couponRepository.AddCoupon(coupon);
            }
            else
            {
                throw new ArgumentException("Invalid coupon data");
            }
        }

        public async Task UpdateCoupon(Coupon coupon)
        {
            await _couponRepository.UpdateCoupon(coupon);
        }

        public async Task DeleteCoupon(int id)
        {
            await _couponRepository.DeleteCoupon(id);
        }

        private bool ValidateCoupon(Coupon coupon)
        {
            if (coupon.Id != null)
            {
                return true;
            }
            return false;
        }
    }
}
