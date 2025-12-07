using Entities;
using Repositories;
using Zxcvbn;
namespace Services
{

    public class UserServices : IUserServices
    {

        private readonly IPasswordService _service;
        private readonly IUserRepository _repository;

        public UserServices(IPasswordService service, IUserRepository repository)
        {
            _service = service;
            _repository = repository;
        }

        public async Task<User> getUserByID(int id)
        {
            return await _repository.getUserByID(id);
        }
        public async Task<User> addUser(User user)
        {
            if (_service.getStrengthByPass(user.Password).strength < 2)
            {
                return null;
            }
            return await _repository.addUser(user);
        }
        public async Task<User> UpdateUser(User userToUpdate)
        {
            if (_service.getStrengthByPass(userToUpdate.Password).strength < 2)
                return null;
            _repository.UpdateUser(userToUpdate);
            return userToUpdate;
        }
    }
}
