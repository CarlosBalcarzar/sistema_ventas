using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemasventas.modelos;

namespace sistemasventas.dal
{
    public class DetalleIngDal
    {
        public DataTable ListarDetalleIngDal()
        {
            string consulta = "select * from DetalleIng";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarDetallIngDal(DetalleIng detalleing)
        {
            string consulta = "insert into detalleing values(" + detalleing.IdProducto + "," + "" + detalleing.IdIngreso + "," + "'" +
                                                                detalleing.FechaVenc + "'," + "'" + detalleing.Cantidad + "'," + "'" + detalleing.PrecioCosto + "'," + "'" +
                                                                detalleing.precioVenta + "'," + "'" + detalleing.SubTotal + "'," + "'Existe')";
            conexion.Ejecutar(consulta);
        }
    }
}
