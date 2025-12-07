using Entities;
using System.Text.Json;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserRepository : IUserRepository
    {
        //string filePath = "..\\file1.txt";
        webApiShop_216339176Context _context;
        public UserRepository(webApiShop_216339176Context webApiShop_216339176Context)
        {
            _context = webApiShop_216339176Context;
        }
        public async Task<User> getUserByID(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> addUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            if(getUserByID(user.Id) != null) 
                return user;
            return null;
        }

        public async Task<User> UpdateUser(User userToUpdate)
        {
            _context.Users.Update(userToUpdate);
            await _context.SaveChangesAsync();
            return userToUpdate;
        }
    }


}
