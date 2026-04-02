using System;

class Program
{
    static void Main()
    {
        Grafo grafo = new Grafo();

        int opcion;

        do
        {
            Console.WriteLine("\n--- MENÚ VUELOS ---");
            Console.WriteLine("1. Agregar vuelo");
            Console.WriteLine("2. Mostrar vuelos");
            Console.WriteLine("3. Buscar vuelo más barato");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Origen: ");
                    string origen = Console.ReadLine();

                    Console.Write("Destino: ");
                    string destino = Console.ReadLine();

                    Console.Write("Costo: ");
                    int costo = int.Parse(Console.ReadLine());

                    grafo.AgregarVuelo(origen, destino, costo);
                    break;

                case 2:
                    grafo.MostrarVuelos();
                    break;

                case 3:
                    Console.Write("Ciudad inicio: ");
                    string inicio = Console.ReadLine();

                    Console.Write("Ciudad destino: ");
                    string fin = Console.ReadLine();

                    grafo.VueloMasBarato(inicio, fin);
                    break;

                case 4:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

        } while (opcion != 4);
    }
}
