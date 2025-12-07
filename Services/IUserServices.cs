using Entities;

namespace Services
{
    public interface IUserServices
    {
        Task<User?> addUser(User user);
        Task<User> getUserByID(int id);
        Task<User?> UpdateUser(User userToUpdate);
    }
}