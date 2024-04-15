using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej1LinqController : ControllerBase
    {
        [HttpGet()]
        public List<int> Get([FromQuery] List<int> oneList)
        {
            var filteredList = oneList.Where(x => x > 30 && x < 100).ToList();
            return filteredList;
            

        }
    }
}

