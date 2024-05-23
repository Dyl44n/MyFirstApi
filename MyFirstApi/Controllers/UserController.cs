using Microsoft.AspNetCore.Mvc;
using System.Net.Cache;

namespace MyFirstApi.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var response = new Response
            {
                Age = 20,
                Name = "Gabriel"
            };

            return Ok(response);
        }
    }
}
