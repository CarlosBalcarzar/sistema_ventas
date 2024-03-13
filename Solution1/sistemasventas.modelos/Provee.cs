using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasventas.modelos
{
    internal class Provee
    {
        public int IdProvee {  get; set; }
        public int IdProducto { get; set; }
        public int IdProveedor { get; set; }
        public string fecha { get; set; }
        public int Precio { get; set; }

    }
}
