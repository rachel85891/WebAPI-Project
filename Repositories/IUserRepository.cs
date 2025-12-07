using Entities;

namespace Repositories
{
    public interface IUserRepository
    {
        Task<User> addUser(User user);
        Task<User> getUserByID(int id);
        Task<User> UpdateUser(User userToUpdate);
    }
}