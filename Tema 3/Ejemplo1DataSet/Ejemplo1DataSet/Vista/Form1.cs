using Ejemplo1DataSet.Controlador;
using MySql.Data.MySqlClient;
using System.Data;

namespace Ejemplo1DataSet.Vista
{
    public partial class Form1 : Form
    {
        private BBDD miBBDD;
        public Form1()
        {
            InitializeComponent();
            //miBBDD = new BBDD();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = miBBDD.ObtenerGrid();
            //almacen.Tables["for"].Rows[0][2];

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            miBBDD = new BBDD();
            if (miBBDD.Conectar(txtBoxIp.Text, txtBoxPuerto.Text, txtBoxUsuario.Text, txtBoxContraseña.Text))
            {
                btnConectar.Enabled = false;
                BtnInsertar.Enabled = true;
                btnMostrar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se pudo conectar a la base de datos. Verifique las credenciales y la conexión.", "Error de conexión");
            }
        }
    }
}
