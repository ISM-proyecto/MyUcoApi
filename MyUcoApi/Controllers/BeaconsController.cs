﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyUcoApi.Models;
using MyUcoApi.Repository;

namespace MyUcoApi.Controllers
{
    [Route("api/[controller]")]
    public class BeaconsController : Controller
    {
        private MyUcoRepository _repository;

        public BeaconsController(MyUcoRepository repository)
        {
            _repository = repository;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _repository.GetBeaconsAsync());
            }
            catch(Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
