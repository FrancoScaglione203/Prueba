using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prueba.Entities;
using Prueba.DTOs;
using System.ComponentModel.DataAnnotations;

namespace Prueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        //[AllowAnonymous] = puede entrar cualquier persona
        //[Authorize] = recibe JWT para validar el uso de la API
        //Irian abajo del verbo http

        /// <summary>
        /// Obtiene todos los usuarios
        /// </summary>
        /// <param name="todos">Valor booleano</param>
        /// <returns>Todos los usuarios</returns>
        [HttpGet]
        [Route("Usuarios")]
        public IActionResult Usuarios(bool todos)
        {
            try  //En el try pongo todo la logica y en el catch iria lo que devuelve si rompe algo de la logica dentro del try
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
            catch (Exception ex)  //Lo ideal en el catch es hacer un Log que devuelva la excepcion
            {
                //Log (ex.Message)
                return BadRequest("Contacte a sistemas");
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
