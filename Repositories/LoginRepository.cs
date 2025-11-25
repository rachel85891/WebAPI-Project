using Entities;
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
        private readonly string filePath = Path.Combine(Directory.GetCurrentDirectory(), "file1.txt");

        public User Login(LoginUser user)
        {
            using (StreamReader reader = System.IO.File.OpenText(filePath))
            {
                string? currentUserInFile;
                while ((currentUserInFile = reader.ReadLine()) != null)
                {
                    User fullUser = JsonSerializer.Deserialize<User>(currentUserInFile);
                    if (fullUser.UserName == user.UserName && fullUser.Password == user.Password)
                        return fullUser;
                }
            }
            return null;
        }
    }
}
