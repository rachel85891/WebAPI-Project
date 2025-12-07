using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //public struct user
        //    {
        //    int userId;
        //    int id;
        //    string title;
        //    string body;
        //    };
        //    public user[] my_users = new user[5];
        //    int ind = 0;

        // GET: api/<UsersController>

        UserClass[] arr = new UserClass[10];
        int index = 0;
        [HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "Michal", "Racheli" };
        //}
        public UserClass[] Get()
        {
            return arr;
        }

        // GET api/<UsersController>/5

        [HttpGet("{id}")]
        public ActionResult<UserClass> GetByID(int id)
        {
            using (StreamReader reader = System.IO.File.OpenText("C:\\Users\\racheli\\Desktop\\file.txt"))
            {
                string? currentUserInFile;
                while ((currentUserInFile = reader.ReadLine()) != null)
                {
                    UserClass user = JsonSerializer.Deserialize<UserClass>(currentUserInFile);
                    if (user.UserID == id)
                        return Ok(user);
                }
            }
            return NoContent();      
        }
        

        // POST api/<UsersController>7
        [HttpPost]
        public ActionResult<UserClass> Post([FromBody] UserClass newUser)
        {
            int numberOfUsers = System.IO.File.ReadLines("C:\\Users\\racheli\\Desktop\\file.txt").Count();
            newUser.UserID = numberOfUsers + 1;
            string userJson = JsonSerializer.Serialize(newUser);
            System.IO.File.AppendAllText("C:\\Users\\racheli\\Desktop\\file.txt", userJson + Environment.NewLine);
            return CreatedAtAction(nameof(Get), new { newUser.UserID }, newUser);


        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] UserClass userToUpdate)
        {
            string textToReplace = string.Empty;
            using (StreamReader reader = System.IO.File.OpenText("C:\\Users\\racheli\\Desktop\\file.txt"))
            {
                string currentUserInFile;
                while ((currentUserInFile = reader.ReadLine()) != null)
                {

                    UserClass user = JsonSerializer.Deserialize<UserClass>(currentUserInFile);
                    if (user.UserID == id)
                        textToReplace = currentUserInFile;
                }
            }

            if (textToReplace != string.Empty)
            {
                string text = System.IO.File.ReadAllText("C:\\Users\\racheli\\Desktop\\file.txt");
                text = text.Replace(textToReplace, JsonSerializer.Serialize(userToUpdate));
                System.IO.File.WriteAllText("C:\\Users\\racheli\\Desktop\\file.txt", text);
            }
        }
        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
