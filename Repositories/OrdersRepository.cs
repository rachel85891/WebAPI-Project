using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        webApiShop_216339176Context _context;
        public OrdersRepository(webApiShop_216339176Context webApiShop_216339176Context)
        {
            _context = webApiShop_216339176Context;
        }

        public async Task<List<Order>> getAllOrders()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<List<Order>> getOrdersForUser(User user)
        {
            return await _context.Orders.Where(u => u.UserId == user.Id).ToListAsync();
        }

        public async Task<Order> getOrdersById(int id)
        {
            return await _context.Orders.FindAsync(id);
        }

        public async Task<Order> AddOrder(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
            if(getOrdersById(order.OrderId) != null) 
                return order;
            return null;
        }

        public async Task<Order> updateOrder(Order order, int id)
        {
            _context.Orders.Update(order);
            await _context.SaveChangesAsync();
            return order;
        }

        //public async Task DeleteOrder(int id)
        //{
        //    await _context.Orders.ExecuteDeleteAsync(await getOrdersById(id));
        //    await _context.SaveChangesAsync();
        //}
    }
}
