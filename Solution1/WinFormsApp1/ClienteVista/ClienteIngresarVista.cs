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

namespace SistemaVentas.vista.ClienteVista
{
    public partial class ClienteIngresarVista : Form
    {
        public ClienteIngresarVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente C = new Cliente();
            C.IdPersona = Convert.ToInt32(textBox1.Text);
            C.TipoCliente = textBox2.Text;
            C.CodigoClie = textBox3.Text;
            bss.InsertarClienteBss(C);
            MessageBox.Show("se guardo correctamente");
        }
    }
}
