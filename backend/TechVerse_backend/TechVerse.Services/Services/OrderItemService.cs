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
    public class OrderItemService:IOrderItemService
    {
        private readonly IOrderItemRepository _orderItemRepository;

        public OrderItemService(IOrderItemRepository orderItemRepository)
        {
            _orderItemRepository = orderItemRepository;
        }

        public async Task<IEnumerable<OrderItem>> GetAllOrderItems()
        {
            return await _orderItemRepository.GetAllOrderItems();
        }

        public async Task<OrderItem> GetOrderItemById(int id)
        {
            return await _orderItemRepository.GetOrderItemById(id);
        }

        public async Task AddOrderItem(OrderItem orderItem)
        {
            if (ValidateOrderItem(orderItem))
            {
                await _orderItemRepository.AddOrderItem(orderItem);
            }
            else
            {
                throw new ArgumentException("Invalid orderItem data");
            }
        }

        public async Task UpdateOrderItem(OrderItem orderItem)
        {
            await _orderItemRepository.UpdateOrderItem(orderItem);
        }

        public async Task DeleteOrderItem(int id)
        {
            await _orderItemRepository.DeleteOrderItem(id);
        }

        private bool ValidateOrderItem(OrderItem orderItem)
        {
            if (orderItem.Id != null)
            {
                return true;
            }
            return false;
        }
    }
}
