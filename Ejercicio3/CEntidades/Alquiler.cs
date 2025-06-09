using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades
{
    public class Alquiler
    {
        public int AlquilerId { get; set; }
        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }
        public Bicicleta Bicicleta { get; set; }
        public Estacion EstacionOrig { get; set; }
        public Estacion EstacionDestino { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime FechaHoraFin {  get; set; }
        public bool Duracion {  get; set; }
        public bool MontoTotal { get; set; }
    }
}
