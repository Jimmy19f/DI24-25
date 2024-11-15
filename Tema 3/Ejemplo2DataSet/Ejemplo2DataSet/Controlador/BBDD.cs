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
                comando = new MySqlCommand("SELECT * FROM forestales", conexion);
                adaptador = new MySqlDataAdapter(comando);
                almacen = new DataSet();

                AbrirConexion();
                adaptador.Fill(almacen, "for");
                CerrarConexion();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar al servidor MySql: " + ex.Message);
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
            return almacen.Tables["for"].DefaultView;
        }

        public void Insertar()
        {
            String consulta = "INSERT INTO `";

        }

        public List<string> ObtenerNombreColumnas()
        {
            try
            {

                comando = new MySqlCommand("SELECT * FROM forestales", conexion);
                adaptador = new MySqlDataAdapter(comando);
                almacen = new DataSet();
                AbrirConexion();
                adaptador.Fill(almacen, "for");
                CerrarConexion();
                List<string> listaDevolver = new List<string>();
                foreach (DataColumn columna in almacen.Tables["for"].Columns)
                {
                    listaDevolver.Add(columna.ColumnName);
                }
                MessageBox.Show(almacen.Tables["for"].Rows[1][1].ToString());
                return listaDevolver;
            }
            catch (MySqlException ex)
            {
                    MessageBox.Show("Error al conectar al servidor MySql: " + ex.Message);
                return null;
                
            }

        }

        //Metodo que devuleva el numero de columnas
        //Metodo que devulva el numero de filas
        //Metodo que devuelva una lista de string del contenido de una columna pasado su indice como parametro 



    } 
}
