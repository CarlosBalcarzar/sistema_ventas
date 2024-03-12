namespace sistemasventas.modelos
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public int IdTipoProducto { get; set; }
        public string Nombre { get; set; }
        public string CodigoBarra { get; set;}
        public string Descripcion { get; set;}
        public string estado { get; set;}
    }
}
