using Entities;
using System.Text.Json;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserRepository : IUserRepository
    {
<<<<<<< HEAD
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
=======
        string filePath = "..\\file1.txt";
        public User getUserByID(int id)
        {
            using (StreamReader reader = System.IO.File.OpenText(filePath))
            {
                string? currentUserInFile;
                while ((currentUserInFile = reader.ReadLine()) != null)
                {
                    User user = JsonSerializer.Deserialize<User>(currentUserInFile);
                    if (user.Id == id)
                        return user;
                }
            }
>>>>>>> a2a7b1af37d7aed8d93ab01dfe8282c82897ce94
            return null;
        }

        public async Task<User> UpdateUser(User userToUpdate)
        {
<<<<<<< HEAD
            _context.Users.Update(userToUpdate);
            await _context.SaveChangesAsync();
=======
            int numberOfUsers = System.IO.File.ReadLines(filePath).Count();
            user.Id = numberOfUsers + 1;
            string userJson = JsonSerializer.Serialize(user);
            System.IO.File.AppendAllText(filePath, userJson + Environment.NewLine);
            return user;
        }

        public User UpdateUser(User userToUpdate)
        {
            string textToReplace = string.Empty;
            using (StreamReader reader = System.IO.File.OpenText(filePath))
            {
                string currentUserInFile;
                while ((currentUserInFile = reader.ReadLine()) != null)
                {

                    User user = JsonSerializer.Deserialize<User>(currentUserInFile);
                    if (user.Id == userToUpdate.Id)
                        textToReplace = currentUserInFile;
                }
            }
            if (textToReplace != string.Empty)
            {
                string text = System.IO.File.ReadAllText(filePath);
                text = text.Replace(textToReplace, JsonSerializer.Serialize(userToUpdate));
                System.IO.File.WriteAllText(filePath, text);
            }
>>>>>>> a2a7b1af37d7aed8d93ab01dfe8282c82897ce94
            return userToUpdate;
        }
    }


}
