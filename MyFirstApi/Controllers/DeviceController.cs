﻿using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Entities;

namespace MyFirstApi.Controllers
{
    public class DeviceController : MyFirstApiBaseController
    {
        [HttpGet]
        public IActionResult Get()
        {
            var laptop = new Laptop();

            var x = laptop.IsConnected();

            var model = laptop.GetModel();

            return Ok(model);
        }
    }
}