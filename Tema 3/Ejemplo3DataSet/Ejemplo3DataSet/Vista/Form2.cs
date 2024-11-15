using Ejemplo1DataSet.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo3DataSet
{
    public partial class Form2 : Form
    {

        BBDD miBase;
        public Form2(BBDD b)
        {
            InitializeComponent();
            miBase = b;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
