using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej1linqController : ControllerBase
    {
        [HttpGet()]
        public int[] Get([FromQuery] int[] score)
        {
            score = [67, 92, 153, 15];

            var scorequery =
            from num in score
            where num > 30 && num < 100
            select num;

            return scorequery.ToArray();
        }
            
            

        
        
    }
}
