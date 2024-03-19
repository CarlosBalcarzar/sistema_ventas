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
    public class DetallEventBss
    {
        DetalleVentDal dal = new DetalleVentDal();
        public DataTable ListaDetallEventBss()
        {
            return dal.ListarDetalleVentDal();
        }
        public void InsertarDetalleVentBss(DetalleVent detalleVent)
        {
            dal.InsertarDetalleVentDal(detalleVent);
        }
    }
}
