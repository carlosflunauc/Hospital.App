using Microsoft.EntityFrameworkCore;
using Hospital.App.Dominio;

namespace Hospital.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get; set;}
        public DbSet<Paciente> Pacientes {get; set;}
        public DbSet<Medico> Medicos {get; set;}
        public DbSet<SignoVital> SignosVitales {get; set;}
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
          optionsBuilder.UseSqlServer("Initial Catalog=HospitalSenaData; Data Source=HOMELUNA; Integrated Security=true");
              //optionsBuilder.UseSqlServer("Data Source=(localdb)\\Nombre_Servidor; Initial Catalog=HospitalSenaData");
          }
      }  
    }
}