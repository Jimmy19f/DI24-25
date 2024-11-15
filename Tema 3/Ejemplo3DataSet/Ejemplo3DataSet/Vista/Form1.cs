using Ejemplo1DataSet.Controlador;
namespace Ejemplo3DataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            BBDD baseDeDatos = new BBDD();
            if (baseDeDatos.ConectarWorld(textBoxServidor.Text, textBoxUsuario.Text, textBoxContraseña.Text, textBoxPuerto.Text))
            {

            }
        }
    }
}
