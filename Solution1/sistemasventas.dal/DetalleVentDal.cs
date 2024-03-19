using sistemasventas.modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasventas.dal
{
    public class DetalleVentDal
    {
        public DataTable ListarDetalleVentDal()
        {
            string consulta = "select * from DetalleVent";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarDetalleVentDal(DetalleVent detallevent)
        {
            string consulta = "insert into detallevent values('" + detallevent.IdVenta + "'," + "'" + detallevent.IdProducto + "'," + "'" +
                                                               detallevent.Cantidad + "'," +"'" + detallevent.PrecioVenta + "'," + "'" +
                                                               detallevent.SubTotal + "'," + "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
