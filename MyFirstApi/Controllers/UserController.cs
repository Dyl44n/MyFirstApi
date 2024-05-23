using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult GetById([FromHeader] int id, [FromHeader] string? nickname)
        {
            var response = new User
            {
                Id = 1,
                Age = 20,
                Name = "Gabriel"
            };

            return Ok(response);
        }
    }
}
