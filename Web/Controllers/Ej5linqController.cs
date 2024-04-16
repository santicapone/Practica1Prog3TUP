using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5linqController : Controller
    {
        [HttpGet]
        public List<string> Get([FromQuery]List<int> num)
        {
            
            var query = 
                from n in num
                where n*n > 20
                select $"{n} | {n*n}";    
            return query.ToList();
        }
    }
}
