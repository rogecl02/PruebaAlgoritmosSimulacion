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
        public List<Asignacion> CrearListaOrigen(int puntosTotales,int limiteInferior, int limiteSuperior)
        { 
            List<Asignacion> listaAsignacion = new List<Asignacion>();
            for (int i =0; i < puntosTotales; i++)
            {
                Asignacion generador = new Asignacion();
                generador.Latitud = Random(0,100);
            }
            return listaAsignacion;
        }

    }
}
