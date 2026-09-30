using Microsoft.EntityFrameworkCore;
using AccesoDatos.Models;

namespace AccesoDatos.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Aca va lo siguiente: public DbSet<clase> clase { get; set; }
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