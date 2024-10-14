using PruebaAlgoritmosSimulacion.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaAlgoritmosSimulacion.Algoritmos
{
    public class GeneradorAleatorios
    {
        public (List<List<float>> matriz, float media) MonteCarloSimulation(int rangomin, int rangomax, int iteraciones, int tmuestra)
        {
            List<List<float>> matrizResultados = new List<List<float>>(); // Lista que contiene todas las muestras

            float media = 0; // Initialization
            Random r = new Random(); // Create the random object once

            for (int i = 0; i < iteraciones; i++)
            {
                List<float> muestra = new List<float>();

                for (int j = 0; j < tmuestra; j++)
                {
                    // Generate random numbers within range
                    int rInt = r.Next(rangomin, rangomax);
                    muestra.Add(rInt);
                }

                float avg = muestra.Average();
                float varianza = (float)Math.Sqrt(muestra.Average(v => Math.Pow(v - avg, 2)));

                muestra.Remove(muestra.Max()); // Remove the max value
                media += muestra.Max(); // Add the new max value
                matrizResultados.Add(new List<float>(muestra)); // Agregar la muestra a la matriz

            }
            media = media / iteraciones; // Calculate the final average
            return (matrizResultados, media);
        }

    }
}
