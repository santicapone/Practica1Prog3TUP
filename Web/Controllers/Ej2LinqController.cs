using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2LinqController : ControllerBase
    {
        [HttpGet()]
        public string[] Get([FromQuery] List<string> words)
        {
            var query =
                from w in words
                where w.Length > 4
                select w.ToUpper();

            return query.ToArray();
        }       
    }
}
