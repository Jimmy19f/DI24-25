using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1DataSet.Controlador
{
    public class BBDD
    {
        private MySqlConnection conexion;
        private MySqlCommand comando;
        private MySqlDataAdapter adaptador;
        private DataSet almacen;

        public BBDD()
        {
            try
            {

                conexion = new MySqlConnection("server=localhost;port=3306;user id = root; password = dam2; database = ingenieros; Allow Zero Datetime = True; CHARSET = utf8");
                comando = new MySqlCommand("SELECT * FROM forestales", conexion);
                adaptador = new MySqlDataAdapter(comando);
                almacen = new DataSet();
                AbrirConexion();
                adaptador.Fill(almacen, "for");
                CerrarConexion();
            }
            catch (MySqlException ex) {
                {
                    MessageBox.Show("Error al conectar al servidor MySql: " + ex.Message);
                }
            }


        }

        public bool Conectar (string servidor, string puerto, string usuario, string pass)
        {
            try
            {
                string cadenaConexion = $"server={servidor};port={puerto};user id ={usuario};password={pass}";
                conexion = new MySqlConnection(cadenaConexion);
                comando = new MySqlCommand("SELECT * FROM ingenieros.forestales", conexion);
                adaptador = new MySqlDataAdapter(comando);
                almacen = new DataSet();

                AbrirConexion();
                adaptador.Fill(almacen, "for");
                CerrarConexion();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar al servidor de MySQL: " + ex.Message );
                return false;
            }

        }

        public bool ConectarWorld(string servidor, string puerto, string usuario, string pass)
        {
            try
            {
                string cadenaConexion = $"server={servidor};port={puerto};user id ={usuario};password={pass}";
                conexion = new MySqlConnection(cadenaConexion);
                comando = new MySqlCommand("SELECT * FROM ingenieros.forestales", conexion);
                adaptador = new MySqlDataAdapter(comando);
                almacen = new DataSet();

                AbrirConexion();
                adaptador.Fill(almacen, "for");
                CerrarConexion();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar al servidor de MySQL: " + ex.Message);
                return false;
            }

        }
        private void AbrirConexion()
        {
            if (conexion != null)
            {
                conexion.Close();

            }
            conexion.Open();

        }
        private void CerrarConexion()
        {
            conexion.Close();
        }

        public DataView ObtenerGrid()
        {
            try
            {
                comando = new MySqlCommand("SELECT * FROM ingenieros.forestales", conexion);
                adaptador = new MySqlDataAdapter(comando);
                almacen = new DataSet();

                AbrirConexion();
                adaptador.Fill(almacen, "for");
                CerrarConexion();
                return almacen.Tables["for"].DefaultView;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar al servidor de MySQL: " + ex.Message, "Error al conectar");
                return null;
            }
            
        }

        public void Insertar()
        {
            String consulta = "INSERT INTO `";
            

        }


    } 
}
