using Microsoft.EntityFrameworkCore;
using MiApp.Dominio;

namespace MiApp.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Accidente> Accidentes { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<AgenteTransito> AgentesTransito { get; set; }
        public DbSet<AccidentePersona> AccidentesPersonas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                 optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Transito5");
                //optionsBuilder.UseSqlServer("Data Source = DTDAGUILAR\\SQLEXPRESS; Trusted_Connection=True; Initial Catalog = Transito4");
                // Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;
            }
        }
    }
}