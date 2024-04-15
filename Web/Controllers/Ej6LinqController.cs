using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6LinqController : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<string> words)
        {

            var query =
                from n in words
                select n.Replace("ia", "*");

            return query.ToList();
        }
    }
}
