using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechVerse.Core.Models;

namespace TechVerse.Core.Interfaces
{
    public interface IOrderItemRepository
    {   
        Task<IEnumerable<OrderItem>> GetAllOrderItems();
        Task<OrderItem> GetOrderItemById(int id);
        Task AddOrderItem(OrderItem item);
        Task UpdateOrderItem(OrderItem item);
        Task DeleteOrderItem(int id);
    }
}
