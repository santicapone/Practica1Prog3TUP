using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3linqController : ControllerBase
    {
        [HttpGet]
        public string[] Get([FromQuery] string[] words)
        {
            var query =
                from w in words
                where w.Substring(0, 1).ToLower() == "b" && w.Substring(1, 1).ToLower() == "r"
                select w;
            return query.ToArray();  
        }
    }
}
