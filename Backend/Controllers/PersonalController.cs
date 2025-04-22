using Microsoft.AspNetCore.Mvc;
using Backend.Models;
using Backend.Data;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalController : ControllerBase
    {
        private readonly RepoPersonal _repository = new RepoPersonal();

        [HttpGet] //Mostrar
        public ActionResult<IEnumerable<Personal>> Get()
        {
            return Ok(_repository.Mostrar());
        }

        [HttpDelete("{dni}")] //Eliminar
        public ActionResult Delete(int dni)
        {
            _repository.Eliminar(dni);
            return Ok("El personal eliminado correctamente.");
        }

        [HttpPost] //Agregar
        public ActionResult Post([FromBody] Personal nuevoPersonal)
        {
            bool resultado = _repository.Insertar(nuevoPersonal._dni, nuevoPersonal._idGrado , nuevoPersonal._idArmEsp, nuevoPersonal._apellido, nuevoPersonal._nombre, nuevoPersonal._sNombre, nuevoPersonal._destino, nuevoPersonal._email);
            if(resultado)
            {
                return Ok("Personal insertado.");
            }
            else
            {
                return BadRequest("Error al insertar el personal");
            }
        }

        [HttpPut("{dni}")] //Modificar
        public ActionResult Put(int id, [FromBody] Personal personal)
        {
            bool resultado = _repository.Modificar(personal._dni, personal._idGrado, personal._idArmEsp, personal._apellido, personal._nombre, personal._sNombre, personal._destino, personal._email);
            if(resultado)
            {
                return Ok("Personal modificado");
            }
            else
            {
                return BadRequest("Error al midificar el personal.");
            }
        }
    }
}