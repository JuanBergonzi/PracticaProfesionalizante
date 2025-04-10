using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdmVet.Clases
{
    public class Atenciones
    {
        public int AtencionesId { get; set; }
        public string TipoAtencion { get; set; }
        public string MotivoConsulta { get; set; }
        public string TratamientoRecibido { get; set; }
        public string Medicamentos { get; set; }
        public DateTime Fecha { get; set; }
    }
}
