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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Transito4");
            }
        }
    }
}