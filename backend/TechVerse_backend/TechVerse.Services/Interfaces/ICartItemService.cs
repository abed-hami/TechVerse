using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechVerse.Core.Models;

namespace TechVerse.Services.Interfaces
{
    public interface ICartItemService
    {
        Task<IEnumerable<CartItem>> GetAllCartItems();
        Task<CartItem> GetCartItemById(int id);
        Task AddCartItem(CartItem item);
        Task UpdateCartItem(CartItem item);
        Task DeleteCartItem(int id);
    }
}
