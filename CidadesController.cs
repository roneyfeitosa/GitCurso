﻿using CRUDVacinas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CRUDVacinas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CidadesController : ControllerBase
    {
        //[HttpGet("")]
        //public IActionResult Get()
        //{
        //    return new Cidade(){ Nome = "Recife" });
        //}

        /*
        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(new Cidade());

        }
        [Route("api/[controller]")]
        */
    }
}
