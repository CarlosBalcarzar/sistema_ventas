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

namespace SistemaVentas.vista.IngresoVista
{
    public partial class IngresoIngresarVIsta : Form
    {
        public IngresoIngresarVIsta()
        {
            InitializeComponent();
        }
        IngresoBss bss = new IngresoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Ingreso i = new Ingreso();
            i.IdProveedor = Convert.ToInt32(textBox1.Text);
            i.FechaIngreso = dateTimePicker1.Value;
            bss.InsertarIngresoBss(i);
            MessageBox.Show("se guardo correctamente");
        }
    }
}
