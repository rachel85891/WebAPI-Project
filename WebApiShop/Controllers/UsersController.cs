using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Entities;
using Services;

namespace WebApiShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserServices _service;
        public UsersController(IUserServices service)
        {
            _service = service;
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Get(int id)
        {
            User user= await _service.GetUserByID(id);
            if(user == null) 
                return NotFound();
            return Ok(user);
        }
        
        // POST api/<UsersController>
        [HttpPost]
        public async Task<ActionResult<User>> Post([FromBody] User user)
        {
            user = await _service.AddUser(user);
            if (user == null)
            {
                return BadRequest("Password is too weak!");
            }
            return CreatedAtAction(nameof(Get), new {user.Id }, user);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id,[FromBody] User userToUpdate)
        {
            userToUpdate.Id = id;
            userToUpdate = await _service.UpdateUser(userToUpdate);
            if (userToUpdate == null)
                return BadRequest("Password is too weak!");
            else
                return NoContent();
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
