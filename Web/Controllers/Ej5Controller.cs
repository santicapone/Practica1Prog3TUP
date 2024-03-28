using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class Ej5Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] string day)
        {
            string[] daysWeek = ["lunes", "martes", "miercoles", "jueves", "viernes"];
            string[] daysWeekend = ["sabado", "domingo"];

            day = day.ToLower().Trim();

            if (daysWeek.Contains(day))
            {
                return "Ese dia NO pertenece al fin de semana";
            }
            else if (daysWeekend.Contains(day))
            {             
                return "Ese dia pertenece al fin de samana";
            }

            return "ERROR: El dia ingresado no coincide con ningun dia existente";
        }
    }
}

