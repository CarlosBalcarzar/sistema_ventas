namespace sistemasventas.modelos
{
    public class usuario
    {
        public int IdUsuario { get; set; }
        public int IdPersona { get; set; }
        public string NombreUser { get; set; }
        public string Contraseña { get; set; }
        public string FechaReg { get; set; }
    }
}