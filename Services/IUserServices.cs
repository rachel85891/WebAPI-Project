using Entities;

namespace Services
{
    public interface IUserServices
    {
        User addUser(User user);
        User getUserByID(int id);
        User? UpdateUser(User userToUpdate);
    }
}