using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        IOrderService _service;
        public OrdersController(IOrderService service)
        {
            _service = service;
        }
        //// GET: api/<OrdersController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> Get(int id)
        {
            return await _service.getOrderById(id);
        }

        // POST api/<OrdersController>
        [HttpPost]
        public async Task<ActionResult<Order>> Post([FromBody] Order order)
        {
            order = await _service.addOrder(order);
            if (order == null)
                return NoContent();
            return Ok(order);
        }

        //// PUT api/<OrdersController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<OrdersController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
