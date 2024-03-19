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

namespace SistemaVentas.vista.IngresoVista
{
    public partial class IngresoListarVista : Form
    {
        public IngresoListarVista()
        {
            InitializeComponent();
        }
        IngresoBss bss = new IngresoBss();
        private void IngresoListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaIngresoBss();
        }
    }
}
