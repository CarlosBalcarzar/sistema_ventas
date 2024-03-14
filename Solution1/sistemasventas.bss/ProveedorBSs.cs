using sistemasventas.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasventas.bss
{
    internal class ProveedorBSs
    {
        ProveedorDal dal = new ProveedorDal();
        public DataTable ListaProveedorBss()
        {
            return dal.ListarProveedorDal();
        }
    }
}
