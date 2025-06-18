using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniClinicaApp.Api.Data;
using MiniClinicaApp.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiniClinicaApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PacienteController(AppDbContext context)
        {
            _context = context;
        }

        // POST: api/Paciente/Crear
        [HttpPost("Crear")]
        public async Task<IActionResult> CrearPaciente([FromBody] Paciente paciente)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _context.Pacientes.AddAsync(paciente);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(VerPaciente), new { id = paciente.Id }, paciente);
        }

        // GET: api/Paciente/Lista
        [HttpGet("Lista")]
        public async Task<ActionResult<IEnumerable<Paciente>>> ListaPaciente()
        {
            var pacientes = await _context.Pacientes.ToListAsync();
            return Ok(pacientes);
        }

        // GET: api/Paciente/Ver/5
        [HttpGet("Ver/{id}")]
        public async Task<IActionResult> VerPaciente(int id)
        {
            var paciente = await _context.Pacientes.FindAsync(id);

            if (paciente == null)
                return NotFound($"No se encontró el paciente con ID {id}");

            return Ok(paciente);
        }


        // PUT: api/Paciente/Editar/5
        [HttpPut("Editar/{id}")]
        public async Task<IActionResult> ActualizarPaciente(int id, [FromBody] Paciente paciente)
        {
            if (id != paciente.Id)
                return BadRequest("El ID del paciente no coincide.");

            var pacienteExistente = await _context.Pacientes.FindAsync(id);

            if (pacienteExistente == null)
                return NotFound($"No se encontró el paciente con ID {id}");

            pacienteExistente.NombreyApellido = paciente.NombreyApellido;
            pacienteExistente.Edad = paciente.Edad;
            pacienteExistente.dni = paciente.dni;

            await _context.SaveChangesAsync();

            return Ok(pacienteExistente);
        }

        // DELETE: api/Paciente/Eliminar/5
        [HttpDelete("Eliminar/{id}")]
        public async Task<IActionResult> EliminarPaciente(int id)
        {
            var paciente = await _context.Pacientes.FindAsync(id);

            if (paciente == null)
                return NotFound($"No se encontró el paciente con ID {id}");

            _context.Pacientes.Remove(paciente);
            await _context.SaveChangesAsync();

            return Ok($"Paciente con ID {id} eliminado correctamente.");
        }
    }
}



