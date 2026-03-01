using System;

// Clase que interactúa con el usuario
public class Traductor
{
    // Composición: el Traductor utiliza un Diccionario
    private Diccionario diccionario;

    // Constructor
    public Traductor()
    {
        diccionario = new Diccionario();
    }

    // Permite al usuario agregar nuevas palabras
    public void AgregarPalabra()
    {
        Console.Write("Ingrese la palabra en español: ");
        string español = Console.ReadLine();

        Console.Write("Ingrese la palabra en inglés: ");
        string ingles = Console.ReadLine();

        diccionario.Agregar(español, ingles);

        Console.WriteLine("Palabras agregadas correctamente.\n");
    }

    // Traduce frases completas
    public void TraducirFrase()
    {
        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine();

        string[] palabras = frase.Split(' ');
        string resultado = "";

        foreach (string palabra in palabras)
        {
            resultado += diccionario.TraducirPalabra(palabra) + " ";
        }

        Console.WriteLine("Traducción: " + resultado + "\n");
    }
}