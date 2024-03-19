using sistemasventas.modelos;
using System.Data;

namespace sistemasventas.dal
{
    public class VentaDal
    {
        public DataTable ListarVentaDal()
        {
            string consulta = "select * from Venta";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}
