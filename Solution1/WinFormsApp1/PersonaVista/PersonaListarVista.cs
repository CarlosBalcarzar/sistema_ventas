using sistemasventas.bss;
using SistemaVentas.vista.UsuarioVistas;


namespace SistemaVentas.vista.PersonaVista
{
    public partial class PersonaListarVista : Form
    {
        public PersonaListarVista()
        {
            InitializeComponent();
        }
        PersonaBss Bss = new PersonaBss();
        private void PersonaListaVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Bss.ListaPersonaBss();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioIngresarVIsta.IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            PersonaIngresarVista fr = new PersonaIngresarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = Bss.ListaPersonaBss();
            }
            dataGridView1.DataSource = Bss.ListaPersonaBss();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de eliminar esta persona", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Bss.EliminarPersonBss(IdPersonaSeleccionada);
                dataGridView1.DataSource = Bss.ListaPersonaBss();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            PersonaEditarvista fr = new PersonaEditarvista(IdPersonaSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = Bss.ListaPersonaBss();
            }
            dataGridView1.DataSource = Bss.ListaPersonaBss();
        }
    }
}
