namespace CampañaVacunacionCOVID
{
    public class Ciudadano
    {
        public string Nombre { get; set; }

        public Ciudadano(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}