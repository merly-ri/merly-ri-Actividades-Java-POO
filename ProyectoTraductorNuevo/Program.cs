using System;

class Program
{
    static void Main(string[] args)
    {
        Traductor traductor = new Traductor();
        int opcion;

        do
        {
            Console.WriteLine("==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida.\n");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    traductor.TraducirFrase();
                    break;

                case 2:
                    traductor.AgregarPalabra();
                    break;

                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.\n");
                    break;
            }

        } while (opcion != 0);
    }
}