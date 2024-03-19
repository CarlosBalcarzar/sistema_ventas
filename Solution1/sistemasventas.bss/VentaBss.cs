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
    public class VentaBss
    {
        VentaDal dal = new VentaDal();
        public DataTable ListaVentaBss()
        {
            return dal.ListarVentaDal();
        }
    }
}
