using Entities;

namespace Repositories
{
    public interface IOrdersRepository
    {
        Task<Order> AddOrder(Order order);
        Task<List<Order>> getAllOrders();
        Task<Order> getOrdersById(int id);
        Task<List<Order>> getOrdersForUser(User user);
        Task<Order> updateOrder(Order order, int id);
    }
}