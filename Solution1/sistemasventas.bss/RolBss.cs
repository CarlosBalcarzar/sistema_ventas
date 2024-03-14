using sistemasventas.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasventas.bss
{
    public class RolBss
    {
        RolDal dal = new RolDal();
        public DataTable ListaRolBss()
        {
            return dal.ListarRolDal();
        }
    }
}
