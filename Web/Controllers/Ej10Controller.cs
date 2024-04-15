using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class Ej10Controller : ControllerBase
    {
        [HttpGet()]
        public string Get()
        {
            List<int> pairNumbers = [];
            List<int> divisibleBy3 = [];

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    pairNumbers.Add(i);
                    
                    if (i % 3 == 0) // si es par y divisible por 3
                    {
                        divisibleBy3.Add(i);
                    }
                }
                else if (i % 3 == 0)
                {
                    divisibleBy3.Add(i);
                }
            }


            return $"Los numeros pares: {string.Join(", ", pairNumbers)}\nLos divisibles por 3: {string.Join(", ", divisibleBy3)}";
        }
    }
}