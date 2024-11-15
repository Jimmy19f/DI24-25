namespace Ejemplo7_MenuStrip2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStripOperaciones = new MenuStrip();
            ToolStripMenuItemArchivo = new ToolStripMenuItem();
            toolStripMenuItemArchivoSalir = new ToolStripMenuItem();
            toolStripMenuItemOperaciones = new ToolStripMenuItem();
            ToolStripMenuItemOperacionesSuma = new ToolStripMenuItem();
            ToolStripMenuItemOperacionesResta = new ToolStripMenuItem();
            ToolStripMenuItemOperacionesMultiplicacion = new ToolStripMenuItem();
            ToolStripMenuItemOperacionesDivision = new ToolStripMenuItem();
            toolStripMenuItemAyuda = new ToolStripMenuItem();
            ToolStripMenuItemAyudaAcerca = new ToolStripMenuItem();
            txtA = new TextBox();
            contextMenutxtA = new ContextMenuStrip(components);
            borrarToolStripMenuItem = new ToolStripMenuItem();
            aleatorioToolStripMenuItem = new ToolStripMenuItem();
            txtB = new TextBox();
            lblResultado = new Label();
            menuStripOperaciones.SuspendLayout();
            contextMenutxtA.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripOperaciones
            // 
            menuStripOperaciones.ImageScalingSize = new Size(20, 20);
            menuStripOperaciones.Items.AddRange(new ToolStripItem[] { ToolStripMenuItemArchivo, toolStripMenuItemOperaciones, toolStripMenuItemAyuda });
            menuStripOperaciones.Location = new Point(0, 0);
            menuStripOperaciones.Name = "menuStripOperaciones";
            menuStripOperaciones.Size = new Size(800, 28);
            menuStripOperaciones.TabIndex = 0;
            menuStripOperaciones.Text = "menuStrip1";
            // 
            // ToolStripMenuItemArchivo
            // 
            ToolStripMenuItemArchivo.AutoToolTip = true;
            ToolStripMenuItemArchivo.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemArchivoSalir });
            ToolStripMenuItemArchivo.Name = "ToolStripMenuItemArchivo";
            ToolStripMenuItemArchivo.Size = new Size(73, 24);
            ToolStripMenuItemArchivo.Text = "Archivo";
            // 
            // toolStripMenuItemArchivoSalir
            // 
            toolStripMenuItemArchivoSalir.Name = "toolStripMenuItemArchivoSalir";
            toolStripMenuItemArchivoSalir.ShortcutKeys = Keys.Control | Keys.S;
            toolStripMenuItemArchivoSalir.Size = new Size(171, 26);
            toolStripMenuItemArchivoSalir.Text = "Salir";
            toolStripMenuItemArchivoSalir.Click += toolStripMenuItemArchivoSalir_Click;
            // 
            // toolStripMenuItemOperaciones
            // 
            toolStripMenuItemOperaciones.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemOperacionesSuma, ToolStripMenuItemOperacionesResta, ToolStripMenuItemOperacionesMultiplicacion, ToolStripMenuItemOperacionesDivision });
            toolStripMenuItemOperaciones.Name = "toolStripMenuItemOperaciones";
            toolStripMenuItemOperaciones.Size = new Size(106, 24);
            toolStripMenuItemOperaciones.Text = "Operaciones";
            // 
            // ToolStripMenuItemOperacionesSuma
            // 
            ToolStripMenuItemOperacionesSuma.Name = "ToolStripMenuItemOperacionesSuma";
            ToolStripMenuItemOperacionesSuma.Size = new Size(186, 26);
            ToolStripMenuItemOperacionesSuma.Text = "Suma";
            // 
            // ToolStripMenuItemOperacionesResta
            // 
            ToolStripMenuItemOperacionesResta.Name = "ToolStripMenuItemOperacionesResta";
            ToolStripMenuItemOperacionesResta.Size = new Size(186, 26);
            ToolStripMenuItemOperacionesResta.Text = "Resta";
            // 
            // ToolStripMenuItemOperacionesMultiplicacion
            // 
            ToolStripMenuItemOperacionesMultiplicacion.Name = "ToolStripMenuItemOperacionesMultiplicacion";
            ToolStripMenuItemOperacionesMultiplicacion.Size = new Size(186, 26);
            ToolStripMenuItemOperacionesMultiplicacion.Text = "Multiplicacion";
            // 
            // ToolStripMenuItemOperacionesDivision
            // 
            ToolStripMenuItemOperacionesDivision.Name = "ToolStripMenuItemOperacionesDivision";
            ToolStripMenuItemOperacionesDivision.Size = new Size(186, 26);
            ToolStripMenuItemOperacionesDivision.Text = "Division";
            // 
            // toolStripMenuItemAyuda
            // 
            toolStripMenuItemAyuda.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemAyudaAcerca });
            toolStripMenuItemAyuda.Name = "toolStripMenuItemAyuda";
            toolStripMenuItemAyuda.Size = new Size(65, 24);
            toolStripMenuItemAyuda.Text = "Ayuda";
            // 
            // ToolStripMenuItemAyudaAcerca
            // 
            ToolStripMenuItemAyudaAcerca.Name = "ToolStripMenuItemAyudaAcerca";
            ToolStripMenuItemAyudaAcerca.Size = new Size(158, 26);
            ToolStripMenuItemAyudaAcerca.Text = "Acerca de";
            ToolStripMenuItemAyudaAcerca.Click += ToolStripMenuItemAyudaAcerca_Click;
            // 
            // txtA
            // 
            txtA.ContextMenuStrip = contextMenutxtA;
            txtA.Location = new Point(73, 84);
            txtA.Name = "txtA";
            txtA.Size = new Size(204, 27);
            txtA.TabIndex = 1;
            txtA.TextAlign = HorizontalAlignment.Right;
            txtA.TextChanged += txtA_TextChanged;
            // 
            // contextMenutxtA
            // 
            contextMenutxtA.ImageScalingSize = new Size(20, 20);
            contextMenutxtA.Items.AddRange(new ToolStripItem[] { borrarToolStripMenuItem, aleatorioToolStripMenuItem });
            contextMenutxtA.Name = "contextMenutxtA";
            contextMenutxtA.Size = new Size(141, 52);
            // 
            // borrarToolStripMenuItem
            // 
            borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            borrarToolStripMenuItem.Size = new Size(140, 24);
            borrarToolStripMenuItem.Text = "Borrar";
            borrarToolStripMenuItem.Click += borrarToolStripMenuItem_Click;
            // 
            // aleatorioToolStripMenuItem
            // 
            aleatorioToolStripMenuItem.Name = "aleatorioToolStripMenuItem";
            aleatorioToolStripMenuItem.Size = new Size(140, 24);
            aleatorioToolStripMenuItem.Text = "Aleatorio";
            aleatorioToolStripMenuItem.Click += aleatorioToolStripMenuItem_Click;
            // 
            // txtB
            // 
            txtB.ContextMenuStrip = contextMenutxtA;
            txtB.Location = new Point(73, 150);
            txtB.Name = "txtB";
            txtB.Size = new Size(204, 27);
            txtB.TabIndex = 2;
            txtB.TextAlign = HorizontalAlignment.Right;
            txtB.TextChanged += txtB_TextChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(227, 209);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 20);
            lblResultado.TabIndex = 3;
            lblResultado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(menuStripOperaciones);
            MainMenuStrip = menuStripOperaciones;
            Name = "Form1";
            Text = "Form1";
            menuStripOperaciones.ResumeLayout(false);
            menuStripOperaciones.PerformLayout();
            contextMenutxtA.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripOperaciones;
        private ToolStripMenuItem ToolStripMenuItemArchivo;
        private ToolStripMenuItem toolStripMenuItemOperaciones;
        private ToolStripMenuItem toolStripMenuItemAyuda;
        private ToolStripMenuItem toolStripMenuItemArchivoSalir;
        private ToolStripMenuItem ToolStripMenuItemOperacionesSuma;
        private ToolStripMenuItem ToolStripMenuItemOperacionesResta;
        private ToolStripMenuItem ToolStripMenuItemOperacionesMultiplicacion;
        private ToolStripMenuItem ToolStripMenuItemOperacionesDivision;
        private ToolStripMenuItem ToolStripMenuItemAyudaAcerca;
        private TextBox txtA;
        private TextBox txtB;
        private Label lblResultado;
        private ContextMenuStrip contextMenutxtA;
        private ToolStripMenuItem borrarToolStripMenuItem;
        private ToolStripMenuItem aleatorioToolStripMenuItem;
    }
}
