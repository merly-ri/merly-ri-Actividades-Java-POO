using System;
using System.Collections.Generic;

namespace CampañaVacunacionCOVID
{
    class Program
    {
        static void Main(string[] args)
        {
            Vacunacion vacunacion = new Vacunacion();

            var ciudadanos = vacunacion.GenerarCiudadanos();
            var pfizer = vacunacion.ObtenerPfizer(ciudadanos);
            var astra = vacunacion.ObtenerAstraZeneca(ciudadanos);

            // Unión
            HashSet<Ciudadano> vacunados = new HashSet<Ciudadano>(pfizer);
            vacunados.UnionWith(astra);

            // Diferencia (no vacunados)
            HashSet<Ciudadano> noVacunados = new HashSet<Ciudadano>(ciudadanos);
            noVacunados.ExceptWith(vacunados);

            // Intersección (ambas dosis)
            HashSet<Ciudadano> ambasDosis = new HashSet<Ciudadano>(pfizer);
            ambasDosis.IntersectWith(astra);

            // Solo Pfizer
            HashSet<Ciudadano> soloPfizer = new HashSet<Ciudadano>(pfizer);
            soloPfizer.ExceptWith(astra);

            // Solo AstraZeneca
            HashSet<Ciudadano> soloAstra = new HashSet<Ciudadano>(astra);
            soloAstra.ExceptWith(pfizer);

            Console.WriteLine("===== RESULTADOS =====\n");
            Console.WriteLine("No vacunados: " + noVacunados.Count);
            Console.WriteLine("Ambas dosis: " + ambasDosis.Count);
            Console.WriteLine("Solo Pfizer: " + soloPfizer.Count);
            Console.WriteLine("Solo AstraZeneca: " + soloAstra.Count);
        }
    }
}
