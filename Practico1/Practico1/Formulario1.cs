namespace Practico1
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void Formulario1_Load(object sender, EventArgs e)
        {

        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            string nombre = textBox2.Text;
            string apellido = textBox1.Text;

            string textoTextBox3 = apellido + " " + nombre;
            textBox3.Text = textoTextBox3;
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Formulario1_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificar si se presionó Ctrl + S
            if (e.Control && e.KeyCode == Keys.S)
            {
                // Llamar al evento del botón Salir
                BSalir_Click(sender, e);
            }
        }
    }
}
