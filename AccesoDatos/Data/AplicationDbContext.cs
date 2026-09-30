using Microsoft.EntityFrameworkCore;
using AccesoDatos.Models;

namespace AccesoDatos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Artista> Artista { get; set; }
        public DbSet<Cancion> Cancion {get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string rutaBaseDeDatos = Path.GetFullPath(
                Path.Combine(
                    AppContext.BaseDirectory,
                    "..",
                    "..",
                    "..",
                    "..",
                   "AccesoDatos",
                   "BaseDatosEjercicios.db"
                )
            );

            optionsBuilder.UseSqlite(
                $"Data Source={rutaBaseDeDatos}"
            );
        }
    }
}