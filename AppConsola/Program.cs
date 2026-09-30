using AccesoDatos.Models;
using AccesoDatos.Repositories;

IGenericRepository<//nombredelaclas//> autorRepository = new GenericRepository<//nombredelaclase//>();

bool continuar = true;

while (continuar)
{
    Console.WriteLine("================================");
    Console.WriteLine(" SISTEMA DE BIBLIOTECA ");
    Console.WriteLine("================================");
    Console.WriteLine("1. Alta Autor");
    Console.WriteLine("2. Alta Categoría");
    Console.WriteLine("3. Alta Libro");
    Console.WriteLine("4. Ver Autores");
    Console.WriteLine("5. Ver Categorías");
    Console.WriteLine("6. Ver Libros");
    Console.WriteLine("7. Modificar Libro");
    Console.WriteLine("8. Eliminar Libro");
    Console.WriteLine("9. Modificar Autor");
    Console.WriteLine("0. Salir");
    Console.WriteLine();

    Console.Write("Seleccione una opción: ");
    string opcion = Console.ReadLine();

    Console.Clear();

    switch (opcion)
    {
        case "1":
            ;
            break;

        case "2":
            ;
            break;

        case "3":
            ;
            break;

        case "4":
            ;
            break;

        case "5":
            ;
            break;

        case "6":
            ;
            break;

        case "7":
            ;
            break;

        case "8":
            ;
            break;

        case "9":
            ;
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