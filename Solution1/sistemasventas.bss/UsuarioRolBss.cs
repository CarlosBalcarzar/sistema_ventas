using sistemasventas.dal;
using sistemasventas.modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasventas.bss
{
    public class UsuarioRolBss
    {
        UsuarioRolDal dal = new UsuarioRolDal();
        public DataTable ListaUsuarioRolBss()
        {
            return dal.ListarUsuarioRolDal();
        }
        public void InsertarUsuarioRolBss(UsuarioRol usuariorol)
        {
            dal.InsertarUsuarioRolDal(usuariorol);
        }
    }
}
