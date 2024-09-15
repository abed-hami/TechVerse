using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TechVerse.Core.Interfaces;
using TechVerse.Services.Interfaces;
using TechVerse.Core.Models;

namespace TechVerse.Services.Services
{
    public class CartItemService : ICartItemService
    {
        private readonly ICartItemRepository _cartItemRepository;

        public CartItemService(ICartItemRepository cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }

        public async Task<IEnumerable<CartItem>> GetAllCartItems()
        {
            return await _cartItemRepository.GetAllCartItems();
        }

        public async Task<CartItem> GetCartItemById(int id)
        {
            return await _cartItemRepository.GetCartItemById(id);
        }

        public async Task AddCartItem(CartItem cartItem)
        {
            if (ValidateCartItem(cartItem))
            {
                await _cartItemRepository.AddCartItem(cartItem);
            }
            else
            {
                throw new ArgumentException("Invalid cartItem data");
            }
        }

        public async Task UpdateCartItem(CartItem cartItem)
        {
            await _cartItemRepository.UpdateCartItem(cartItem);
        }

        public async Task DeleteCartItem(int id)
        {
            await _cartItemRepository.DeleteCartItem(id);
        }

        private bool ValidateCartItem(CartItem cartItem)
        {
            if (cartItem.Id != null)
            {
                return true;
            }
            return false;
        }
    }
}
