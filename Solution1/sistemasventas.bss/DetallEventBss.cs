using sistemasventas.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasventas.bss
{
    public class DetallEventBss
    {
        DetalleVentDal dal = new DetalleVentDal();
        public DataTable ListaDetallEventBss()
        {
            return dal.ListarDetalleVentDal();
        }
    }
}
