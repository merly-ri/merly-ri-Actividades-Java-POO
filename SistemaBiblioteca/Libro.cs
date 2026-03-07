using System;

// Clase que representa un libro dentro del sistema
public class Libro
{
    // Propiedades del libro
    public string Codigo { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Anio { get; set; }

    // Constructor para inicializar los datos del libro
    public Libro(string codigo, string titulo, string autor, int anio)
    {
        Codigo = codigo;
        Titulo = titulo;
        Autor = autor;
        Anio = anio;
    }

    // Método que permite mostrar la información del libro
    public void MostrarInformacion()
    {
        Console.WriteLine("Código: " + Codigo);
        Console.WriteLine("Título: " + Titulo);
        Console.WriteLine("Autor: " + Autor);
        Console.WriteLine("Año: " + Anio);
        Console.WriteLine("---------------------------");
    }
}