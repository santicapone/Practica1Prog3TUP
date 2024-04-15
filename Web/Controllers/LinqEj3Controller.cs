using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace web.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj3Controller : ControllerBase
    {
        [HttpGet]
        public List<string> Get([FromQuery] List<string> lista)
        {
            var query = from string l in lista
                        where l[0].ToString() == "b" && l.EndsWith('r')
                        select l;

            return query.ToList();
        }
    }
}

//3) Escriba una consulta que devuelva las palabras que empiezan por la letra "b" y terminan con la letra "r".
//Ejemplo: "ventilador", "reloj", "buscador" → "buscador"