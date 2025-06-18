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

        public decimal PrecioConsulta { get; set; }

        public int MedicoId { get; set; }

        [JsonIgnore]
        public Medico? Medico { get; set; }
  
    }
   
}
