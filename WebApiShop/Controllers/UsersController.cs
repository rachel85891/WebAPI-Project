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
        private readonly UserServices _userServices = new UserServices();

        /

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            User user = _userServices.GetUserByID(id);
            if(user == null) 
                return NotFound();
            return Ok(user);

        }
        
        // POST api/<UsersController>
        [HttpPost]
        public ActionResult<User> Post([FromBody] User user)
        {
            user = _userServices.AddUser(user);
            if (user == null)
            {
                return BadRequest("Password is not strong enough");
            }
            return CreatedAtAction(nameof(Get), new {user.Id }, user);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] User userToUpdate)
        {
            _userServices.UpdateUser(userToUpdate);
            return NoContent();
        }
    }
}
