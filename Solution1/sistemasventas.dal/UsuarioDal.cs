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
            string fechaFormateada = u.FechaReg.ToString("yyyy-MM-dd HH:mm:ss");
            string consulta = "INSERT INTO usuario VALUES(" + u.IdPersona + ", '" + u.NombreUser + "', '" + u.Contraseña + "', '" + fechaFormateada + "')";
            conexion.Ejecutar(consulta);
        }
        public void EliminarUsuarioDal(int id)
        {
            string consulta = "delete from usuario where idusuario=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}