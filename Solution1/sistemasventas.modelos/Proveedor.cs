using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasventas.modelos
{
    internal class Proveedor
    {
        public int IdProveedor {  get; set; }
        public string Nombre { get; set; }
        public int telefono { get; set; }
        public string direccion {  get; set; }
        public string estado { get; set; }
    }
}
