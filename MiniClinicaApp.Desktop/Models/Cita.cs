using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniClinicaApp.Desktop.Models
{
    internal class Cita
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int PacienteId { get; set; }
        public string Medico { get; set; } = "";
        public Paciente? Paciente { get; set; }
    }
}
