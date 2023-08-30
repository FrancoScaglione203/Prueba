using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prueba.Entities;
using Prueba.DTOs;

namespace Prueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        [HttpGet]
        [Route("Usuarios")]
        public IActionResult Usuarios(bool todos)
        {
            if (todos)
            {
                return Ok("Todos los usuarios");
            }
            else
            {
                return Ok("Un usuario");
            }
        }


        [HttpPost]    
        public IActionResult Login(LoginDto login)  //Un objeto solo se puede mandar por body
        {
            if(login.usuario == "Franco" && login.clave == "1234")
            {
                return Ok("token: salio bien");
            }
            else 
            {
                return Unauthorized("Usuario o Clave Erronea");
            }
        }


        [HttpPut]
        [Route("Editar")]
        public IActionResult EditarLogin(LoginDto login)
        {
            login.usuario = "Franco";
            login.clave = "1234";
            return Ok(login);
        }


        [HttpDelete]
        [Route("Eliminar")]
        public IActionResult EliminarLogin(int id)
        {
            return Ok($"Se elimino el elemento {id} correctamente");  //Para mandar un parametro tengo que poner el signo pesos al inicio y
        }                                                              //el parametro entre corchetes

    }
}
