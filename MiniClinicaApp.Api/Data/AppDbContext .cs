using Microsoft.EntityFrameworkCore;
using MiniClinicaApp.Api.Models;

namespace MiniClinicaApp.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Cita> Citas { get; set; }
       
           



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuraciones personalizadas si es necesario
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cita>()
                .Property(c => c.PrecioConsulta)
                .HasPrecision(18, 2); // <- Esto evita truncamientos

            base.OnModelCreating(modelBuilder);
        }
    }
}