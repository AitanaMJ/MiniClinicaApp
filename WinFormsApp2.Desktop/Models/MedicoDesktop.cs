using MiniClinicaaApp2.Desktop.Models;

namespace MiniClinicaaApp2.Desktop
{
    public class MedicoDesktop
    {
        public int Id { get; set; } 

        public string Nombre { get; set; } = string.Empty;

        public ICollection<CitaDesktop> Citas { get; set; } = new List<CitaDesktop>();
    }
}