﻿using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Communication.Requests;
using MyFirstApi.Communication.Responses;

namespace MyFirstApi.Controllers

{
    public class UserController : MyFirstApiBaseController
    {
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult GetById([FromRoute] int id)
        {
            var response = new User
            {
                Id = 1,
                Age = 20,
                Name = "Gabriel"
            };

            return Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status201Created)]
        public IActionResult Creat([FromBody]RequestRegisterUserJson request)
        {
            var response = new ResponseRegisteredUserJson
            {
                Id = 1,
                Name = request.Name,
            };

            return Created(string.Empty, response);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Update([FromBody] RequestUpdateUserProfileJson request)
        {
            return NoContent();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete()
        {
            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]

        public IActionResult GetAll() 
        {
            var response = new List<User>()
            {
                new User { Id = 1, Age = 20, Name = "Gabriel" },
                new User { Id = 2, Age = 20, Name = "Maria" }
            };



            var key = GetCustomKey();

            return Ok(key);

        }

        [HttpPut("change-password")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult ChangePassword([FromBody] RequestChangePasswordJson request)
        {
            return NoContent();
        }
    }
}
