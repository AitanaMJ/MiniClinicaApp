using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Desktop.Models
{
    public class Medico
    {
        public int Id { get; set; } // Agrega un Id si usarás EF Core

        public string Nombre { get; set; } = string.Empty;

        public ICollection<CitaDesktop> Citas { get; set; } = new List<CitaDesktop>();
    }
}
