using sistemasventas.modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasventas.dal
{
    public class IngresoDal
    {
        public DataTable ListarIngresoDal()
        {
            string consulta = "select * from Ingreso";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarIngresoDal(Ingreso ingreso)
        {
            string consulta = "insert into ingreso values(" + ingreso.IdProveedor + "," + "'" + ingreso.FechaIngreso + "'," + "'" +
                                                                ingreso.Total + "'," + "'Existe')";
            conexion.Ejecutar(consulta);
        }
    }
}
