﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasventas.dal
{
    public class DetalleVentDal
    {
        public DataTable ListarDetalleVentDal()
        {
            string consulta = "select * from DetalleVent";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}