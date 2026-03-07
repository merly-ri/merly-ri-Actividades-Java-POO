using System;

class Program
{
    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();

        int opcion = 0;

        while (opcion != 4)
        {
            Console.WriteLine("\n===== SISTEMA DE BIBLIOTECA =====");
            Console.WriteLine("1. Registrar libro");
            Console.WriteLine("2. Mostrar libros");
            Console.WriteLine("3. Buscar libro");
            Console.WriteLine("4. Salir");

            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    Console.Write("Código: ");
                    string codigo = Console.ReadLine();

                    Console.Write("Título: ");
                    string titulo = Console.ReadLine();

                    Console.Write("Autor: ");
                    string autor = Console.ReadLine();

                    Console.Write("Año: ");
                    int anio = int.Parse(Console.ReadLine());

                    Libro libro = new Libro(codigo, titulo, autor, anio);

                    biblioteca.RegistrarLibro(libro);

                    break;

                case 2:

                    biblioteca.MostrarLibros();

                    break;

                case 3:

                    Console.Write("Ingrese el código: ");
                    string buscar = Console.ReadLine();

                    biblioteca.BuscarLibro(buscar);

                    break;

                case 4:

                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:

                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}