using Entities;

namespace Repositories
{
    public interface IUserRepository
    {
        User addUser(User user);
        User getUserByID(int id);
        User UpdateUser(User userToUpdate);
    }
}