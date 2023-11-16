using System.Windows.Forms;

namespace ProyectoJuliana
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmBusqueda buscarLibro = new frmBusqueda();
            buscarLibro.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Deseas Salir de la Aplicacion?", "", MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
            {

            }
            else
            {
                Application.Exit();
            }
        }
    }
}