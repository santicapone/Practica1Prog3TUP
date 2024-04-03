using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] double inputPrice, [FromQuery] string paymentMethod , [FromQuery] string cardNumber = null)
        {
            string response;

            if (inputPrice <= 0)
            {
                return "Costo no puede ser menor o igual a 0";
            }

            if (paymentMethod.Equals("tarjeta", StringComparison.OrdinalIgnoreCase)) 
            {   
                if (cardNumber == null || cardNumber.Length != 16)
                {
                    return "El numero de tarjeta tiene que tener 16 digitos";
                }

                double total = inputPrice * 1.10;
                response = $"El valor a pagar con tarjeta es: {total}";
                return response ;
            }
            else if(paymentMethod.Equals("efectivo", StringComparison.OrdinalIgnoreCase))
            {
                response = $"El valor a pagar con efectivo es: {inputPrice}";
                return response;
            }
            else
            {
                response = "La forma de pago no es válida. Debe ser 'efectivo' o 'tarjeta'.";
                return response;
            }
        }
    }
}
