using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmVet.Clases
{
    public class Animales
    {
        public int AnimalId { get; set; }
        public int TipoId { get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public bool TieneDuenio { get; set; }
    }
}
