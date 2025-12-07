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
        webApiShop_216339176Context _context;
        public LoginRepository(webApiShop_216339176Context webApiShop_216339176Context)
        {
            _context = webApiShop_216339176Context;
        }

        public async Task<User> Login(LoginUser user)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.UserName == user.UserName && u.Password == user.Password);
        }
    }
}