using sistemasventas.modelos;
using System.Data;

namespace sistemasventas.dal
{
    public class RolDal
    {
        public DataTable ListarRolDal()
        {
            string consulta = "select * from Rol";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarRolDal(Rol rol)
        {
            string consulta = "insert into rol values('" + rol.Nombre + "'," + "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
