namespace sistemasventas.modelos
{
    public class Venta
    {
        public int IdVenta {  get; set; }
        public int IdCliente { get; set;}
        public int IdVendedor { get; set;}
        public DateTime Fecha { get; set;}
        public string Total { get; set;}
        public string Estado { get; set;}
    }
}