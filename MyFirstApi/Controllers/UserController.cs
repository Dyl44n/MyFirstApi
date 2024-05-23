﻿using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("{id}/{nickname}")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult Get(int id, string nickname)
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
