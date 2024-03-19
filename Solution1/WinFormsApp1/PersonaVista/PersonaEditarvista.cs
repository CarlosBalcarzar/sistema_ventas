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

namespace SistemaVentas.vista.PersonaVista
{
    public partial class PersonaEditarvista : Form
    {
        int idx = 0;
        Persona persona = new Persona();
        PersonaBss bss = new PersonaBss();
        public PersonaEditarvista(int id)
        {
            idx = id;
            InitializeComponent();
        }
        private void PersonaEditarvista_Load(object sender, EventArgs e)
        {
            persona = bss.ObtenerIdBss(idx);
            textBox1.Text = persona.Nombre;
            textBox2.Text = persona.Apellido;
            textBox3.Text = persona.Telefono;
            textBox4.Text = persona.Ci;
            textBox5.Text = persona.Correo;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            persona.Nombre = textBox1.Text;
            persona.Apellido = textBox2.Text;
            persona.Telefono = textBox3.Text;
            persona.Ci = textBox4.Text;
            persona.Correo = textBox5.Text;

            bss.EditarPersonaBss(persona);
            MessageBox.Show("Datos actulizados");
        }

        
    }
}
