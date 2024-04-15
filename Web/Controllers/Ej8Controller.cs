using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej8Controller : ControllerBase
    {
        [HttpGet()]
        public int Get()
        {
            int cont = 1;

            while (cont < 100)
            {
                cont++;
            }

            return cont; // que retorne el ultimo numero para verificar que llego bien al contado
        }
    }
}