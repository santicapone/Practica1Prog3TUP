using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4linqController : ControllerBase
    {
        [HttpGet]
        public List<int> Get([FromQuery] List<int> num)
        {
           var query = 
                (from n in num
                where n > 0
                select n).ToList();
                return query;
        }
    }
}
