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
    public class OrderService:IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<IEnumerable<Order>> GetAllOrders()
        {
            return await _orderRepository.GetAllOrders();
        }

        public async Task<Order> GetOrderById(int id)
        {
            return await _orderRepository.GetOrderById(id);
        }

        public async Task AddOrder(Order order)
        {
            if (ValidateOrder(order))
            {
                await _orderRepository.AddOrder(order);
            }
            else
            {
                throw new ArgumentException("Invalid order data");
            }
        }

        public async Task UpdateOrder(Order order)
        {
            await _orderRepository.UpdateOrder(order);
        }

        public async Task DeleteOrder(int id)
        {
            await _orderRepository.DeleteOrder(id);
        }

        private bool ValidateOrder(Order order)
        {
            if (order.Id != null)
            {
                return true;
            }
            return false;
        }
    }
}
