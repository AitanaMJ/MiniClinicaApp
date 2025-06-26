using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MiniClinicaApp.Api.Models;

namespace MiniClinicaaApp2.Desktop.Models
{
    public class CitaDesktop
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
    }
}
