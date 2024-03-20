using sistemasventas.bss;
using sistemasventas.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaVentas.vista.UsuarioVistas
{
    public partial class UsuarioEditarVista : Form
    {
        int idx = 0;
        Usuario usuario = new Usuario();
        UsuarioBss bss = new UsuarioBss();
        public UsuarioEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }
        private void UsuarioEditarVista_Load(object sender, EventArgs e)
        {
            usuario = bss.ObtenerIdBss(idx);
            textBox2.Text = usuario.NombreUser;
            textBox3.Text = usuario.Contraseña;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            usuario.NombreUser = textBox2.Text;
            usuario.Contraseña = textBox3.Text;
            bss.EditarUsuarioBss(usuario);
            MessageBox.Show("Datos actulizados");
        }
    }
}
