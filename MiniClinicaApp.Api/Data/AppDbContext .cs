using Microsoft.EntityFrameworkCore;
using MiniClinicaApp.Api.Models;

namespace MiniClinicaApp.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Cita> Citas { get; set; }
       
        public DbSet<Medico> Medicos { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuraciones personalizadas si es necesario
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cita>()
                .Property(c => c.PrecioConsulta)
                .HasPrecision(18, 2); // <- Esto evita truncamientos

            modelBuilder.Entity<Cita>()
               .HasOne(c => c.Medico)
               .WithMany(m => m.Citas)
               .HasForeignKey(c => c.MedicoId);

            modelBuilder.Entity<Medico>().HasData(
            new Medico { Id = 1, Nombre = "Dr. Castillo" },
            new Medico { Id = 2, Nombre = "Dra. Hernandez" },
            new Medico { Id = 3, Nombre = "Dr. Molina" });


           base.OnModelCreating(modelBuilder);
        }

    }
}