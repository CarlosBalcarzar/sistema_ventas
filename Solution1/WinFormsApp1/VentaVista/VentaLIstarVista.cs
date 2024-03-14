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

namespace SistemaVentas.vista.VentaVista
{
    public partial class VentaLIstarVista : Form
    {
        public VentaLIstarVista()
        {
            InitializeComponent();
        }
        VentaBss bss = new VentaBss();
        private void VentaLIstarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaVentaBss();
        }
    }
}
