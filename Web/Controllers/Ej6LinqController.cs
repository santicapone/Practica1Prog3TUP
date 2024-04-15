using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6LinqController : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<string> list)
        {
            var query =
                from word in list
                select word.Replace("ia", "*");

            return query.ToList();
        }
    }
}