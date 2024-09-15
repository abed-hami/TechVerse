﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechVerse.Core.Models;

namespace TechVerse.Services.Interfaces
{
    public interface ICouponService
    {
        Task<IEnumerable<Coupon>> GetAllCoupons();
        Task<Coupon> GetCouponById(int id);
        Task AddCoupon(Coupon coupon);
        Task UpdateCoupon(Coupon coupon);
        Task DeleteCoupon(int id);
    }
}
