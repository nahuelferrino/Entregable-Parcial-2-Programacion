using AccesoDatos.Models;
using AccesoDatos.Repositories;

IGenericRepository<Artista> artistaRepository = new GenericRepository<Artista>();
CancionRepository cancionRepository = new CancionRepository();

bool continuar = true;

while (continuar)
{
    Console.WriteLine("================================");
    Console.WriteLine(" GESTION DE ARTISTAS ");
    Console.WriteLine("================================");
    Console.WriteLine("1. Alta artista");
    Console.WriteLine("2. Alta cancion");
    Console.WriteLine("3. Ver canciones");
    Console.WriteLine("4. Mostrar canciones mas largas");
    Console.WriteLine("5. Cantidad total de canciones");
    Console.WriteLine("6. Mostrar canciones ordenadas alfabeticamente por titulo");
    Console.WriteLine("7. Verificar si existen canciones registradas");
    Console.WriteLine("0. Salir");
    Console.WriteLine();

    Console.Write("Seleccione una opción: ");
    string opcion = Console.ReadLine();

    Console.Clear();

    switch (opcion)
    {
        case "1":
            AltaArtista();
            break;

        case "2":
            AltaCancion();
            break;

        case "3":
            MostrarCanciones();
            break;

        case "4":
            VerCancionesMasLargas();
            break;

        case "5":
            MostrarCantCanciones();
            break;

        case "6":
            VerCancionesAlfabeticamente();
            break;

        case "7":
            VerificarCancionesRegistradas();
            break;

        case "0":
            continuar = false;
            Console.WriteLine("Aplicación finalizada.");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            PresioneParaContinuar();
            break;
    }
}

void PresioneParaContinuar()
{
    Console.WriteLine();
    Console.WriteLine("Presione una tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
}

void AltaArtista()
{
    Console.Write("Nombre del artista: ");

    Artista artista = new Artista
    {
        Nombre = Console.ReadLine()
    };

    artistaRepository.Agregar(artista);

    Console.WriteLine("Artista registrado correctamente.");

    PresioneParaContinuar();
    
}
void AltaCancion()
{
    Console.WriteLine("Titulo de la cancion: ");
    string titulo = Console.ReadLine();

    Console.WriteLine("Duracion de la cancion en segundos: ");
    decimal duracion = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el Id del Artista que creo la cancion: ");
    int artistaId = int.Parse(Console.ReadLine());

    Cancion cancion = new Cancion
    {
        Titulo = titulo,
        Duracion = duracion,
        ArtistaId = artistaId,
    };
    cancionRepository.Agregar(cancion);

    Console.WriteLine("Cancion agregada correctamente");

    PresioneParaContinuar();
}

void MostrarCanciones()
{
    Console.WriteLine("===== LISTADO DE CANCIONES =====");

    var canciones = cancionRepository.ObtenerTodosCon("Artista");

    if(!canciones.Any())
    {
        Console.WriteLine("No hay canciones registradas");
    }
    else
    {
        foreach (var c in canciones)
        {
            Console.WriteLine(
                $"ID: {c.Id} | " +
                $"Título: {c.Titulo} | " +
                $"Duracion {c.Duracion} | "+
                $"Autor: {c.Artista.Nombre}");
        }
    }

    PresioneParaContinuar();
}

void VerCancionesMasLargas()
{
    var canciones = cancionRepository.OrdenarCancionesPorDuracion();

    if(!canciones.Any())
    {
        Console.WriteLine("No hay canciones registradas");
    }
    else
    {
    foreach (var c in canciones)
        {
            Console.WriteLine(
                $"Título: {c.Titulo} | Duracion {c.Duracion}");
        }
    }

    PresioneParaContinuar();
}

void MostrarCantCanciones()
{
    int CantCanciones = cancionRepository.ContarCanciones();
    Console.WriteLine($"La cantidad de canciones actualmente son {CantCanciones}");

    PresioneParaContinuar();
}

void VerCancionesAlfabeticamente()
{
    var canciones = cancionRepository.OrdenarCancionesAlfabeticamente();

    if(!canciones.Any())
    {
        Console.WriteLine("No hay canciones registradas");
    }
    else
    {
        foreach (var c in canciones)
        {
            Console.WriteLine(
                $"Título: {c.Titulo} | Duracion {c.Duracion}");
            
        }
    }

    PresioneParaContinuar();
}

void VerificarCancionesRegistradas()
{
    var canciones = cancionRepository.ObtenerTodos();

    if(!canciones.Any())
    {
        Console.WriteLine("No hay canciones registradas");
    }
    else
    {
        Console.WriteLine("Si hay canciones registradas");
    }

    PresioneParaContinuar();
}