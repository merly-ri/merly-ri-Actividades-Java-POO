using System;
using System.Collections.Generic;

// Clase Traductor: contiene toda la lógica del programa
public class Traductor
{
    // Diccionario privado que almacena palabras en inglés y su traducción al español
    private Dictionary<string, string> diccionario;

    // Constructor: se ejecuta automáticamente al crear el objeto
    public Traductor()
    {
        // Inicialización del diccionario con palabras base
        diccionario = new Dictionary<string, string>()
        {
            {"time","tiempo"},
            {"person","persona"},
            {"year","año"},
            {"way","camino"},
            {"day","día"},
            {"thing","cosa"},
            {"man","hombre"},
            {"world","mundo"},
            {"life","vida"},
            {"hand","mano"},
            {"eye","ojo"},
            {"woman","mujer"},
            {"place","lugar"},
            {"work","trabajo"},
            {"week","semana"}
        };
    }

    // Método público que inicia el programa y muestra el menú
    public void Iniciar()
    {
        int opcion;

        // Ciclo que se repite hasta que el usuario elija salir
        do
        {
            MostrarMenu();

            // Se intenta convertir la opción ingresada a número
            int.TryParse(Console.ReadLine(), out opcion);

            // Estructura de control para ejecutar la opción seleccionada
            switch (opcion)
            {
                case 1:
                    TraducirFrase();
                    break;

                case 2:
                    AgregarPalabra();
                    break;

                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            Console.WriteLine();

        } while (opcion != 0);
    }

    // Método que muestra el menú en pantalla
    private void MostrarMenu()
    {
        Console.WriteLine("==================== MENÚ ====================");
        Console.WriteLine("1. Traducir una frase");
        Console.WriteLine("2. Agregar palabras al diccionario");
        Console.WriteLine("0. Salir");
        Console.Write("Seleccione una opción: ");
    }

    // Método que traduce una frase completa
    private void TraducirFrase()
    {
        Console.Write("Ingrese la frase: ");
        string frase = Console.ReadLine();

        // Se divide la frase en palabras usando espacio como separador
        string[] palabras = frase.Split(' ');

        string traduccion = "";

        // Se recorre cada palabra de la frase
        foreach (string palabra in palabras)
        {
            // Se limpia la palabra (minúsculas y sin signos básicos)
            string limpia = palabra.ToLower().Replace(",", "").Replace(".", "");

            // Se verifica si la palabra existe en el diccionario
            if (diccionario.ContainsKey(limpia))
            {
                // Si existe, se agrega su traducción
                traduccion += diccionario[limpia] + " ";
            }
            else
            {
                // Si no existe, se mantiene igual
                traduccion += palabra + " ";
            }
        }

        // Se muestra la traducción final
        Console.WriteLine("Traducción: " + traduccion.Trim());
    }

    // Método que permite agregar nuevas palabras al diccionario
    private void AgregarPalabra()
    {
        Console.Write("Ingrese palabra en inglés: ");
        string ingles = Console.ReadLine().ToLower();

        Console.Write("Ingrese traducción en español: ");
        string espanol = Console.ReadLine().ToLower();

        // Se verifica si la palabra ya existe
        if (!diccionario.ContainsKey(ingles))
        {
            // Si no existe, se agrega al diccionario
            diccionario.Add(ingles, espanol);
            Console.WriteLine("Palabra agregada correctamente.");
        }
        else
        {
            Console.WriteLine("La palabra ya existe en el diccionario.");
        }
    }
}