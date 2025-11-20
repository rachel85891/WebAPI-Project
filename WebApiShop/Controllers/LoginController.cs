using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Entities;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginService _loginService = new LoginService();

        // POST api/<LoginController>
        [HttpPost]
        public ActionResult<User> Post([FromBody] LoginUser loginUser)
        {
            User user = _loginService.Login(loginUser);
            if (user == null) 
                return Unauthorized();
            return Ok(user);
        }
    }
}
