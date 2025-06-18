namespace MiniClinicaApp.Api.Models
{
    public class Medico
    {
        public int Id { get; set; } // Agrega un Id si usarás EF Core

        public string Nombre { get; set; } = string.Empty;

        public ICollection<Cita> Citas { get; set; } = new List<Cita>();
    }
}
