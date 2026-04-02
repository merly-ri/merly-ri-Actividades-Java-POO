using System;
using System.Collections.Generic;

// Clase que representa el grafo de vuelos
public class Grafo
{
    // Diccionario donde:
    // clave = ciudad origen
    // valor = lista de vuelos desde esa ciudad
    private Dictionary<string, List<Vuelo>> vuelos;

    // Constructor
    public Grafo()
    {
        vuelos = new Dictionary<string, List<Vuelo>>();
    }

    // Método para agregar un vuelo al grafo
    public void AgregarVuelo(string origen, string destino, int costo)
    {
        // Si la ciudad no existe, se crea
        if (!vuelos.ContainsKey(origen))
        {
            vuelos[origen] = new List<Vuelo>();
        }

        // Se agrega el vuelo a la lista
        vuelos[origen].Add(new Vuelo(destino, costo));
    }

    // Método para mostrar todos los vuelos (reportería)
    public void MostrarVuelos()
    {
        Console.WriteLine("\n--- LISTA DE VUELOS ---");

        // Recorre cada ciudad
        foreach (var ciudad in vuelos)
        {
            Console.WriteLine($"Desde {ciudad.Key}:");

            // Recorre cada vuelo de esa ciudad
            foreach (var vuelo in ciudad.Value)
            {
                Console.WriteLine($"  -> {vuelo.Destino} (${vuelo.Costo})");
            }
        }
    }

    // Método que calcula el vuelo más barato (algoritmo tipo Dijkstra)
    public void VueloMasBarato(string inicio, string fin)
    {
        // Diccionario para guardar distancias mínimas
        var distancias = new Dictionary<string, int>();

        // Conjunto para marcar nodos visitados
        var visitados = new HashSet<string>();

        // Inicializa todas las distancias en infinito
        foreach (var ciudad in vuelos.Keys)
        {
            distancias[ciudad] = int.MaxValue;
        }

        // La ciudad inicial tiene costo 0
        distancias[inicio] = 0;

        while (true)
        {
            string actual = null;
            int menor = int.MaxValue;

            // Buscar el nodo con menor distancia no visitado
            foreach (var ciudad in distancias)
            {
                if (!visitados.Contains(ciudad.Key) && ciudad.Value < menor)
                {
                    menor = ciudad.Value;
                    actual = ciudad.Key;
                }
            }

            // Si no hay más nodos, termina
            if (actual == null) break;

            // Marcar como visitado
            visitados.Add(actual);

            // Si no tiene vuelos, continuar
            if (!vuelos.ContainsKey(actual)) continue;

            // Revisar vecinos
            foreach (var vecino in vuelos[actual])
            {
                int nuevoCosto = distancias[actual] + vecino.Costo;

                // Si se encuentra un camino más barato
                if (!distancias.ContainsKey(vecino.Destino) || nuevoCosto < distancias[vecino.Destino])
                {
                    distancias[vecino.Destino] = nuevoCosto;
                }
            }
        }

        // Mostrar resultado
        if (distancias.ContainsKey(fin))
            Console.WriteLine($"\nCosto mínimo de {inicio} a {fin}: ${distancias[fin]}");
        else
            Console.WriteLine("\nNo existe ruta.");
    }
}