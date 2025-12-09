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

        public async Task<User> GetUserByID(int id)
        {
            return await _repository.GetUserByID(id);
        }
        public async Task<User> AddUser(User user)
        {
            if (_service.GetStrengthByPass(user.Password).strength < 2)
            {
                return null;
            }
            return await _repository.AddUser(user);
        }
        public async Task<User> UpdateUser(User userToUpdate)
        {
            if (_service.GetStrengthByPass(userToUpdate.Password).strength < 2)
                return null;
            await _repository.UpdateUser(userToUpdate);
            return userToUpdate;
        }
    }
}
