using sistemasventas.modelos;
using System.Data;

namespace sistemasventas.dal
{
    public class UsuarioDal
    {
        public DataTable ListarUsuarioDal()
        {
            string consulta = "select * from Usuario";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public UsuarioDal() { }
        public void InsertarUsuarioDal(Usuario u)
        {
            string fechaRegr = u.FechaReg.ToString("yyyy-MM-dd HH:mm:ss");
            string consulta = "INSERT INTO usuario VALUES(" + u.IdPersona + ", '" + u.NombreUser + "', '" + u.Contraseña + "', '" + fechaRegr + "')";
            conexion.Ejecutar(consulta);
        }
        public Usuario obtenerUsuarioId(int id)
        {
            string consulta = "SELECT * FROM usuario WHERE Idusuario =" + id;
            DataTable table = conexion.EjecutarDataTabla(consulta, "asdas");
            Usuario u = new Usuario();
            if (table.Rows.Count > 0)
            {
                u.NombreUser = table.Rows[0]["NombreUser"].ToString();
                u.Contraseña = table.Rows[0]["Contraseña"].ToString();
            }
            return u;
        }
        public void EditarUsuarioDal(Usuario usuario)
        {
            string consulta = "UPDATE usuario SET NombreUser='" + usuario.NombreUser + "', " +
                                              "Contraseña='" + usuario.Contraseña + "' " +
                          "WHERE idusuario=" + usuario.IdUsuario;

            conexion.Ejecutar(consulta);
        }
        
        public void EliminarUsuarioDal(int id)
        {
            string consulta = "delete from usuario where idusuario=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}