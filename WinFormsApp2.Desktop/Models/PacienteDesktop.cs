using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniClinicaaApp2.Desktop.Models
{
    public class Paciente
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres.")]
        public string NombreyApellido { get; set; } = "";
        public int Edad { get; set; }
        public int dni { get; set; }


    }
}
