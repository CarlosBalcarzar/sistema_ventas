using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasventas.modelos
{
    internal class DetalleIng
    {
        public int IdDetalleIng {  get; set; }
        public int IdProducto { get; set;}
        public int IdIngreso { get;set; }
        public string FechaVenc { get;set; }
        public int Cantidad { get; set; }
        public int PrecioCosto { get; set; }
        public int SubTotal { get; set; }
        public string Estado { get; set; }
    }
}
