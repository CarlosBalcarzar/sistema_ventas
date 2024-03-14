using sistemasventas.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasventas.bss
{
    internal class IngresoBss
    {
        IngresoDal dal = new IngresoDal();
        public DataTable ListaIngresoBss()
        {
            return dal.ListarIngresoDal();
        }
    }
}
