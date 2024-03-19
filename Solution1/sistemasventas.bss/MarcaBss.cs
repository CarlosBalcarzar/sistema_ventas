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
    public class MarcaBss
    {
        MarcaDal dal = new MarcaDal();
        public DataTable ListaMarcaBss()
        {
            return dal.ListarMarcaDal();
        }
        public void InsertarMarcaBss(Marca marca)
        {
            dal.InsertarMarcaDal(marca);
        }
    }
}
