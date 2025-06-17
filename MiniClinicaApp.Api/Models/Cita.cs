using System.ComponentModel.DataAnnotations;
using MiniClinicaApp.Api.Models;

namespace MiniClinicaApp.Api.Models
{
    public class Cita
    {
        [Key]
        public int PacienteId { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(500, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres.")]
        public string MotivoConsulta { get; set; } = "";

        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres.")]
       
        public string Medico  { get; set; }
        
        public DateTime Fecha { get; set; }

        public decimal PrecioConsulta { get; set; }

        //public Paciente? Paciente { get; set; }       
    }
   
}
