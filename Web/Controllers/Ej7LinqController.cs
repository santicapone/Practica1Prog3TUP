using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej7LinqController : ControllerBase
    {
        [HttpGet()]
        public IList<string> Get([FromQuery] string words)
        {
            return DevolverPalabrasCapitales(words);
        }
        public static IList<string> DevolverPalabrasCapitales(string cadena)
        {
            var splitChain = cadena.Split(" ");

            var query =
                from word in splitChain
                where word == (word.ToUpper())
                select word;

            return query.ToList();
        }
    }
}