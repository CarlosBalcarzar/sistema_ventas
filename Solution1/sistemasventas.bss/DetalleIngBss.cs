﻿using sistemasventas.dal;
using sistemasventas.modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasventas.bss
{
    public class DetalleIngBss
    {
        DetalleIngDal dal = new DetalleIngDal();
        public DataTable ListaDetalleIngBss()
        {
            return dal.ListarDetalleIngDal();
        }
        public void InsertarDetalleIngBss(DetalleIng detalleing)
        {
            dal.InsertarDetallIngDal(detalleing);
        }
    }
}
