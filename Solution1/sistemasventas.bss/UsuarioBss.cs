using sistemasventas.dal;
using sistemasventas.modelos;
using System.Data;

namespace sistemasventas.bss
{
    public class UsuarioBss
    {
        public UsuarioBss() { }
        UsuarioDal dal = new UsuarioDal();
        public DataTable ListaUsuarioBss()
        {
            return dal.ListarUsuarioDal();
        }
        public void InsertarUsuarioBss(Usuario usuario)
        {
            dal.InsertarUsuarioDal(usuario);
        }
        public Usuario ObtenerIdBss(int id)
        {
            return dal.obtenerUsuarioId(id);
        }
        public void EditarUsuarioBss(Usuario u)
        {
            dal.EditarUsuarioDal(u);
        }
        public void EliminarUsuarioBss(int id)
        {
            dal.EliminarUsuarioDal(id);
        }
    }
}