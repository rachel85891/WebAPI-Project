using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Repositories
{
    public class LoginRepository : ILoginRepository
    {
<<<<<<< HEAD
        webApiShop_216339176Context _context;
        public LoginRepository(webApiShop_216339176Context webApiShop_216339176Context)
=======
        string filePath = "..\\file1.txt";

        public User Login(LoginUser user)
>>>>>>> a2a7b1af37d7aed8d93ab01dfe8282c82897ce94
        {
            _context = webApiShop_216339176Context;
        }

        public async Task<User> Login(LoginUser user)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.UserName == user.UserName && u.Password == user.Password);
        }
    }
}