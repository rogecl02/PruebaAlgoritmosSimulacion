using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaAlgoritmosSimulacion.Clases
{
    public class Asignacion
    {
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public int IdPunto { get; set; }
        public bool Activo { get; set; }
        public string Especie {  get; set; }
        public Asignacion() 
        { 
        }
        public Asignacion(Asignacion asignacion)
        {
            Longitud = asignacion.Longitud;
            Latitud= asignacion.Latitud;
            IdPunto = asignacion.IdPunto;
            Activo= asignacion.Activo;
            Especie = asignacion.Especie;
        }

    }
}
