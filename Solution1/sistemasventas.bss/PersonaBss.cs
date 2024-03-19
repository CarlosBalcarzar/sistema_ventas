using sistemasventas.dal;
using sistemasventas.modelos;
using System.Data;

namespace sistemasventas.bss
{
    public class PersonaBss
    {
        PersonaDal dal = new PersonaDal();
        public DataTable ListaPersonaBss()
        {
            return dal.ListarPersonaDal();
        }
        public void InsertarPersonaBss(Persona persona)
        {
            dal.InsertarPersonaDal(persona);
        }
        public Persona ObtenerIdBss(int id)
        {
            return dal.obtenerPersonaId(id);
        }
        public void EditarPersonaBss(Persona p)
        {
            dal.EditarPersonaDal(p);
        }
        public void EliminarPersonBss(int id)
        {
            dal.EliminarPersonaDal(id);
        }
    }

}
