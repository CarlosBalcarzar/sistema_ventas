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

namespace SistemaVentas.vista.DetalleVentVista
{
    public partial class DetalleVentaIngresarVista : Form
    {
        public DetalleVentaIngresarVista()
        {
            InitializeComponent();
        }
        DetallEventBss bss = new DetallEventBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVent dv = new DetalleVent();
            dv.IdVenta = Convert.ToInt32(textBox1.Text);
            dv.IdProducto = Convert.ToInt32(textBox2.Text);
            dv.Cantidad = Convert.ToInt32(textBox3.Text);
            dv.PrecioVenta = Convert.ToInt32(textBox4.Text);
            dv.SubTotal = Convert.ToInt32(textBox5.Text);
            bss.InsertarDetalleVentBss(dv);
            MessageBox.Show("se guardo correctamente");
        }
    }
}
