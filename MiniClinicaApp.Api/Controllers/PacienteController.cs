using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniClinicaApp.Api.Data;
using MiniClinicaApp.Api.Models;
using SQLitePCL;

namespace MiniClinicaApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly AppDbContext context;
        private AppDbContext _context;

        public PacienteController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("Crear")]
        public async Task <IActionResult>CrearPaciente(Paciente paciente)
        {
            await _context.Pacientes.AddAsync(paciente);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet]
        [Route("lista")]
        public async Task<ActionResult<IEnumerable<Paciente>>>ListaPaciente()
        {
            var paciente = await _context.Pacientes.ToListAsync();

            return Ok(paciente);
        }

        [HttpGet]
        [Route("Ver")]
        public async Task<IActionResult>VerPaciente(int id)
        {
            Paciente paciente = await _context.Pacientes.FindAsync(id);

            if(paciente == null)
            {
                return NotFound();
            }
            return Ok(paciente);
        }

        [HttpPut]
        [Route("Editar")]
        public async Task<IActionResult>ActualizarPaciente(int id, Paciente paciente)
        {
            var pacienteExistente = await _context.Pacientes.FindAsync(id);

            pacienteExistente! .NombreyApellido = paciente.NombreyApellido;
            pacienteExistente.Edad = paciente.Edad;
            pacienteExistente.dni = paciente.dni;

            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete]
        [Route("Eliminar")]
        public async Task<IActionResult>EliminarPaciente(int id)
        {
            var pacienteBorrado = await _context.Pacientes.FindAsync(id);

            _context.Pacientes.Remove(pacienteBorrado!);

            await _context.SaveChangesAsync();
            return Ok();
        }

    }
}
