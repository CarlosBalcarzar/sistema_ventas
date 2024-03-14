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
    }
}
