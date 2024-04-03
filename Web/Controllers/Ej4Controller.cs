using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class Ej4Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] int number1, [FromQuery] int number2)
        {
            if (number1 > number2)
            {
                return $"El numero {number1} es mayor";
            }
            else if (number1 < number2)
            {
                return $"El numero {number2} es mayor";
            }
            else
            {
                return $"Ambos numeros son iguales";
            }
        }
    }
}
