namespace Ejemplo2DataSet
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
            LisNombreColumnas = new ListBox();
            labelNumeroColumnas = new Label();
            lisContenidoColumna = new ListBox();
            labelNumeroFilas = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblDni = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblTelefono = new Label();
            lblemail = new Label();
            txtBoxDni = new TextBox();
            txtBoxNombre = new TextBox();
            txtBoxApellido = new TextBox();
            txtBoxTelefono = new TextBox();
            txtBoxEmail = new TextBox();
            SuspendLayout();
            // 
            // LisNombreColumnas
            // 
            LisNombreColumnas.FormattingEnabled = true;
            LisNombreColumnas.Location = new Point(12, 24);
            LisNombreColumnas.Name = "LisNombreColumnas";
            LisNombreColumnas.Size = new Size(226, 244);
            LisNombreColumnas.TabIndex = 0;
            LisNombreColumnas.DoubleClick += LisNombreColumnas_DoubleClick;
            // 
            // labelNumeroColumnas
            // 
            labelNumeroColumnas.AutoSize = true;
            labelNumeroColumnas.Location = new Point(557, 37);
            labelNumeroColumnas.Name = "labelNumeroColumnas";
            labelNumeroColumnas.Size = new Size(153, 20);
            labelNumeroColumnas.TabIndex = 1;
            labelNumeroColumnas.Text = "Numero de Columnas";
            // 
            // lisContenidoColumna
            // 
            lisContenidoColumna.FormattingEnabled = true;
            lisContenidoColumna.Location = new Point(284, 24);
            lisContenidoColumna.Name = "lisContenidoColumna";
            lisContenidoColumna.Size = new Size(241, 244);
            lisContenidoColumna.TabIndex = 2;
            lisContenidoColumna.DoubleClick += lisContenidoColumna_DoubleClick;
            // 
            // labelNumeroFilas
            // 
            labelNumeroFilas.AutoSize = true;
            labelNumeroFilas.Location = new Point(557, 77);
            labelNumeroFilas.Name = "labelNumeroFilas";
            labelNumeroFilas.Size = new Size(117, 20);
            labelNumeroFilas.TabIndex = 3;
            labelNumeroFilas.Text = "Numero de Filas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(557, 120);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 4;
            label1.Text = "Ejemplo campo 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(557, 202);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 5;
            label2.Text = "Ejemplo Campo 2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(557, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(557, 241);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(1163, 27);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(35, 20);
            lblDni.TabIndex = 8;
            lblDni.Text = "DNI";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(1163, 73);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(1163, 116);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 10;
            lblApellido.Text = "Apellido";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(1163, 158);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 11;
            lblTelefono.Text = "Telefono";
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Location = new Point(1163, 202);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(52, 20);
            lblemail.TabIndex = 12;
            lblemail.Text = "e-mail";
            // 
            // txtBoxDni
            // 
            txtBoxDni.Location = new Point(891, 24);
            txtBoxDni.Name = "txtBoxDni";
            txtBoxDni.Size = new Size(256, 27);
            txtBoxDni.TabIndex = 13;
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(891, 70);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.Size = new Size(256, 27);
            txtBoxNombre.TabIndex = 14;
            // 
            // txtBoxApellido
            // 
            txtBoxApellido.Location = new Point(891, 113);
            txtBoxApellido.Name = "txtBoxApellido";
            txtBoxApellido.Size = new Size(256, 27);
            txtBoxApellido.TabIndex = 15;
            // 
            // txtBoxTelefono
            // 
            txtBoxTelefono.Location = new Point(891, 155);
            txtBoxTelefono.Name = "txtBoxTelefono";
            txtBoxTelefono.Size = new Size(256, 27);
            txtBoxTelefono.TabIndex = 16;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(891, 199);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(256, 27);
            txtBoxEmail.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 450);
            Controls.Add(txtBoxEmail);
            Controls.Add(txtBoxTelefono);
            Controls.Add(txtBoxApellido);
            Controls.Add(txtBoxNombre);
            Controls.Add(txtBoxDni);
            Controls.Add(lblemail);
            Controls.Add(lblTelefono);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblDni);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelNumeroFilas);
            Controls.Add(lisContenidoColumna);
            Controls.Add(labelNumeroColumnas);
            Controls.Add(LisNombreColumnas);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LisNombreColumnas;
        private Label labelNumeroColumnas;
        private ListBox lisContenidoColumna;
        private Label labelNumeroFilas;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblDni;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblTelefono;
        private Label lblemail;
        private TextBox txtBoxDni;
        private TextBox txtBoxNombre;
        private TextBox txtBoxApellido;
        private TextBox txtBoxTelefono;
        private TextBox txtBoxEmail;
    }
}
