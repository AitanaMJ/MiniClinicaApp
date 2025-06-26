using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniClinicaApp.Api.Data;
using MiniClinicaApp.Api.Models;

namespace MiniClinicaApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CitaController(AppDbContext context)
        {
            _context = context;
        }
        // POST: api/Cita/Crear
        [HttpPost("Crear")]
        public async Task<IActionResult> CrearCita([FromBody] Cita cita)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Opcional: verifica que el MedicoId exista antes de guardar
            var medicoExistente = await _context.Medicos.FindAsync(cita.MedicoId);
            if (medicoExistente == null)
                return BadRequest($"No existe el médico con ID {cita.MedicoId}");

            await _context.Citas.AddAsync(cita);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(VerCita), new { id = cita.Id }, cita);
        }

        // GET: api/Cita/Lista
        [HttpGet("Lista")]
        public async Task<ActionResult<IEnumerable<Cita>>> ListaCitas()
        {
            return await _context.Citas
               .Include(c => c.Medico) 
               .ToListAsync();
        }

        // GET: api/Cita/Ver/5
        [HttpGet("Ver/{id}")]
        public async Task<IActionResult> VerCita(int id)
        {
            var cita = await _context.Citas.Include(c => c.Medico).FirstOrDefaultAsync(c => c.Id == id);

            if (cita == null)
                return NotFound($"No se encontró la cita con ID {id}");

            return Ok(cita);
        }

       

        // PUT: api/Cita/Editar/5
        [HttpPut("Editar/{id}")]
        public async Task<IActionResult> ActualizarCita(int id, [FromBody] Cita cita)
        {
            if (id != cita.Id)
                return BadRequest("El ID de la cita no coincide.");

            var citaExistente = await _context.Citas.FindAsync(id);

            if (citaExistente == null)
                return NotFound($"No se encontró la cita con ID {id}");

            // Actualizar campos
            citaExistente.MotivoConsulta = cita.MotivoConsulta;
            citaExistente.Fecha = cita.Fecha;
            citaExistente.Hora = cita.Hora;
            citaExistente.PrecioConsulta = cita.PrecioConsulta;
            citaExistente.MedicoId = cita.MedicoId;

            await _context.SaveChangesAsync();

            return Ok(citaExistente);
        }

        // DELETE: api/Cita/Eliminar/5
        [HttpDelete("Eliminar/{id}")]
        public async Task<IActionResult> EliminarCita(int id)
        {
            var cita = await _context.Citas.FindAsync(id);

            if (cita == null)
                return NotFound($"No se encontró la cita con ID {id}");

            _context.Citas.Remove(cita);
            await _context.SaveChangesAsync();

            return Ok($"Cita con ID {id} eliminada correctamente.");
        }
    }
}