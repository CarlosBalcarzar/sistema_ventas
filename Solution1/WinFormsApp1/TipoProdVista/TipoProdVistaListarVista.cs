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

namespace SistemaVentas.vista.TipoProdVista
{
    public partial class TipoProdVistaListarVista : Form
    {
        public TipoProdVistaListarVista()
        {
            InitializeComponent();
        }
        TipoProdBss bss = new TipoProdBss();
        private void TipoProdVistaListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaTipoProdBss();
        }
    }
}
