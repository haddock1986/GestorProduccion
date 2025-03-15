using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorProduccion
{
    public class ParteTrabajo
    {
        public int id { get; set; }
        public string nombreTrabajador { get; set; }
        public string apellido1Trabajador { get; set; }
        public string apellido2Trabajador { get; set; }
        public string fecha { get; set; }
        public string nombreCliente { get; set; }
        public string codigoProducto { get; set; }
        public string nombreProducto { get; set; }
        public string piezas { get; set; }
        public string tiempoInvertido { get; set; }
    }
}
