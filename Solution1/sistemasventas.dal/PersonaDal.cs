using System.Data;

namespace sistemasventas.dal
{
    public class PersonaDal
    {
        public DataTable ListarPersonaDal() 
        {
            string consulta = "select * from Persona";
           DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}