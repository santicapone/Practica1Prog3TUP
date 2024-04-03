using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj1Controller : ControllerBase
    {
        [HttpGet()]
        public int[] Get([FromQuery] int[] inputList)
        {

            var numQuery =
                from num in inputList
                where num > 30 && num < 100
                select num;

            return numQuery.ToArray();
        }
    }
}
