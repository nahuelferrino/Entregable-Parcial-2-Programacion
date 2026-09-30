using System.Security.Cryptography;
using AccesoDatos.Data;
using AccesoDatos.Models;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatos.Repositories
{
    public class CancionRepository : GenericRepository<Cancion>
    {
        public List<Cancion> OrdenarCancionesPorDuracion()
        {
            return _context.Cancion
                            .OrderByDescending(c => c.Duracion)
                            .ToList();
        }

        public int ContarCanciones()
        {
            return _context.Cancion
                            .Count();
        }

        public List<Cancion> OrdenarCancionesAlfabeticamente()
        {
            return _context.Cancion
                            .OrderBy(c => c.Titulo)
                            .ToList();
        }
    }
}