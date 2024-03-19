using sistemasventas.modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasventas.dal
{
    public class MarcaDal
    {
        public DataTable ListarMarcaDal()
        {
            string consulta = "select * from Marca";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarMarcaDal(Marca marca)
        {
            string consulta = "insert into marca values('"+ marca.Nombre + "'," + "'Existe')";
            conexion.Ejecutar(consulta);
        }
    }
}
