using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasswordController : ControllerBase
    {
        private readonly PasswordService _passwordService = new PasswordService();

        // POST api/<PasswordController>
        [HttpPost]
        public ActionResult<PasswordEntity> Post([FromBody] string password)
        {
            PasswordEntity passwordEntity = _passwordService.GetStrengthByPass(password);
            if (passwordEntity == null)
                return BadRequest("Invalid password");
            return Ok(passwordEntity);
        }
    }
}
