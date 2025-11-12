using Entities;
using Repositories;
using Zxcvbn;
namespace Services
{

    public class UserServices()
    {
        PasswordService service = new PasswordService();
        UserRepository repository = new UserRepository();
        public User getUserByID(int id)
        {
            return repository.getUserByID(id);
        }
        public User addUser(User user)
        {
            if (service.getStrengthByPass(user.Password).strength < 2)
            {
                return null;
            }
            return repository.addUser(user);
        }
        public void UpdateUser(User userToUpdate)
        {
            repository.UpdateUser(userToUpdate);
        }
    }
}
