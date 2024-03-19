using sistemasventas.modelos;
using System.Data;

namespace sistemasventas.dal
{
    public class UsuarioRolDal
    {
        public DataTable ListarUsuarioRolDal()
        {
            string consulta = "select * from UsuarioRol";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioRolDal(UsuarioRol usuariorol)
        {
            string consulta = "insert into usuariorol values('" + usuariorol.IdUsuario + "'," + "'" + usuariorol.IdRol + "'," + "'" + usuariorol.FechaAsigna + "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}