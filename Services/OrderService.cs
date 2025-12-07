using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class OrderService : IOrderService
    {
        IOrdersRepository _repository;

        public OrderService(IOrdersRepository repository)
        {
            _repository = repository;
        }

        public async Task<Order> getOrderById(int id)
        {
            return await _repository.getOrdersById(id);
        }
        public async Task<Order> addOrder(Order order)
        {
            return await _repository.AddOrder(order);
        }
    }
}
