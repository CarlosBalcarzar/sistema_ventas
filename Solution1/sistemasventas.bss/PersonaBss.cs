﻿using sistemasventas.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasventas.bss
{
    public class PersonaBss
    {
        PersonaDal dal = new PersonaDal();
        public DataTable ListaPersonaBss()
        {
            return dal.ListarPersonaDal();
        }
    }
}
