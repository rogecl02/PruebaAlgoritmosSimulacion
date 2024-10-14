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
        public List<int> CrearListaOrigen(List<int> listaaleatoria, int a, int b, int c, int x, int m)
        {
            int nuevo_x = (a * x * x + b * x + c) % m;
            if (!listaaleatoria.Contains(nuevo_x))
            {
                listaaleatoria.Add(nuevo_x);
                return CrearListaOrigen(listaaleatoria, a, b, c, nuevo_x, m);
            }
            listaaleatoria.Add(nuevo_x);
            return listaaleatoria;
        }

    }
}
