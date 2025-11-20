using Entities;
using Repositories;
using Zxcvbn;
namespace Services
{

    public class UserServices()
    {
        private readonly PasswordService _passwordService = new PasswordService();
        private readonly UserRepository _userRepository = new UserRepository();
        
        public User GetUserByID(int id)
        {
            return _userRepository.GetUserByID(id);
        }
        
        public User AddUser(User user)
        {
            if (_passwordService.GetStrengthByPass(user.Password).Strength < 2)
            {
                return null;
            }
            return _userRepository.AddUser(user);
        }
        
        public void UpdateUser(User userToUpdate)
        {
            _userRepository.UpdateUser(userToUpdate);
        }
    }
}
