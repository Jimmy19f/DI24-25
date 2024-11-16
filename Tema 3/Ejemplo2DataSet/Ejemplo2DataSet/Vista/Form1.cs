using Ejemplo1DataSet.Controlador;
using Ejemplo2DataSet.Modelo;

namespace Ejemplo2DataSet
{
    public partial class Form1 : Form
    {
        BBDD bbddforestales;
        public Form1()
        {
            InitializeComponent();
            bbddforestales = new BBDD();
            bbddforestales.Conectar("127.0.0.1", "3306", "root", "dam2");
            LisNombreColumnas.DataSource = bbddforestales.ObtenerNombreColumnas();
        }

        private void LisNombreColumnas_DoubleClick(object sender, EventArgs e)
        {
            lisContenidoColumna.DataSource = bbddforestales.ObtenerElementosColumna(LisNombreColumnas.SelectedIndex);
        }

        private void lisContenidoColumna_DoubleClick(object sender, EventArgs e)
        {
            forestales forestasl = bbddforestales.ObtenerFila(lisContenidoColumna.SelectedIndex);

            txtBoxDni.Text = forestasl.DNI;
            txtBoxNombre.Text = forestasl.Nombre;
            txtBoxApellido.Text = forestasl.Apellidos;
            txtBoxTelefono.Text = forestasl.Telefono;
            txtBoxEmail.Text = forestasl.Email;
        }
    }
}
