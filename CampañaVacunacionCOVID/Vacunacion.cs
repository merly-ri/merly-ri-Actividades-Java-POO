using System.Collections.Generic;
using System.Linq;

namespace CampañaVacunacionCOVID
{
    public class Vacunacion
    {
        public HashSet<Ciudadano> GenerarCiudadanos()
        {
            HashSet<Ciudadano> ciudadanos = new HashSet<Ciudadano>();

            for (int i = 1; i <= 500; i++)
            {
                ciudadanos.Add(new Ciudadano("Ciudadano " + i));
            }

            return ciudadanos;
        }

        public HashSet<Ciudadano> ObtenerPfizer(HashSet<Ciudadano> ciudadanos)
        {
            return ciudadanos.Take(75).ToHashSet();
        }

        public HashSet<Ciudadano> ObtenerAstraZeneca(HashSet<Ciudadano> ciudadanos)
        {
            return ciudadanos.Skip(50).Take(75).ToHashSet();
        }
    }
}