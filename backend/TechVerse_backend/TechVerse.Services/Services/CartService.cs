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
    public class CartService:ICartService
    {
        private readonly ICartRepository _cartRepository;

        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public async Task<IEnumerable<Cart>> GetAllCarts()
        {
            return await _cartRepository.GetAllCarts();
        }

        public async Task<Cart> GetCartById(int id)
        {
            return await _cartRepository.GetCartById(id);
        }

        public async Task AddCart(Cart cart)
        {
            if (ValidateCart(cart))
            {
                await _cartRepository.AddCart(cart);
            }
            else
            {
                throw new ArgumentException("Invalid cart data");
            }
        }

        public async Task UpdateCart(Cart cart)
        {
            await _cartRepository.UpdateCart(cart);
        }

        public async Task DeleteCart(int id)
        {
            await _cartRepository.DeleteCart(id);
        }

        private bool ValidateCart(Cart cart)
        {
            if (cart.Id != null)
            {
                return true;
            }
            return false;
        }
    }
}
