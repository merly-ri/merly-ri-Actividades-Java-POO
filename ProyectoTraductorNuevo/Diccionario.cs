using System;
using System.Collections.Generic;

// Clase encargada de almacenar las palabras y sus equivalencias
public class Diccionario
{
    // Diccionarios para traducción bidireccional
    private Dictionary<string, string> espIng;
    private Dictionary<string, string> ingEsp;

    // Constructor: inicializa el diccionario con palabras base
    public Diccionario()
    {
        espIng = new Dictionary<string, string>();
        ingEsp = new Dictionary<string, string>();

        // Palabras iniciales (mínimo 10)
        Agregar("tiempo", "time");
        Agregar("persona", "person");
        Agregar("año", "year");
        Agregar("día", "day");
        Agregar("cosa", "thing");
        Agregar("hombre", "man");
        Agregar("mundo", "world");
        Agregar("vida", "life");
        Agregar("mano", "hand");
        Agregar("ojo", "eye");
    }

    // Método para agregar nuevas palabras
    public void Agregar(string español, string ingles)
    {
        español = español.ToLower();
        ingles = ingles.ToLower();

        espIng[español] = ingles;
        ingEsp[ingles] = español;
    }

    // Método que traduce una palabra automáticamente
    public string TraducirPalabra(string palabra)
    {
        palabra = palabra.ToLower();

        if (espIng.ContainsKey(palabra))
            return espIng[palabra];

        if (ingEsp.ContainsKey(palabra))
            return ingEsp[palabra];

        return palabra; // Si no existe, la deja igual
    }
}