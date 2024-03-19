using sistemasventas.modelos;
using System.Data;

namespace sistemasventas.dal
{
    public class ClienteDal
    {
        public DataTable ListarClienteDal()
        {
            string consulta = "select * from Cliente";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarClienteDal(Cliente cliente)
        {
            string consulta = "insert into cliente values(" + cliente.IdPersona + "," + "" + cliente.TipoCliente + "," + "" +
                                                                cliente.CodigoClie + "," + "'Existe')";
            conexion.Ejecutar(consulta);
        }
    }
}