using Ejemplo2DataSet.Modelo;
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

        string hola;

        public bool Conectar (string servidor, string puerto, string usuario, string pass)
        {
            try
            {
                string cadenaConexion = $"server={servidor};port={puerto};user id ={usuario};password={pass}";
                conexion = new MySqlConnection(cadenaConexion);

                AbrirConexion();
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

        public bool CargarEnMemoria()
        {
            try
            {
                comando = new MySqlCommand("SELECT * FROM ingenieros.forestales",conexion);
                adaptador = new MySqlDataAdapter(comando);
                almacen = new DataSet();

                AbrirConexion();

                adaptador.Fill(almacen, "for");

                CerrarConexion();
                return true;

            }catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar al servidor MySql: " + ex.Message);
                return false;
            }
        }

        public DataView ObtenerGrid()
        {
                if (CargarEnMemoria()) return almacen.Tables["for"].DefaultView;
                else return null;

        }

        public void Insertar(string dni, string nombre, string apellidos, string telefono, string email)
        {
            
            
                String consulta = $"INSERT INTO `ingenieros`.`forestales` (`dni`, `nombre`, `apellidos`, `telefono`, `e-mail`) VALUES('{dni}', '{nombre}', '{apellidos}', '{telefono}', '{email}');";
                comando = new MySqlCommand(consulta, conexion);
                AbrirConexion();
                comando.ExecuteNonQuery();
                CerrarConexion();
            
            


        }

        public List<string> ObtenerNombreColumnas()
        {
                List<string> listaDevolver = new List<string>();
                if (CargarEnMemoria())
                {
                    foreach (DataColumn columna in almacen.Tables["for"].Columns)
                    {
                        listaDevolver.Add(columna.ColumnName);
                    }
                    //MessageBox.Show(almacen.Tables["for"].Rows[1][1].ToString());
                    
                }
                return listaDevolver;



        }

        public List<string> ObtenerElementosColumna(int indice)
        {

            List<string> listaDevolver = new List<string>();
            if (CargarEnMemoria())
            {
                foreach (DataRow fila in almacen.Tables["for"].Rows)
                {
                    listaDevolver.Add(fila[indice].ToString());
                }
            }
            return listaDevolver;
 
        }

        public forestales ObtenerFila(int indice)
        {
            forestales forestal = new forestales();
            if (CargarEnMemoria())
            {
                forestal.DNI = almacen.Tables["for"].Rows[indice][0].ToString();
                forestal.Nombre = almacen.Tables["for"].Rows[indice][1].ToString();
                forestal.Apellidos = almacen.Tables["for"].Rows[indice][2].ToString();
                forestal.Telefono = almacen.Tables["for"].Rows[indice][3].ToString();
                forestal.Email = almacen.Tables["for"].Rows[indice][4].ToString();
            }
            return forestal;

        }

        //Metodo que devuleva el numero de columnas
        //Metodo que devulva el numero de filas
        //Metodo que devuelva una lista de string del contenido de una columna pasado su indice como parametro 



    } 
}
