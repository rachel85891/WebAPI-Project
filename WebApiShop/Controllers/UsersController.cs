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
        {
            _service = service;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public string Get()
        {
            return "value";
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            User user= _service.getUserByID(id);
            if(user == null) 
                return NoContent();
            return Ok(user);

        }
        
        // POST api/<UsersController>
        [HttpPost]
        public ActionResult <User> POST([FromBody] User user)
        {
            user = _service.addUser(user);
            if (user == null)
            {
                return BadRequest("Password is too weak!");
            }
            return CreatedAtAction(nameof(Get), new {user.Id }, user);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public ActionResult<User> Put(int id,[FromBody] User userToUpdate)
        {
            userToUpdate.Id = id;
            userToUpdate =_service.UpdateUser(userToUpdate);
            if (userToUpdate == null)
                return BadRequest("Password is too weak!");
            else
                return Ok(userToUpdate);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
