using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using MiniClinicaApp.Api.Models;

namespace MiniClinicaApp.Api.Models
{
    public class Cita
    {
        [Key]
        public int Id { get; set; }
       
        [DataType(DataType.MultilineText)]
        [MaxLength(500, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres.")]
        public string MotivoConsulta { get; set; } = "";

        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }

        public decimal PrecioConsulta { get; set; }

        public int MedicoId { get; set; }

        public Medico? Medico { get; set; }

        public int PacienteId { get; set; }
        public Paciente? Paciente { get; set; }

    }
   
}
