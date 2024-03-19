using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasventas.modelos
{
    public class DetalleIng
    {
        public int IdDetalleIng {  get; set; }
        public int IdProducto { get; set;}
        public int IdIngreso { get;set; }
        public DateTime FechaVenc { get;set; }
        public string Cantidad { get; set; }
        public string PrecioCosto { get; set; }
        public string precioVenta { get; set; }
        public string SubTotal { get; set; }
        public string Estado { get; set; }
    }
}
