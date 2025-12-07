using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Entities;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserServices _service;
        public UsersController(IUserServices service)
<<<<<<< HEAD
=======
        {
            _service = service;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public string Get()
>>>>>>> a2a7b1af37d7aed8d93ab01dfe8282c82897ce94
        {
            _service = service;
        }

        //// GET: api/<UsersController>
        //[HttpGet]
        //public string Get()
        //{
        //    return "value";
        //}

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>>Get(int id)
        {
<<<<<<< HEAD
            User user= await _service.getUserByID(id);
=======
            User user= _service.getUserByID(id);
>>>>>>> a2a7b1af37d7aed8d93ab01dfe8282c82897ce94
            if(user == null) 
                return NoContent();
            return Ok(user);

        }
        
        // POST api/<UsersController>
        [HttpPost]
        public async Task<ActionResult<User>> POST([FromBody] User user)
        {
<<<<<<< HEAD
            user = await _service.addUser(user);
=======
            user = _service.addUser(user);
>>>>>>> a2a7b1af37d7aed8d93ab01dfe8282c82897ce94
            if (user == null)
            {
                return BadRequest("Password is too weak!");
            }
            return CreatedAtAction(nameof(Get), new {user.Id }, user);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
<<<<<<< HEAD
        public async Task<ActionResult<User>> Put(int id,[FromBody] User userToUpdate)
        {
            userToUpdate.Id = id;
            userToUpdate =await _service.UpdateUser(userToUpdate);
=======
        public ActionResult<User> Put(int id,[FromBody] User userToUpdate)
        {
            userToUpdate.Id = id;
            userToUpdate =_service.UpdateUser(userToUpdate);
>>>>>>> a2a7b1af37d7aed8d93ab01dfe8282c82897ce94
            if (userToUpdate == null)
                return BadRequest("Password is too weak!");
            else
                return Ok(userToUpdate);
        }

        //// DELETE api/<UsersController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
