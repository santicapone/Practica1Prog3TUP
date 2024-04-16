﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2linqController : ControllerBase
    {
        [HttpGet()]
        public string[] Get([FromQuery] string[] words)
        {


            var query =
                from upper in words
                where upper.Length > 4 
                select upper.ToUpper();

            return query.ToArray();
        }
    }
}
