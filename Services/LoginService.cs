using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class LoginService
    {
        private readonly LoginRepository _loginRepository = new LoginRepository();
        
        public User Login(LoginUser user)
        {
            return _loginRepository.Login(user);
        }
    }
}
