using Ejemplo1DataSet.Controlador;

namespace Ejemplo2DataSet
{
    public partial class Form1 : Form
    {
        BBDD bbddforestales;
        public Form1()
        {
            InitializeComponent();
            bbddforestales = new BBDD();
            bbddforestales.Conectar("127.0.0.1","3306","root","dam2");
            LisNombreColumnas.DataSource = bbddforestales;
        }
    }
}
