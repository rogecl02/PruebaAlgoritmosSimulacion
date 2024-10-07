using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaAlgoritmosSimulacion.Clases
{
    public class Arco
    {
        //Nace Id Punto
        public int IdPuntoOrigen { get; set; }
        public int IdPuntoDestino { get; set; }
        public double Distancia { get; set; }
        public double Competitividad  { get; set; }
        public Arco() { 
        }
        // Se define el constructor
        public Arco(Arco arco)
        {
            IdPuntoOrigen = arco.IdPuntoOrigen;
            IdPuntoDestino = arco.IdPuntoDestino;
            Distancia = arco.Distancia;
            Competitividad = arco.Competitividad;
        }
    }
}
