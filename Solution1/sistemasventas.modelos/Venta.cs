﻿namespace sistemasventas.modelos
{
    public class venta
    {
        public int IdVenta {  get; set; }
        public int IdCliente { get; set;}
        public int IdVendedor { get; set;}
        public string Fecha { get; set;}
        public int Total { get; set;}
        public string Estado { get; set;}
    }
}