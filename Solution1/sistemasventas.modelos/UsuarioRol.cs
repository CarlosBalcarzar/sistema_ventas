namespace sistemasventas.modelos
{
    public class UsuarioRol
    {
        public int IdUsurioRol { get; set; }
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public DateTime FechaAsigna { get; set; }
        public string Estado { get; set; }
    }
}