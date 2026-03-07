using System;
using System.Collections.Generic;

// Clase que administra el conjunto de libros de la biblioteca
public class Biblioteca
{
    // Se utiliza un Dictionary para almacenar los libros
    // Clave -> Código del libro
    // Valor -> Objeto Libro
    private Dictionary<string, Libro> libros = new Dictionary<string, Libro>();

    // Método para registrar un nuevo libro
    public void RegistrarLibro(Libro libro)
    {
        // Verifica si el libro ya existe en el diccionario
        if (libros.ContainsKey(libro.Codigo))
        {
            Console.WriteLine("El libro ya está registrado.");
        }
        else
        {
            // Se agrega el libro al diccionario
            libros.Add(libro.Codigo, libro);
            Console.WriteLine("Libro registrado correctamente.");
        }
    }

    // Método para mostrar todos los libros registrados
    public void MostrarLibros()
    {
        // Verifica si la biblioteca está vacía
        if (libros.Count == 0)
        {
            Console.WriteLine("No hay libros registrados.");
            return;
        }

        // Recorre todos los libros almacenados
        foreach (var libro in libros.Values)
        {
            libro.MostrarInformacion();
        }
    }

    // Método para buscar un libro por su código
    public void BuscarLibro(string codigo)
    {
        // Verifica si el libro existe
        if (libros.ContainsKey(codigo))
        {
            libros[codigo].MostrarInformacion();
        }
        else
        {
            Console.WriteLine("Libro no encontrado.");
        }
    }
}