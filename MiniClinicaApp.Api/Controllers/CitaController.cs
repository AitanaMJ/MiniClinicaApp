using Microsoft.AspNetCore.Http;
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

        private readonly AppDbContext context;
        private AppDbContext _context;

       
        public CitaController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        [Route("Crear")]
        public async Task<IActionResult> CrearCita(Cita cita)
        {
            await _context.Citas.AddAsync(cita);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet]
        [Route("lista")]
        public async Task<ActionResult<IEnumerable<Cita>>> ListaCita()
        {
            var paciente = await _context.Citas.ToListAsync();

            return Ok(paciente);
        }

        [HttpGet]
        [Route("Ver")]
        public async Task<IActionResult> VerCita(int PacienteId)
        {
            Cita cita = await _context.Citas.FindAsync(PacienteId);

            if (cita == null)
            {
                return NotFound();
            }
            return Ok(cita);
        }

        [HttpPut]
        [Route("Editar")]
        public async Task<IActionResult> ActualizarCita(int PacienteId, Cita cita)
        {
            var citaExistente = await _context.Citas.FindAsync(PacienteId);

            citaExistente!.MotivoConsulta = cita.MotivoConsulta;
            citaExistente.Medico = cita.Medico;
            citaExistente.Fecha = cita.Fecha;

            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete]
        [Route("Eliminar")]
        public async Task<IActionResult> EliminarCita(int Pacienteid)
        {
            var citaBorrada = await _context.Citas.FindAsync(Pacienteid);

            _context.Citas.Remove(citaBorrada!);

            await _context.SaveChangesAsync();
            return Ok();
       }
    }
}
