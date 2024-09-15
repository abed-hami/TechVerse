using TechVerse.Core.Models;
using AutoMapper;
using TechVerse_backend.Resources;

namespace TechVerse_backend.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile() {

            CreateMap<CartResources,Cart >();
            CreateMap<Cart, CartResources>();

            CreateMap<Order, OrderResources>();
            CreateMap<OrderResources, Order >();

            CreateMap<Category, CategoryResources>();
            CreateMap<CategoryResources, Category >();

            CreateMap<CouponResources, Coupon >();
            CreateMap<Coupon, CouponResources>();
            
            CreateMap<GiftCard, GiftCardResources>();
            CreateMap<GiftCardResources, GiftCard>();

            CreateMap<CartItem, CartItemResources>();
            CreateMap<CartItemResources, CartItem>();

            CreateMap<OrderItem, OrderItemResources>();
            CreateMap<OrderItemResources, OrderItem>();

            CreateMap<Payment, PaymentResources>();
            CreateMap<PaymentResources, Payment>();

            CreateMap<Product, ProductResources>();
            CreateMap<ProductResources, Product>();

            CreateMap<ProductVariant, ProductVariantResources>();
            CreateMap<ProductVariantResources, ProductVariant>();

            CreateMap<User, UserResources>();
            CreateMap<UserResources, User>();

        }
    }
}
