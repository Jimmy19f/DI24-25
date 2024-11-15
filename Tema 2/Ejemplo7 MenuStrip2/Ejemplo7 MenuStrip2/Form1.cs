namespace Ejemplo7_MenuStrip2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void toolStripMenuItemArchivoSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItemAyudaAcerca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicaion realizada por Jimmy");
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contextMenutxtA.SourceControl.Text = "";
        }

        private void aleatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
