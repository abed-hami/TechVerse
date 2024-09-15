using System.Collections.Generic;
using System.Threading.Tasks;
using TechVerse.Core.Models;

namespace TechVerse.Core.Interfaces
{
    public interface ICartItemRepository
    {
        Task<IEnumerable<CartItem>> GetAllCartItems();
        Task<CartItem> GetCartItemById(int id);
        Task AddCartItem(CartItem item);
        Task UpdateCartItem(CartItem item);
        Task DeleteCartItem(int id);
    }
}
