// Clase que representa un vuelo individual
public class Vuelo
{
    // Propiedad que almacena la ciudad destino
    public string Destino { get; set; }

    // Propiedad que almacena el costo del vuelo
    public int Costo { get; set; }

    // Constructor de la clase Vuelo
    public Vuelo(string destino, int costo)
    {
        Destino = destino; // Se asigna el destino
        Costo = costo;     // Se asigna el costo
    }
}