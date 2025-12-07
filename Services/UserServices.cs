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
<<<<<<< HEAD
        {
            _service = service;
            _repository = repository;
=======
        {
            _service = service;
            _repository = repository;
        }

        public User getUserByID(int id)
        {
            return _repository.getUserByID(id);
>>>>>>> a2a7b1af37d7aed8d93ab01dfe8282c82897ce94
        }

        public async Task<User> getUserByID(int id)
        {
<<<<<<< HEAD
            return await _repository.getUserByID(id);
        }
        public async Task<User> addUser(User user)
        {
=======
>>>>>>> a2a7b1af37d7aed8d93ab01dfe8282c82897ce94
            if (_service.getStrengthByPass(user.Password).strength < 2)
            {
                return null;
            }
<<<<<<< HEAD
            return await _repository.addUser(user);
        }
        public async Task<User> UpdateUser(User userToUpdate)
=======
            return _repository.addUser(user);
        }
        public User UpdateUser(User userToUpdate)
>>>>>>> a2a7b1af37d7aed8d93ab01dfe8282c82897ce94
        {
            if (_service.getStrengthByPass(userToUpdate.Password).strength < 2)
                return null;
            _repository.UpdateUser(userToUpdate);
            return userToUpdate;
        }
    }
}
