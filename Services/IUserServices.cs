using Entities;

namespace Services
{
    public interface IUserServices
    {
<<<<<<< HEAD
        Task<User?> addUser(User user);
        Task<User> getUserByID(int id);
        Task<User?> UpdateUser(User userToUpdate);
=======
        User addUser(User user);
        User getUserByID(int id);
        User? UpdateUser(User userToUpdate);
>>>>>>> a2a7b1af37d7aed8d93ab01dfe8282c82897ce94
    }
}