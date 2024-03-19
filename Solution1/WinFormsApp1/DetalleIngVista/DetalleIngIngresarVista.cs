using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemasventas.bss;
using sistemasventas.modelos;

namespace SistemaVentas.vista.DetalleIngVista
{
    public partial class DetalleIngIngresarVista : Form
    {
        public DetalleIngIngresarVista()
        {
            InitializeComponent();
        }
        DetalleIngBss bss = new DetalleIngBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleIng di = new DetalleIng();
            di.IdProducto = Convert.ToInt32(textBox1.Text);
            di.IdIngreso = Convert.ToInt32(textBox2.Text);
            di.FechaVenc = dateTimePicker1.Value;
            di.Cantidad = textBox3.Text;
            di.PrecioCosto = textBox4.Text;
            di.precioVenta = textBox5.Text;
            di.SubTotal = textBox6.Text;
            bss.InsertarDetalleIngBss(di);
            MessageBox.Show("se guardo correctamente");
        }
    }
}
