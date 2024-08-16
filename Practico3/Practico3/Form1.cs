namespace Practico3
{
    public partial class PequeñoFormulario : Form
    {
        public PequeñoFormulario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void TGuardar_Click(object sender, EventArgs e)
        {
            LModificar.Text = TNombre.Text + " " + TApellido.Text;      
        }
    }
}
