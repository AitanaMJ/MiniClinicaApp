using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniClinicaApp1.Desktop.Models
{
    public class Cita
    {
        public int Idcita { get; set; }
        public DateTime Fecha { get; set; }
        public int PacienteId { get; set; }
        public string Medico { get; set; } = "";

        public decimal total { get; set; }
        //public Paciente? Paciente { get; set; }
    }
}
