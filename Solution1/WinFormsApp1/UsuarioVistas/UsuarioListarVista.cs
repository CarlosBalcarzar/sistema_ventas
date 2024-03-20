using sistemasventas.bss;
using SistemaVentas.vista.PersonaVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.vista.UsuarioVistas
{
    public partial class UsuarioListarVista : Form
    {
        public UsuarioListarVista()
        {
            InitializeComponent();
        }
        UsuarioBss bss = new UsuarioBss();
        private void UsuarioListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaUsuarioBss();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            UsuarioIngresarVIsta fr = new UsuarioIngresarVIsta();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaUsuarioBss();
            }
            dataGridView1.DataSource = bss.ListaUsuarioBss();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int IdUsuarioSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de eliminar esta usuario", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarUsuarioBss(IdUsuarioSeleccionada);
                dataGridView1.DataSource = bss.ListaUsuarioBss();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int IdUsuarioSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            UsuarioEditarVista fr = new UsuarioEditarVista(IdUsuarioSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListaUsuarioBss();
            }
            dataGridView1.DataSource = bss.ListaUsuarioBss();
        }
    }
}
