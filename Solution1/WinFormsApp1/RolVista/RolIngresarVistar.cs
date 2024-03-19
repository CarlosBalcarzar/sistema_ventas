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

namespace SistemaVentas.vista.RolVista
{
    public partial class RolIngresarVistar : Form
    {
        public RolIngresarVistar()
        {
            InitializeComponent();
        }
        RolBss bss = new RolBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Rol r = new Rol();
            r.Nombre = textBox1.Text;
            bss.InsertarRolBss(r);
            MessageBox.Show("se guardo correctamente");
        }
    }
}
