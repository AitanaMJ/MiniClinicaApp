using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniClinicaApp1.Desktop.Models
{
    public class Paciente
    {
        public int IdPaciente { get; set; }
        public string NombreyApellido { get; set; }
        public int Edad { get; set; }
        public int Dni { get; set; }


        public Paciente(int idpaciente, string nombreyapellido, int edad, int dni)
        {
            IdPaciente = idpaciente;
            NombreyApellido = nombreyapellido;
            Edad = edad;
            Dni = dni;
            
            
        }

    }
}
