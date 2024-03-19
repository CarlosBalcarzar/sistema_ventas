using sistemasventas.modelos;
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
        public void InsertarPersonaDal(Persona persona)
        {
            string consulta = "insert into persona values('" + persona.Nombre + "'," + 
                                                         "'" + persona.Apellido + "'," +
                                                         "'" + persona.Telefono + "'," + 
                                                         "'" + persona.Ci + "'," + 
                                                         "'" + persona.Correo + "'," + 
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public Persona obtenerPersonaId(int id)
        {
            string consulta = "select * from persona where Idpersona =" + id;
            DataTable table = conexion.EjecutarDataTabla(consulta, "asdas");
            Persona p = new Persona();
            if (table.Rows.Count > 0)
            {

                p.IdPersona = Convert.ToInt32(table.Rows[0]["Idpersona"]);
                p.Nombre = table.Rows[0]["nombre"].ToString();
                p.Apellido = table.Rows[0]["Apellido"].ToString();
                p.Telefono = table.Rows[0]["Telefono"].ToString();
                p.Ci = table.Rows[0]["Ci"].ToString();
                p.Correo = table.Rows[0]["Correo"].ToString();
                p.Estado = table.Rows[0]["Correo"].ToString();
            }
            return p;
        }
        public void EditarPersonaDal(Persona persona)
        {
            string consulta = "UPDATE persona SET nombre='" + persona.Nombre + "', " +
                                                  "apellido='" + persona.Apellido + "', " +
                                                  "telefono='" + persona.Telefono + "', " +
                                                  "ci='" + persona.Ci + "', " +
                                                  "correo='" + persona.Correo + "' " +
                              "WHERE idpersona=" + persona.IdPersona;

            conexion.Ejecutar(consulta);
        }

        public void EliminarPersonaDal(int id)
        {
            string consulta = "delete from persona where idpersona=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}