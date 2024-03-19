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
        public void EliminarUsuarioBss(int id)
        {
            dal.EliminarUsuarioDal(id);
        }
    }
}