using Microsoft.AspNetCore.Mvc;
using Backend.Models;
using Backend.Data;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradoController : ControllerBase
    {
        private readonly RepoGrado _repository = new RepoGrado();

        [HttpGet] //Mostrar
        public ActionResult<IEnumerable<Grado>> Get()
        {
            return Ok(_repository.Mostrar());
        }

        [HttpDelete("{id}")] //Eliminar
        public ActionResult Delete(int id)
        {
            _repository.Eliminar(id);
            return Ok("Grado eliminado correctamente.");
        }

        [HttpPost] //Agregar
        public ActionResult Post([FromBody] Grado nuevoGrado)
        {
            bool resultado = _repository.Insertar(nuevoGrado._idGrado, nuevoGrado._abreviatura, nuevoGrado._grado);
            if(resultado)
            {
                return Ok("Grado insertado.");
            }
            else
            {
                return BadRequest("Error al insertar el grado");
            }
        }

        [HttpPut("{id}")] //Modificar
        public ActionResult Put(int id, [FromBody] Grado grado)
        {
            bool resultado = _repository.Modificar(grado._idGrado, grado._abreviatura, grado._grado);
            if(resultado)
            {
                return Ok("Grado modificado");
            }
            else
            {
                return BadRequest("Error al midificar el grado.");
            }
        }
    }
}