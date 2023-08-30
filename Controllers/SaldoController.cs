using Microsoft.AspNetCore.Mvc;
using Prueba.Entities;
using Prueba.DTOs;

namespace Prueba.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SaldoController : ControllerBase
    {

        [HttpGet]    //Ejemplo de EndPoint
        [Route("Consultar")] //Funcion para agregar otra ruta
        public IActionResult Consultar()
        {
            return Ok(190);
        }

        [HttpPost]   //En un post es recomendable que devuelva un "Se guardo correctamente" o "Algo salio mal" o "El nombre ya existe"
        [Route("Agregar")]
        public IActionResult AgregarSaldo()   //FromBody para mandar por body
        {
            return Unauthorized("Hola");
        }
    }
}
