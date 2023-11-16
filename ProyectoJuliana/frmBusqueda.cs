using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoJuliana
{
    public partial class frmBusqueda : Form
    {
        //Se crea una variable tipo string llamada dato
        string dato = "";
        public frmBusqueda()
        {
            InitializeComponent();
        }


        private void DataTablaEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        // Al momento de darle click en el boton de salir manda un mensaje de dialogo
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

        // cuando le da en el boton de buscar manda a la clase limpiartextbox y llena los tabla con datos aleatorios
        private void frmBusqueda_Load(object sender, EventArgs e)
        {
            LimpiarCasillas();
            LlenarDataGridViewConDatosAleatorios();
        }

        // Limpio los textBox 
        private void LimpiarCasillas()
        {
            TextNombreLibro.Clear();
            TextNombreAutor.Clear();
            TextAño.Clear();
            TextUbicacion.Clear();
            TextCantidad.Clear();

        }

        // lleno la tabla con los datos aleatorios definidos en los vectores 
        private void LlenarDataGridViewConDatosAleatorios()
        {
            // Nombres de libros y autores ficticios para el ejemplo
            string[] nombresLibros = {
                "Cien años de soledad",
                "1984",
                "To Kill a Mockingbird",
                "The Great Gatsby",
                "The Catcher in the Rye",
                "One Hundred Years of Solitude",
                "The Lord of the Rings",
                "Harry Potter and the Sorcerer's Stone",
                "The Hobbit",
                "Brave New World"
            };

            string[] autores = {
                "Gabriel García Márquez",
                "George Orwell",
                "Harper Lee",
                "F. Scott Fitzgerald",
                "J.D. Salinger",
                "G.G Márquez",
                "J. Tolkien",
                "J.K. Rowling",
                "J.R.R. Tolkien",
                "Aldous Huxley"
            };

            string[] nombresBibliotecas = {
                "Biblioteca Nacional",
                "Biblioteca Pública Municipal",
                "Biblioteca Comunitaria",
                "Biblioteca del Congreso",
                "Biblioteca Digital",
                "Biblioteca Universitaria",
                "Biblioteca Escolar",
                "Biblioteca Regional",
                "Biblioteca Virtual",
                "Biblioteca Itinerante"
            };


            // Limpiar el DataGridView antes de agregar nuevos datos
            dataGridView1.Rows.Clear();

            // Llenar el DataGridView con datos aleatorios
            Random random = new Random();

            for (int i = 0; i < 10; i++) // Cambia 10 por la cantidad de filas que deseas
            {
                string nombreLibro = nombresLibros[i];
                string autor = autores[i];
                string ubicacion = nombresBibliotecas[i];
                int cantidad = random.Next(1, 11);
                DateTime fechaPublicacion = new DateTime(random.Next(2000, 2023), random.Next(1, 13), random.Next(1, 29));

                // Agregar una nueva fila al DataGridView con datos aleatorios
                dataGridView1.Rows.Add(nombreLibro, autor, fechaPublicacion.ToShortDateString(), ubicacion, cantidad);
            }
        }


        //Cuando le da en el boton buscar me realizar unas validacion para verificar que los datos si estan diligenciados
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                if (checkBoxNombre.Checked == false && checkBoxAutor.Checked == false)
                {
                    MessageBox.Show("Debe seleccionar el tipo de busqueda");
                }
                else
                {
                    if (checkBoxNombre.Checked == true) 
                    {
                        Busqueda_en_Grid(dataGridView1, 0);
                    }
                    else if (checkBoxAutor.Checked == true)
                    {
                        Busqueda_en_Grid(dataGridView1, 1);
                    }
                    txtBuscar.Clear();
                }
            }
            else
            {
                MessageBox.Show("Debe diligenciar la casilla de busqueda");
            }
        }

        // Se realiza la busqueda en la datagrid por medio de un bucle y me llena los textbox cuando encuentra los datos

        private void Busqueda_en_Grid(DataGridView d, int col)
        {
            for (int i = 0; i < d.Rows.Count - 1; i++)
            {
                dato = Convert.ToString(d.Rows[i].Cells[col].Value);
                if (dato == txtBuscar.Text.Trim())
                {
                    TextNombreLibro.Text = Convert.ToString(d.Rows[i].Cells[0].Value);
                    TextNombreAutor.Text = Convert.ToString(d.Rows[i].Cells[1].Value);
                    TextAño.Text = Convert.ToString(d.Rows[i].Cells[2].Value);
                    TextUbicacion.Text = Convert.ToString(d.Rows[i].Cells[3].Value);
                    TextCantidad.Text = Convert.ToString(d.Rows[i].Cells[4].Value);
                    break;
                }
            }
        }
    }
}
