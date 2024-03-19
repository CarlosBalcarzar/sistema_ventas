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

namespace SistemaVentas.vista.DetalleIngVista
{
    public partial class DetalleIngListarVista : Form
    {
        public DetalleIngListarVista()
        {
            InitializeComponent();
        }
        DetalleIngBss bss = new DetalleIngBss();
        private void DetalleIngListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaDetalleIngBss();
        }
    }
}
