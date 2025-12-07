using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _repository; 

        public LoginService(ILoginRepository repository)
<<<<<<< HEAD
        {
            _repository = repository;
        }

        public async Task<User> Login(LoginUser user)
        {
            return await _repository.Login(user);
=======
        {
            _repository = repository;
        }

        public User Login(LoginUser user)
        {
            return _repository.Login(user);
>>>>>>> a2a7b1af37d7aed8d93ab01dfe8282c82897ce94
        }
    }
}
